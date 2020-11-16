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
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void seeUsers_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            UsersPage user = new UsersPage();
            user.Show();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mww = new MainWindow();
            mww.Show();
        }

        private void followers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            followers follow = new followers();
            follow.Show();
        }

        private void following_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Following follow = new Following();
            follow.Show();
        }
    }
}
