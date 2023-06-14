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
    /// Логика взаимодействия для vibor_rekord_admin.xaml
    /// </summary>
    public partial class vibor_rekord_admin : Page
    {
        public vibor_rekord_admin()
        {
            InitializeComponent();
        }

        private void Viktorina_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new rekordi_admin());
        }

        private void Memo_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new rekord_memo_admin());
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new StartPage());
        }
    }
}
