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

namespace Cactus.Pages
{
    /// <summary>
    /// Логика взаимодействия для captha.xaml
    /// </summary>
    public partial class captha : Page
    {
        public captha()
        {
            InitializeComponent();
            UpdateCaptcha();
        }
        Random rnd = new Random();
        string capch;

        private void BtnUpdateCaptcha_Click(object sender, RoutedEventArgs e) // метод для обновления капчи
        {
            UpdateCaptcha();
        }
        private void UpdateCaptcha() //метод который обновляет капчу
        {
            SPanelSymbols.Children.Clear();  //очистка StackPanel
            CanvasNoise.Children.Clear(); //очистка капчи
            GenerateSymbols(5); //генерация символов
            GenerateNoise(25); //генерация фигур

        }
        private void GenerateSymbols(int count) //метод для генерации символов
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < count; i++)
            {
                string symbol = alphabet.ElementAt(rnd.Next(0, alphabet.Length)).ToString();
                TextBlock lbl = new TextBlock();
                lbl.Text = symbol;
                lbl.FontSize = rnd.Next(35, 85);
                lbl.RenderTransform = new RotateTransform(rnd.Next(-45, 45));
                lbl.Margin = new Thickness(10, 10, 10, 10);
                lbl.Foreground = new SolidColorBrush(Color.FromArgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256)));
                SPanelSymbols.Children.Add(lbl);
                capch += lbl.Text;
            }
        }
        private void GenerateNoise(int volumeNoise) // метод для генерации фигур
        {
            for (int i = 0; i < volumeNoise; i++)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.Fill = new SolidColorBrush(Color.FromArgb((byte)rnd.Next(100, 256), (byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256)));
                ellipse.Width = ellipse.Height = rnd.Next(5, 50);
                CanvasNoise.Children.Add(ellipse);
                Canvas.SetLeft(ellipse, rnd.Next(0, 350));
                Canvas.SetTop(ellipse, rnd.Next(0, 250));

            }
        }

        private void BtnButton_Click(object sender, RoutedEventArgs e) //проверка капчи на правильность ввода
        {
            var a = SPanelSymbols.Children;
            string res = "";
            for (int i = 0; i < a.Count; i++)
            {
                res += ((TextBlock)a[i]).Text;
            }
            if (TxtCapch.Text == res)
            {
                MessageBox.Show("Верно!");
                NavigationService.Navigate(new Info());


            }
            else
            {
                MessageBox.Show("вы робот");
                UpdateCaptcha();
            }
        }
    }
}
