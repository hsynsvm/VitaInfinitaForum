using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaInfinitaForum
{
    public class Products
    {
        public string Name;
        public string Category;
        public double Price;
        public int Stock;

        public Products(string name, string category, double price, int stock)
        {
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Stock = stock;
        }
    }
    
}
