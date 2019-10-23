
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Myproject3.Data
{
    public class MyContext: DbContext
    {
        public DbSet<Orders> Order { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Recipe> Restaurant { get; set; }
        public MyContext() : base("MyContext") { }
    }
}