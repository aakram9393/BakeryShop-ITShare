using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Data
{
    public static class ModelBuilderExtenstion
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            Products[] products = { };
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 1,
                Name = "Carrot Cake",
                Describtion = "Carrot Cake Any Description",
                ImageName = "carrot_cake.jpg",
                Price = 5

            },
            new Products
            {
                Id = 2,
                Name = "Bread",
                Describtion = "Bread Any Description",
                ImageName = "bread.jpg",
                Price = 10

            },
            new Products
            {
                Id = 3,
                Name = "Chocolate Cake",
                Describtion = "Chocolate Cake Any Description",
                ImageName = "chocolate_cake.jpg",
                Price = 15

            },
            new Products
            {
                 Id = 4,
                 Name = "Cup Cake",
                 Describtion = "Cup Cake Any Description",
                 ImageName = "cup_cake.jpg",
                Price = 20

            },
            new Products
             {
                  Id = 5,
                  Name = "Lemon Tart",
                  Describtion = "Lemon Tart Any Description",
                  ImageName = "lemon_tart.jpg",
                  Price = 25

            },
            new Products
            {
                   Id = 6,
                   Name = "Pear Tart",
                   Describtion = "Pear Tart Any Description",
                   ImageName = "pear_tart.jpg",
                   Price = 30

            }
            );
            return modelBuilder;
        }
    }
}
