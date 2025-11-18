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

        public static string filePath = "users.json";

        public static void JsonConverterReg(RegisteredUser user)
        {
            List<RegisteredUser> users = new();

         
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                string existingJson = File.ReadAllText(filePath);
                var loadedUsers = JsonSerializer.Deserialize<List<RegisteredUser>>(existingJson);

                if (loadedUsers != null)
                    users = loadedUsers;
            }

           
            users.Add(user);

          
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<RegisteredUser> JsonConverterLog()
        {
            if (!File.Exists(filePath))
                return new List<RegisteredUser>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<RegisteredUser>>(json)
                   ?? new List<RegisteredUser>();
        }


        /*
        public static string filePath = "users.json";


        static public void JsonConverterReg(RegisteredUser user)
        {

            List<RegisteredUser>? users = new();

            
           
            

            //Přidání nového uživatele
            users?.Add(user);

            //Zápis zpět do souboru
           
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, json);



        }

        static public void JsonConverterLog() 
        {

            string json = File.ReadAllText(filePath) ?? string.Empty;
            
            RegisteredUser user = JsonSerializer.Deserialize<RegisteredUser>(json);


        }









        internal static void JsonConverter(RegisteredUser user)
        {
            throw new NotImplementedException();
        }
        */




    }
}
