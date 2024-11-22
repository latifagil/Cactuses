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
using Cactus.Pages;

namespace Cactus.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        MainWindow _mainWindow;
        public LoginPage(MainWindow mainindow)
        {
            InitializeComponent();

             _mainWindow = mainindow;
        }


        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            var loginObj = ConnectionClass.cac.Login.FirstOrDefault(log => log.Login1 == login && log.Password == password);

            if (loginObj == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            ConnectionClass.user = loginObj.Users;
            _mainWindow.MainFrame.NavigationService.Navigate(new captha());

        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }
    }
}
