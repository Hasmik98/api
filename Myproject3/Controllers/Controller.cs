using Myproject3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Myproject3.Controllers
{
    public class Controller : ApiController
    {
        [BasicAuthentication]
        MyContext db = new MyContext();
        public IEnumerable<Products> Get()
        {
            return db.Product;
        }
        // GET api/<controller>/5
        public Products Get(int id)
        {
            Products prod = db.Product.Find(id);
            return prod;
        }
        // DELETE api/<controller>/5
        public void DeleteProd(int id)
        {
            Products prod = db.Product.Find(id);
            if (prod != null)
            {
                db.Product.Remove(prod);
                db.SaveChanges();
            }
        }

        public IEnumerable<Orders> GetOrder()
        {
            return db.Order;
        }
        public Orders GetOrder(int id)
        {
            Orders ord = db.Order.Find(id);
            return ord;
        }
        public void DeleteOrder(int id)
        {
            Orders ord = db.Order.Find(id);
            if (ord != null)
            {
                db.Order.Remove(ord);
                db.SaveChanges();
            }
        }
        public IEnumerable<Branch> GetBranch()
        {
            return db.Branch;
        }
        public Branch GetBranch(int id)
        {
            Branch res = db.Branch.Find(id);
            return res;
        }
        public void DeleteBranch(int id)
        {
            Branch br = db.Branch.Find(id);
            if (br != null)
            {
                db.Branch.Remove(br);
                db.SaveChanges();
            }
        }
        public IEnumerable<Recipe> GetRecipe()
        {
            return db.Restaurant;
        }
        public Recipe Getec(int id)
        {
            Recipe res = db.Restaurant.Find(id);
            return res;
        }
        public void DeleteRec(int id)
        {
            Recipe r = db.Restaurant.Find(id);
            if (r != null)
            {
                db.Restaurant.Remove(r);
                db.SaveChanges();
            }
        }
    }
}