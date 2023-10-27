using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Binance
{
    public partial class CentralScreen : Form
    {
        public CentralScreen()
        {
            InitializeComponent();
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ValorDespesaBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ValorDespesaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere é um dígito, ponto decimal, ou tecla de controle (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Rejeita o caractere
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains("."))
            {
                e.Handled = true; // Rejeita caracteres adicionais de ponto decimal
            }
        }

        private void ValorDespesaBox_Validating(object sender, CancelEventArgs e)
        {
            // Verifica se o texto inserido pode ser convertido em um número float
            if (!float.TryParse(ValorDespesaBox.Text, out float result))
            {
                e.Cancel = true; // Cancela a validação se não for um número float válido
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
