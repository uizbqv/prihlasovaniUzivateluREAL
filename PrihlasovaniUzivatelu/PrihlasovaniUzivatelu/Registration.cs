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
            notStrongEnoughLabel.Visible = false; //nastavi text "Password isn't strong enough" na neviditelny :)
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
            if (usernameREG.Equals("admin", StringComparison.OrdinalIgnoreCase)) //zjisti jestli jmeno neni admin + ignoruje velikost pismen pomoci StringComparison.OrdinalIgnoreCase
            {
                MessageBox.Show("Your password can't be \"admin\"!");
                return;
            }
            UserManager um = new UserManager(dontMatchLABEL, notStrongEnoughLabel);
            um.Registration(usernameREG, passwordREG, passwordAgainREG);
            if (passwordREG == passwordAgainREG)
            {
                Form1? f1 = (Form1?)Application.OpenForms["Form1"]; //Application.OpenForms hledá všechny forms co jsou ted otevreny, ["Form1"] hleda presne form1
                f1.WindowState = FormWindowState.Normal;
                this.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1? f1 = (Form1?)Application.OpenForms["Form1"];
            f1.WindowState = FormWindowState.Normal;
        }

        private void NotStrongEnoughLabel_Click(object sender, EventArgs e)
        {

        }

        private void dontMatchLABEL_Click(object sender, EventArgs e)
        {

        }
    }
}
