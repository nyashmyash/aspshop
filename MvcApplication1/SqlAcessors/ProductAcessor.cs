using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;


namespace MvcApplication1.SqlAcessors
{
    public class ProductAcessor
    {
        public static List<ItemProduct> SelProducts()
        {        
            ShopClassesDataContext dc = new ShopClassesDataContext();
            return (from p in dc.GetTable<Product>()
                    orderby p.Name
                    select new ItemProduct(p))
                    .ToList<ItemProduct>();
        }
        public static ItemProduct SelProduct(int Id)
        {
            ShopClassesDataContext dc = new ShopClassesDataContext();

            return (from p in dc.GetTable<Product>()
                        where p.Id == Id

                    select new ItemProduct(p)
                            ).SingleOrDefault<ItemProduct>();
        }
        public static List<ItemProduct> SelProducts(int Idshop)
        {
            ShopClassesDataContext dc = new ShopClassesDataContext();
            return (from p in dc.GetTable<Product>()
                    where p.Idshop == Idshop
                    orderby p.Name
                    select new ItemProduct(p))
                    .ToList<ItemProduct>();
        }
    }
}