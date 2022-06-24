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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    loggin dni = new loggin();
                    Class1 conexion = new Class1();
                    DataTable tb = dni.dni(Convert.ToInt32(textBox1.Text), Class1.Conectar());

                    if (tb.Rows.Count > 0)
                    {

                        this.Hide();
                        Form forulario = new Form7();
                        forulario.Show();
                    }
                    else
                    {
                        MessageBox.Show("DNI incorrecto");
                        if (textBox1.Text == "")
                        {
                            textBox1.Focus();
                        }

                    }
                }
            }
            catch { }


        }
    }
}
