using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class AppDbContext:DbContext
    {
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //   modelBuilder.Entity<Product>()
        //        .Property(p => p.Amount)
        //        .
        //}
        public AppDbContext():base("TrDbContext")
        {

        }
        public IDbSet<Product> products { get; set; }
        public IDbSet<Category> Categories { get; set; }
    }
}
