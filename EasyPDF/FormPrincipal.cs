using EasyPDF.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPDF
{
    public partial class FormPrincipal : Form
    {
        string Nome;
        DateTime dataFimLicenca;
        DateTime datainicio;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPdfMerge formToImageColetiva =  new FormPdfMerge();
            formToImageColetiva.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPdfRemoveOrderPage formPdfRemovePagina = new FormPdfRemoveOrderPage();
            formPdfRemovePagina.ShowDialog();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            HabilitarCamposLisenca();
        }
        private void HabilitarCamposLisenca()
        {
            string HardwareId = HardwareInfo.GetHardwareId();

            LicenseValidator validator = new LicenseValidator(ConnectionDB.ConnectionString());

            string hardwareId = HardwareInfo.GetHardwareId();
            richTextBoxLicense.Text = hardwareId;

            if (InternetChecker.IsConnectedToInternet())
            {
                var validationResult = validator.ValidateAndUpdateHardwareId(hardwareId);
                if (validationResult.isValid)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    richTextBoxLicense.Text = validationResult.mensagem;
                    this.Nome = validationResult.nome;
                    this.datainicio = validationResult.datainicio;
                    this.dataFimLicenca = validationResult.dataFimLicenca;
                }
                else
                {
                    if (validationResult.codigoError == 2)
                    {
                        richTextBoxLicense.Text = "A licença expirou em " + $"{validationResult.dataFimLicenca.ToString("dd/MM/yyyy")}" + ". Por favor, entre em contato com o administrador.";
                    }
                    else
                    {
                        richTextBoxLicense.Text = "Ocorreu um erro durante a validação da licença. Por favor, entre em contato com o administrador.";
                    }
                }
            }
            else
            {
                richTextBoxLicense.Text = "Você não está conectado à internet. O sistema precisa de uma conexão com a internet para validar a licença com o servidor. Por favor, conecte-se à internet para utilizar o sistema.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormComprimir formComprimir = new FormComprimir();
            formComprimir.ShowDialog();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre formSobre = new FormSobre(this.Nome, this.datainicio, this.dataFimLicenca);
            formSobre.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormExtrairTexto formExtrair = new FormExtrairTexto();
            formExtrair.ShowDialog();
        }
    }
}
