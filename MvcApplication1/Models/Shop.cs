using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class ItemShop
    {
        public int Id = 0;
        [Required(ErrorMessage = "Введите название магазина")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите адрес магазина")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Введите время работы магазина")]
       // [RegularExpression("[0-2][0-9].[0-5][0-9]+\\-+[0-2][0-9].[0-5][0-9]", ErrorMessage = "Вы ввели неправильно время работы, пример: 9.10-24.00")]
        public string Mode { get; set; }
        public ItemShop(Shop sh) { Id = sh.Id; Name = sh.Name; Address = sh.Address; Mode = sh.Mode; }
    }
}