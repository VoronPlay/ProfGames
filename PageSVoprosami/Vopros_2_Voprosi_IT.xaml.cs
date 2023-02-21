using ProfGames.ApplicationData;
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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            Vopros.ItemsSource = profgamessEntities.GetContext().Voprosi_IT.ToList();
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Viktorina());
        }

        private void Otvet_Click(object sender, RoutedEventArgs e)
        {
            Totvet.Background = Brushes.Black;
        }

        private void K_1_Click(object sender, RoutedEventArgs e)
        {
            ohko_1.Value = ohko_1.Value + 20;
            Manager.MainFrame.Navigate(new Viktorina());
        }

        private void K_2_Click(object sender, RoutedEventArgs e)
        {
            ohko_2.Value = ohko_2.Value + 20;
            Manager.MainFrame.Navigate(new Viktorina());
        }
    }
}
