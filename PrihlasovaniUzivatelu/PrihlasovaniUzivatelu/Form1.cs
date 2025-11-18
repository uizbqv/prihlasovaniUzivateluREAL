using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrihlasovaniUzivatelu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passwordBOX1.Text = "";
            // The password character is an asterisk.
            passwordBOX1.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ahoj lidi, tohle je zkouska

            //jsem diddler
        }



        private void logInBUTTON1_Click(object sender, EventArgs e)
        {
            string username = usernameBOX1.Text;
            string password = passwordBOX1.Text;
            UserManager.LogIn(username, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void registerLABEL_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
