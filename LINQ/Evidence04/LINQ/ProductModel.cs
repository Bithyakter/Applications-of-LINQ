using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ProductModel
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public ProductModel()
        {
            Products = new HashSet<Product>();
        }
        public ProductModel(int modelID, string name) : this()
        {
            ModelID = modelID;
            ModelName = name;
        }
    }
}

