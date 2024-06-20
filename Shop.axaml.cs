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
    public Shop(int? id)
    {
        InitializeComponent();
        UserName.Text = DataLists.Users[Convert.ToInt32(id)].username;
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
        if (DataLists.Users[Convert.ToInt32(id)].role != "Admin")
        {
            AddButton.IsVisible = false;
        }
    }
    public void Exit(object sender, RoutedEventArgs args)
    {
        DataLists.currentUserId = null;
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
        int id = Convert.ToInt32(DataLists.currentUserId);
        if (DataLists.Users[id].role == "Admin" && DataLists.currentUserId != null)
        {
            DataLists.currentProductId = ShoppingCart.SelectedIndex;
            Adding editWindow = new Adding(Convert.ToInt32(DataLists.currentProductId));
            editWindow.Show();
            Close();
        }
    }
}