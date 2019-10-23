using Myproject3.Data;
using Myproject3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Myproject3.Managers
{
    public class BranchManager:Manager
    {
        public Branch Find(int id)
        {
            using (MyContext context = new MyContext())
            {
                Branch b = (Branch)Find(id);
                return b;
            }
        }
        public void Add(BranchModel model)
        {
            using (MyContext context = new MyContext())
            {
                var myrest = context.Branch.Add(new Branch
                {
                    Id=model.Id,
                    Name=model.Name,
                    Address=model.Address,
                    Starting=model.Starting,
                    Ending=model.Ending,
                });
                context.SaveChanges();
            }
        }
        public static void ChangeName(string NewName, int id)
        {
            using (MyContext context = new MyContext())
            {
                var result = context.Set<Branch>().SingleOrDefault(i => i.Id == id);
                if (result != null)
                {
                    result.Name = NewName;
                    context.SaveChanges();
                    var rest = context.Branch.ToList();
                    foreach (var r in rest)
                        Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", r.Id,r.Name,r.Stars,r.Starting,r.Ending);
                }
            }
        }
        public static void ChangeStar(int NewStar, int id)
        {
            using (MyContext context = new MyContext())
            {
                var result = context.Set<Branch>().SingleOrDefault(i => i.Id == id);
                if (result != null)
                {
                    result.Stars = NewStar;
                    context.SaveChanges();
                    var rest = context.Branch.ToList();
                    foreach (var r in rest)
                        Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", r.Id, r.Name, r.Stars, r.Starting, r.Ending);
                }
            }
        }
        public static void ChangeTime(DateTime NewStart,DateTime NewEnd, int id)
        {
            using (MyContext context = new MyContext())
            {
                var result = context.Set<Branch>().SingleOrDefault(i => i.Id == id);
                if (result != null)
                {
                    result.Starting = NewStart;
                    result.Ending = NewEnd;
                    context.SaveChanges();
                    var rest = context.Branch.ToList();
                    foreach (var r in rest)
                        Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}", r.Id, r.Name, r.Stars, r.Starting, r.Ending);
                }
            }
        }
    }
}