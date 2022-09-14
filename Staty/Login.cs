using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staty
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Wprowadź dane");
            }

            else if (tbUser.Text == "admin" && tbPassword.Text == "admin")
            {
                Stats stats = new Stats();
                stats.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Błędne dane logowania");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
