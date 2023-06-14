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

namespace ProfGames
{
    /// <summary>
    /// Логика взаимодействия для diapozon.xaml
    /// </summary>
    public partial class diapozon : Page
    {
        public diapozon()
        {
            InitializeComponent();
        }

        private void dva_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new memo());
        }
        private void hetire_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new memo_4na4());
        }

        private void voseni_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new memo_8na8());
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new StartPage());
        }
    }
}
