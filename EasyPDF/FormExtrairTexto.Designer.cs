namespace EasyPDF
{
    partial class FormExtrairTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtrairTexto));
            this.groupBoxSequencia = new System.Windows.Forms.GroupBox();
            this.numericUpDownSequencia = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNomeArquivo = new System.Windows.Forms.TextBox();
            this.buttonExtrair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOutPath = new System.Windows.Forms.TextBox();
            this.buttonOutPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInpPath = new System.Windows.Forms.TextBox();
            this.buttonInpPath = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSequencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSequencia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSequencia
            // 
            this.groupBoxSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSequencia.Controls.Add(this.numericUpDownSequencia);
            this.groupBoxSequencia.Location = new System.Drawing.Point(693, 432);
            this.groupBoxSequencia.Name = "groupBoxSequencia";
            this.groupBoxSequencia.Size = new System.Drawing.Size(92, 55);
            this.groupBoxSequencia.TabIndex = 4;
            this.groupBoxSequencia.TabStop = false;
            this.groupBoxSequencia.Text = "Sequência";
            // 
            // numericUpDownSequencia
            // 
            this.numericUpDownSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSequencia.Enabled = false;
            this.numericUpDownSequencia.Location = new System.Drawing.Point(6, 21);
            this.numericUpDownSequencia.Name = "numericUpDownSequencia";
            this.numericUpDownSequencia.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownSequencia.TabIndex = 0;
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
            this.groupBox3.Controls.Add(this.textBoxNomeArquivo);
            this.groupBox3.Location = new System.Drawing.Point(108, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 55);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salvar Arquivo";
            // 
            // textBoxNomeArquivo
            // 
            this.textBoxNomeArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomeArquivo.Location = new System.Drawing.Point(6, 21);
            this.textBoxNomeArquivo.Name = "textBoxNomeArquivo";
            this.textBoxNomeArquivo.Size = new System.Drawing.Size(567, 22);
            this.textBoxNomeArquivo.TabIndex = 0;
            this.textBoxNomeArquivo.TextChanged += new System.EventHandler(this.textBoxNomeArquivo_TextChanged);
            // 
            // buttonExtrair
            // 
            this.buttonExtrair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExtrair.Location = new System.Drawing.Point(11, 438);
            this.buttonExtrair.Name = "buttonExtrair";
            this.buttonExtrair.Size = new System.Drawing.Size(91, 49);
            this.buttonExtrair.TabIndex = 5;
            this.buttonExtrair.Text = "Extrair";
            this.buttonExtrair.UseVisualStyleBackColor = true;
            this.buttonExtrair.Click += new System.EventHandler(this.buttonExtrair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxOutPath);
            this.groupBox2.Controls.Add(this.buttonOutPath);
            this.groupBox2.Location = new System.Drawing.Point(11, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 55);
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
            this.textBoxOutPath.Size = new System.Drawing.Size(665, 22);
            this.textBoxOutPath.TabIndex = 1;
            // 
            // buttonOutPath
            // 
            this.buttonOutPath.Location = new System.Drawing.Point(6, 21);
            this.buttonOutPath.Name = "buttonOutPath";
            this.buttonOutPath.Size = new System.Drawing.Size(91, 23);
            this.buttonOutPath.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 55);
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
            this.textBoxInpPath.Size = new System.Drawing.Size(665, 22);
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
            this.dataGridView.Location = new System.Drawing.Point(11, 159);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(774, 267);
            this.dataGridView.TabIndex = 2;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // FormExtrairTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 493);
            this.Controls.Add(this.groupBoxSequencia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonExtrair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExtrairTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extrair Texto de PDFs";
            this.groupBoxSequencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSequencia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSequencia;
        private System.Windows.Forms.NumericUpDown numericUpDownSequencia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxNomeArquivo;
        private System.Windows.Forms.Button buttonExtrair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutPath;
        private System.Windows.Forms.Button buttonOutPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInpPath;
        private System.Windows.Forms.Button buttonInpPath;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}