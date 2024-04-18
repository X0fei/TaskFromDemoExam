using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace TaskFromDemoExam;

public partial class UserMain : Window
{
    public UserMain()
    {
        InitializeComponent();
        UserName.Text = "Гость";
    }
    public UserMain(int id)
    {
        InitializeComponent();
        UserName.Text = Lists.Users[id].username;
    }
    public void Exit(object sender, RoutedEventArgs args)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
}