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

namespace ProfGames.PageSVoprosami_4_k
{
    /// <summary>
    /// Логика взаимодействия для Vopros_1_3_Voprosi_People_in_Programming_4k.xaml
    /// </summary>
    public partial class Vopros_1_3_Voprosi_People_in_Programming_4k : Page
    {
        public Vopros_1_3_Voprosi_People_in_Programming_4k()
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
                TOtvet.Foreground = Brushes.DodgerBlue;
            }
            else if ((bool)Chek_2.IsChecked)
            {
                TOtvet.Foreground = Brushes.DodgerBlue;
            }
            else if ((bool)Chek_3.IsChecked)
            {
                TOtvet.Foreground = Brushes.DodgerBlue;
            }
            else if ((bool)Chek_4.IsChecked)
            {
                TOtvet.Foreground = Brushes.DodgerBlue;
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Viktotina_4k());

        }



        private void Test_V1_Click(object sender, RoutedEventArgs e)
        {




        }

        private void K_1_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Chek_1.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
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
                ohko_2.Value = ohko_2.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
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
                ohko_3.Value = ohko_3.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_3.Value = ohko_3.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_3.Value = ohko_3.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_3.Value = ohko_3.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }
        private void K_4_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Chek_1.IsChecked)
            {
                ohko_4.Value = ohko_4.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_4.Value = ohko_4.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_4.Value = ohko_4.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_4.Value = ohko_4.Value + 10;
                test3.Value = test3.Value + 1;
                Manager.MainFrame.Navigate(new Viktotina_4k());
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }

        private void K_0_Click(object sender, RoutedEventArgs e)
        {
            test3.Value = test3.Value + 1;
            Manager.MainFrame.Navigate(new Viktotina_4k());
        }
    }
}
