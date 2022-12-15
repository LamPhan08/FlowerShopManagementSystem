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
using System.Windows.Shapes;

namespace FlowerShopManagementSystem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            tbxUsername.Focus();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbxUsername.Text == "")
            {
                if (tbxPassword.Password.ToString() == "")
                {
                    loginNotification("Please input full information!");
                    tbxUsername.BorderBrush = new SolidColorBrush(Colors.Red);
                    tbxPassword.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    loginNotification("Please input full information!");
                    tbxUsername.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
            else
            {
                if (tbxPassword.Password.ToString() == "")
                {
                    loginNotification("Please input full information!");
                    tbxPassword.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    if (tbxUsername.Text != "admin" || tbxPassword.Password.ToString() != "admin")
                    {
                        loginNotification("Invalid Username or Password!");
                        tbxUsername.BorderBrush = new SolidColorBrush(Colors.Red);
                        tbxPassword.BorderBrush = new SolidColorBrush(Colors.Red);
                    }
                    else
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Close();
                    }
                }
            }
        }

        private void loginNotification(String notify)
        {
            loginNotify.Text = notify;
            loginNotify.Visibility = Visibility.Visible;
        }

        private void tbxUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            loginNotify.Visibility = Visibility.Hidden;
            tbxUsername.BorderBrush = new SolidColorBrush(Colors.Black);
            tbxPassword.BorderBrush = new SolidColorBrush(Colors.Black);
        }

        private void tbxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            loginNotify.Visibility = Visibility.Hidden;
            tbxUsername.BorderBrush = new SolidColorBrush(Colors.Black);
            tbxPassword.BorderBrush = new SolidColorBrush(Colors.Black);
        }
    }
}
