using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.SqlAcessors
{
    public class ShopAcessor
    {
        public static List<ItemShop> SelShops()
        {
            ShopClassesDataContext dc = new ShopClassesDataContext();
            return (from p in dc.GetTable<Shop>()
                    orderby p.Name
                    select new ItemShop(p))
                    .ToList<ItemShop>();
        }
        public static ItemShop SelShop(int Id)
        {
            ShopClassesDataContext dc = new ShopClassesDataContext();

            return (from c in dc.GetTable<Shop>()
                    where c.Id == Id

                    select new ItemShop(c)
                            ).SingleOrDefault<ItemShop>();
        }
    }
}