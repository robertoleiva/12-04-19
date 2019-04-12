using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer2
{
    public partial class ejerB : Form
    {
        public ejerB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String usuario, password;
            usuario = textLogin.Text.TrimEnd();
            password = textPassword.Text.TrimEnd();

            if ((usuario == "UTEC") && (password == "Programacion1")) 
            {

                MessageBox.Show("BIENVENIDO AL SISTEMA"); 

            }
            else
            {
                MessageBox.Show("Verifique usuario y pass");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {







        }
    }
}
