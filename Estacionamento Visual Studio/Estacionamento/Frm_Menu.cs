using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

     

            this.Visible = false;
            Frm_Clientes produtos = new Frm_Clientes();
            produtos.ShowDialog();
            this.Visible = true;

  

    }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Frm_Veiculo veiculo = new Frm_Veiculo();
            veiculo.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Frm_Veiculo veiculo = new Frm_Veiculo();
            veiculo.ShowDialog();
            this.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Frm_Clientes produtos = new Frm_Clientes();
            produtos.ShowDialog();
            this.Visible = true;
        }
    }
}
