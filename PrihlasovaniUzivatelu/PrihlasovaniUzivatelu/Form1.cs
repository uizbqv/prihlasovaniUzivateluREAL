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
            passwordBOX1.PasswordChar = '■'; //nastavi aby heslo nebylo videt
            this.AcceptButton = logInBUTTON1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void logInBUTTON1_Click(object sender, EventArgs e)
        {
            string username = usernameBOX1.Text;
            string password = passwordBOX1.Text;
            UserManager.LogIn(username, password);
        }


        private void registerLABEL_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.WindowState = FormWindowState.Minimized;

        }

    }
}
