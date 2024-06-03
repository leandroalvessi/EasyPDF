using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EasyPDF
{
    public partial class FormPdfRemoveOrderPage : Form
    {
        public FormPdfRemoveOrderPage()
        {
            InitializeComponent();
        }

        private void buttonInpPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxInpPath.Text = openFileDialog.FileName;
                    string pdfFile = openFileDialog.FileName;
                    LoadPdfFile(pdfFile);
                }
            }
        }

        private void LoadPdfFile(string pdfFile)
        {
            dataGridView.Rows.Clear();
            int pageCount = GetNumberOfPages(pdfFile);
            string pdfName = Path.GetFileName(pdfFile);

            for (int pageIndex = 1; pageIndex <= pageCount; pageIndex++)
            {
                dataGridView.Rows.Add(true, pdfName, pageIndex);
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

        public static int GetNumberOfPages(string filePath)
        {
            int numberOfPages = 0;

            try
            {
                using (var document = PdfReader.Open(filePath, PdfDocumentOpenMode.Import))
                {
                    numberOfPages = document.PageCount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao tentar obter o número de páginas do: " + ex.Message);
            }

            return numberOfPages;
        }

        private void buttonCima_Click(object sender, EventArgs e)
        {
            MoveRow(-1);
        }

        private void buttonBaixo_Click(object sender, EventArgs e)
        {
            MoveRow(1);
        }

        private List<int> GetNewPageOrder()
        {
            List<int> newOrder = new List<int>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleciona"].Value))
                {
                    newOrder.Add((int)row.Cells["Pagina"].Value);
                }
            }
            return newOrder;
        }

        public void RemoveOrderPages(string sourcePdfPath, string destinationPdfPath, List<int> pagesToKeep)
        {
            PdfDocument inputDocument = PdfReader.Open(sourcePdfPath, PdfDocumentOpenMode.Import);
            PdfDocument outputDocument = new PdfDocument();

            foreach (int pageIndex in pagesToKeep)
            {
                outputDocument.AddPage(inputDocument.Pages[pageIndex - 1]);
            }

            outputDocument.Save(destinationPdfPath);

            MessageBox.Show($"PDF mesclado com sucesso em: {destinationPdfPath}");
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

        private void buttonProcessar_Click(object sender, EventArgs e)
        {
            List<int> pagesToKeep = GetNewPageOrder();
            string tempDirectory = textBoxOutPath.Text;
            string outputPdfPath = Path.Combine(tempDirectory, textBoxMergePDF.Text + "_" + numericUpDownSequencia.Value.ToString("0000") + ".pdf");

            if (Directory.Exists(tempDirectory))
            {
                RemoveOrderPages(textBoxInpPath.Text, outputPdfPath, pagesToKeep);
                numericUpDownSequencia.Value += 1;
            }
            else
            {
                MessageBox.Show("Especifique um caminho de saída.");
            }
        }

        private void dataGridViewImagens_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView.Rows.Count > 1)
            {
                buttonProcessar.Enabled = true;
            }
            else
            {
                buttonProcessar.Enabled = false;
            }
        }
    }
}
