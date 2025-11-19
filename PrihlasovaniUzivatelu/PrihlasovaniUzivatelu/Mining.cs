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
    public partial class Mining : Form
    {
        public Mining()
        {
            InitializeComponent();
            this.Cursor = new Cursor(new MemoryStream(Properties.Resources.myCursor));
        }


        private void Mining_Load(object sender, EventArgs e)
        {

        }

    }
}
