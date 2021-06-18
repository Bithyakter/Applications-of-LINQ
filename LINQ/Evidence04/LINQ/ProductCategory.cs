using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ProductCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        public ProductCategory(int categoryID, string name) : this()
        {
            CategoryID = categoryID;
            CategoryName = name;
        }

    }
}

