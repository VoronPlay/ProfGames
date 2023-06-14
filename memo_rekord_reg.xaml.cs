using ProfGames.ApplicationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для memo_rekord_reg.xaml
    /// </summary>
    public partial class memo_rekord_reg : Page
    {
        private Memo _current = new Memo();

        public memo_rekord_reg(Memo selected)
        {
            InitializeComponent();

            if (selected != null)
                _current = selected;
            DataContext = _current;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_current.name))
                errors.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_current.time))
                errors.AppendLine("Укажите время");
            if (string.IsNullOrWhiteSpace(_current.diapozon))
                errors.AppendLine("Укажите диапозон");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_current.id == 0)
                ProfGamesEntities.GetContext().Memo.Add(_current);

            try
            {
                ProfGamesEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.Navigate(new rekord_memo_admin());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
