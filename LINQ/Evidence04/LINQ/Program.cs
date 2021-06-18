using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var Categories = new ProductCategory[]
            {
                new ProductCategory { CategoryID = 1, CategoryName = "Mobile"},
                new ProductCategory { CategoryID = 2, CategoryName = "Computer"}
            };

            var Models = new ProductModel[]
            {
                new ProductModel { ModelID = 1, ModelName = "12 pro max"},
                new ProductModel { ModelID = 2, ModelName = "Galaxy Note"},
                new ProductModel { ModelID = 3, ModelName = "Core i5"},
                new ProductModel { ModelID = 4, ModelName = "Core i7"}
            }; 

            var Products = new Product[]
            {
                new Product { ProductID = 1, ProductName = "Nokia", Color = "Blue", Weight = 0.8, Size =13.3, Price = 30000, CategoryID = 1, ModelID = 1},
                new Product { ProductID = 2, ProductName = "Asus", Color = "Gray", Weight = 0.17, Size =14, Price = 15000, CategoryID = 2, ModelID = 3},
                new Product { ProductID = 3, ProductName = "iPhone", Color = "White", Weight = 0.7, Size =17, Price = 80000, CategoryID = 1, ModelID = 1},
                new Product { ProductID = 4, ProductName = "HP", Color = "Black", Weight = 0.12, Size =15.6, Price = 40000, CategoryID = 2, ModelID = 4},
                new Product { ProductID = 5, ProductName = "DELL", Color = "Orange", Weight = 0.8, Size =11, Price = 35000, CategoryID = 2, ModelID = 3},
                new Product { ProductID = 6, ProductName = "Samsung", Color = "Red", Weight = 0.7, Size =14, Price = 12000, CategoryID = 1, ModelID = 2}  
            };

            /*=============================Joining==========================*/
            Console.WriteLine("Product Information\n=============================================================================\n");
            var result = Products
                .Select(pd => new { pd.ProductName, pd.CategoryID, pd.ModelID, pd.Color, pd.Size, pd.Weight, pd.Price })
                .Join(Categories, pr => pr.CategoryID, pc => pc.CategoryID, (pr, pc) => new { pr.ProductName, Category = pc.CategoryName, pr.ModelID, pr.Color, pr.Size, pr.Weight, pr.Price })
                .Join(Models, prc => prc.ModelID, pm => pm.ModelID, (prc, pm) => new { prc.ProductName, prc.Category, Model = pm.ModelName, prc.Color, prc.Size, prc.Weight, prc.Price });

            foreach (var product in result)
            {
                string productInfo = product.ToString();
                Console.WriteLine(productInfo.Replace("{ ", "").Replace(" }", ""));
            }


            /*=========================Select,where======================*/
            Console.WriteLine("\n--------Select,where--------");
            var pInfo = Products
            .Where(sg => String.Equals(sg.ProductName, "Nokia"))

            .Select(pd => new
            {
                pd.ProductID,
                pd.ProductName,
                pd.CategoryID,
                pd.Size, 
                pd.Color,
                pd.Price,
            });
            foreach (var info in pInfo)
            {
                Console.WriteLine(info);
            }

            Console.ReadKey();

        }
    }
}
