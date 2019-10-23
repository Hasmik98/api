using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Myproject3.Data
{
    public class Products
    {
        [Key]
        public int Prod_Id { get; set; }
        public string Prod_Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}