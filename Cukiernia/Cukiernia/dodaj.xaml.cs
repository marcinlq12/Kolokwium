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
using System.Windows.Shapes;

namespace Cukiernia
{
    /// <summary>
    /// Interaction logic for dodaj.xaml
    /// </summary>
    public partial class dodaj : Window
    {
        public dodaj()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.txb_nazwa.Text != "" && this.txb_czas.Text != "")
            {
                listbx.Items.Add(this.txb_nazwa.Text);
                listbx.Items.Add(this.txb_czas.Text);
            }
            else 
            {
                MessageBox.Show("Nie dodano wartości", "Bład dodawania", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        }
    }

