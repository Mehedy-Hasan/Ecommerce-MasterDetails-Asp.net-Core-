using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseContext;
using Models;
using Repositories;

namespace EFCoreExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryRepository categoryRepo = new CategoryRepository();

            var categories = categoryRepo.GetAll();

            categoryRepo.LoadProducts(categories);

            if (categories != null && categories.Any())
            {
                foreach (var category in categories)
                {
                    Console.WriteLine("Category: "+category.Name+" Code: "+category.Code);
                    if (category.Products != null && category.Products.Any())
                    {
                        Console.WriteLine("\t\t Product List: ");
                        foreach (var product in category.Products)
                        {
                            Console.WriteLine("\t\t Product: " + product.Name + " - " + product.Price);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\t\t No Product Available!");
                    }
                }
            }
            
           
            //if (isSaved)
            //{
            //    Console.WriteLine("Product Updated!");
            //}



          


            Console.ReadKey();
        }
    }
}
