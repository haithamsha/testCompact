using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        // [Computed]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal Amount { get; set; }

        public Category Category { get; set; }
        public int CatId { get; set; }
    }
}
