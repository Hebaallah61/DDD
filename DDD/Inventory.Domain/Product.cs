using SharedKernal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Inventory.Domain
{
    public class Product: AggregateRoot<int>
    {
        public Product(int id) : base(id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Restock { get; set; }
        public string ProductCode { get; set; }
    }
}
