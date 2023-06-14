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

namespace ProfGames.PageSVoprosami_4_k
{
    /// <summary>
    /// Логика взаимодействия для dialog_1_4k.xaml
    /// </summary>
    public partial class dialog_1_4k : Page
    {
        public dialog_1_4k()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami_3_k.dialog_1_3k());
        }

        private void nazvati_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(komanda_1.Text) || string.IsNullOrWhiteSpace(komanda_2.Text) || string.IsNullOrWhiteSpace(komanda_3.Text) || string.IsNullOrWhiteSpace(komanda_4.Text))
            {
                MessageBox.Show("Введите название команды");
            }
            else
            {
                text_1.Value = text_1.Value = komanda_1.Text;
                text_2.Value = text_2.Value = komanda_2.Text;
                text_3.Value = text_3.Value = komanda_3.Text;
                text_4.Value = text_4.Value = komanda_4.Text;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new StartPage());
        }
    }
}
