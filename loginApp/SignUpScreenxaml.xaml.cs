using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace loginApp
{
    public partial class SignUpScreenxaml : Window
    {
        User user = new User();
        public SignUpScreenxaml()
        {

            InitializeComponent();
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != "" && username.Text != "" && password.Text != "")
            {
                user.name = Name.Text;
                user.Username = username.Text;
                user.password = password.Text;
                user.profilePhoto = "";
                user.followers = new BindingList<User>();
                user.following = new BindingList<User>();
                this.Hide();
                Selectprofilephoto screen = new Selectprofilephoto(user);
                screen.Show();
            }
            else
            {
                MessageBox.Show("Please fill the remaining space.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow screen = new MainWindow();
            screen.Show();
        }
    }
}
