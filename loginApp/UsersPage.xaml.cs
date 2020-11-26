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

namespace loginApp
{
    /// <summary>
    /// Interaction logic for UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Window
    {
        User user = new User();
        public UsersPage(User user)
        {
            this.user = user;
           
            InitializeComponent();
            usersList.ItemsSource = AllUsers.allUsers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 wn = new Window1(user);
            wn.Show();
        }

        private void usersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
