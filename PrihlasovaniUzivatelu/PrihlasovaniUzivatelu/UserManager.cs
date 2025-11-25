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
            ActionManager honza = new ActionManager(_username);
            //zkontroluje, jestli jsou username i password vyplneny
            if (string.IsNullOrWhiteSpace(_username) || string.IsNullOrWhiteSpace(_password))
            {
                MessageBox.Show ("Please fill in both boxes!");
                return;
            }
            List<RegisteredUser> users = IOManager.JsonConverterLog(); //načte uživatele z jsonu
            RegisteredUser userFromJson = users.FirstOrDefault(u => u.username == _username);

            if (userFromJson == null)
            {
                MessageBox.Show("User does not exist");
                return;
            }
            bool correct = VerifyPassword(_password, userFromJson.password); //ověří heslo

            if (correct)
            {
                MessageBox.Show("Login successful!"); //zatim jen vypise ze hesla jsou shodna a vyhrali jsme
                
                //tady pak bude neco jako if(username == "admin" a tam pak udelas nejakou akci kotě :3)
            }
            else
            {
                MessageBox.Show("Wrong password!"); //zatim vypise ze jsi kokot :3
            }




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
                IOManager.JsonConverterReg(user); //posle uzivatele k zapsani do jsonu
            }
            else
            {
                _label.Visible = true; //ukaze ze hesla nejsou stejny
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
            byte[] key = pbkdf2.GetBytes(keySize);
            string hash = Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(key);
            rng.Dispose();
            pbkdf2.Dispose();
            //Dispose() proste zahodi nahodny cislo aby se s nim nemohlo pracovat nikde jinde a nikdy jindy kvuli bezpecnosti
            return hash;


        }
        public static bool VerifyPassword(string _password, string _hash) //metoda nic neodkryptovává, jen znova vypocitava a porovnava znova zahashovane heslo s ulozenym zahashovanym heslem
        {
            const int keySize = 32;
            const int iterations = 100000;

            string[] parts = _hash.Split(':'); //hashovane heslo se uklada jako salt:enkodovaneHeslo, takze timto je rozdelim 
            byte[] salt = Convert.FromBase64String(parts[0]); //tady zjistim salt z rozdeleneho zahashovaneho hesla
            byte[] storedKey = Convert.FromBase64String(parts[1]); //tady zjistim enkodovaneHeslo z rozdeleneho zahashovaneho hesla

            //dostane heslo co zadal uzivatel ted, salt, stejny pocet opakovani
            // a stejny hashovaci algoritmus, takze to dokaze vytvorit stejny hash pokud je heslo spravne
            using var pbkdf2 = new Rfc2898DeriveBytes(_password, salt, iterations, HashAlgorithmName.SHA256); 
            byte[] enteredKey = pbkdf2.GetBytes(keySize);//tohle pak vypocita ten hash ze zadaneho hesla, takze vlastne tahle medota dela uplne to stejny jako ta primo nad ni

            return storedKey.SequenceEqual(enteredKey);
        }

    }
}
