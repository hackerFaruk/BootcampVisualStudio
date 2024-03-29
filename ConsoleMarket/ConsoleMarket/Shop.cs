﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Shop
    {
        public string Name { get; private set; }

        private List<Seller> SellerList = new List<Seller>();

        // adds all sellers

        private List<Product> ShopFront = new List<Product>();

        public Shop(string name)
        {
            Name = name;
        }


        public Shop(string name, params Seller[] sellerList)
        {
            Name = name;
            AddSeller(sellerList);
        }



        public void AddSeller(params Seller[] sellerList)
        {
            foreach (Seller seller in sellerList)
            {
                if (!SellerList.Contains(seller)) // eğer listede eklki değilse
                {
                    SellerList.Add(seller);  // listeye satıcıyı ekle 
                    foreach (Product product in seller.ProductList) // satıcı ürünlerini listeye ekle 
                    {
                        ShopFront.Add(product);
                    }
                }
            }
        }




      
    }
}
