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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Ginecología");
            comboBox1.Items.Add("Obstetricia");
            dataGridView1.DataSource = llenargrid(Class1.Conectar());
            comboBox2.Items.Clear();
            comboBox2.Items.Add(" pm");
            comboBox2.Items.Add(" am");

        }
        public DataTable llenargrid(SqlConnection con)
        {
            DataTable tb = new DataTable();
            string strSql = "SELECT * FROM Citas";
            SqlCommand cmd = new SqlCommand(strSql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            return tb;
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Form2();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    string insertar = "INSERT INTO Citas(Cliente, Apellido, Fecha, Hora, Telefono, Area) VALUES(@cliente, @Apellido, @fecha, @hora, @cell,@area)";
                    SqlCommand cmd1 = new SqlCommand(insertar, Class1.Conectar());
                    cmd1.Parameters.AddWithValue("@cliente", textBox1.Text);
                    cmd1.Parameters.AddWithValue("@Apellido", textBox2.Text);
                    cmd1.Parameters.AddWithValue("@fecha", textBox3.Text);
                    cmd1.Parameters.AddWithValue("@hora", textBox4.Text + comboBox2.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@Cell", textBox5.Text);
                    cmd1.Parameters.AddWithValue("@area", comboBox1.SelectedItem.ToString());
                    cmd1.ExecuteNonQuery();
                    dataGridView1.DataSource = llenargrid(Class1.Conectar());
                    delete();
                }

            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    string update = "UPDATE Citas SET Cliente =@cliente, Apellido = @Apellido, Fecha = @fecha, Hora = @hora, Telefono = @cell, Area = @area WHERE ID = @ID";
                    SqlCommand cmd1 = new SqlCommand(update, Class1.Conectar());
                    cmd1.Parameters.AddWithValue("@cliente", textBox1.Text);
                    cmd1.Parameters.AddWithValue("@Apellido", textBox2.Text);
                    cmd1.Parameters.AddWithValue("@fecha", textBox3.Text);
                    cmd1.Parameters.AddWithValue("@hora", textBox4.Text + comboBox2.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@Cell", textBox5.Text);
                    cmd1.Parameters.AddWithValue("@area", comboBox1.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd1.ExecuteNonQuery();
                    dataGridView1.DataSource = llenargrid(Class1.Conectar());
                    delete();
                }

            }
            catch { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    string eliminar = "DELETE FROM Citas WHERE ID=@ID";
                    SqlCommand cmd3 = new SqlCommand(eliminar, Class1.Conectar());
                    cmd3.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd3.ExecuteNonQuery();
                    dataGridView1.DataSource = llenargrid(Class1.Conectar());
                    delete();
                }
            }
            catch { }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = string.Join("", dataGridView1.CurrentRow.Cells[4].Value.ToString().Split('a', 'p', 'm'));
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
 
        }
        private void delete()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}
