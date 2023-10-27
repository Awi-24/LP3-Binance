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
            this.LoginBox.Location = new System.Drawing.Point(464, 193);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(455, 382);
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
            this.RegisterButton.Location = new System.Drawing.Point(230, 295);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(205, 59);
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
            this.LoginButton.Location = new System.Drawing.Point(19, 295);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(205, 59);
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
            this.PasswordBox.Location = new System.Drawing.Point(65, 209);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(322, 36);
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
            this.UserBox.Location = new System.Drawing.Point(65, 127);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(322, 36);
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
            this.LabelLoginRegister.Location = new System.Drawing.Point(33, 39);
            this.LabelLoginRegister.Name = "LabelLoginRegister";
            this.LabelLoginRegister.Size = new System.Drawing.Size(383, 40);
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
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Size = new System.Drawing.Size(1332, 29);
            this.MainWindow.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.Location = new System.Drawing.Point(1298, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 29);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1368, 727);
            this.Controls.Add(this.MainWindow);
            this.Controls.Add(this.LoginBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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

