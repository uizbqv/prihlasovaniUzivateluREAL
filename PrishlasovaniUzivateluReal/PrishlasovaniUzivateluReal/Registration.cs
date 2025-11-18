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
            dontMatchLABEL.Visible = false;
            passwordBOX.Text = "";
            passwordBOX.PasswordChar = '*';
            passwordAgainBOX.Text = "";
            passwordAgainBOX.PasswordChar = '*';
        }

        private void registerBUTTON_Click(object sender, EventArgs e)
        {
            string usernameREG = usernameBOX.Text;
            string passwordREG = passwordBOX.Text;
            string passwordAgainREG = passwordAgainBOX.Text;
            //UserManager.Registration(usernameREG, passwordREG, passwordAgainREG);
            UserManager um = new UserManager(dontMatchLABEL);
            um.Registration(usernameREG, passwordREG, passwordAgainREG);
        }
    }
}
