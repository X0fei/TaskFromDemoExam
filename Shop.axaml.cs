using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TaskFromDemoExam;

public partial class Shop : Window
{
    public Shop()
    {
        InitializeComponent();
        UserName.Text = "Гость";
        ShoppingCart.ItemsSource = DataLists.Products.ToList();
    }
    public Shop(int id)
    {
        InitializeComponent();
        UserName.Text = DataLists.Users[id].username;
        ShoppingCart.ItemsSource = DataLists.Products.ToList();
    }
    public void Exit(object sender, RoutedEventArgs args)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
    public void ProductAdd(object sender, RoutedEventArgs args)
    {

    }
}