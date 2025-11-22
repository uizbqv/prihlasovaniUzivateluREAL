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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            dontMatchLABEL.Visible = false; //nastavi text "passwords don't match" na neviditelny :3
            passwordBOX.Text = "";
            passwordBOX.PasswordChar = '■'; //nebudou videt pismena pri psani ale *
            passwordAgainBOX.Text = "";
            passwordAgainBOX.PasswordChar = '■';
            this.AcceptButton = registerBUTTON; //kdyz se zmackne enter kdekoli tak to zmackne register tlacitko
        }

        private void registerBUTTON_Click(object sender, EventArgs e)
        {
            string usernameREG = usernameBOX.Text;
            string passwordREG = passwordBOX.Text;
            string passwordAgainREG = passwordAgainBOX.Text;
            if (string.IsNullOrWhiteSpace(usernameREG) || string.IsNullOrWhiteSpace(passwordREG) || string.IsNullOrWhiteSpace(passwordAgainREG))
            {
                MessageBox.Show("Please fill in all boxes!");
                return;
            }
            UserManager um = new UserManager(dontMatchLABEL);
            um.Registration(usernameREG, passwordREG, passwordAgainREG);
            this.Close();
            Form1? f1 = (Form1?)Application.OpenForms["Form1"]; //Application.OpenForms hledá všechny forms co jsou ted otevreny, ["Form1"] hleda presne form1
            f1.WindowState = FormWindowState.Normal;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1? f1 = (Form1?)Application.OpenForms["Form1"];
            f1.WindowState = FormWindowState.Normal;
        }
    }
}
