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
using Cactus.DB;
using Cactus.Pages;
using Cactus; 



namespace Cactus.Pages
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : Page
    {
        
        public Info()
        {
            InitializeComponent();

            ListInfo.ItemsSource = ConnectionClass.cac.Cactus.ToList();
            
      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                var b = ListInfo.SelectedItem as Cactusi;
                if (b != null)
                {
                    ConnectionClass.cac.Cactus.Remove(b);
                    ConnectionClass.cac.SaveChanges();
                    ListInfo.ItemsSource = ConnectionClass.cac.Cactus.ToList();
                    MessageBox.Show($"Кактус {b.Name_cactus} удален", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Для начала выберите запись!");
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListInfo.ItemsSource = ConnectionClass.cac.Cactus.Where(z => z.Name_cactus.ToLower().Contains(TxtSearch.Text)).ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs eventArgs) 
        {
            var a = (sender as Button).DataContext as DB.Cactusi;
            NavigationService.Navigate(new EditPage(a));
        }

        private void BtnVist_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Vistav());
        }
    }
}
