using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using SkiaSharp;
using Avalonia.Media;
using Avalonia.Platform.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using Avalonia.Media.Imaging;
using Bitmap = Avalonia.Media.Imaging.Bitmap;
using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Platform;
using System.Text.Unicode;

namespace TaskFromDemoExam;

public partial class Adding : Window
{
    public Adding()
    {
        InitializeComponent();
        Edit.IsVisible = false;
    }
    public Adding(int id)
    {
        InitializeComponent();
        Name.Text = DataLists.Products[id].name;
        Category.Text = DataLists.Products[id].category;
        Manufacturer.Text = DataLists.Products[id].manufacturer;
        Quantity.Text = DataLists.Products[id].quantity;
        MeasureUnit.Text = DataLists.Products[id].measureUnit;
        Price.Text = DataLists.Products[id].price;
        Description.Text = DataLists.Products[id].description;
        Add.IsVisible = false;
    }
    public async void AddImage(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        var topLevel = await openFileDialog.ShowAsync(this);
        DataLists.Products[DataLists.currentProductId].fileName = String.Join("", topLevel);
        ProductImage.Source = new Bitmap(DataLists.Products[DataLists.currentProductId].fileName);
    }
    public void ProductAdd(object sender, RoutedEventArgs args)
    {
        DataLists.Products.Add(new Products()
        {
            name = Name.Text,
            category = Category.Text,
            manufacturer = Manufacturer.Text,
            quantity = Quantity.Text,
            measureUnit = MeasureUnit.Text,
            price = Price.Text,
            description = Description.Text
        });
        Shop shop = new Shop(DataLists.currentUserId);
        shop.Show();
        Close();
    }
    public void ProductEdit(object sender, RoutedEventArgs args)
    {
        DataLists.Products[DataLists.currentProductId].name = Name.Text;
        DataLists.Products[DataLists.currentProductId].category = Category.Text;
        DataLists.Products[DataLists.currentProductId].manufacturer = Manufacturer.Text;
        DataLists.Products[DataLists.currentProductId].quantity = Quantity.Text;
        DataLists.Products[DataLists.currentProductId].measureUnit = MeasureUnit.Text;
        DataLists.Products[DataLists.currentProductId].price = Price.Text;
        DataLists.Products[DataLists.currentProductId].description = Description.Text;
        Shop shop = new Shop(DataLists.currentUserId);
        shop.Show();
        Close();
    }
}