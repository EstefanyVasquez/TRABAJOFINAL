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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Form4();
            formulario.Show();
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form forulario = new Form1();
            forulario.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form forulario = new Form5();
            forulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form forulario = new Form6();
            forulario.Show();
        }
    }
}
