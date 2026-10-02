using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_EF.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //1 to many with product
        public List<Product> Products { get; set; }
    }
}
