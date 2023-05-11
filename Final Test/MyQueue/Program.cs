using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System;
using System.IO;

namespace ConsoleApp
{
    public class PlayerSettings
    {
        public string PlayerName { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public string[] Inventory { get; set; }
        public string LicenseKey { get; set; }

        // Singleton instance
        private static PlayerSettings instance;

        private PlayerSettings()
        {
            // Private constructor to prevent external instantiation
        }

        public static PlayerSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = LoadSettings();
                }
                return instance;
            }
        }

        public void SaveSettings()
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText("settings.json", json);
        }

        private static PlayerSettings LoadSettings()
        {
            if (File.Exists("settings.json"))
            {
                string json = File.ReadAllText("settings.json");
                return JsonConvert.DeserializeObject<PlayerSettings>(json);
            }

            // If no settings file found, return a new instance with default values
            return new PlayerSettings();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PlayerSettings playerSettings = PlayerSettings.Instance;

            // Update player settings
            playerSettings.PlayerName = "dschuh";
            playerSettings.Level = 4;
            playerSettings.HP = 99;
            playerSettings.Inventory = new string[]
            {
                "spear", "water bottle", "hammer", "sonic screwdriver", "cannonball",
                "wood", "Scooby snack", "Hydra", "poisonous potato", "dead bush", "repair powder"
            };
            playerSettings.LicenseKey = "DFGU99-1454";

            // Save player settings to file
            playerSettings.SaveSettings();

            // Read and display player settings
            PlayerSettings loadedSettings = PlayerSettings.Instance;
            Console.WriteLine($"Player Name: {loadedSettings.PlayerName}");
            Console.WriteLine($"Level: {loadedSettings.Level}");
            Console.WriteLine($"HP: {loadedSettings.HP}");
            Console.WriteLine("Inventory:");
            foreach (string item in loadedSettings.Inventory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"License Key: {loadedSettings.LicenseKey}");

            Console.ReadLine();
        }
    }
}
