using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_2705
{
    public partial class Exemplo : Form
    {
        public Exemplo()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            txtSalvarEx.Text = "Texto Alterado";
            btnApagar.Enabled = true;// habilitar o botao apagar apos o load
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtSalvarEx.Text.Length == 0)
            {
                MessageBox.Show("nada para limpar");
            }
            else
            {
                txtSalvarEx.Text = "";
                btnApagar.Enabled = false;
            }
           // txtSalvarEx.Text = "Apagado";
        }
        private void Exemplo_Load(object sender, EventArgs e) // assim que abrir o form carrega algo
        {
            btnApagar.Enabled = false; // desabilitar o botão apagar
        }

       

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog(); // instanciar sua janela Cliente (show),Metodo para ocultar(anular) a janela de tras(dialog)
        }
    }   
}
