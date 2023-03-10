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
    /// Логика взаимодействия для Viktorina.xaml
    /// </summary
    public partial class Viktorina : Page
    {
        

        public Viktorina()
        {
            InitializeComponent();
            if (ohko_1.Value == null)
            {
                ohko_1.Value = Convert.ToInt32(Komanda_1.Text);
            }
            if (ohko_2.Value == null)
            {
                ohko_2.Value = Convert.ToInt32(Komanda_2.Text);
            }
            Komanda_1.Text = ohko_1.Value.ToString();
            Komanda_2.Text = ohko_2.Value.ToString();
            
            if (Test_1.Value == 1)
            {
                Vopros_1_Voprosi_IT.Background = Brushes.Red;
            }
        }
        


        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new StartPage());
        }

        private void Vopros_1_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page5());
        }

        private void Vopros_2_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page4());
        }

        private void Vopros_4_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page2());
        }

        private void Vopros_5_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page14());
        }

        private void Vopros_3_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page3());
        }

        private void Vopros_1_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page13());
        }

        private void Vopros_2_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page12());
        }

        private void Vopros_3_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page11());
        }

        private void Vopros_4_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page10());
        }

        private void Vopros_5_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page1());
        }

        private void Vopros_1_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_History_of_the_IT_sphere());
        }

        private void Vopros_2_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page9());
        }

        private void Vopros_3_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page8());
        }

        private void Vopros_4_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page7());
        }

        private void Vopros_5_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSVoprosami.Page6());
        }

        private void Pobeda_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(Komanda_1.Text);
            double y = double.Parse(Komanda_2.Text);

            if (x > y)
            {
                MessageBox.Show("Победила команда 1");
            }
            else if (x < y)
            {
                MessageBox.Show("Победила команда 2");
            }
            else if (x == y)
            {
                MessageBox.Show("Победила нечья");
            }

        }
    }
}
