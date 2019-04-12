using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1, num2, suma;

            num1 = int.Parse(textNumero1.Text);
            num2 = int.Parse(textNumero2.Text);

            suma = num1 + num2;
            textResultado.Text = suma.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {


            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // textNumero1.Text = "";
            // textNumero2.Text = "";
            // textResultado.Text = ""; 

            textNumero1.Clear();
            textNumero2.Clear();
            textResultado.Clear();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
