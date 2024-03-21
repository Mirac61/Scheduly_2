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
using SQLite;

namespace Scheduly_2.Resources.Views
{
    public class Registreierung
    {
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string username = Benutzername_Eingabe.Text;
            string password = Passwort_Eingabe.Text;
            string email = EMail_Eingabe.Text;

            if (Registrierungsregeln(username, password, email))
            {
                if (UserErstellen(username, password, email))
                {
                    Intent intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                }
                else
                {

                }
            }
            else
            {

            }
        }


        private bool Registrierungsregeln(string username, string password, string email)
        {
            return !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(email);
        }

        private bool UserErstellen(string username, string password, string email)
        {
            try
            {
                User.UserD newUser = new User.UserD
                {
                    Username = username,
                    Password = password,
                    Email = email
                };

                int rowsAffected = User.Database.Insert(newUser);

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Erstellen des Benutzers: {ex}");
                return false;
            }
        }
    }
}