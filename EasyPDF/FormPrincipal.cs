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
            //HabilitarCamposLisenca();
        }

        private void HabilitarCamposLisenca()
        {
            string HardwareId = HardwareInfo.GetHardwareId();

            LicenseValidator validator = new LicenseValidator(ConnectionDB.ConnectionString());

            //validator.CreateLicensesTable();

            string hardwareId = HardwareInfo.GetHardwareId();
            richTextBoxLicense.Text = hardwareId;

            if (InternetChecker.IsConnectedToInternet())
            {
                var validationResult = validator.ValidateAndUpdateHardwareId(hardwareId);
                if (validationResult.isValid)
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                    richTextBoxLicense.Text = "Licença ativada.";
                }
                else
                {
                    if (validationResult.codigoError == 2)
                    {
                        richTextBoxLicense.Text = "A licença expirou em " + $"{validationResult.dataFimLicenca.ToString("dd/MM/yyyy")}" + ". Por favor, entre em contato com o administrador.";

                    }
                    else if (validationResult.codigoError == 1)
                    {
                        richTextBoxLicense.Text = "O ID não foi encontrado em nossa base de dados. Por favor, entre em contato com o administrador para que ele possa adicionar o seu ID ao servidor, garantindo a validação da licença." + "\n" + $"{hardwareId}";
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
    }
}
