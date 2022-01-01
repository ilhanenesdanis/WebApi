using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiUdemy.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Perice { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string ImagePath { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
