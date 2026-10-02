using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_EF.Models
{
    internal class OrderDetail
    {
        //The 2 foreign keys (composite primary key) u will find the composite kwy code on DbContexts
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        //extra column
        public int Quantity { get; set; }

        //mapping 1 to many relations between OrderDetail and Order + OrderDetail and Product
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
