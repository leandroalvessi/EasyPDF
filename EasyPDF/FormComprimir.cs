using iTextSharp.text.pdf;
using iTextSharp.text;
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

namespace EasyPDF
{
    public partial class FormComprimir : Form
    {
        public FormComprimir()
        {
            InitializeComponent();
            comboBoxVersao.SelectedIndex = 5;
            comboBoxCompressao.SelectedIndex = 3;
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
                    string imageName = Path.GetFileName(imageFile);
                    dataGridView.Rows.Add(false, imageName);
                }
            }
            else
            {
                MessageBox.Show("Diretório não encontrado.");
            }
        }

        private void buttonComprimir_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && !string.IsNullOrWhiteSpace(textBoxOutPath.Text))
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Seleciona"].Value))
                    {
                        string filePath = Path.Combine(textBoxInpPath.Text, row.Cells["Nome"].Value.ToString());
                        string fileOutPath = Path.Combine(textBoxOutPath.Text, row.Cells["Nome"].Value.ToString().Replace(".pdf", "") + "_" + textBoxMergePDF.Text + "_" + numericUpDownSequencia.Value.ToString("0000") + ".pdf");
                        CompressPdfFile(filePath, fileOutPath);
                    }
                }
                MessageBox.Show($"PDF comprimido com sucesso em: {textBoxOutPath.Text}");
                numericUpDownSequencia.Value += 1;
            }
            else
            {
                MessageBox.Show("Selecione PDFs e especifique um caminho de saída.");
            }
        }

        public void CompressPdfFile(string pdfPath, string outputPdfFileName)
        {
            string tempDirectory = textBoxOutPath.Text;
            string outputPdfPath = Path.Combine(tempDirectory, outputPdfFileName);

            try
            {
                using (PdfReader reader = new PdfReader(pdfPath))
                {
                    using (FileStream fs = new FileStream(outputPdfPath, FileMode.Create, FileAccess.Write))
                    {
                        using (Document document = new Document())
                        {
                            using (PdfCopy copy = new PdfCopy(document, fs))
                            {
                                // Set PDF version
                                switch (comboBoxVersao.SelectedIndex)
                                {
                                    case 0:
                                        copy.SetPdfVersion(PdfWriter.PDF_VERSION_1_2);
                                        break;
                                    case 1:
                                        copy.SetPdfVersion(PdfWriter.PDF_VERSION_1_3);
                                        break;
                                    case 2:
                                        copy.SetPdfVersion(PdfWriter.PDF_VERSION_1_4);
                                        break;
                                    case 3:
                                        copy.SetPdfVersion(PdfWriter.PDF_VERSION_1_5);
                                        break;
                                    case 4:
                                        copy.SetPdfVersion(PdfWriter.PDF_VERSION_1_6);
                                        break;
                                    case 5:
                                        copy.SetPdfVersion(PdfWriter.PDF_VERSION_1_7);
                                        break;
                                    default:
                                        copy.SetPdfVersion(PdfWriter.PDF_VERSION_1_7);
                                        break;
                                }

                                // Enable compression
                                copy.SetFullCompression();
                                switch (comboBoxCompressao.SelectedIndex)
                                {
                                    case 0:
                                        copy.CompressionLevel = PdfStream.DEFAULT_COMPRESSION;
                                        break;
                                    case 1:
                                        copy.CompressionLevel = PdfStream.NO_COMPRESSION;
                                        break;
                                    case 2:
                                        copy.CompressionLevel = PdfStream.BEST_SPEED;
                                        break;
                                    case 3:
                                        copy.CompressionLevel = PdfStream.BEST_COMPRESSION;
                                        break;
                                    default:
                                        copy.CompressionLevel = PdfStream.BEST_COMPRESSION;
                                        break;
                                }
                                copy.CompressionLevel = PdfStream.BEST_COMPRESSION;

                                // Open document
                                document.Open();

                                int numberOfPages = reader.NumberOfPages;

                                for (int i = 1; i <= numberOfPages; i++)
                                {
                                    PdfImportedPage page = copy.GetImportedPage(reader, i);
                                    copy.AddPage(page);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
    }
}
