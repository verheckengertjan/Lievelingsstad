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

namespace Lievelings.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string stad;
        string beginVanDeZin;
        public MainWindow()
        {
            InitializeComponent();
            beginVanDeZin = "je lievelingsstad is ";
        }

        private void wndMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lstSteden.Items.Add("Brugge");
            lstSteden.Items.Add("Antwerpen");
            lstSteden.Items.Add("Gent");
            lstSteden.Items.Add("Brussel");
            lstSteden.Items.Add("Hasselt");

            btnEng.Visibility = Visibility.Hidden;
            btnNL.Visibility = Visibility.Hidden;

            Title = "kies je lievelingsstad ";

        }

        private void lstSteden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            
            stad = lstSteden.SelectedItem.ToString();
            lblLievelingsStad.Content = $"{beginVanDeZin} {stad}";

            btnEng.Visibility = Visibility.Visible;
            btnNL.Visibility = Visibility.Visible;

            
        }

        private void btnEng_Click(object sender, RoutedEventArgs e)
        {
           
           
            beginVanDeZin = "your favorite city is ";
           
            lblLievelingsStad.Content = $"{beginVanDeZin} {stad}";
            
            Title = "choose your favorite city ";
        }

        private void btnNL_Click(object sender, RoutedEventArgs e)
        {
            beginVanDeZin = "jouw favoriete stad is ";

            lblLievelingsStad.Content = $"{beginVanDeZin} {stad}";

            Title = "kies je stad ";
        }
    }
}
