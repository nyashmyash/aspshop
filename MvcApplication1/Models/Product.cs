using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class ItemProduct
    {
        public int Id;
        [Required(ErrorMessage = "Введите имя продукта")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите описание продукта")]
        public string Note { get; set; }
        public ItemProduct() { }
        public ItemProduct(Product pr) { Id = pr.Id; Name = pr.Name; Note = pr.Note; }
   
    }
}