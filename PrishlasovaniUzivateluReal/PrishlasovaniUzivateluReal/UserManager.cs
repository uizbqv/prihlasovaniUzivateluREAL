using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrihlasovaniUzivatelu
{
    internal class UserManager
    {
        protected Label _label;
        public UserManager(Label label) 
        {
            _label = label;
        }


        public static void LogIn(string _username, string _password)
        {
            //ziskani promennych
            string username = _username;
            string password = _password;




        }
        public void Registration(string _username, string _password, string _passwordAgain)
        {
           
            if (_password == _passwordAgain)
            {
                //ziska promenne
                string hashedPassword = PasswordHasher(_password);
                string username = _username;
                DateTime registrationTime = GetRegistrationDate();
                //vytvori noveho uzivatele
                RegisteredUser user = new RegisteredUser(username, hashedPassword, registrationTime);
                IOManager.JsonConverterReg(user);
            }
            else
            {
                ShowLabel();//ukaze ze hesla nejsou stejny
            }



        }

        private static DateTime GetRegistrationDate()
        {
            //ziska aktualni cas a datum(myslim)
            DateTime currentDate = DateTime.Now;
            return currentDate;
        }

        private static string PasswordHasher(string _password)//tohle cely neni z my hlavy, NIKDY bych na to neprisel takze se me na to u obhajob neprejte prosim 
        {
            const int saltSize = 32;
            const int keySize = 32;
            const int iterations = 100000;
            //randomnumbergenerator je oproti klasickýmu randomu nepredvidatelny, proto se pouziva na tyhle veci
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[saltSize];
            rng.GetBytes(salt);
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(_password, salt, iterations, HashAlgorithmName.SHA256);
            //pbkdf2 je kryptografický algoritmus používaný k derivování silného kryptografického klíče z hesla (ať to znamená cokoli)
            byte[] key = new byte[keySize];
            string hash = Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(key);
            rng.Dispose();
            pbkdf2.Dispose();
            //Dispose() proste zahodi nahodny cislo aby se s nim nemohlo pracovat nikde jinde a nikdy jindy
            return hash;


        }
        private void ShowLabel() 
        {
            _label.Visible = true;
        }

    }
}
