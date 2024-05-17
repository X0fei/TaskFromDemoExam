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
                    DataLists.currentId = DataLists.Users.IndexOf(user);
                    GoToShop();
                }
                else
                {
                    ErrorLogIn.IsVisible = true;
                }
            }
        }

        public void GoToShop()
        {
            Shop shop = new Shop(DataLists.currentId);
            shop.Show();
            Close();
        }
        public void GusetLogIn(object sender, RoutedEventArgs args)
        {
            Shop shop = new Shop();
            shop.Show();
            Close();
        }
    }
}