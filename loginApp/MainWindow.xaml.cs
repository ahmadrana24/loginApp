using System;
using System.Collections.Generic;
using System.ComponentModel;
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
  
    public class AllUsers
    {
        public static BindingList<User> allUsers = new BindingList<User>();

    }
    public class User
    {
        public String name { get; set; }
        public String Username { get; set; }
        public String password { get; set; }
        public String profilePhoto { get; set; }

        public BindingList<String> followers { get; set; }
        public BindingList<String> following { get; set; }
        public BindingList<String> images { get; set; }
    }
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            //Submitted by SP18-BSE-009 AHMED ASHRAF    
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public MainWindow()
        {
            InitializeComponent();

             Database1Entities1 db = new Database1Entities1();
             db.AllUsersOfApps .ToList().ForEach((item) =>
             {
                 List<String> followersList = new List<string>();
                 if (item.followers != null)
                 {
                      followersList = item.followers.Split(',').ToList<String>();
                 }
                 List<String> followeingList = new List<string>();
                 if (item.followers != null)
                 {
                     followeingList = item.following.Split(',').ToList<String>();
                 }
                 List<String> imagesList = new List<string>();
                 if (item.followers != null)
                 {
                     imagesList = item.Images.Split(',').ToList<String>();
                 }
                 Console.WriteLine(item.Username);
                 AllUsers.allUsers.Add(
                     new User{
                 Username= item.Username,
                 profilePhoto= item.ProfilePic,
                 name = item.Name,
                 password = item.Password,
                 followers = new BindingList<String>(followersList),
                 following = new BindingList<String>(followeingList),
                 images =  new BindingList<String>(imagesList),
                 });
             });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(Username.Text != "" && password.Password != "")
            {
                
                    bool found = false;
                    for(int i = 0; i< AllUsers.allUsers.Count; i++)
                    {
                        if(AllUsers.allUsers[i].Username == Username.Text && AllUsers.allUsers[i].password == password.Password)
                        {
                            this.Hide();
                            Window1 win = new Window1(AllUsers.allUsers[i]);
                            win.Show();
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show("Please register first or check your email or password");
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

        private void signUp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignUpScreenxaml win = new SignUpScreenxaml();
            win.Show();
        }
    }
}
