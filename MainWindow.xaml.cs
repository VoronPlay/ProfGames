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

    static class ohko_1
    {
        public static int? Value { get; set; }
    }
    static class ohko_2
    {
        public static int? Value { get; set; }
    }
    static class text_1
    {
        public static string Value { get; set; }
    }
    static class text_2
    {
        public static string Value { get; set; }
    }
    static class test1
    {
        public static int? Value { get; set; }
    }
    static class test2
    {
        public static int? Value { get; set; }
    }
    static class test3
    {
        public static int? Value { get; set; }
    }
    static class test4
    {
        public static int? Value { get; set; }
    }
    static class test5
    {
        public static int? Value { get; set; }
    }
    static class test6
    {
        public static int? Value { get; set; }
    }
    static class test7
    {
        public static int? Value { get; set; }
    }
    static class test8
    {
        public static int? Value { get; set; }
    }
    static class test9
    {
        public static int? Value { get; set; }
    }
    static class test10
    {
        public static int? Value { get; set; }
    }
    static class test11
    {
        public static int? Value { get; set; }
    }
    static class test12
    {
        public static int? Value { get; set; }
    }
    static class test13
    {
        public static int? Value { get; set; }
    }
    static class test14
    {
        public static int? Value { get; set; }
    }
    static class test15
    {
        public static int? Value { get; set; }
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model1db = new ProfGamesEntities();
            MainFrame.Navigate(new StartPage());
            Manager.MainFrame = MainFrame;
        }
    }
}
