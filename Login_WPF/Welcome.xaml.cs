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
using System.Windows.Shapes;

namespace Login_WPF
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
            btnAdminSelect.IsEnabled = false;

        }
        private void btnAdminSelect_Click(object sender, RoutedEventArgs e)
        {
            string u = Utenti_Listbox.SelectedItem.ToString();
            utenti.CambiaRuolo(u);
        }

        private void Utenti_Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnAdminSelect.IsEnabled = true;
        }
    }
}
