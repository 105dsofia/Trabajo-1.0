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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form6 Info = new Form6();
            Info.Show();
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

        private void btn2_Click(object sender, EventArgs e)
        {
            Form7 Comosecreo = new Form7();
            Comosecreo.Show();
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form8 Proposito = new Form8();
            Proposito.Show();
            this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Form9 Mision = new Form9();
            Mision.Show();
            this.Hide();
        }
    }
}
