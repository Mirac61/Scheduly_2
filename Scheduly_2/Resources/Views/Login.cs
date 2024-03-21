using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Scheduly_2.Resources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Scheduly_2.Resources.Views
{   
    public class Login : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login_page);   
        }
        public bool Benutzer(string benutzername, string email)
        {
            var benutzer = User.Database.Table<User.UserD>().FirstOrDefault(u => u.Username == benutzername);

            var benutzer2 = User.Database.Table<User.UserD>().FirstOrDefault(u => u.Email == email);

            // Wenn weder ein Benutzer mit dem Benutzernamen noch mit der E-Mail-Adresse vorhanden ist, geben Sie true zurück
            if (benutzer == null && benutzer2 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool legitimerbenutzer(string benutzernameOderEmail, string passwort)
        {
            var benutzer = User.Database.Table<User.UserD>().FirstOrDefault(u =>
                    u.Username == benutzernameOderEmail || u.Email == benutzernameOderEmail);

            if (benutzer != null && benutzer.Password == passwort)
            {
                return true;
            }

            return false;
        }

        public void LoginButton_Clicked(object sender, EventArgs e)
        {
            EditText benutzername = FindViewById<EditText>(Resource.Id.userName);
            EditText passwort = FindViewById<EditText>(Resource.Id.password);

            string benutzernameOderEmail = benutzername.Text.Trim();
            string Passwort = passwort.Text.Trim();

            if (string.IsNullOrWhiteSpace(benutzernameOderEmail) || string.IsNullOrWhiteSpace(Passwort))
            {

                return;
            }

            if (legitimerbenutzer(benutzernameOderEmail, Passwort))
            {
                Intent intent = new Intent(this, typeof(Hauptseite));
                StartActivity(intent);
            }
            else
            {
                
            }
            
        }

        public void Registrierung(View view)
        {
            
        }
    }
}