using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace TaskFromDemoExam;

public partial class Adding : Window
{
    public Adding()
    {
        InitializeComponent();
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
        Shop shop = new Shop(DataLists.currentId);
        shop.Show();
        Close();
    }
}