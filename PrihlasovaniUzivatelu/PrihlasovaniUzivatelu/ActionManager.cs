using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrihlasovaniUzivatelu
{
    internal class ActionManager
    {
        string Username;
       public ActionManager (string _Username)
       {
            _Username = Username;
       }

       public static void AdminAction(string _Username)
       {
            AdminScreen admin = new AdminScreen();
            admin.Show();
       }

        public static void basicUserAction(string _Username)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }


    }
}
