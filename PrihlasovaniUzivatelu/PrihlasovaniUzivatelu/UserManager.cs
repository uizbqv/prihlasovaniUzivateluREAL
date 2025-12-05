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
        protected Label _label2;
        public UserManager(Label label, Label label2) 
        {
            _label = label;
            _label2 = label2;
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
                ActionManager.Deciding(username);
                Form1? f1 = (Form1?)Application.OpenForms["Form1"];
                f1.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong password!"); //zatim vypise ze jsi kokot :3
            }




        }


       


        public void Registration(string _username, string _password, string _passwordAgain)
        {

            bool passwordControll = PasswordControl(_password);

            if (_password == _passwordAgain & passwordControll == true)
            {
                //ziska promenne
                string hashedPassword = PasswordHasher(_password);
                string username = _username;
                DateTime registrationTime = GetRegistrationDate();
                double balance = 1000; //DOUFÁM ŽE JSEM NIC NEPOSRAL -honzík
                //vytvori noveho uzivatele
                RegisteredUser user = new RegisteredUser(username, hashedPassword, registrationTime,balance);
                IOManager.JsonConverterReg(user); //posle uzivatele k zapsani do 
            }
            
           

            else if (_password != _passwordAgain)
            {
                _label.Visible = true; //ukaze ze hesla nejsou stejny
            }

            else if (passwordControll == false)
            {
                _label2.Visible = true; //ukaze ze heslo není dostatečně bezpečné
            }


        }

        public bool PasswordControl(string _password ) 
        {
            bool passwordControll;
            bool bigChar = _password.Any(char.IsUpper); //zkontroluje že heslo obsahuje velké písmeno

            bool smallChar = _password.Any(char.IsLower); //zkontroluje že heslo obsahuje malé písmeno

            bool digit = _password.Any(char.IsDigit); //zkontroluje že heslo obsahuje číslici

            bool specialChar = _password.Any(ch => !char.IsLetterOrDigit(ch)); //zkontroluje že heslo obsahuje speciální znak

            bool longEnough = _password.Length >= 8; //obsahuje že heslo obsahuje 8 nebo více znaků

            //podmínky definují zda je heslo vpořádku 

            if (bigChar == true & smallChar == true & digit == true & specialChar == true & longEnough == true)
            {
                passwordControll = true;
            }

            else
            {
                passwordControll = false;
            }

            //vrátí true nebo false
            return passwordControll;
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
