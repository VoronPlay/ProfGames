using Microsoft.VisualBasic;
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
using System.Windows.Threading;

namespace ProfGames
{
    
    /// <summary>
    /// Логика взаимодействия для memo_4na4.xaml
    /// </summary>
    public partial class memo_4na4 : Page
    {
        DispatcherTimer _timer;
        TimeSpan _time;

        int summ;
        public memo_4na4()
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

        private void xaml_1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            xaml_1.Content = "xaml";

            if (if_1_t.Text == "2")
            {
                if (xaml_1.Content.ToString() == "xaml" && xaml_2.Content.ToString() == "xaml")
                {
                    xaml_1.Background = Brushes.Transparent;
                    xaml_2.Background = Brushes.Transparent;

                    xaml_2.Content = "";
                    xaml_1.Content = "";


                    x_1.Background = Brushes.Transparent;
                    x_2.Background = Brushes.Transparent;

                    Image img6 = new Image();
                    img6.Source = new BitmapImage(new Uri("Resource/xaml.png", UriKind.Relative));
                    x_1.Content = img6;

                    Image img7 = new Image();
                    img7.Source = new BitmapImage(new Uri("Resource/xaml.png", UriKind.Relative));
                    x_2.Content = img7;

                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void void_1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            void_1.Content = "void";

            if (if_1_t.Text == "2")
            {
                if (void_1.Content.ToString() == "void" && void_2.Content.ToString() == "void")
                {
                    void_1.Background = Brushes.Transparent;
                    void_2.Background = Brushes.Transparent;

                    void_1.Content = "";
                    void_2.Content = "";

                    v_11.BorderBrush = Brushes.Transparent;
                    v_22.BorderBrush = Brushes.Transparent;
                    v_11.Background = Brushes.Transparent;
                    v_22.Background = Brushes.Transparent;

                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri("Resource/void.png", UriKind.Relative));
                    v_11.Content = img;

                    Image img1 = new Image();
                    img1.Source = new BitmapImage(new Uri("Resource/void.png", UriKind.Relative));
                    v_22.Content = img1;

                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void void_2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            void_2.Content = "void";

            if (if_1_t.Text == "2")
            {
                if (void_1.Content.ToString() == "void" && void_2.Content.ToString() == "void")
                {
                    void_1.Background = Brushes.Transparent;
                    void_2.Background = Brushes.Transparent;

                    void_1.Content = "";
                    void_2.Content = "";


                    v_11.Background = Brushes.Transparent;
                    v_22.Background = Brushes.Transparent;

                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri("Resource/void.png", UriKind.Relative));
                    v_11.Content = img;

                    Image img1 = new Image();
                    img1.Source = new BitmapImage(new Uri("Resource/void.png", UriKind.Relative));
                    v_22.Content = img1;

                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void mode_1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            mode_1.Content = "mode";

            if (if_1_t.Text == "2")
            {
                if (mode_1.Content.ToString() == "mode" && mode_2.Content.ToString() == "mode")
                {
                    mode_1.Background = Brushes.Transparent;
                    mode_2.Background = Brushes.Transparent;

                    mode_1.Content = "";
                    mode_2.Content = "";


                    m_1.Background = Brushes.Transparent;
                    m_2.Background = Brushes.Transparent;

                    Image img10 = new Image();
                    img10.Source = new BitmapImage(new Uri("Resource/mode.png", UriKind.Relative));
                    m_1.Content = img10;

                    Image img11 = new Image();
                    img11.Source = new BitmapImage(new Uri("Resource/mode.png", UriKind.Relative));
                    m_2.Content = img11;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }
        private void int_1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            int_1.Content = "int";

            if (if_1_t.Text == "2")
            {
                if (int_1.Content.ToString() == "int" && int_2.Content.ToString() == "int")
                {
                    int_1.Background = Brushes.Transparent;
                    int_2.Background = Brushes.Transparent;

                    int_1.Content = "";
                    int_2.Content = "";


                    in_1.Background = Brushes.Transparent;
                    in_2.Background = Brushes.Transparent;

                    Image img12 = new Image();
                    img12.Source = new BitmapImage(new Uri("Resource/int.png", UriKind.Relative));
                    in_1.Content = img12;

                    Image img13 = new Image();
                    img13.Source = new BitmapImage(new Uri("Resource/int.png", UriKind.Relative));
                    in_2.Content = img13;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void int_2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            int_2.Content = "int";

            if (if_1_t.Text == "2")
            {
                if (int_1.Content.ToString() == "int" && int_2.Content.ToString() == "int")
                {
                    int_1.Background = Brushes.Transparent;
                    int_2.Background = Brushes.Transparent;

                    int_1.Content = "";
                    int_2.Content = "";


                    in_1.Background = Brushes.Transparent;
                    in_2.Background = Brushes.Transparent;

                    Image img12 = new Image();
                    img12.Source = new BitmapImage(new Uri("Resource/int.png", UriKind.Relative));
                    in_1.Content = img12;

                    Image img13 = new Image();
                    img13.Source = new BitmapImage(new Uri("Resource/int.png", UriKind.Relative));
                    in_2.Content = img13;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void value_1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            value_1.Content = "value";

            if (if_1_t.Text == "2")
            {
                if (value_1.Content.ToString() == "value" && value_2.Content.ToString() == "value")
                {
                    value_1.Background = Brushes.Transparent;
                    value_2.Background = Brushes.Transparent;

                    value_1.Content = "";
                    value_2.Content = "";


                    va_1.Background = Brushes.Transparent;
                    va_2.Background = Brushes.Transparent;

                    Image img14 = new Image();
                    img14.Source = new BitmapImage(new Uri("Resource/value.png", UriKind.Relative));
                    va_1.Content = img14;

                    Image img15 = new Image();
                    img15.Source = new BitmapImage(new Uri("Resource/value.png", UriKind.Relative));
                    va_2.Content = img15;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
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

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
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

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
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

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
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

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void xaml_2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            xaml_2.Content = "xaml";

            if (if_1_t.Text == "2")
            {
                if (xaml_1.Content.ToString() == "xaml" && xaml_2.Content.ToString() == "xaml")
                {
                    xaml_1.Background = Brushes.Transparent;
                    xaml_2.Background = Brushes.Transparent;

                    xaml_2.Content = "";
                    xaml_1.Content = "";


                    x_1.Background = Brushes.Transparent;
                    x_2.Background = Brushes.Transparent;

                    Image img6 = new Image();
                    img6.Source = new BitmapImage(new Uri("Resource/xaml.png", UriKind.Relative));
                    x_1.Content = img6;

                    Image img7 = new Image();
                    img7.Source = new BitmapImage(new Uri("Resource/xaml.png", UriKind.Relative));
                    x_2.Content = img7;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void Grid_2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            Grid_2.Content = "Grid";

            if (if_1_t.Text == "2")
            {
                if (Grid_1.Content.ToString() == "Grid" && Grid_2.Content.ToString() == "Grid")
                {
                    Grid_1.Background = Brushes.Transparent;
                    Grid_2.Background = Brushes.Transparent;

                    Grid_1.Content = "";
                    Grid_2.Content = "";


                    g_1.Background = Brushes.Transparent;
                    g_2.Background = Brushes.Transparent;

                    Image img8 = new Image();
                    img8.Source = new BitmapImage(new Uri("Resource/Grid.png", UriKind.Relative));
                    g_1.Content = img8;

                    Image img9 = new Image();
                    img9.Source = new BitmapImage(new Uri("Resource/Grid.png", UriKind.Relative));
                    g_2.Content = img9;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void Grid_1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            Grid_1.Content = "Grid";

            if (if_1_t.Text == "2")
            {
                if (Grid_1.Content.ToString() == "Grid" && Grid_2.Content.ToString() == "Grid")
                {
                    Grid_1.Background = Brushes.Transparent;
                    Grid_2.Background = Brushes.Transparent;

                    Grid_1.Content = "";
                    Grid_2.Content = "";


                    g_1.Background = Brushes.Transparent;
                    g_2.Background = Brushes.Transparent;

                    Image img8 = new Image();
                    img8.Source = new BitmapImage(new Uri("Resource/Grid.png", UriKind.Relative));
                    g_1.Content = img8;

                    Image img9 = new Image();
                    img9.Source = new BitmapImage(new Uri("Resource/Grid.png", UriKind.Relative));
                    g_2.Content = img9;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void mode_2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            mode_2.Content = "mode";

            if (if_1_t.Text == "2")
            {
                if (mode_1.Content.ToString() == "mode" && mode_2.Content.ToString() == "mode")
                {
                    mode_1.Background = Brushes.Transparent;
                    mode_2.Background = Brushes.Transparent;

                    mode_1.Content = "";
                    mode_2.Content = "";


                    m_1.Background = Brushes.Transparent;
                    m_2.Background = Brushes.Transparent;

                    Image img10 = new Image();
                    img10.Source = new BitmapImage(new Uri("Resource/mode.png", UriKind.Relative));
                    m_1.Content = img10;

                    Image img11 = new Image();
                    img11.Source = new BitmapImage(new Uri("Resource/mode.png", UriKind.Relative));
                    m_2.Content = img11;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }

        private void value_2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(if_1_t.Text);
            summ = cvn1 + 1;
            if_1_t.Text = summ.ToString();
            value_2.Content = "value";

            if (if_1_t.Text == "2")
            {
                if (value_1.Content.ToString() == "value" && value_2.Content.ToString() == "value")
                {
                    value_1.Background = Brushes.Transparent;
                    value_2.Background = Brushes.Transparent;

                    value_1.Content = "";
                    value_2.Content = "";


                    va_1.Background = Brushes.Transparent;
                    va_2.Background = Brushes.Transparent;

                    Image img14 = new Image();
                    img14.Source = new BitmapImage(new Uri("Resource/value.png", UriKind.Relative));
                    va_1.Content = img14;

                    Image img15 = new Image();
                    img15.Source = new BitmapImage(new Uri("Resource/value.png", UriKind.Relative));
                    va_2.Content = img15;
                    cvn1 = Convert.ToInt32(if_2_t.Text);
                    summ = cvn1 + 1;
                    if_2_t.Text = summ.ToString();
                    if_1_t.Text = "0";

                    if (if_2_t.Text == "8")
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
                        memo.diapozon = "4x4";

                        AppConnect.model1db.Memo.Add(memo);
                        AppConnect.model1db.SaveChanges();
                        Manager.MainFrame.Navigate(new StartPage());

                    }


                }
                else if (Grid_1.Background == Brushes.Transparent || Grid_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (value_1.Background == Brushes.Transparent || value_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (int_1.Background == Brushes.Transparent || int_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (if_1.Background == Brushes.Transparent || if_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (else_1.Background == Brushes.Transparent || else_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (mode_1.Background == Brushes.Transparent || mode_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (void_1.Background == Brushes.Transparent || void_2.Background == Brushes.Transparent)
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else if (xaml_1.Background == Brushes.Transparent || xaml_2.Background == Brushes.Transparent)
                {
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
                else
                {
                    xaml_1.Content = "";
                    xaml_2.Content = "";
                    else_1.Content = "";
                    else_2.Content = "";
                    if_1.Content = "";
                    if_2.Content = "";
                    void_1.Content = "";
                    void_2.Content = "";
                    Grid_1.Content = "";
                    Grid_2.Content = "";
                    mode_1.Content = "";
                    mode_2.Content = "";
                    int_1.Content = "";
                    int_2.Content = "";
                    value_1.Content = "";
                    value_2.Content = "";
                    if_1_t.Text = "0";
                }
            }
        }
    }
}
