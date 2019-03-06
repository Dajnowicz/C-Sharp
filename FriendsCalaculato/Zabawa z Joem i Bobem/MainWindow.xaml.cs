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

namespace Zabawa_z_Joem_i_Bobem
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public MainWindow()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };
            bob = new Guy() { Cash = 100, Name = "Bob" };
            UpdateForm();
        }

        public void UpdateForm()
        {
            TextJoe.Text = "Joe ma " + joe.Cash + "zł na koncie";
            TextBob.Text = "Bob ma " + bob.Cash + "zł na koncie";
            TextBank.Text = "Bank ma " + bank + "zł w banku";
        }

        private void GiveJoe_Click(object sender, RoutedEventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.GiveCash(10);
            }
            else
            {
                System.Windows.MessageBox.Show("Bank posiada " + bank + "zl i nie ma wystraczyjacych srodkow na przekazanie " + 10 + "zl");
            }
        
            UpdateForm();
        }

        private void TakeBob_Click(object sender, RoutedEventArgs e)
        {
                bank += bob.GiveCash(5);
                UpdateForm();
        }

        private void JoeToBob_Click(object sender, RoutedEventArgs e)
        {
            bob.GetCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void BobToJoe_Click(object sender, RoutedEventArgs e)
        {
            joe.GetCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
