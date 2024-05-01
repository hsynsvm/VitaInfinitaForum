using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaInfinitaForum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forum forum = new Forum();
            List<Products> urunler = new List<Products>();
            
            urunler.Add(new Products("Apple", "Grocery", 5, 4100));
            urunler.Add(new Products("Grape", "Grocery", 6, 100));
            urunler.Add(new Products("Veal", "Butcher", 8, 150));
            urunler.Add(new Products("Chicken", "Butcher", 5, 20));
            urunler.Add(new Products("Cola", "Beverage", 30, 2000));
            urunler.Add(new Products("Beer", "Beverage", 4, 10000));
            urunler.Add(new Products("Chocolate", "Snack", 30, 5000));
            urunler.Add(new Products("Wafer", "Snack", 15, 12000));

            string choice = "y";
            double total = 0;
            while (choice == "y")
            {
                Console.Clear();
                Console.WriteLine("Please Choose Category!");
                Console.WriteLine("1) Grocery \n2) Butcher\n3) Beverage\n4) Snack ");
                string secim = Console.ReadLine();
                
                switch (secim)
                {
                    case "1":
                        int groceryIndex = 1;
                        foreach (Products product in urunler)
                        {
                            if (product.Category == "Grocery")
                            {
                                Console.WriteLine(groceryIndex + ")" + product.Name + " $" + product.Price + " Stock: " + product.Stock);
                                groceryIndex++;
                            }
                        }
                        break;

                    case "2":
                        int butcherIndex = 1;
                        foreach (Products product in urunler)
                        {
                            if (product.Category == "Butcher")
                            {
                                Console.WriteLine(butcherIndex + ")" + product.Name + " $" + product.Price + " Stock: " + product.Stock);
                                butcherIndex++;
                            }
                        }
                        break;

                    case "3":
                        int beverageIndex = 1;
                        foreach (Products product in urunler)
                        {
                            if (product.Category == "Beverage")
                            {
                                Console.WriteLine(beverageIndex + ")" + product.Name + " $" + product.Price + " Stock: " + product.Stock);
                                beverageIndex++;
                            }
                        }
                        break;

                    case "4":
                        int snackIndex = 1;
                        foreach (Products product in urunler)
                        {
                            if (product.Category == "Snack")
                            {
                                Console.WriteLine(snackIndex + ")" + product.Name + " $" + product.Price + " Stock: " + product.Stock);
                            }
                        }
                        break;
                }

                Console.WriteLine("Please enter the number of the product you want to buy!");
                int urunno = Convert.ToInt32(Console.ReadLine());

                int index = urunno - 1;

                Console.WriteLine("How many " + urunler[index].Name + " you will receive? Max = " + urunler[index].Stock);
                int adet = Convert.ToInt32(Console.ReadLine());

                if (adet <= urunler[index].Stock)
                {
                    total += urunler[index].Price * adet;
                    urunler[index].Stock -= adet; // Stoktan düşürme
                }

                Console.WriteLine("Will you continue shopping? y/n");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Total = " + total + "$");
            Console.WriteLine("Goodbye :) ");


        }
    }
}
