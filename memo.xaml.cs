using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.VisualBasic;
using ProfGames.ApplicationData;
using ProfGames.PageSVoprosami;
using static System.Net.Mime.MediaTypeNames;
using static ProfGames.MainWindow;
using Application = System.Windows.Application;
using Image = System.Windows.Controls.Image;

namespace ProfGames
{

    /// <summary>
    /// Логика взаимодействия для memo.xaml
    /// </summary>
    public partial class memo : Page
    {

        DispatcherTimer _timer;
        TimeSpan _time;

        int summ;
        public memo()
        {
            InitializeComponent();
            _time = TimeSpan.FromSeconds(0);
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");

                _time = _time.Add(TimeSpan.FromSeconds(+1));
            }, Application.Current.Dispatcher);
            _timer.Start();

        }

        private void if_1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            if_1.Content = "if";
            if (if_1_t.Text == "2")
            {
                if (if_1.Content.ToString() == "if" && if_2.Content.ToString() == "if")
                {
                    if_1.Background = Brushes.Transparent;
                    if_2.Background = Brushes.Transparent;

                    if_1.Content = "";
                    if_2.Content = "";


                    i_1.Background = Brushes.Transparent;
                    i_2.Background = Brushes.Transparent;

                    Image img2 = new Image();
                    img2.Source = new BitmapImage(new Uri("Resource/if.png", UriKind.Relative));
                    i_1.Content = img2;

                    Image img3 = new Image();
                    img3.Source = new BitmapImage(new Uri("Resource/if.png", UriKind.Relative));
                    i_2.Content = img3;

                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "2")
                    {
                        _timer.Stop();
                        // Текстовая переменная: 
                        string name;
                        // Отображение окна с полем ввода: 
                        name = Interaction.InputBox(
                            "Введите свое имя"// Текст над полем ввода 
                            );
                        // Еще одна текстовая переменная: 
                        string txt = "Поздравляю вас " + name + " ваш результат " + tbTime.Text;
                        // Окно с сообщением:
                        MessageBox.Show(txt);

                        Memo memo = new Memo();

                        memo.name = name;
                        memo.time = tbTime.Text;
                        memo.diapozon = "2x2";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }
                    else
                    {
                        return;
                    }


                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {

                        else_1.Content = "";
                        else_2.Content = "";
                        if_1_t.Text = "0";

                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {

                    if_1.Content = "";
                        if_2.Content = "";
                        if_1_t.Text = "0";
                    
                }
                else
                {

                    else_1.Content = "";
                        else_2.Content = "";
                        if_1.Content = "";
                        if_2.Content = "";
                        if_1_t.Text = "0";
                    
                }


            }

        }

        private void if_2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            if_2.Content = "if";
            if (if_1_t.Text == "2")
            {
                if (if_1.Content.ToString() == "if" && if_2.Content.ToString() == "if")
                {
                    if_1.Background = Brushes.Transparent;
                    if_2.Background = Brushes.Transparent;

                    if_1.Content = "";
                    if_2.Content = "";


                    i_1.Background = Brushes.Transparent;
                    i_2.Background = Brushes.Transparent;

                    Image img2 = new Image();
                    img2.Source = new BitmapImage(new Uri("Resource/if.png", UriKind.Relative));
                    i_1.Content = img2;

                    Image img3 = new Image();
                    img3.Source = new BitmapImage(new Uri("Resource/if.png", UriKind.Relative));
                    i_2.Content = img3;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "2")
                    {
                        _timer.Stop();
                        // Текстовая переменная: 
                        string name;
                        // Отображение окна с полем ввода: 
                        name = Interaction.InputBox(
                            "Введите свое имя"// Текст над полем ввода 
                            );
                        // Еще одна текстовая переменная: 
                        string txt = "Поздравляю вас " + name + " ваш результат " + tbTime.Text;
                        // Окно с сообщением:
                        MessageBox.Show(txt);

                        Memo memo = new Memo();

                        memo.name = name;
                        memo.time = tbTime.Text;
                        memo.diapozon = "2x2";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }
                    else
                    {
                        return;
                    }


                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {

                    else_1.Content = "";
                    else_2.Content = "";
                    if_1_t.Text = "0";

                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {

                    if_1.Content = "";
                    if_2.Content = "";
                    if_1_t.Text = "0";

                }
                else
                {

                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    if_1_t.Text = "0";

                }
            }
        }

        private void else_1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            else_1.Content = "else";
            Task.Delay(1000);
            if (if_1_t.Text == "2")
            {
                if (else_1.Content.ToString() == "else" && else_2.Content.ToString() == "else")
                {
                    else_1.Background = Brushes.Transparent;
                    else_2.Background = Brushes.Transparent;

                    else_1.Content = "";
                    else_2.Content = "";


                    e_1.Background = Brushes.Transparent;
                    e_2.Background = Brushes.Transparent;

                    Image img4 = new Image();
                    img4.Source = new BitmapImage(new Uri("Resource/else.png", UriKind.Relative));
                    e_1.Content = img4;

                    Image img5 = new Image();
                    img5.Source = new BitmapImage(new Uri("Resource/else.png", UriKind.Relative));
                    e_2.Content = img5;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "2")
                    {
                        _timer.Stop();
                        // Текстовая переменная: 
                        string name;
                        // Отображение окна с полем ввода: 
                        name = Interaction.InputBox(
                            "Введите свое имя"// Текст над полем ввода 
                            );
                        // Еще одна текстовая переменная: 
                        string txt = "Поздравляю вас " + name + " ваш результат " + tbTime.Text;
                        // Окно с сообщением:
                        MessageBox.Show(txt);

                        Memo memo = new Memo();

                        memo.name = name;
                        memo.time = tbTime.Text;
                        memo.diapozon = "2x2";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }
                    else
                    {
                        return;
                    }


                }

                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {

                    else_1.Content = "";
                    else_2.Content = "";
                    if_1_t.Text = "0";

                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {

                    if_1.Content = "";
                    if_2.Content = "";
                    if_1_t.Text = "0";

                }
                else
                {

                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    if_1_t.Text = "0";

                }

            }
        }

        private void else_2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            else_2.Content = "else";
            if (if_1_t.Text == "2")
            {
                if (else_1.Content.ToString() == "else" && else_2.Content.ToString() == "else")
                {
                    else_1.Background = Brushes.Transparent;
                    else_2.Background = Brushes.Transparent;

                    else_1.Content = "";
                    else_2.Content = "";


                    e_1.Background = Brushes.Transparent;
                    e_2.Background = Brushes.Transparent;

                    Image img4 = new Image();
                    img4.Source = new BitmapImage(new Uri("Resource/else.png", UriKind.Relative));
                    e_1.Content = img4;

                    Image img5 = new Image();
                    img5.Source = new BitmapImage(new Uri("Resource/else.png", UriKind.Relative));
                    e_2.Content = img5;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "2")
                    {
                        _timer.Stop();
                        // Текстовая переменная: 
                        string name;
                        // Отображение окна с полем ввода: 
                        name = Interaction.InputBox(
                            "Введите свое имя"// Текст над полем ввода 
                            );
                        // Еще одна текстовая переменная: 
                        string txt = "Поздравляю вас " + name + " ваш результат " + tbTime.Text;
                        // Окно с сообщением:
                        MessageBox.Show(txt);

                        Memo memo = new Memo();

                        memo.name = name;
                        memo.time = tbTime.Text;
                        memo.diapozon = "2x2";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }
                    else
                    {
                        return;
                    }


                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {

                    else_1.Content = "";
                    else_2.Content = "";
                    if_1_t.Text = "0";

                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {

                    if_1.Content = "";
                    if_2.Content = "";
                    if_1_t.Text = "0";

                }
                else
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    if_1_t.Text = "0";

                }

            }
    }





    }
}
