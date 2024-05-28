using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_2705
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0 && txtSenha.Text.Length == 0) 
            { 
                MessageBox.Show("Voce nao digitou o usuario e senha");
            } else
            {
                MessageBox.Show("Entrando no sistema aguarde...");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
