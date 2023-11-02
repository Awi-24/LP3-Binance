namespace Binance
{
    partial class CentralScreen
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
            this.MultiTabPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.DespesaTextBox = new System.Windows.Forms.TextBox();
            this.DespesaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorDespesaBox = new System.Windows.Forms.TextBox();
            this.IncomeCheck = new System.Windows.Forms.CheckBox();
            this.ExitCheck = new System.Windows.Forms.CheckBox();
            this.CategoriasCheckList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.MultiTabPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MultiTabPanel
            // 
            this.MultiTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiTabPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.MultiTabPanel.Controls.Add(this.button1);
            this.MultiTabPanel.Controls.Add(this.label3);
            this.MultiTabPanel.Controls.Add(this.label2);
            this.MultiTabPanel.Controls.Add(this.CategoriasCheckList);
            this.MultiTabPanel.Controls.Add(this.ExitCheck);
            this.MultiTabPanel.Controls.Add(this.IncomeCheck);
            this.MultiTabPanel.Controls.Add(this.label1);
            this.MultiTabPanel.Controls.Add(this.ValorDespesaBox);
            this.MultiTabPanel.Controls.Add(this.DespesaLabel);
            this.MultiTabPanel.Controls.Add(this.DespesaTextBox);
            this.MultiTabPanel.Location = new System.Drawing.Point(-9, 25);
            this.MultiTabPanel.Name = "MultiTabPanel";
            this.MultiTabPanel.Size = new System.Drawing.Size(389, 666);
            this.MultiTabPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 29);
            this.panel1.TabIndex = 1;
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.dataGridView1);
            this.DataPanel.Location = new System.Drawing.Point(397, 35);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(943, 568);
            this.DataPanel.TabIndex = 2;
            // 
            // DespesaTextBox
            // 
            this.DespesaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DespesaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DespesaTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DespesaTextBox.Location = new System.Drawing.Point(25, 125);
            this.DespesaTextBox.Name = "DespesaTextBox";
            this.DespesaTextBox.Size = new System.Drawing.Size(336, 28);
            this.DespesaTextBox.TabIndex = 0;
            // 
            // DespesaLabel
            // 
            this.DespesaLabel.AutoSize = true;
            this.DespesaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DespesaLabel.ForeColor = System.Drawing.Color.White;
            this.DespesaLabel.Location = new System.Drawing.Point(20, 92);
            this.DespesaLabel.Name = "DespesaLabel";
            this.DespesaLabel.Size = new System.Drawing.Size(164, 30);
            this.DespesaLabel.TabIndex = 1;
            this.DespesaLabel.Text = "Insira a despesa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira o valor";
            // 
            // ValorDespesaBox
            // 
            this.ValorDespesaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValorDespesaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValorDespesaBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorDespesaBox.Location = new System.Drawing.Point(25, 199);
            this.ValorDespesaBox.Name = "ValorDespesaBox";
            this.ValorDespesaBox.Size = new System.Drawing.Size(336, 28);
            this.ValorDespesaBox.TabIndex = 2;
            this.ValorDespesaBox.TextChanged += new System.EventHandler(this.ValorDespesaBox_TextChanged);
            // 
            // IncomeCheck
            // 
            this.IncomeCheck.AutoSize = true;
            this.IncomeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeCheck.ForeColor = System.Drawing.Color.White;
            this.IncomeCheck.Location = new System.Drawing.Point(25, 247);
            this.IncomeCheck.Name = "IncomeCheck";
            this.IncomeCheck.Size = new System.Drawing.Size(94, 28);
            this.IncomeCheck.TabIndex = 4;
            this.IncomeCheck.Text = "Entrada";
            this.IncomeCheck.UseVisualStyleBackColor = true;
            // 
            // ExitCheck
            // 
            this.ExitCheck.AutoSize = true;
            this.ExitCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitCheck.ForeColor = System.Drawing.Color.White;
            this.ExitCheck.Location = new System.Drawing.Point(250, 247);
            this.ExitCheck.Name = "ExitCheck";
            this.ExitCheck.Size = new System.Drawing.Size(76, 28);
            this.ExitCheck.TabIndex = 5;
            this.ExitCheck.Text = "Saída";
            this.ExitCheck.UseVisualStyleBackColor = true;
            // 
            // CategoriasCheckList
            // 
            this.CategoriasCheckList.BackColor = System.Drawing.Color.MediumPurple;
            this.CategoriasCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriasCheckList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriasCheckList.ForeColor = System.Drawing.Color.White;
            this.CategoriasCheckList.FormattingEnabled = true;
            this.CategoriasCheckList.Items.AddRange(new object[] {
            "Comida",
            "Luz",
            "Água",
            "Salário",
            "Saúde",
            "Outro"});
            this.CategoriasCheckList.Location = new System.Drawing.Point(25, 333);
            this.CategoriasCheckList.Name = "CategoriasCheckList";
            this.CategoriasCheckList.Size = new System.Drawing.Size(340, 168);
            this.CategoriasCheckList.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adicione um novo registro";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Despesa,
            this.Data,
            this.Valor,
            this.Tipo,
            this.Categoria});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 568);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Despesa
            // 
            this.Despesa.HeaderText = "Despesa";
            this.Despesa.Name = "Despesa";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1321, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CentralScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1352, 688);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MultiTabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CentralScreen";
            this.Text = "Form1";
            this.MultiTabPanel.ResumeLayout(false);
            this.MultiTabPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MultiTabPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.TextBox DespesaTextBox;
        private System.Windows.Forms.Label DespesaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorDespesaBox;
        private System.Windows.Forms.CheckBox ExitCheck;
        private System.Windows.Forms.CheckBox IncomeCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox CategoriasCheckList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Button button2;
    }
}