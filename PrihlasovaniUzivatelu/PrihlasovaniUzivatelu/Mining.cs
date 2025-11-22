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
        //tady jsem si musel pomoct pomocí internetu (protože jsem nevěděl že vůbec nějakej callback existoval :D)
        private Action<double>_addBalance_;

        int moneyadding = 0;
        public Mining(Action<double> addBalance_)
        {
            InitializeComponent();
            //změna kurzor
            this.Cursor = new Cursor(new MemoryStream(Properties.Resources.myCursor2));
            //Uložení callbacku ig ????
            _addBalance_ = addBalance_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //přidání 10 do balance
            _addBalance_(10);

            //Bude ukazovat kolik jsme vidělali miněním
            moneyadding += 10;
            //Jelikož mi něšlo tam prostě napsat "Funds.Text = _addBalance_.ToString();" tak jsem musel nahoře udělat "int moneyadding" kterýmu to vždycky přičte 10 a pak to tam napíše
            Funds.Text = moneyadding.ToString();
        }
    }
}
