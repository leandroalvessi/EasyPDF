namespace EasyPDF
{
    partial class FormComprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprimir));
            this.groupBoxSequencia = new System.Windows.Forms.GroupBox();
            this.numericUpDownSequencia = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxMergePDF = new System.Windows.Forms.TextBox();
            this.buttonComprimir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOutPath = new System.Windows.Forms.TextBox();
            this.buttonOutPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInpPath = new System.Windows.Forms.TextBox();
            this.buttonInpPath = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxVersao = new System.Windows.Forms.ComboBox();
            this.groupBoxVersao = new System.Windows.Forms.GroupBox();
            this.groupBoxCompressao = new System.Windows.Forms.GroupBox();
            this.comboBoxCompressao = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSequencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSequencia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxVersao.SuspendLayout();
            this.groupBoxCompressao.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSequencia
            // 
            this.groupBoxSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSequencia.Controls.Add(this.numericUpDownSequencia);
            this.groupBoxSequencia.Location = new System.Drawing.Point(693, 426);
            this.groupBoxSequencia.Name = "groupBoxSequencia";
            this.groupBoxSequencia.Size = new System.Drawing.Size(92, 55);
            this.groupBoxSequencia.TabIndex = 6;
            this.groupBoxSequencia.TabStop = false;
            this.groupBoxSequencia.Text = "Sequência";
            // 
            // numericUpDownSequencia
            // 
            this.numericUpDownSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSequencia.Location = new System.Drawing.Point(6, 21);
            this.numericUpDownSequencia.Name = "numericUpDownSequencia";
            this.numericUpDownSequencia.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownSequencia.TabIndex = 9;
            this.numericUpDownSequencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBoxMergePDF);
            this.groupBox3.Location = new System.Drawing.Point(108, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nome Arquivo";
            // 
            // textBoxMergePDF
            // 
            this.textBoxMergePDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMergePDF.Location = new System.Drawing.Point(6, 21);
            this.textBoxMergePDF.Name = "textBoxMergePDF";
            this.textBoxMergePDF.Size = new System.Drawing.Size(567, 22);
            this.textBoxMergePDF.TabIndex = 8;
            this.textBoxMergePDF.Text = "ArquivoPDF";
            // 
            // buttonComprimir
            // 
            this.buttonComprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonComprimir.Location = new System.Drawing.Point(11, 432);
            this.buttonComprimir.Name = "buttonComprimir";
            this.buttonComprimir.Size = new System.Drawing.Size(91, 49);
            this.buttonComprimir.TabIndex = 7;
            this.buttonComprimir.Text = "Comprimir";
            this.buttonComprimir.UseVisualStyleBackColor = true;
            this.buttonComprimir.Click += new System.EventHandler(this.buttonComprimir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxOutPath);
            this.groupBox2.Controls.Add(this.buttonOutPath);
            this.groupBox2.Location = new System.Drawing.Point(11, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diretório para salvar";
            // 
            // textBoxOutPath
            // 
            this.textBoxOutPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutPath.Location = new System.Drawing.Point(103, 21);
            this.textBoxOutPath.Name = "textBoxOutPath";
            this.textBoxOutPath.Size = new System.Drawing.Size(471, 22);
            this.textBoxOutPath.TabIndex = 3;
            // 
            // buttonOutPath
            // 
            this.buttonOutPath.Location = new System.Drawing.Point(6, 21);
            this.buttonOutPath.Name = "buttonOutPath";
            this.buttonOutPath.Size = new System.Drawing.Size(91, 23);
            this.buttonOutPath.TabIndex = 2;
            this.buttonOutPath.Text = "Selecionar";
            this.buttonOutPath.UseVisualStyleBackColor = true;
            this.buttonOutPath.Click += new System.EventHandler(this.buttonOutPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxInpPath);
            this.groupBox1.Controls.Add(this.buttonInpPath);
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diretório dos arquivos";
            // 
            // textBoxInpPath
            // 
            this.textBoxInpPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInpPath.Location = new System.Drawing.Point(103, 21);
            this.textBoxInpPath.Name = "textBoxInpPath";
            this.textBoxInpPath.Size = new System.Drawing.Size(471, 22);
            this.textBoxInpPath.TabIndex = 1;
            // 
            // buttonInpPath
            // 
            this.buttonInpPath.Location = new System.Drawing.Point(6, 21);
            this.buttonInpPath.Name = "buttonInpPath";
            this.buttonInpPath.Size = new System.Drawing.Size(91, 23);
            this.buttonInpPath.TabIndex = 0;
            this.buttonInpPath.Text = "Selecionar";
            this.buttonInpPath.UseVisualStyleBackColor = true;
            this.buttonInpPath.Click += new System.EventHandler(this.buttonInpPath_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleciona,
            this.Nome});
            this.dataGridView.Location = new System.Drawing.Point(11, 153);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(774, 267);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Seleciona
            // 
            this.Seleciona.HeaderText = "Seleciona";
            this.Seleciona.MinimumWidth = 6;
            this.Seleciona.Name = "Seleciona";
            this.Seleciona.ReadOnly = true;
            this.Seleciona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleciona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleciona.Width = 80;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 500;
            // 
            // comboBoxVersao
            // 
            this.comboBoxVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVersao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVersao.FormattingEnabled = true;
            this.comboBoxVersao.Items.AddRange(new object[] {
            "PDF 1.2",
            "PDF 1.3",
            "PDF 1.4",
            "PDF 1.5",
            "PDF 1.6",
            "PDF 1.7"});
            this.comboBoxVersao.Location = new System.Drawing.Point(6, 20);
            this.comboBoxVersao.Name = "comboBoxVersao";
            this.comboBoxVersao.Size = new System.Drawing.Size(176, 24);
            this.comboBoxVersao.TabIndex = 23;
            // 
            // groupBoxVersao
            // 
            this.groupBoxVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVersao.Controls.Add(this.comboBoxVersao);
            this.groupBoxVersao.Location = new System.Drawing.Point(597, 31);
            this.groupBoxVersao.Name = "groupBoxVersao";
            this.groupBoxVersao.Size = new System.Drawing.Size(188, 55);
            this.groupBoxVersao.TabIndex = 2;
            this.groupBoxVersao.TabStop = false;
            this.groupBoxVersao.Text = "Versão PDF";
            // 
            // groupBoxCompressao
            // 
            this.groupBoxCompressao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCompressao.Controls.Add(this.comboBoxCompressao);
            this.groupBoxCompressao.Location = new System.Drawing.Point(597, 92);
            this.groupBoxCompressao.Name = "groupBoxCompressao";
            this.groupBoxCompressao.Size = new System.Drawing.Size(188, 55);
            this.groupBoxCompressao.TabIndex = 3;
            this.groupBoxCompressao.TabStop = false;
            this.groupBoxCompressao.Text = "Tipo Compressão";
            // 
            // comboBoxCompressao
            // 
            this.comboBoxCompressao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCompressao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompressao.FormattingEnabled = true;
            this.comboBoxCompressao.Items.AddRange(new object[] {
            "Compressão Padrão",
            "Sem Compressão",
            "Compressão Rápida",
            "Melhor Compressão"});
            this.comboBoxCompressao.Location = new System.Drawing.Point(6, 20);
            this.comboBoxCompressao.Name = "comboBoxCompressao";
            this.comboBoxCompressao.Size = new System.Drawing.Size(176, 24);
            this.comboBoxCompressao.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // FormComprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 493);
            this.Controls.Add(this.groupBoxCompressao);
            this.Controls.Add(this.groupBoxVersao);
            this.Controls.Add(this.groupBoxSequencia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonComprimir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormComprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprimir PDFs";
            this.groupBoxSequencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSequencia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxVersao.ResumeLayout(false);
            this.groupBoxCompressao.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSequencia;
        private System.Windows.Forms.NumericUpDown numericUpDownSequencia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxMergePDF;
        private System.Windows.Forms.Button buttonComprimir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutPath;
        private System.Windows.Forms.Button buttonOutPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInpPath;
        private System.Windows.Forms.Button buttonInpPath;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.ComboBox comboBoxVersao;
        private System.Windows.Forms.GroupBox groupBoxVersao;
        private System.Windows.Forms.GroupBox groupBoxCompressao;
        private System.Windows.Forms.ComboBox comboBoxCompressao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}