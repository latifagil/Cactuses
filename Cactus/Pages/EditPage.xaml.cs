using Cactus.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
        }
        DB.Cactusi _cactusi;

        public EditPage(DB.Cactusi cactusi)
        {
            InitializeComponent();

            vid.ItemsSource = ConnectionClass.cac.Vid.ToList();
            vistavka.ItemsSource = ConnectionClass.cac.Vistavka.ToList();

            _cactusi = cactusi;

            name.Text = _cactusi.Name_cactus;
            age.Text = Convert.ToString(_cactusi.Age);
            from.Text = _cactusi.Where_from;
            price.Text = Convert.ToString(_cactusi.Price);
            instructions.Text = _cactusi.Instructions;
            _cactusi.Vid.Name_vid = Convert.ToString(vid.SelectedItem);




        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var a = ConnectionClass.cac.Cactus.Where(z => z.Id_cactus == _cactusi.Id_cactus).FirstOrDefault();
            a.Name_cactus = name.Text;
            age.Text = Convert.ToString(a.Age);
            price.Text = Convert.ToString(a.Price);
            a.Where_from = from.Text;
            a.Instructions = instructions.Text;
            a.Vid.Name_vid = Convert.ToString(vid.SelectedItem);
            ConnectionClass.cac.SaveChanges();

        }

        private void BtnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                _cactusi.Image = File.ReadAllBytes(openFileDialog.FileName);
                MemoryStream byteStream = new MemoryStream(_cactusi.Image);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                IPicture.Source = image;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Info());
        }
    }
}
