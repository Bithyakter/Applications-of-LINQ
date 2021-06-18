using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
        public int Price { get; set; }
        public int CategoryID { get; set; }
        public int ModelID { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductModel ProductModel { get; set; }

        public Product()
        {

        }
        public Product(int productID, string productName, string color, double weight, double size, int price, int categoryID, int modelID) : this()
        {
            ProductID = productID;
            ProductName = productName;
            Color = color;
            Weight = weight;
            Size = size;
            Price = price;
            CategoryID = categoryID;
            ModelID = modelID;
        }
    }
}
