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
    /// Логика взаимодействия для win_k_1.xaml
    /// </summary>
    public partial class win_k_1 : Page
    {
        public win_k_1()
        {
            InitializeComponent();

            win.Content = "Победила команда " + text_1.Value + " со счетам " + ohko_1.Value;
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new StartPage());
            ohko_1.Value = 0;
            ohko_2.Value = 0;
            test1.Value = 0;
            test2.Value = 0;
            test3.Value = 0;
            test4.Value = 0;
            test5.Value = 0;
            test6.Value = 0;
            test7.Value = 0;
            test8.Value = 0;
            test9.Value = 0;
            test10.Value = 0;
            test11.Value = 0;
            test12.Value = 0;
            test13.Value = 0;
            test14.Value = 0;
            test15.Value = 0;
        }
    }
}
