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

        public Vopros_1_History_of_the_IT_sphere()
        {
            InitializeComponent();
            var v = profgamessEntities.GetContext().Voprosi_History_of_the_IT_sphere.ToString();
            Vopros.Text = v;
        }

        private void Otvet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
