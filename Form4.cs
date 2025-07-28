using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Articulos = new Form2();
            Articulos.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paginadeinicio Inicio = new Paginadeinicio();
            Inicio.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void acercaDeNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Ayuda = new Form5();
            Ayuda.Show();
            this.Hide();
        }
    }
}
