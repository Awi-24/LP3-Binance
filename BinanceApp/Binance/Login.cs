using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binance
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelLoginRegister_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Aqui você pode verificar a autenticação
            // Se a autenticação for bem-sucedida, crie e exiba a tela CentralWindow
            if (true)
            {
                CentralScreen centralWindow = new CentralScreen();
                centralWindow.ShowDialog();
            }
        }


        private void RegisterButton_Click(object sender, EventArgs e) 
        {

        }
    }
}
