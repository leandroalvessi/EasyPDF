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
    public partial class FormSobre : Form
    {
        public FormSobre(string nome, DateTime datainicio, DateTime dataFimLicenca)
        {
            InitializeComponent();
            labelRegistro.Text = nome != null ? "Nome do Registro: " + nome : "Nome do Registro: Não disponível";
            labelDtaIni.Text = datainicio.Date != DateTime.MinValue ? "Data Inicio da Licença: " + datainicio.ToString() : "Data Inicio da Licença: Não disponível";
            labelDtaFim.Text = dataFimLicenca.Date != DateTime.MinValue ? "Data Fim da Licença: " + dataFimLicenca.ToString() : "Data Fim da Licença: Não disponível";
        }
    }
}
