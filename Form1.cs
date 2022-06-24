using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJOFINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loggin loggin = new loggin();
            Class1 conexion = new Class1();
            DataTable tb = loggin.login(textBox1.Text, textBox2.Text, Class1.Conectar());

            if (tb.Rows.Count > 0)
            {

                this.Hide();
                Form formulario = new Form2();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else
                {
                    textBox2.Focus();
                }

            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form forulario = new Form3();
            forulario.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
