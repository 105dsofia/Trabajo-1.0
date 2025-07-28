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
  

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass, correct_pass, correct_user;
            user = textBox1.Text;
            pass = textBox2.Text;
            correct_user = "Usuario1";
            correct_pass = "123";
            if (user == correct_user & pass == correct_pass)

            {

                Paginadeinicio principal = new Paginadeinicio();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 principal = new Form2();
            principal.Show();
            this.Hide();
        }
    }
}
