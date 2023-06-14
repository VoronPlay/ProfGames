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

namespace ProfGames.PageSVoprosami_3_k
{
    /// <summary>
    /// Логика взаимодействия для Vopros_5_3_Voprosi_People_in_Programming_3k.xaml
    /// </summary>
    public partial class Vopros_5_3_Voprosi_People_in_Programming_3k : Page
    {
        public Vopros_5_3_Voprosi_People_in_Programming_3k()
        {
            InitializeComponent();
            Vopros.ItemsSource = ProfGamesEntities.GetContext().Voprosi_People_in_Programming.ToList();
        }

        private void Otvet_Click(object sender, RoutedEventArgs e)
        {

            if ((bool)Chek_1.IsChecked)
            {
                Text_1.Background = Brushes.Red;
                K_0.Background = Brushes.Red;
                K_0.Foreground = Brushes.Black;
                K_0.Content = "0";
            }
            if ((bool)Chek_2.IsChecked)
            {
                Text_2.Background = Brushes.Red;
                K_0.Background = Brushes.Red;
                K_0.Foreground = Brushes.Black;
                K_0.Content = "0";
            }
            if ((bool)Chek_3.IsChecked)
            {
                Text_3.Background = Brushes.Red;
                K_0.Background = Brushes.Red;
                K_0.Foreground = Brushes.Black;
                K_0.Content = "0";
            }
            if ((bool)Chek_4.IsChecked)
            {
                Text_4.Background = Brushes.Green;
            }

            if ((bool)Chek_1.IsChecked)
            {
                TOtvet.Foreground = Brushes.White;
            }
            else if ((bool)Chek_2.IsChecked)
            {
                TOtvet.Foreground = Brushes.White;
            }
            else if ((bool)Chek_3.IsChecked)
            {
                TOtvet.Foreground = Brushes.White;
            }
            else if ((bool)Chek_4.IsChecked)
            {
                TOtvet.Foreground = Brushes.White;
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Viktotina_3k());

        }



        private void Test_V1_Click(object sender, RoutedEventArgs e)
        {




        }

        private void K_1_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Chek_1.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }

        private void K_2_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Chek_1.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }

        private void K_3_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Chek_1.IsChecked)
            {
                ohko_3.Value = ohko_3.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_3.Value = ohko_3.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_3.Value = ohko_3.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_3.Value = ohko_3.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_3k());
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }
        private void K_0_Click(object sender, RoutedEventArgs e)
        {
            test15.Value = test15.Value + 1;
            Manager.MainFrame.Navigate(new Viktotina_3k());
        }
    }
}
