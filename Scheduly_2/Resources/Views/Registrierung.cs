/*
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
using System.Threading.Tasks;

namespace Scheduly_2.Resources.Views
{
    public class Registrierung : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.register_page);

            Button registerButton = FindViewById<Button>(Resource.Id.register);
            registerButton.Click += OnRegisterClicked;
        }

        public async void OnRegisterClicked(View view)
        {
            EditText benutzername = FindViewById<EditText>(Resource.Id.userName);
            EditText passwort = FindViewById<EditText>(Resource.Id.password);
            EditText eMail = FindViewById<EditText>(Resource.Id.email);

            string username = benutzername.Text;
            string password = passwort.Text;
            string email = eMail.Text;

            if (Registrierungsregeln(username, password, email))
            {
                if (UserErstellen(username, password, email))
                {
                    await Task.Delay(100); // Add a small delay
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

        public bool Registrierungsregeln(string username, string password, string email)
        {
            return !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(email);
        }

        public bool UserErstellen(string username, string password, string email)
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
using System.Threading.Tasks;
using Scheduly_2;

namespace Scheduly_2.Resources.Views
{
    public class Registrierung : Activity
    {
        public class Registrierung : Activity
        {
            protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.register_page);

                Button registerButton = FindViewById<Button>(Resource.Id.register);
                registerButton.Click += OnRegisterClicked;
            }

            public void OnRegisterClicked(object sender, EventArgs e)
            {
                EditText benutzername = FindViewById<EditText>(Resource.Id.userName);
                EditText passwort = FindViewById<EditText>(Resource.Id.password);
                EditText eMail = FindViewById<EditText>(Resource.Id.email);

                string username = benutzername.Text;
                string password = passwort.Text;
                string email = eMail.Text;

                if (Registrierungsregeln(username, password, email))
                {
                    if (UserErstellen(username, password, email))
                    {
                        await Task.Delay(100); // Add a small delay
                        Intent intent = new Intent(this, typeof(MainActivity));
                        StartActivity(intent);
                    }
                    else
                    {
                        // Handle error
                    }
                }
                else
                {
                    // Handle error
                }
            }

            public bool Registrierungsregeln(string username, string password, string email)
            {
                return !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(email);
            }

            public bool UserErstellen(string username, string password, string email)
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

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Erstellen des Benutzers: {ex}");
                    return false;
                }
            }
        }

        public async void OnRegisterClicked(View view)
        {
            EditText benutzername = FindViewById<EditText>(Resource.Id.userName);
            EditText passwort = FindViewById<EditText>(Resource.Id.password);
            EditText eMail = FindViewById<EditText>(Resource.Id.email);

            string username = benutzername.Text;
            string password = passwort.Text;
            string email = eMail.Text;

            if (Registrierungsregeln(username, password, email))
            {
                if (UserErstellen(username, password, email))
                {
                    await Task.Delay(100); // Add a small delay
                    Intent intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                }
                else
                {
                    // Handle error
                }
            }
            else
            {
                // Handle error
            }
        }

        public bool Registrierungsregeln(string username, string password, string email)
        {
            return !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(email);
        }

        public bool UserErstellen(string username, string password, string email)
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

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Erstellen des Benutzers: {ex}");
                return false;
            }
        }
    }

public class Registrierung : Activity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.register_page);

        Button registerButton = FindViewById<Button>(Resource.Id.register);
        registerButton.Click += OnRegisterClicked;
    }

    public async void OnRegisterClicked(object sender, EventArgs e)
    {
        EditText benutzername = FindViewById<EditText>(Resource.Id.userName);
        EditText passwort = FindViewById<EditText>(Resource.Id.password);
        EditText eMail = FindViewById<EditText>(Resource.Id.email);

        string username = benutzername.Text;
        string password = passwort.Text;
        string email = eMail.Text;

        if (Registrierungsregeln(username, password, email))
        {
            if (await UserErstellen(username, password, email))
            {
                await Task.Delay(100); // Add a small delay
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }
            else
            {
                // Handle error
            }
        }
        else
        {
            // Handle error
        }
    }

    public bool Registrierungsregeln(string username, string password, string email)
    {
        return !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(email);
    }

    public async Task<bool> UserErstellen(string username, string password, string email)
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

            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Erstellen des Benutzers: {ex}");
            return false;
        }
    }
}*/

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
using System.Threading.Tasks;
using Scheduly_2;


namespace YourNamespace
{
    [Activity(Label = "RegistrierungsAktivität")]
    public class Registrierung : Activity
    {
        private Button registrierenButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.register_page);

            registrierenButton = FindViewById<Button>(Resource.Id.register);
            registrierenButton.Click += OnRegisterClicked;
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            EditText benutzernameEditText = FindViewById<EditText>(Resource.Id.userName);
            EditText passwortEditText = FindViewById<EditText>(Resource.Id.password);
            EditText eMailEditText = FindViewById<EditText>(Resource.Id.email);

            string benutzername = benutzernameEditText.Text;
            string passwort = passwortEditText.Text;
            string eMail = eMailEditText.Text;

            if (string.IsNullOrEmpty(benutzername) || string.IsNullOrEmpty(passwort) || string.IsNullOrEmpty(eMail))
            {
                ZeigeFehlerNachricht("Bitte geben Sie einen gültigen Benutzernamen, Passwort und E-Mail-Adresse ein.");
                return;
            }

            try
            {
                if (await BenutzerErstellen(benutzername, passwort, eMail))
                {
                    StartActivity(new Intent(this, typeof(MainActivity)));
                }
                else
                {
                    ZeigeFehlerNachricht("Benutzererstellung fehlgeschlagen. Bitte versuchen Sie es später nochmal.");
                }
            }
            catch (Exception ex)
            {
                ZeigeFehlerNachricht("Beim Erstellen des Benutzers ist ein Fehler aufgetreten. Bitte versuchen Sie es später nochmal.");
                Console.WriteLine($"Fehler beim Erstellen des Benutzers: {ex}");
            }
        }

        private async Task<bool> BenutzerErstellen(string benutzername, string passwort, string eMail)
        {
            // Implementieren Sie Ihre Benutzererstellungslogik hier
            // Geben Sie true zurück, wenn der Benutzer erfolgreich erstellt wurde, andernfalls false
            // Sie können eine API-Anruf oder eine andere Methode verwenden, um den Benutzer zu erstellen
            await Task.Delay(1000); // Simulieren Sie die Verzögerung bei der Benutzererstellung
            return true;
        }

        private void ZeigeFehlerNachricht(string nachricht)
        {
            Toast.MakeText(this, nachricht, ToastLength.Short).Show();
        }
    }
}