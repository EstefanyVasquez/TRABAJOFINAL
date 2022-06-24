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
    public partial class Form7 : Form
    {
        public Form7()
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
            string insertar = "INSERT INTO Expediente(f_creacion, cod_exp, cod_emp, nom_pac, ape_pac, f_naci, genero, l_naci, cell, d_actual) VALUES(@f_c, @cd_exp, @cd_emp, @nom, @ape, @f_n, @gen, @l_n, @cell, @d_a)";
            SqlCommand cmd1 = new SqlCommand(insertar, Class1.Conectar());
            cmd1.Parameters.AddWithValue("@f_c", textBox1.Text);
            cmd1.Parameters.AddWithValue("@cd_exp", textBox2.Text);
            cmd1.Parameters.AddWithValue("@cd_emp", textBox3.Text);
            cmd1.Parameters.AddWithValue("@nom", textBox4.Text);
            cmd1.Parameters.AddWithValue("@ape", textBox5.Text);
            cmd1.Parameters.AddWithValue("@f_n", textBox6.Text);
            cmd1.Parameters.AddWithValue("@gen", comboBox2.SelectedItem.ToString());
            cmd1.Parameters.AddWithValue("@l_n", textBox8.Text);
            cmd1.Parameters.AddWithValue("@cell", textBox9.Text);
            cmd1.Parameters.AddWithValue("@d_a", textBox10.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Guardado.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox2.SelectedItem = null;
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("M");
            comboBox2.Items.Add("F");
        }
    }
}
