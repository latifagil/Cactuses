using Cactus.DB;
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
    /// Логика взаимодействия для Vistav.xaml
    /// </summary>
    public partial class Vistav : Page
    {
        public Vistav()
        {
            InitializeComponent();

            ListVistav.ItemsSource = ConnectionClass.cac.Vistavka.ToList();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListVistav.ItemsSource = ConnectionClass.cac.Vistavka.Where(z => z.Name_vistav.ToLower().Contains(TxtSearch.Text)).ToList();

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                var b = ListVistav.SelectedItem as Vistavka;
                if (b != null)
                {
                    ConnectionClass.cac.Vistavka.Remove(b);
                    ConnectionClass.cac.SaveChanges();
                    ListVistav.ItemsSource = ConnectionClass.cac.Vistavka.ToList();
                    MessageBox.Show($"Выставка {b.Name_vistav} удалена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Для начала выберите запись!");
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Info());
        }
    }
}
