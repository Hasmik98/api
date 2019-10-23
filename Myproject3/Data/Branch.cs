using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Myproject3.Data
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Stars { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
    }
}