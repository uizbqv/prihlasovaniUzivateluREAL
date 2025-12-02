using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrihlasovaniUzivatelu
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //otevreni form Infinite_Craftsino
            Infinite_Craftsino r = new Infinite_Craftsino();
            r.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //otevreni form Admin_Vypsat_Users
            Button2 r = new Button2();
            r.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
