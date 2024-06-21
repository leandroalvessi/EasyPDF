using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EasyPDF.Controllers;

namespace EasyPDF
{
    public partial class FormPdfMerge : Form
    {
        public FormPdfMerge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadPdfNames(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                string[] pdfFiles = Directory.GetFiles(directoryPath, "*.*", SearchOption.TopDirectoryOnly)
                                                .Where(s => s.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                                                .ToArray();

                dataGridView.Rows.Clear();

                foreach (string pdfFile in pdfFiles)
                {
                    string imageName = Path.GetFileName(pdfFile);
                    long fileSize = new FileInfo(pdfFile).Length;
                    string readableSize = FileFunction.GetReadableFileSize(fileSize);
                    dataGridView.Rows.Add(false, imageName, readableSize);
                }
            }
            else
            {
                MessageBox.Show("Diretório não encontrado.");
            }
        }

        private bool allRowsSelected = false;
        private void dataGridViewImagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void buttonSelecionar_Click(object sender, EventArgs e)
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

        private void MoveRow(int direction)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;

                if ((selectedIndex + direction) >= 0 && (selectedIndex + direction) < dataGridView.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView.Rows[selectedIndex];
                    dataGridView.Rows.Remove(selectedRow);
                    dataGridView.Rows.Insert(selectedIndex + direction, selectedRow);
                    dataGridView.ClearSelection();
                    dataGridView.Rows[selectedIndex + direction].Selected = true;
                }
            }
        }

        private void buttonBaixo_Click(object sender, EventArgs e)
        {
            MoveRow(1);
        }

        private void buttonCima_Click(object sender, EventArgs e)
        {
            MoveRow(-1);
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

        private void buttonMesclar_Click(object sender, EventArgs e)
        {
            List<string> filePathList = new List<string>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleciona"].Value))
                {
                    string filePath = Path.Combine(textBoxInpPath.Text, row.Cells["Nome"].Value.ToString());
                    filePathList.Add(filePath);
                }
            }

            if (filePathList.Count > 1)
            {
                string[] filePaths = filePathList.ToArray();
                string outputPdfPath = textBoxOutPath.Text;

                if (filePaths.Length > 0 && !string.IsNullOrWhiteSpace(outputPdfPath))
                {
                    MergePdfFiles(filePaths, textBoxMergePDF.Text + "_" + numericUpDownSequencia.Value.ToString("0000") + ".pdf");
                    numericUpDownSequencia.Value += 1;
                }
                else
                {
                    MessageBox.Show("Selecione PDFs e especifique um caminho de saída.");
                }
            } 
            else { MessageBox.Show("Por favor, selecione dois ou mais PDFs"); }
        }

        public void MergePdfFiles(string[] pdfPaths, string outputPdfFileName)
        {
            string tempDirectory = textBoxOutPath.Text;
            string outputPdfPath = Path.Combine(tempDirectory, outputPdfFileName);

            try
            {
                using (PdfDocument outputDocument = new PdfDocument())
                {
                    foreach (string pdfPath in pdfPaths)
                    {
                        using (PdfDocument inputDocument = PdfReader.Open(pdfPath, PdfDocumentOpenMode.Import))
                        {
                            int pageCount = inputDocument.PageCount;

                            for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
                            {
                                PdfPage page = inputDocument.Pages[pageIndex];
                                outputDocument.AddPage(page);
                            }
                        }
                    }

                    outputDocument.Save(outputPdfPath);
                }

                MessageBox.Show($"PDF mesclado com sucesso em: {outputPdfPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
