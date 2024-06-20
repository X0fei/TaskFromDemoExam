using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromDemoExam
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string quantity { get; set; }
        public string measureUnit { get; set; }
        public string manufacturer { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string fileName { get; set; }
        public Bitmap productImage { get { return new Bitmap(fileName); } set { } }
    }
}
