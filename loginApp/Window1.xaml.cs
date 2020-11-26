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
    public partial class Window1 : Window, INotifyPropertyChanged
    {
        User user = new User();

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Window1(User passedUser)

        {
            this.user = passedUser;
            InitializeComponent();
            followersNum.Content = user.followers.Count;
            followingNum.Content = user.following.Count;
            username.Content = user.Username;
            profilePic.Source = new BitmapImage(new Uri(user.profilePhoto));
        }

        private void seeUsers_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            UsersPage user = new UsersPage(this.user);
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
            followers follow = new followers(this.user);
            follow.Show();
        }

        private void following_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Following follow = new Following(this.user);
            follow.Show();
        }

        private void addPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Image files(*.jpg, *.png) | *.jpg; *.png";
            Nullable<bool> dialogOK = fileDialog.ShowDialog();
            user.images.Add(fileDialog.FileName);

        }
    }
}
