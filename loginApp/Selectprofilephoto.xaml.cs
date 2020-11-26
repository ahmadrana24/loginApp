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
    public partial class Selectprofilephoto : Window, INotifyPropertyChanged
    {
        User users = new User();


        public Selectprofilephoto(User user)
        {
            this.users = user;
            Console.WriteLine(user.name);
            InitializeComponent();
            Console.WriteLine(users.profilePhoto);
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void selectPicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Image files(*.jpg, *.png) | *.jpg; *.png";
            Nullable<bool> dialogOK = fileDialog.ShowDialog();
            
            if (dialogOK == true)
            {
                users.profilePhoto = fileDialog.FileName;
                users.images = new BindingList<String>();
                profilePhoto.Source = new BitmapImage(new Uri(users.profilePhoto));
                Button btn = new Button();
                btn.Content = "Done";
                btn.Background = new SolidColorBrush(Colors.White);
                btn.Foreground = new SolidColorBrush(Colors.Black);
                btn.Height = 30;
                btn.Width = 70;
                btn.HorizontalAlignment = HorizontalAlignment.Left;
                btn.VerticalAlignment = VerticalAlignment.Top;
                btn.Margin = new Thickness(99, 361, 0, 0);
                btn.Click += done_Click;
                MainGrid.Children.Add(btn);
                NotifyPropertyChanged("profilePhoto");
                Console.WriteLine(fileDialog.FileName);
            }
        }
        private void done_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AllUsers.allUsers.Add(users);
            Window1 screen = new Window1(users);
            screen.Show();
        }
    }
}
