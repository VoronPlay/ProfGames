using ProfGames.ApplicationData;
using ProfGames.PageSVoprosami;
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
using System.Windows.Media.Animation;
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

            DataContext = _current;

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

            if (text_1.Value == null)
            {
                text_1.Value = Convert.ToString(naz_1.Text);
            }
            if (text_2.Value == null)
            {
                text_2.Value = Convert.ToString(naz_2.Text);
            }
            if (test1.Value == null)
            {
                test1.Value = Convert.ToInt32(test_1.Text);
            }
            test_1.Text = test1.Value.ToString();
            if (test2.Value == null)
            {
                test2.Value = Convert.ToInt32(test_2.Text);
            }
            test_2.Text = test2.Value.ToString();
            if (test3.Value == null)
            {
                test3.Value = Convert.ToInt32(test_3.Text);
            }
            test_3.Text = test3.Value.ToString();
            if (test4.Value == null)
            {
                test4.Value = Convert.ToInt32(test_4.Text);
            }
            test_4.Text = test4.Value.ToString();
            if (test5.Value == null)
            {
                test5.Value = Convert.ToInt32(test_5.Text);
            }
            test_5.Text = test5.Value.ToString();
            if (test6.Value == null)
            {
                test6.Value = Convert.ToInt32(test_6.Text);
            }
            test_6.Text = test6.Value.ToString();
            if (test7.Value == null)
            {
                test7.Value = Convert.ToInt32(test_7.Text);
            }
            test_7.Text = test7.Value.ToString();
            if (test8.Value == null)
            {
                test8.Value = Convert.ToInt32(test_8.Text);
            }
            test_8.Text = test8.Value.ToString();
            if (test9.Value == null)
            {
                test9.Value = Convert.ToInt32(test_9.Text);
            }
            test_9.Text = test9.Value.ToString();
            if (test10.Value == null)
            {
                test10.Value = Convert.ToInt32(test_10.Text);
            }
            test_10.Text = test10.Value.ToString();
            if (test11.Value == null)
            {
                test11.Value = Convert.ToInt32(test_11.Text);
            }
            test_11.Text = test11.Value.ToString();
            if (test12.Value == null)
            {
                test12.Value = Convert.ToInt32(test_12.Text);
            }
            test_12.Text = test12.Value.ToString();
            if (test13.Value == null)
            {
                test13.Value = Convert.ToInt32(test_13.Text);
            }
            test_13.Text = test13.Value.ToString();
            if (test14.Value == null)
            {
                test14.Value = Convert.ToInt32(test_14.Text);
            }
            test_14.Text = test14.Value.ToString();
            if (test15.Value == null)
            {
                test15.Value = Convert.ToInt32(test_15.Text);
            }
            test_15.Text = test15.Value.ToString();
            naz_1.Text = text_1.Value.ToString();
            naz_2.Text = text_2.Value.ToString();

            double y_1 = double.Parse(test_1.Text);
            if (y_1 == 1)
            {
                Vopros_1_History_of_the_IT_sphere.Background = Brushes.Red;
            }

            double y_2 = double.Parse(test_2.Text);
            if (y_2 == 1)
            {
                Vopros_1_Voprosi_IT.Background = Brushes.Red;
            }

            double y_3 = double.Parse(test_3.Text);
            if (y_3 == 1)
            {
                Vopros_1_Voprosi_People_in_Programming.Background = Brushes.Red;
            }

            double y_4 = double.Parse(test_4.Text);
            if (y_4 == 1)
            {
                Vopros_2_History_of_the_IT_sphere.Background = Brushes.Red;
            }

            double y_5 = double.Parse(test_5.Text);
            if (y_5 == 1)
            {
                Vopros_2_Voprosi_IT.Background = Brushes.Red;
            }

            double y_6 = double.Parse(test_6.Text);
            if (y_6 == 1)
            {
                Vopros_2_Voprosi_People_in_Programming.Background = Brushes.Red;
            }

            double y_7 = double.Parse(test_7.Text);
            if (y_7 == 1)
            {
                Vopros_3_History_of_the_IT_sphere.Background = Brushes.Red;
            }

            double y_8 = double.Parse(test_8.Text);
            if (y_8 == 1)
            {
                Vopros_3_Voprosi_IT.Background = Brushes.Red;
            }

            double y_9 = double.Parse(test_9.Text);
            if (y_9 == 1)
            {
                Vopros_3_Voprosi_People_in_Programming.Background = Brushes.Red;
            }

            double y_10 = double.Parse(test_10.Text);
            if (y_10 == 1)
            {
                Vopros_4_History_of_the_IT_sphere.Background = Brushes.Red;
            }

            double y_11 = double.Parse(test_11.Text);
            if (y_11 == 1)
            {
                Vopros_4_Voprosi_IT.Background = Brushes.Red;
            }

            double y_12 = double.Parse(test_12.Text);
            if (y_12 == 1)
            {
                Vopros_4_Voprosi_People_in_Programming.Background = Brushes.Red;
            }

            double y_13 = double.Parse(test_13.Text);
            if (y_13 == 1)
            {
                Vopros_5_History_of_the_IT_sphere.Background = Brushes.Red;
            }

            double y_14 = double.Parse(test_14.Text);
            if (y_14 == 1)
            {
               Vopros_5_Voprosi_IT.Background = Brushes.Red;
            }

            double y_15 = double.Parse(test_15.Text);
            if (y_15 == 1)
            {
                Vopros_5_Voprosi_People_in_Programming.Background = Brushes.Red;
            }
        }
        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new StartPage());
            ohko_1.Value = 0;
            ohko_2.Value = 0;
            test1.Value = 0;
            test2.Value = 0;
            test3.Value = 0;
            test4.Value = 0;
            test5.Value = 0;
            test6.Value = 0;
            test7.Value = 0;
            test8.Value = 0;
            test9.Value = 0;
            test10.Value = 0;
            test11.Value = 0;
            test12.Value = 0;
            test13.Value = 0;
            test14.Value = 0;
            test15.Value = 0;

        }

        private void Vopros_1_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            if (Vopros_1_Voprosi_IT.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_1_Voprosi_IT.Background == Brushes.LightBlue)
            {
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_3_Voprosi_IT());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_2_Voprosi_IT());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page5());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_2());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page5());
                    }

                }
            }
            else
            {
                return;
            }
                
        }

        private void Vopros_2_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_2_Voprosi_IT.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_2_Voprosi_IT.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_2_3_Voprosi_IT());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_2_2_Voprosi_IT());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page4());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_5());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page4());
                    }

                }
            }
            else
            {
                return;
            }

            
        }

        private void Vopros_4_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_4_Voprosi_IT.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_4_Voprosi_IT.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_4_3_Voprosi_IT());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_4_2_Voprosi_IT());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page2());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_11());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page2());
                    }

                }
            }
            else
            {
                return;
            }

            

        }

        private void Vopros_5_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_5_Voprosi_IT.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_5_Voprosi_IT.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_5_3_Voprosi_IT());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_5_2_Voprosi_IT());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page14());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_14());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page14());
                    }

                }
            }
            else
            {
                return;
            }

            
        }

        private void Vopros_3_Voprosi_IT_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_3_Voprosi_IT.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_3_Voprosi_IT.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_3_3_Voprosi_IT());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_3_2_Voprosi_IT());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page3());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_8());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page3());
                    }

                }
            }
            else
            {
                return;
            }

        }

        private void Vopros_1_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_1_Voprosi_People_in_Programming.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_1_Voprosi_People_in_Programming.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_2_Voprosi_People_in_Programming());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_3_Voprosi_People_in_Programming());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page13());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_3());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page13());
                    }

                }
            }
            else
            {
                return;
            }
        }

        private void Vopros_2_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_2_Voprosi_People_in_Programming.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_2_Voprosi_People_in_Programming.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_2_2_Voprosi_People_in_Programming());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_2_3_Voprosi_People_in_Programming());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page12());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_6());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page12());
                    }

                }
            }
            else
            {
                return;
            }

        }

        private void Vopros_3_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_3_Voprosi_People_in_Programming.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_3_Voprosi_People_in_Programming.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_3_2_Voprosi_People_in_Programming());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_3_3_Voprosi_People_in_Programming());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page11());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_9());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page11());
                    }

                }
            }
            else
            {
                return;
            }
        }

        private void Vopros_4_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_4_Voprosi_People_in_Programming.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_4_Voprosi_People_in_Programming.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_4_2_Voprosi_People_in_Programming());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_4_3_Voprosi_People_in_Programming());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page10());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_12());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page10());
                    }

                }
            }
            else
            {
                return;
            }
        }

        private void Vopros_5_Voprosi_People_in_Programming_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_5_Voprosi_People_in_Programming.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_5_Voprosi_People_in_Programming.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_5_2_Voprosi_People_in_Programming());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_5_3_Voprosi_People_in_Programming());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page1());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_15());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page1());
                    }

                }
            }
            else
            {
                return;
            }
        }

        private void Vopros_1_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_1_History_of_the_IT_sphere.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_1_History_of_the_IT_sphere.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_3_History_of_the_IT_sphere());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_2_History_of_the_IT_sphere());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_History_of_the_IT_sphere());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_1());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_1_History_of_the_IT_sphere());
                    }

                }
            }
            else
            {
                return;
            }
        }

        private void Vopros_2_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_2_History_of_the_IT_sphere.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_2_History_of_the_IT_sphere.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_2_3_History_of_the_IT_sphere());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_2_2_History_of_the_IT_sphere());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page9());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_4());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page9());
                    }

                }
            }
            else
            {
                return;
            }

        }

        private void Vopros_3_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_3_History_of_the_IT_sphere.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_3_History_of_the_IT_sphere.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_3_3_History_of_the_IT_sphere());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_3_2_History_of_the_IT_sphere());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page8());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_7());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page8());
                    }

                }
            }
            else
            {
                return;
            }

        }

        private void Vopros_4_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_4_History_of_the_IT_sphere.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_4_History_of_the_IT_sphere.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_4_3_History_of_the_IT_sphere());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_4_2_History_of_the_IT_sphere());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page7());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_10());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page7());
                    }

                }
            }
            else
            {
                return;
            }

        }

        private void Vopros_5_History_of_the_IT_sphere_Click(object sender, RoutedEventArgs e)
        {
            if (Vopros_5_History_of_the_IT_sphere.Background == Brushes.Red)
            {
                MessageBox.Show("На этот вопрос уже ответили");
            }
            else if (Vopros_5_History_of_the_IT_sphere.Background == Brushes.LightBlue)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1; i++)
                {
                    R_1.Text = R_1.Text + rnd.Next((4));
                    double x = double.Parse(R_1.Text);
                    if (x == 0)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_5_3_History_of_the_IT_sphere());
                    }
                    else if (x == 1)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Vopros_5_2_History_of_the_IT_sphere());
                    }
                    else if (x == 2)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page6());
                    }
                    else if (x == 3)
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Kot_v_Meshke_13());
                    }
                    else
                    {
                        R_1.Text = "";
                        Manager.MainFrame.Navigate(new PageSVoprosami.Page6());
                    }

                }
            }
            else
            {
                return;
            }

        }
         private Rekordi _current = new Rekordi();

        private void Pobeda_Click(object sender, RoutedEventArgs e)
        {
            Komanda_1_t.Text = Komanda_1.Text;
            Komanda_2_t.Text = Komanda_2.Text;
            naz_1_t.Text = naz_1.Text;
            naz_2_t.Text = naz_2.Text;

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(_current.komanda_1))
                errors.AppendLine("Укажите название команды");
            if (_current.ohko_k_1 <= 0)
                errors.AppendLine("Количество очков не может быть меньше или равно 0");
            if (string.IsNullOrWhiteSpace(_current.komanda_2))
                errors.AppendLine("Укажите название команды");
            if (_current.ohko_k_2 <= 0)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        

            double x = double.Parse(Komanda_1.Text);
            double y = double.Parse(Komanda_2.Text);

            if (x > y)
            {
                Manager.MainFrame.Navigate(new win_k_1());
            }
            else if (x < y)
            {
                Manager.MainFrame.Navigate(new win_k_2());
            }
            else if (x == y)
            {
                Manager.MainFrame.Navigate(new win_draw());
            }

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
           
        }
    }
}
