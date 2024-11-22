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
using Microsoft.Win32;
using Cactus.DB;
using Cactus.Pages;
using System.IO;

namespace Cactus.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();

            vid.ItemsSource = ConnectionClass.cac.Vid.ToList();
            vistavka.ItemsSource = ConnectionClass.cac.Vistavka.ToList();
           
        }
        Cactusi cactusi = new Cactusi();
        Cactus_Vistavka cv = new Cactus_Vistavka();

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на заполненность полей
            if (string.IsNullOrEmpty(name.Text) ||
                string.IsNullOrEmpty(instructions.Text) ||
                string.IsNullOrEmpty(price.Text) ||
                vid.SelectedItem == null ||
                vistavka.SelectedItem == null ||
                string.IsNullOrEmpty(from.Text) ||
                string.IsNullOrEmpty(age.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!!");
                return;
            }

           
            DB.Vistavka selectedVistavka = (DB.Vistavka)vistavka.SelectedItem;






            cactusi.Name_cactus = name.Text;
            cactusi.Age = Convert.ToInt32(age.Text);
            cactusi.Where_from = from.Text;
            cactusi.Instructions = instructions.Text;
            cactusi.Price = Convert.ToDecimal(price.Text);
            cactusi.Vid = (Vid)vid.SelectedItem;
              

            ConnectionClass.cac.Cactus.Add(cactusi);
            ConnectionClass.cac.SaveChanges();

            NavigationService.Navigate(new Info());
        }



        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Info());
        }

        private void BtnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                cactusi.Image = File.ReadAllBytes(openFileDialog.FileName);
                MemoryStream byteStream = new MemoryStream(cactusi.Image);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                IPicture.Source = image;
            }
        }

        private void vid_SelectionChanged()
        {

        }
    }
}
