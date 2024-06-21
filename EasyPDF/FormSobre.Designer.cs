namespace EasyPDF
{
    partial class FormSobre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            this.label1 = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.labelDtaIni = new System.Windows.Forms.Label();
            this.labelDtaFim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVersao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "EasyPDF";
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(16, 96);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(58, 16);
            this.labelRegistro.TabIndex = 1;
            this.labelRegistro.Text = "Registro";
            // 
            // labelDtaIni
            // 
            this.labelDtaIni.AutoSize = true;
            this.labelDtaIni.Location = new System.Drawing.Point(16, 112);
            this.labelDtaIni.Name = "labelDtaIni";
            this.labelDtaIni.Size = new System.Drawing.Size(70, 16);
            this.labelDtaIni.TabIndex = 2;
            this.labelDtaIni.Text = "Data Inicio";
            // 
            // labelDtaFim
            // 
            this.labelDtaFim.AutoSize = true;
            this.labelDtaFim.Location = new System.Drawing.Point(16, 128);
            this.labelDtaFim.Name = "labelDtaFim";
            this.labelDtaFim.Size = new System.Drawing.Size(61, 16);
            this.labelDtaFim.TabIndex = 3;
            this.labelDtaFim.Text = "Data Fim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desenvolvido por Leandro Alves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contato: +55 62 9 9821-1684";
            // 
            // labelVersao
            // 
            this.labelVersao.AutoSize = true;
            this.labelVersao.Location = new System.Drawing.Point(16, 48);
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(57, 16);
            this.labelVersao.TabIndex = 6;
            this.labelVersao.Text = "Versão: ";
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 180);
            this.Controls.Add(this.labelVersao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDtaFim);
            this.Controls.Add(this.labelDtaIni);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Label labelDtaIni;
        private System.Windows.Forms.Label labelDtaFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVersao;
    }
}