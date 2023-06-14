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
    /// Логика взаимодействия для rekord_memo_admin.xaml
    /// </summary>
    public partial class rekord_memo_admin : Page
    {
        public rekord_memo_admin()
        {
            InitializeComponent();
            DtGrid.ItemsSource = ProfGamesEntities.GetContext().Memo.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new memo_rekord_reg((sender as Button).DataContext as Memo));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var toverForRemoving = DtGrid.SelectedItems.Cast<Memo>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующее {toverForRemoving.Count()} рекорд ?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ProfGamesEntities.GetContext().Memo.RemoveRange(toverForRemoving);
                    ProfGamesEntities.GetContext().SaveChanges();
                    MessageBox.Show("Рекорд удален");

                    DtGrid.ItemsSource = ProfGamesEntities.GetContext().Memo.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new vibor_rekord_admin());
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new memo_rekord_reg(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ProfGamesEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DtGrid.ItemsSource = ProfGamesEntities.GetContext().Memo.ToList().ToList();
        }
    }
}
