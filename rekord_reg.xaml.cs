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
    /// Логика взаимодействия для rekord_reg.xaml
    /// </summary>
    public partial class rekord_reg : Page
    {
        private Rekordi _current = new Rekordi();

        public rekord_reg(Rekordi selected)
        {
            InitializeComponent();

            if (selected != null)
                _current = selected;
            DataContext = _current;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(_current.komanda_1 + " "))
                errors.AppendLine("Укажите название команды");
            if (string.IsNullOrEmpty(_current.komanda_3 + " "))
                errors.AppendLine("Укажите название команды");
            if (_current.ohko_k_1 <= 0)
                errors.AppendLine("Количество очков не может быть меньше или равно 0");
            if (string.IsNullOrEmpty(_current.komanda_2 + " "))
                errors.AppendLine("Укажите название команды");
            if (string.IsNullOrEmpty(_current.komanda_4 + " "))
                errors.AppendLine("Укажите название команды");
            if (_current.ohko_k_2 <= 0)
                errors.AppendLine("Количество очков не может быть меньше или равно 0");
            if (_current.ohko_k_3 <= 0)
                errors.AppendLine("Количество очков не может быть меньше или равно 0");
            if (_current.ohko_k_4 <= 0)
                errors.AppendLine("Количество очков не может быть меньше или равно 0");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_current.id == 0)
                ProfGamesEntities.GetContext().Rekordi.Add(_current);

            try
            {
                ProfGamesEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.Navigate(new rekordi_admin());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
