using SharedKernal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Pricing.Domain
{
    public class Product: AggregateRoot<int>
    {
        public Product(int id) : base(id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public decimal PriceWithVAT { get; set; }
        public int VATPercentage { get; set; }
        public decimal VATValue { get; set; }
        public decimal PriceIncludeVAT { get; set; }
    }
}
