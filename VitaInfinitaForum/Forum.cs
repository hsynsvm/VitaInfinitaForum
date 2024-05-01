using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaInfinitaForum
{
    internal class Forum
    {
        public Products[] products;

        public Forum()
        {
            products = new Products[0];
        }

        public void Add(Products p)
        {
            Products[] temporary = new Products[products.Length+1];
            Array.Copy(products, temporary, products.Length);
            temporary[temporary.Length-1] = p;
            products = temporary;
        }
        public void Add(string n,string c,double p,int s)
        {
            Products[] temporary = new Products[products.Length + 1];
            Array.Copy(products, temporary, products.Length);
            temporary[temporary.Length - 1] = new Products(n,c,p,s);
            products = temporary;
        }





    }
}
