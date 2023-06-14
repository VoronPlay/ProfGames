﻿using ProfGames.ApplicationData;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Vopros.ItemsSource = ProfGamesEntities.GetContext().Voprosi_People_in_Programming.ToList();
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Viktorina());
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
                Text_2.Background = Brushes.Green;
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
                Text_4.Background = Brushes.Red;
                K_0.Background = Brushes.Red;
                K_0.Foreground = Brushes.Black;
                K_0.Content = "0";
            }

            if ((bool)Chek_1.IsChecked)
            {
                Totvet.Foreground = Brushes.DodgerBlue;
            }
            else if ((bool)Chek_2.IsChecked)
            {
                Totvet.Foreground = Brushes.DodgerBlue;
            }
            else if ((bool)Chek_3.IsChecked)
            {
                Totvet.Foreground = Brushes.DodgerBlue;
            }
            else if ((bool)Chek_4.IsChecked)
            {
                Totvet.Foreground = Brushes.DodgerBlue;
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }

        private void K_1_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Chek_1.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktorina());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktorina());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktorina());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_1.Value = ohko_1.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktorina());
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
                Manager.MainFrame.Navigate(new Viktorina());
            }
            else if ((bool)Chek_2.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktorina());
            }
            else if ((bool)Chek_3.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktorina());
            }
            else if ((bool)Chek_4.IsChecked)
            {
                ohko_2.Value = ohko_2.Value + 50;
                test15.Value = test15.Value + 1;
                Manager.MainFrame.Navigate(new Viktorina());
            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }

        private void K_0_Click(object sender, RoutedEventArgs e)
        {
            test15.Value = test15.Value + 1;
            Manager.MainFrame.Navigate(new Viktorina());
        }
    }
}
