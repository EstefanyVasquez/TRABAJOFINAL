using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJOFINAL
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form forulario = new Form2();
            forulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                {
                    string insertar = "INSERT INTO Pacientes(Nom, Ape, Ciud, Cell, Email, F_naci, T_sangre) VALUES(@nom, @ape, @ciud, @cell, @ema,@fnaci,@sangre)";
                    SqlCommand cmd1 = new SqlCommand(insertar, Class1.Conectar());
                    cmd1.Parameters.AddWithValue("@nom", textBox2.Text);
                    cmd1.Parameters.AddWithValue("@ape", textBox3.Text);
                    cmd1.Parameters.AddWithValue("@ciud", textBox4.Text);
                    cmd1.Parameters.AddWithValue("@cell", textBox5.Text);
                    cmd1.Parameters.AddWithValue("@ema", textBox6.Text);
                    cmd1.Parameters.AddWithValue("@fnaci", textBox7.Text);
                    cmd1.Parameters.AddWithValue("@sangre", textBox8.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("¡Paciente Registrado Correctamente!.");
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                }

            }
            catch { }


        }
    }
}
