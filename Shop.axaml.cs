using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System;
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
        foreach (Products product in DataLists.Products)
        {
            if (product.fileName == null)
            {
                product.fileName = AppDomain.CurrentDomain.BaseDirectory + "/assets/no_picture.png";
                product.productImage = new Bitmap(product.fileName);
            }
        }
        ShoppingCart.ItemsSource = DataLists.Products.ToList();
        ItemQuantity.Text = $"{ShoppingCart.ItemCount} из {DataLists.Products.Count}";
        AddButton.IsVisible = false;
    }
    public Shop(int id)
    {
        InitializeComponent();
        UserName.Text = DataLists.Users[id].username;
        foreach (Products product in DataLists.Products)
        {
            if (product.fileName == null)
            {
                product.fileName = AppDomain.CurrentDomain.BaseDirectory + "/assets/no_picture.png";
                product.productImage = new Bitmap(product.fileName);
            }
        }
        ShoppingCart.ItemsSource = DataLists.Products.ToList();
        ItemQuantity.Text = $"{ShoppingCart.ItemCount} из {DataLists.Products.Count}";
        if (DataLists.Users[id].role != "Admin")
        {
            AddButton.IsVisible = false;
        }
    }
    public void Exit(object sender, RoutedEventArgs args)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
    public void ProductAdd(object sender, RoutedEventArgs args)
    {
        Adding adding = new Adding();
        adding.Show();
        Close();
    }
    public void Edit(object? sender, PointerReleasedEventArgs e)
    {
        DataLists.currentProductId = ShoppingCart.SelectedIndex;
        Adding editWindow = new Adding(DataLists.currentProductId);
        editWindow.Show();
        Close();
    }
}