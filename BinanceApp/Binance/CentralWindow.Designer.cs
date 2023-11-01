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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriasCheckList = new System.Windows.Forms.CheckedListBox();
            this.ExitCheck = new System.Windows.Forms.CheckBox();
            this.IncomeCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorDespesaBox = new System.Windows.Forms.TextBox();
            this.DespesaLabel = new System.Windows.Forms.Label();
            this.DespesaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
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
            this.MultiTabPanel.Controls.Add(this.label4);
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
            this.MultiTabPanel.Location = new System.Drawing.Point(-12, 31);
            this.MultiTabPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MultiTabPanel.Name = "MultiTabPanel";
            this.MultiTabPanel.Size = new System.Drawing.Size(519, 820);
            this.MultiTabPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 652);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 87);
            this.button1.TabIndex = 9;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adicione um novo registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria";
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
            this.CategoriasCheckList.Location = new System.Drawing.Point(33, 410);
            this.CategoriasCheckList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriasCheckList.Name = "CategoriasCheckList";
            this.CategoriasCheckList.Size = new System.Drawing.Size(453, 203);
            this.CategoriasCheckList.TabIndex = 6;
            // 
            // ExitCheck
            // 
            this.ExitCheck.AutoSize = true;
            this.ExitCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitCheck.ForeColor = System.Drawing.Color.White;
            this.ExitCheck.Location = new System.Drawing.Point(333, 304);
            this.ExitCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitCheck.Name = "ExitCheck";
            this.ExitCheck.Size = new System.Drawing.Size(97, 33);
            this.ExitCheck.TabIndex = 5;
            this.ExitCheck.Text = "Saída";
            this.ExitCheck.UseVisualStyleBackColor = true;
            // 
            // IncomeCheck
            // 
            this.IncomeCheck.AutoSize = true;
            this.IncomeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeCheck.ForeColor = System.Drawing.Color.White;
            this.IncomeCheck.Location = new System.Drawing.Point(33, 304);
            this.IncomeCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IncomeCheck.Name = "IncomeCheck";
            this.IncomeCheck.Size = new System.Drawing.Size(118, 33);
            this.IncomeCheck.TabIndex = 4;
            this.IncomeCheck.Text = "Entrada";
            this.IncomeCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
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
            this.ValorDespesaBox.Location = new System.Drawing.Point(33, 245);
            this.ValorDespesaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ValorDespesaBox.Name = "ValorDespesaBox";
            this.ValorDespesaBox.Size = new System.Drawing.Size(448, 35);
            this.ValorDespesaBox.TabIndex = 2;
            // 
            // DespesaLabel
            // 
            this.DespesaLabel.AutoSize = true;
            this.DespesaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DespesaLabel.ForeColor = System.Drawing.Color.White;
            this.DespesaLabel.Location = new System.Drawing.Point(27, 113);
            this.DespesaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DespesaLabel.Name = "DespesaLabel";
            this.DespesaLabel.Size = new System.Drawing.Size(210, 37);
            this.DespesaLabel.TabIndex = 1;
            this.DespesaLabel.Text = "Insira a despesa";
            // 
            // DespesaTextBox
            // 
            this.DespesaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DespesaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DespesaTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DespesaTextBox.Location = new System.Drawing.Point(33, 154);
            this.DespesaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DespesaTextBox.Name = "DespesaTextBox";
            this.DespesaTextBox.Size = new System.Drawing.Size(448, 35);
            this.DespesaTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1803, 36);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1762, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.dataGridView1);
            this.DataPanel.Location = new System.Drawing.Point(529, 43);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(1257, 699);
            this.DataPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 699);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(238, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saldo:";
            // 
            // CentralScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1803, 847);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MultiTabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}