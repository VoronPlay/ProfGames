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

namespace ProfGames.PageSVoprosami
{
    /// <summary>
    /// Логика взаимодействия для dialog_1.xaml
    /// </summary>
    public partial class dialog_1 : Page
    {
        public dialog_1()
        {
            InitializeComponent();
        }

        private void nazvati_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(komanda_1.Text) || string.IsNullOrEmpty(komanda_2.Text))
            {
                MessageBox.Show("Введите название команды");
            }
            else
            {
                text_1.Value = text_1.Value = komanda_1.Text;
                text_2.Value = text_2.Value = komanda_2.Text;
                Manager.MainFrame.Navigate(new Viktorina());
            }
        }
    }
}
