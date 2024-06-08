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
                    string imageName = Path.GetFileName(imageFile);
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
    }
}
