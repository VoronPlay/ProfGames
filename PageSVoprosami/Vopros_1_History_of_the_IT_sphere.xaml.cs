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
using ProfGames.ApplicationData;

namespace ProfGames.PageSVoprosami
{
    /// <summary>
    /// Логика взаимодействия для Vopros_1_History_of_the_IT_sphere.xaml
    /// </summary>
    public partial class Vopros_1_History_of_the_IT_sphere : Page
    {

        public static int Testohko;
        public Vopros_1_History_of_the_IT_sphere()
        {
            InitializeComponent();
            Vopros.ItemsSource = profgamessEntities.GetContext().Voprosi_History_of_the_IT_sphere.ToList();
            
        }

        private void Otvet_Click(object sender, RoutedEventArgs e)
        {
            TOtvet.Background = Brushes.Black;
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Viktorina());
        }

        

        private void Test_V1_Click(object sender, RoutedEventArgs e)
        {

            


        }

        private void K_1_Click(object sender, RoutedEventArgs e)
        {
            ohko_1.Value = ohko_1.Value+10;
            Test_1.Value = Test_1.Value + 1;
            Manager.MainFrame.Navigate(new Viktorina());
        }

        private void K_2_Click(object sender, RoutedEventArgs e)
        {
            ohko_2.Value = ohko_2.Value+10;
            Test_1.Value = Test_1.Value + 1;
            Manager.MainFrame.Navigate(new Viktorina());
        }
    }
}
