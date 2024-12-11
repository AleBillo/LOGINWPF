using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Login_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class Login : Window
    {
        private Model.Utenti utenti;
        Registration registration; 
        Welcome welcome; 
        public Login()
        {
            InitializeComponent();
            utenti = new Model.Utenti();
            utenti.LeggiUtenti();
            registration = new Registration();
            welcome = new Welcome();
        }
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                string email = textBoxEmail.Text;
                string password = passwordBox1.Password;
                if (utenti.CredenzialiCorrette(email, password))
                {
                    if (utenti.IsAdmin(email) == false)
                    {
                        string fullName = utenti.GetFullName(email);
                        welcome.TextBlockName.Text = fullName;//Passaggio di un valore da una windows ad un'altra
                        welcome.Show();
                        Close();
                    }
                    else if(utenti.IsAdmin(email) == true)
                    {
                        string fullName = utenti.GetFullName(email);
                        welcome.TextBlockName.Text = fullName;//Passaggio di un valore da una windows ad un'altra
                        welcome.SeAdmin_textBlock.Text = "Sei l'admin di questo sito\n ecco a te gli utenti:";
                        for (int i = 0; i < 100; i++)
                        {
                            welcome.Utenti_Listbox.Items.Add(utenti.InserisciUtentiLista());
                        }
                       
                        welcome.Show();
                        Close();
                    }
                    
                }
                else
                {
                    errormessage.Text = "Sorry! Please enter existing emailid/password.";
                }
            }
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }

    }
}
