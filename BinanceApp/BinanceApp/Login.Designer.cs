namespace BinanceApp
{
    partial class BinanceHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinanceHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.WindowName = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.btLogar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.WindowName);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 38);
            this.panel1.TabIndex = 0;
            // 
            // WindowName
            // 
            this.WindowName.AutoSize = true;
            this.WindowName.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowName.ForeColor = System.Drawing.Color.White;
            this.WindowName.Location = new System.Drawing.Point(0, 0);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(93, 28);
            this.WindowName.TabIndex = 2;
            this.WindowName.Text = "BINANCE";
            this.WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(1328, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 38);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.Color.Indigo;
            this.LoginPanel.Controls.Add(this.panel3);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Location = new System.Drawing.Point(403, 193);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(571, 411);
            this.LoginPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça o seu Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btLogar);
            this.panel3.Controls.Add(this.PasswordInput);
            this.panel3.Controls.Add(this.UserInput);
            this.panel3.Location = new System.Drawing.Point(123, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 188);
            this.panel3.TabIndex = 1;
            // 
            // UserInput
            // 
            this.UserInput.AccessibleName = "Usuário";
            this.UserInput.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com",
            "@hotmail.com",
            "@outlook.com"});
            this.UserInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UserInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInput.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.ForeColor = System.Drawing.Color.Silver;
            this.UserInput.Location = new System.Drawing.Point(0, 0);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(322, 36);
            this.UserInput.TabIndex = 0;
            this.UserInput.Text = "Usuário";
            this.UserInput.TextChanged += new System.EventHandler(this.UserBoxInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInput.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.ForeColor = System.Drawing.Color.Silver;
            this.PasswordInput.Location = new System.Drawing.Point(0, 65);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(322, 36);
            this.PasswordInput.TabIndex = 1;
            this.PasswordInput.Text = "Senha";
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // btLogar
            // 
            this.btLogar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btLogar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogar.ForeColor = System.Drawing.Color.White;
            this.btLogar.Location = new System.Drawing.Point(0, 137);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(322, 51);
            this.btLogar.TabIndex = 2;
            this.btLogar.Text = "Logar";
            this.btLogar.UseVisualStyleBackColor = false;
            // 
            // BinanceHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1373, 795);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BinanceHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label WindowName;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button btLogar;
    }
}

