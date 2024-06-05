namespace EasyPDF
{
    partial class FormPdfRemoveOrderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPdfRemoveOrderPage));
            this.groupBoxSequencia = new System.Windows.Forms.GroupBox();
            this.numericUpDownSequencia = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxMergePDF = new System.Windows.Forms.TextBox();
            this.buttonProcessar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOutPath = new System.Windows.Forms.TextBox();
            this.buttonOutPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInpPath = new System.Windows.Forms.TextBox();
            this.buttonInpPath = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBaixo = new System.Windows.Forms.Button();
            this.buttonCima = new System.Windows.Forms.Button();
            this.groupBoxSequencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSequencia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSequencia
            // 
            this.groupBoxSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSequencia.Controls.Add(this.numericUpDownSequencia);
            this.groupBoxSequencia.Location = new System.Drawing.Point(632, 426);
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
            this.groupBox3.Location = new System.Drawing.Point(109, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salvar Arquivo";
            // 
            // textBoxMergePDF
            // 
            this.textBoxMergePDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMergePDF.Location = new System.Drawing.Point(6, 21);
            this.textBoxMergePDF.Name = "textBoxMergePDF";
            this.textBoxMergePDF.Size = new System.Drawing.Size(505, 22);
            this.textBoxMergePDF.TabIndex = 8;
            this.textBoxMergePDF.Text = "ArquivoPDF";
            // 
            // buttonProcessar
            // 
            this.buttonProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProcessar.Enabled = false;
            this.buttonProcessar.Location = new System.Drawing.Point(12, 432);
            this.buttonProcessar.Name = "buttonProcessar";
            this.buttonProcessar.Size = new System.Drawing.Size(91, 49);
            this.buttonProcessar.TabIndex = 7;
            this.buttonProcessar.Text = "Processar";
            this.buttonProcessar.UseVisualStyleBackColor = true;
            this.buttonProcessar.Click += new System.EventHandler(this.buttonProcessar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxOutPath);
            this.groupBox2.Controls.Add(this.buttonOutPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 55);
            this.groupBox2.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            this.Nome,
            this.Pagina});
            this.dataGridView.Location = new System.Drawing.Point(12, 134);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(712, 286);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImagens_CellContentClick);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewImagens_RowsAdded);
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
            this.Nome.Width = 350;
            // 
            // Pagina
            // 
            this.Pagina.HeaderText = "Página";
            this.Pagina.MinimumWidth = 6;
            this.Pagina.Name = "Pagina";
            this.Pagina.ReadOnly = true;
            this.Pagina.Width = 80;
            // 
            // buttonBaixo
            // 
            this.buttonBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBaixo.Image = global::EasyPDF.Properties.Resources.icons8_flecha_grossa_apontando_para_baixo_48;
            this.buttonBaixo.Location = new System.Drawing.Point(730, 215);
            this.buttonBaixo.Name = "buttonBaixo";
            this.buttonBaixo.Size = new System.Drawing.Size(58, 75);
            this.buttonBaixo.TabIndex = 3;
            this.buttonBaixo.UseVisualStyleBackColor = true;
            this.buttonBaixo.Click += new System.EventHandler(this.buttonBaixo_Click);
            // 
            // buttonCima
            // 
            this.buttonCima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCima.Image = global::EasyPDF.Properties.Resources.icons8_flecha_grossa_apontando_para_cima_48;
            this.buttonCima.Location = new System.Drawing.Point(730, 134);
            this.buttonCima.Name = "buttonCima";
            this.buttonCima.Size = new System.Drawing.Size(58, 75);
            this.buttonCima.TabIndex = 2;
            this.buttonCima.UseVisualStyleBackColor = true;
            this.buttonCima.Click += new System.EventHandler(this.buttonCima_Click);
            // 
            // FormPdfRemoveOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 493);
            this.Controls.Add(this.groupBoxSequencia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonProcessar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBaixo);
            this.Controls.Add(this.buttonCima);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPdfRemoveOrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover/Ordenar Paginas de PDF";
            this.groupBoxSequencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSequencia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSequencia;
        private System.Windows.Forms.NumericUpDown numericUpDownSequencia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxMergePDF;
        private System.Windows.Forms.Button buttonProcessar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutPath;
        private System.Windows.Forms.Button buttonOutPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInpPath;
        private System.Windows.Forms.Button buttonInpPath;
        private System.Windows.Forms.Button buttonBaixo;
        private System.Windows.Forms.Button buttonCima;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagina;
    }
}