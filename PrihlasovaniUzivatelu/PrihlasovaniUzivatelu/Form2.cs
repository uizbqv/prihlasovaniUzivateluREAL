using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrihlasovaniUzivatelu
{
    public partial class Form2 : Form
    {
        //random pro random hodnoty
        Random rdm1 = new Random();
        Random rdm2 = new Random();
        Random rdm3 = new Random();

        double balance = 1000;
        double investment;

        int S1, S2, S3;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private Image PictureGiver(int multiS)
        {
            //Case na rozdělování těch obrázků
            switch (multiS)
            {
                case 1:
                    return Properties.Resources.Diamant;
                case 2:
                    return Properties.Resources.Cherry;
                case 3:
                    return Properties.Resources._7;
                case 4:
                    return Properties.Resources.Pear;
                case 5:
                    return Properties.Resources.Lemon;

                default:
                    return null;
            }
        }

        private void RerollButton_Click(object sender, EventArgs e)
        {

            //Investment = kolik chce gamblit 
            investment = Convert.ToDouble(Investment.Text);


            //Kontrola proti blbům
            if (investment <= 0)
            {
                MessageBox.Show("You cant gamble if you dont invest anything!");
                return;
            }

            if (investment > balance)
            {
                MessageBox.Show("You cant gamble more than you have!");
                return;
            }

            if (balance <= 0)
            {
                MessageBox.Show("You got no money (Go mine for us boy)");
                return;
            }


            //S* znamená Slot takže Slot 1 až 3
            S1 = rdm1.Next(1, 5);
            S2 = rdm2.Next(1, 5);
            S3 = rdm3.Next(1, 5);

            //Udělá to že dává pictureboxům obrázky podle toho co vygeneruje random (přes tu metodu picturegiver)
            pictureSlot1.Image = PictureGiver(S1);
            pictureSlot2.Image = PictureGiver(S2);
            pictureSlot3.Image = PictureGiver(S3);

            //Gamblení výhry a prohry
            GambleOutcome();

        }

        private void GambleOutcome()
        {
            //Tady se bude řešit výhra a prohra
            balance -= investment;
            NumberOfFunds.Text = balance.ToString();

            if (S1 == S2 && S2 == S3)
            {
                //WIN!!!!
                double win = investment * 2;

                balance += win;
                NumberOfFunds.Text = balance.ToString();

                GambleVýsledek.Text = "You won " + win.ToString() + " Dollars!";
            }
            else if (S1 == S2 || S2 == S3 || S1 == S3)
            {

                //Menší win :/
                double win = investment * 0.5;

                balance += win;
                NumberOfFunds.Text = balance.ToString();

                GambleVýsledek.Text = "You won " + win.ToString() + " Dollars!";
            }
            else
            {
                //Loss (nemumíš gamblit :PPP)
                GambleVýsledek.Text = "You lost " + investment.ToString() + " Dollars!";
            }

        }
        //Metoda která bude přidávat balance z mininění
        public void addBalance(double amount)
        {
            balance += amount;
            NumberOfFunds.Text = balance.ToString();
        }
        //Tlačítko pro otevření mininění
        private void button1_Click(object sender, EventArgs e)
        {
            //Otevře to mining plus to tomu předá tu metodu pro přidávání money :P
            Mining mine = new Mining(addBalance);
            mine.Show();
            MessageBox.Show("Craftsino will only take 99% of all emerald value you will mine (leaving you with 10 coins for each mine)");
       
        }
    }
}
