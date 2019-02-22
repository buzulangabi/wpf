using elevi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace elevi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to do that?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);

            if (result == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }
        }

        private void AddElevs(object sender, RoutedEventArgs e)
        {

            Genul gen;

            if (masculin.IsChecked == true)
            {
                gen = Genul.Masculin;
            }
            else
            {
                gen = Genul.Feminin;
            }

            var elev = new Elev();
            var iDNP = idnp.Text;
            string characters = "abc\u0000def";
            Console.WriteLine(characters.Length);
            if (iDNP.Length != 13)
            {
                MessageBox.Show("Please insert a number with 13 digits", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            if (String.IsNullOrEmpty(iDNP))
            {
                MessageBox.Show("Please insert your IDNP", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            var lastName = Nume.Text;
            if (String.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please insert your Last Name,Dear!", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            var firstName = Prenume.Text;
            if (String.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please insert your First Name!", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            bool isClassValid = Int32.TryParse(Clasa.Text, out int result);
            if (isClassValid = false)
            {
                MessageBox.Show("Please insert your grade correctly", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            
            if (datanasterii.SelectedDate == null)
            {
                MessageBox.Show("Please insert a date", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var dataNasterii = datanasterii.SelectedDate.Value;
            if (dataNasterii > DateTime.Now)
            {
                MessageBox.Show("Please insert a correct Birth Date", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            elev.Gen = gen;
            elev.Adresa = new Adresa();
            var orasul = Orasul.Text;
            if (String.IsNullOrEmpty(orasul))
            {
                MessageBox.Show("Please insert your City", "Warning ", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            var strada = Strada.Text;
            if (String.IsNullOrEmpty(strada))
            {
                MessageBox.Show("Please insert your Street", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            bool isBlocValid = Int32.TryParse(Blocul.Text, out int result2);
            if (isBlocValid = false)
            {
                MessageBox.Show("Please insert Blocul utilizid cifre", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            bool isApartamentValid = Int32.TryParse(Apartamentul.Text, out int result3);
            if (isApartamentValid = false)
            {
                MessageBox.Show("Please insert Apartamentul utilizind cifre", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                return;
            }

            elev.GetVarsta();


        }
    }

}
