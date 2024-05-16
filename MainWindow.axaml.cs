using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TaskFromDemoExam
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void LogIn(object sender, RoutedEventArgs args)
        {
            foreach (Users user in DataLists.Users)
            {
                if (user.login == Login.Text && user.password == Password.Text)
                {
                    int id = DataLists.Users.IndexOf(user);
                    GoToShop(id);
                }
                else
                {
                    ErrorLogIn.IsVisible = true;
                }
            }
        }

        public void GoToShop(int id)
        {
            Shop adminMain = new Shop(id);
            adminMain.Show();
            Close();
        }
        public void GusetLogIn(object sender, RoutedEventArgs args)
        {
            Shop adminMain = new Shop();
            adminMain.Show();
            Close();
        }
    }
}