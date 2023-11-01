namespace Binance
{
    partial class Login
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
            this.LoginBox = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.LabelLoginRegister = new System.Windows.Forms.Label();
            this.MainWindow = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LoginBox.SuspendLayout();
            this.MainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBox.BackColor = System.Drawing.Color.BlueViolet;
            this.LoginBox.Controls.Add(this.RegisterButton);
            this.LoginBox.Controls.Add(this.LoginButton);
            this.LoginBox.Controls.Add(this.PasswordBox);
            this.LoginBox.Controls.Add(this.UserBox);
            this.LoginBox.Controls.Add(this.LabelLoginRegister);
            this.LoginBox.Location = new System.Drawing.Point(619, 238);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(607, 470);
            this.LoginBox.TabIndex = 0;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterButton.BackColor = System.Drawing.Color.Violet;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(307, 363);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(273, 73);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Registrar";
            this.RegisterButton.UseVisualStyleBackColor = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.Violet;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(25, 363);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(273, 73);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Logar";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PasswordBox.Location = new System.Drawing.Point(87, 257);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(429, 45);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.Tag = "Insira Sua Senha";
            this.PasswordBox.Text = "Insira Sua Senha";
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // UserBox
            // 
            this.UserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UserBox.Location = new System.Drawing.Point(87, 156);
            this.UserBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(429, 45);
            this.UserBox.TabIndex = 1;
            this.UserBox.Text = "Insira seu usuário";
            this.UserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelLoginRegister
            // 
            this.LabelLoginRegister.AutoSize = true;
            this.LabelLoginRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLoginRegister.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoginRegister.ForeColor = System.Drawing.Color.White;
            this.LabelLoginRegister.Location = new System.Drawing.Point(68, 50);
            this.LabelLoginRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLoginRegister.Name = "LabelLoginRegister";
            this.LabelLoginRegister.Size = new System.Drawing.Size(484, 50);
            this.LabelLoginRegister.TabIndex = 0;
            this.LabelLoginRegister.Text = "Faça seu Login ou Registro";
            this.LabelLoginRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelLoginRegister.Click += new System.EventHandler(this.LabelLoginRegister_Click);
            // 
            // MainWindow
            // 
            this.MainWindow.BackColor = System.Drawing.Color.BlueViolet;
            this.MainWindow.Controls.Add(this.CloseButton);
            this.MainWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainWindow.Location = new System.Drawing.Point(0, 0);
            this.MainWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Size = new System.Drawing.Size(1824, 36);
            this.MainWindow.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.Location = new System.Drawing.Point(1779, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 36);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1824, 895);
            this.Controls.Add(this.MainWindow);
            this.Controls.Add(this.LoginBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Binance";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.MainWindow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginBox;
        private System.Windows.Forms.Panel MainWindow;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label LabelLoginRegister;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
    }
}

