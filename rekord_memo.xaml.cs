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

namespace ProfGames
{
    /// <summary>
    /// Логика взаимодействия для rekord_memo.xaml
    /// </summary>
    public partial class rekord_memo : Page
    {
        public rekord_memo()
        {
            InitializeComponent();
            DtGrid.ItemsSource = ProfGamesEntities.GetContext().Memo.ToList();


        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new vibor_rekord());
        }
    }
}
