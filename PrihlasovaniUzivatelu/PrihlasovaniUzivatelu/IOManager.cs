using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static PrihlasovaniUzivatelu.IOManager;

namespace PrihlasovaniUzivatelu
{
    internal class IOManager
    {
        //deklarování cesty k souboru json
        public static string filePath = Path.GetFullPath (Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\users.json") );


        //metoda pro registraci uživatele, načte zadané hodnoty, přidá nového uživatele a zapíše ho do souboru 
        public static void JsonConverterReg(RegisteredUser user)
        {
            //deklarování listu který obsahuje třídu registeredUser, která obsahuje hodnoty uživatele (username, heslo a čas registrace)
            List<RegisteredUser> users = new();

            //nastavení json zápisu
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                //aby uměl zapisovat diakritiku
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All),
                
                //úprava zápisu, aby vypadal "lidsky" = každá hodnota na novém řádku, přehledná struktura...
                WriteIndented = true
            };

            //kontrola, že soubor json již existuje, jinak by serializace sama od sebe vytvořila nový a cesta by nefungovala, takže by program spadl
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                string existingJson = File.ReadAllText(filePath);
                var loadedUsers = JsonSerializer.Deserialize<List<RegisteredUser>>(existingJson, options);

                if (loadedUsers != null)
                    users = loadedUsers;
            }

            //přidání nového uživatele do listu
            users.Add(user);

          //serializace a vypsání hodnot
            string json = JsonSerializer.Serialize(users,options);
            File.WriteAllText(filePath, json);
        }

        //metoda pro přihlášení, přečte json soubor a načte uživatele, pokud existuje samozřejmě
        public static List<RegisteredUser> JsonConverterLog()
        {
            //ověří že soubor existuje
            if (!File.Exists(filePath))
                return new List<RegisteredUser>();

            //přečte json, deserializije ho a vrátí string
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<RegisteredUser>>(json)

            //vrátí prázdný list místo null
            ?? new List<RegisteredUser>();
           
        }


        


    }
}
