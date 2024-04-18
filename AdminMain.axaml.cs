using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;

namespace TaskFromDemoExam;

public partial class AdminMain : Window
{
    public AdminMain()
    {
        InitializeComponent();
    }
    public AdminMain(int id)
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