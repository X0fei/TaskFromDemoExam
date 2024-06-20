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
    string fileName = AppDomain.CurrentDomain.BaseDirectory + "/assets/no_picture.png";
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
        fileName = DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].fileName;
        ProductImage.Source = new Bitmap(DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].fileName);
        Add.IsVisible = false;
    }
    public async void AddImage(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        var topLevel = await openFileDialog.ShowAsync(this);
        fileName = String.Join("", topLevel);
        ProductImage.Source = new Bitmap(fileName);
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
            description = Description.Text,
            fileName = this.fileName
        });
        DataLists.currentProductId = null;
        Shop shop = new Shop(DataLists.currentUserId);
        shop.Show();
        Close();
    }
    public void ProductEdit(object sender, RoutedEventArgs args)
    {
        DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].name = Name.Text;
        DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].category = Category.Text;
        DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].manufacturer = Manufacturer.Text;
        DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].quantity = Quantity.Text;
        DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].measureUnit = MeasureUnit.Text;
        DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].price = Price.Text;
        DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].description = Description.Text;
        DataLists.Products[Convert.ToInt32(DataLists.currentProductId)].fileName = this.fileName;
        DataLists.currentProductId = null;
        Shop shop = new Shop(DataLists.currentUserId);
        shop.Show();
        Close();
    }
}