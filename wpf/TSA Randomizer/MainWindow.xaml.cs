using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

namespace TSA_Randomizer
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

        // Create new random object
        Random rand = new Random();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgArrow.Source = rand.Next(2) > 0 ? new BitmapImage(new Uri(@"/Resources/Back-96.png", UriKind.Relative)) : new BitmapImage(new Uri(@"/Resources/Forward-96.png", UriKind.Relative));
            lastUpd.Content = "Last Updated: " + DateTime.Now;
            lastUpd.Margin = new Thickness(160, lastUpd.Margin.Top, 96, lastUpd.Margin.Bottom);

            /* Cleaner Version */
            //var num = rand.Next(2);
            //Uri uri;
            //if (num > 0)
            //    uri = new Uri(@"/Images/Back-96.png", UriKind.Relative); // Get image path of the back icon
            //else
            //    uri = new Uri(@"/Images/Forward-96.png", UriKind.Relative); // Get image path of the forward button

            //imgArrow.Source = new BitmapImage(uri); // Load the image into the imageview after casting
        }
    }
}
