using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Myproject3.Data
{
    public class Recipe
    {
        [Key, Column(Order = 1)]
        public int Order_Id { get; set; }
        [Key, Column(Order = 2)]
        public int Prod_Id { get; set; }
        public double Amount { get; set; }
        [ForeignKey("Order_ID")]
        public Orders Order { get; set; }

        [ForeignKey("Prod_ID")]
        public Products Product { get; set; }
    }
}