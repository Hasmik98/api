using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Myproject3.Data
{
    public class Orders
    {
        [Key]
        public int Order_Id { get; set; }
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public DateTime Order_Time { get; set; }
        [ForeignKey("ID")]
        public Branch Restorant { get; set; }

    }
}