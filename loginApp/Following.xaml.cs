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
    public partial class Following : Window
    {
        User user = new User();
        public Following(User user)
        {
            this.user = user;
            InitializeComponent();

            followinglist.ItemsSource = user.following;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 win = new Window1(user);
            win.Show();
        }

        private void followinglist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
