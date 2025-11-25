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
        //dostanu username z martinovy metody 
       public ActionManager (string _Username)
       {
            _Username = Username;
       }
       public static void Admin(string _username)
       {
         AdminScreen admin = new AdminScreen();
         admin.Show();  
       }
       public static void OtherUsers(string _username)
       {
            Form2 f2 = new Form2();
            f2.Show();
       }
      

      
        
    }
}
