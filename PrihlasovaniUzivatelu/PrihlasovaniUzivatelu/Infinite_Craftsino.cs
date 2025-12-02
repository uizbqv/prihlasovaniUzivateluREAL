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
    public partial class Infinite_Craftsino : Form
    {
        // Random pro generování slotů
        Random rdm1 = new Random();
        Random rdm2 = new Random();
        Random rdm3 = new Random();

        double balance = 100000;
        double investment;

        int S1, S2, S3;

        public Infinite_Craftsino()
        {
            InitializeComponent();

            //udělalo reroll zase funkční
            RerollButton.Click += RerollButton_Click;

            // Inicializace fundů
            NumberOfFunds.Text = balance.ToString();
        }

        // Metoda na přiřazení obrázku podle čísla slotu
        private Image PictureGiver(int multiS)
        {
            switch (multiS)
            {
                case 1: return Properties.Resources.Diamant;
                case 2: return Properties.Resources.Cherry;
                case 3: return Properties.Resources._7;
                case 4: return Properties.Resources.Pear;
                case 5: return Properties.Resources.Lemon;
                default: return null;
            }
        }

        private void RerollButton_Click(object sender, EventArgs e)
        {
            // validace investice
            if (!double.TryParse(Investment.Text, out investment))
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            if (investment <= 0)
            {
                MessageBox.Show("You can't gamble if you dont invest anything!");
                return;
            }

            if (investment > balance)
            {
                MessageBox.Show("You can't gamble more than you have!");
                return;
            }

            if (balance <= 0)
            {
                MessageBox.Show("You got no money (Go mine for us boy)");
                return;
            }

            // generování slotů (1–5)
            S1 = rdm1.Next(1, 6);
            S2 = rdm2.Next(1, 6);
            S3 = rdm3.Next(1, 6);

            // přiřazení obrázků do PictureBoxů
            pictureSlot1.Image = PictureGiver(S1);
            pictureSlot2.Image = PictureGiver(S2);
            pictureSlot3.Image = PictureGiver(S3);

            // vyhodnocení výsledku
            GambleOutcome();
        }

        private void GambleOutcome()
        {
            // House má vždy peníze (žádný odčítání)

            NumberOfFunds.Text = balance.ToString();

            double win = 0;

            // výhra podle kombinace
            if (S1 == S2 && S2 == S3)
            {
                win = investment * 4;
                balance += win;
                GambleVýsledek.Text = $"You won {win} Dollars!";
            }
            else if (S1 == S2 || S2 == S3 || S1 == S3)
            {
                win = investment * 0.5;
                balance += win;
                GambleVýsledek.Text = $"You won {win} Dollars!";
            }
            else
            {
                GambleVýsledek.Text = $"You lost {investment} Dollars!";
            }

            // aktualizace balansu
            NumberOfFunds.Text = balance.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminScreen A1 = (AdminScreen)Application.OpenForms["AdminScreen"];
            A1.WindowState = FormWindowState.Normal;
        }
    }
}
