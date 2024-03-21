using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Scheduly_2.Resources.Model
{   
    public class User
    {
        public static SQLiteConnection Database { get; set; }
        private static string dbPath; // Verschieben Sie die Deklaration hierhin
        static User()
        {
            // Überprüfen, ob die Datenbankdatei existiert, falls nicht, erstellen
            if (!File.Exists(dbPath))
            {
                File.Create(dbPath).Dispose();
            }

            // Datenbankverbindung herstellen und Tabelle erstellen
            Database = new SQLiteConnection(dbPath);
            Database.CreateTable<UserD>();
        }
        


        [Table("Table")]
        public class UserD
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

        }
    }
}