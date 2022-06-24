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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                string insertar = "INSERT INTO Usuarios(Nombre,Apellido,Usuario,Pass,Cell) VALUES(@nom, @ape,@usu,@con,@cell)";
                SqlCommand cmd1 = new SqlCommand(insertar, Class1.Conectar());
                cmd1.Parameters.AddWithValue("@nom", textBox1.Text);
                cmd1.Parameters.AddWithValue("@ape", textBox2.Text);
                cmd1.Parameters.AddWithValue("@usu", textBox3.Text);
                cmd1.Parameters.AddWithValue("@con", textBox4.Text);
                cmd1.Parameters.AddWithValue("@cell", textBox5.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado.");

                this.Hide();
                Form formulario = new Form1();
                formulario.Show();
            }

        }
    }
}
