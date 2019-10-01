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
using UserManagement.Controllers;
using UserManagement.Views;

namespace UserManagement.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            UsernameTextBox.Text = Properties.Settings.Default.Email;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            UserController CallUser = new UserController();

            if (UsernameTextBox.Text.Length == 0 && PasswordTextBox.Password.Length == 0)
            {
                UsernameErrorMessage.Text = "You Must Enter Valid Email!";
                PasswordErrorMessage.Text = "You Must Enter Password!";
                PasswordTextBox.Focus();
                UsernameTextBox.Focus();
            }
            else if (UsernameTextBox.Text.Length == 0)
            {
                UsernameErrorMessage.Text = "You Must Enter Valid Email!";
                UsernameTextBox.Focus();
            }
            else if (PasswordTextBox.Password.Length == 0)
            {
                PasswordErrorMessage.Text = "You Must Enter Password!";
                PasswordTextBox.Focus();
            }
            else
            {
                string email = UsernameTextBox.Text;
                string password = PasswordTextBox.Password;

                var status = CallUser.UserLogin(email, password);
                if (status == true)
                {
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }

            }
        }




        private void RememberCheck_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Email = UsernameTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
