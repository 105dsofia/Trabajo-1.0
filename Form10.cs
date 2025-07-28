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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Ayuda = new Form5();
            Ayuda.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paginadeinicio Inicio = new Paginadeinicio();
            Inicio.Show();
            this.Hide();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Articulos = new Form2();
            Articulos.Show();
            this.Hide();
        }
    }
}
