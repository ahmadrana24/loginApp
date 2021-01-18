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
    public partial class Window2 : Window
    {
        User user = new User();
        User currentuser = new User();
        List<BitmapImage> imagesBitMap = new List<BitmapImage>();
        public Window2(User passedUser,User currentUserPassed)
        {
            this.user = passedUser;
            this.currentuser = currentUserPassed;
            foreach (String var in this.user.images)
            {

                imagesBitMap.Add(new BitmapImage(new Uri(var)));
            }
            InitializeComponent();
            username.Content = user.Username;
            profilePic.Source = new BitmapImage(new Uri(user.profilePhoto));
            imagesListView.ItemsSource = null;
            imagesListView.ItemsSource = this.imagesBitMap;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                this.Hide();
                UsersPage user = new UsersPage(this.currentuser);
                user.Show();
        }
    }
}
