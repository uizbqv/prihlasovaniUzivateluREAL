using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrihlasovaniUzivatelu
{
    public partial class Admin_Vypsat_Users : Form
    {
        public Admin_Vypsat_Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("users.json");

            //Půjčím si Users z registeredUser (Od martina)
            var users = JsonSerializer.Deserialize<List<RegisteredUser>>(json);

            //Vyčistím listbox
            UsersListBox.Items.Clear();

            //Přidám username do listboxu
            foreach (var user in users)
            {
                UsersListBox.Items.Add(user.username);
            }
        }
    }
}
