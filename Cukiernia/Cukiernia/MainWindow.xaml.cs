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

namespace Cukiernia
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

        private void bt_nowy_przepis_Click(object sender, RoutedEventArgs e)
        {
            dodaj win2 = new dodaj();
            win2.Show();
            this.Close();
        }

        private void bt_wyjscie_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_dodaj_skladniki_Click(object sender, RoutedEventArgs e)
        {
            skladniki win3 = new skladniki();
            win3.Show();
            this.Close();
        }

       
    }
}
