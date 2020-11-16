using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace loginApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usernamee = "ahmadrana";
            string pssword = "12345";
            if(Username.Text != "" && password.Password != "")
            {
                if (Username.Text == usernamee && password.Password == pssword)
                {
                    this.Hide();
                    Window1 win = new Window1();
                    win.Show();
                }
                else
                {
                    MessageBox.Show("Failed to login Try again\nIncorrect username or password","Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill the remaining space.");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
