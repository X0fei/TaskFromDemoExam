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