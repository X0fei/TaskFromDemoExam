using Avalonia.Controls;
using Avalonia.Interactivity;

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
            foreach (Users user in Lists.Users)
            {
                if (user.login == Login.Text)
                {
                    if (user.password == Password.Text)
                    {
                        int id = Lists.Users.IndexOf(user);
                        if (user.role == "Admin")
                        {
                            GoToAdminMain(id);
                        }
                        else
                        {
                            GoToUserMain(id);
                        }
                    }
                }
            }
        }

        public void GoToAdminMain(int id)
        {
            AdminMain adminMain = new AdminMain(id);
            adminMain.Show();
            Close();
        }
        public void GoToUserMain(int id)
        {
            UserMain userMain = new UserMain(id);
            userMain.Show();
            Close();
        }
        public void GoToGuestMain(object sender, RoutedEventArgs args)
        {
            UserMain guestMain = new UserMain();
            guestMain.Show();
            Close();
        }
    }
}