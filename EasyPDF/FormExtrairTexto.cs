using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace EasyPDF
{
    public partial class FormExtrairTexto : Form
    {
        public FormExtrairTexto()
        {
            InitializeComponent();
        }

        private void buttonInpPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxInpPath.Text = folderBrowserDialog.SelectedPath;
                    LoadPdfNames(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void buttonOutPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxOutPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void LoadPdfNames(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                string[] imageFiles = Directory.GetFiles(directoryPath, "*.*", SearchOption.TopDirectoryOnly)
                                                .Where(s => s.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                                                .ToArray();

                dataGridView.Rows.Clear();

                foreach (string imageFile in imageFiles)
                {
                    string imageName = System.IO.Path.GetFileName(imageFile);
                    dataGridView.Rows.Add(false, imageName);
                }
            }
            else
            {
                MessageBox.Show("Diretório não encontrado.");
            }
        }

        private bool allRowsSelected = false;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == dataGridView.Columns["Seleciona"].Index)
            {
                allRowsSelected = !allRowsSelected;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Seleciona"];
                    checkBoxCell.Value = allRowsSelected;
                }
            }
            else if (e.ColumnIndex == dataGridView.Columns["Seleciona"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView.Rows[e.RowIndex].Cells["Seleciona"];
                bool isChecked = (bool)checkBoxCell.Value;
                checkBoxCell.Value = !isChecked;
            }
        }

        static string ExtractTextFromPdf(string filePath)
        {
            var text = new StringWriter();

            try
            {
                // Extrair texto usando PdfReader e PdfTextExtractor
                using (var pdfReader = new PdfReader(filePath))
                {
                    for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                    {
                        var strategy = new SimpleTextExtractionStrategy();
                        var currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                        currentText = Encoding.UTF8.GetString(Encoding.Convert(
                            Encoding.Default,
                            Encoding.UTF8,
                            Encoding.Default.GetBytes(currentText)));

                        text.WriteLine(currentText);
                    }
                }

                // Extrair texto usando Tesseract
                using (var tesseractEngine = new TesseractEngine("./tessdata", "por", EngineMode.Default))
                {
                    using (var pix = Pix.LoadFromFile(filePath))
                    {
                        var ocrResult = tesseractEngine.Process(pix);
                        text.WriteLine(ocrResult.GetText());
                    }
                }
            }
            catch (Exception ex)
            {
                // Log ou tratamento de erro
                Console.WriteLine($"Erro ao extrair texto do PDF: {ex.Message}");
            }

            return text.ToString();
        }

        private void buttonExtrair_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && !string.IsNullOrWhiteSpace(textBoxOutPath.Text))
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Seleciona"].Value))
                    {
                        string filePath = System.IO.Path.Combine(textBoxInpPath.Text, row.Cells["Nome"].Value.ToString());

                        string fileOutPath = System.IO.Path.Combine(textBoxOutPath.Text, row.Cells["Nome"].Value.ToString().Replace(".pdf", "") + (textBoxNomeArquivo.Text == "" ? ".txt" : "_" + textBoxNomeArquivo.Text + "_" + numericUpDownSequencia.Value.ToString("0000") + ".txt"));

                        File.WriteAllText(fileOutPath, ExtractTextFromPdf(filePath));
                    }
                }
                if (textBoxNomeArquivo.Text != "") numericUpDownSequencia.Value += 1;
                MessageBox.Show($"Texto extraido com sucesso em: {textBoxOutPath.Text}");
            }
            else
            {
                MessageBox.Show("Selecione PDFs e especifique um caminho de saída.");
            }
        }

        private void textBoxNomeArquivo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNomeArquivo.Text == "")
            {
                numericUpDownSequencia.Enabled = false;
            }
            else
            {
                numericUpDownSequencia.Enabled = true;
            }
        }
    }
}
