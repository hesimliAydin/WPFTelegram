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

namespace WPFTelegram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            uc1.Width = 640;
            uc1.Message1Lbl.Content = "Sabah necede gedessen derse?";
            uc1.Message2Lbl.Content = "Vaxtinda";
            uc1.Message3Lbl.Content = "Hec bi sey sabah biraz tez gelersen";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_2.png", UriKind.Relative));
            uc1.NameCentral.Content = "Kamran"; 
            uc1.Message1Lbl.Content = "Salam qaqa necesen ";
            uc1.Message2Lbl.Content = "Sukur qaqi sen necesen neyniyirsen";
            uc1.Message3Lbl.Content = "Task yaziram qaqa sen neyniyrsen";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_3.png", UriKind.Relative));
            uc1.NameCentral.Content = "Salfetka";
            uc1.Message1Lbl.Content = "Qaqa xeta var atim baxda bi dene koda";
            uc1.Message2Lbl.Content = "He at baxim";
            uc1.Message3Lbl.Content = "He hell eledim qaqa cox sagol yenede";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown3(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_4.png", UriKind.Relative));
            uc1.NameCentral.Content = "Fatih";
            uc1.Message1Lbl.Content = "oyuna girmicem bu gun";
            uc1.Message2Lbl.Content = "niye";
            uc1.Message3Lbl.Content = "gelemicem isim var baska zaman artik";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown4(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_5.png", UriKind.Relative));
            uc1.NameCentral.Content = "Omer";
            uc1.Message1Lbl.Content = "Zeng elemisen brat";
            uc1.Message2Lbl.Content = "xeta var idi kodda tapa bilmirdim tapdim day";
            uc1.Message3Lbl.Content = "Ela brat";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown5(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_6.png", UriKind.Relative));
            uc1.NameCentral.Content = "Sari";
            uc1.Message1Lbl.Content = "Gorusey sabah brat";
            uc1.Message2Lbl.Content = "Vaxtim yoxdu qaqa";
            uc1.Message3Lbl.Content = "Basqa vaxta qalsin onda";
            
            MessageGrid.Children.Add(uc1);
        }
    }
}
