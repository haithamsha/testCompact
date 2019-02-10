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
        public AppDbContext():base("TrDbContext")
        {

        }
        public IDbSet<Product> products { get; set; }
        public IDbSet<Category> Categories { get; set; }
    }
}
