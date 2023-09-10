using SharedKernal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Review.Domain
{
    public class Product: AggregateRoot<int>
    {
        public Product(int id) : base(id)
        {
            Id = id;
        }
        public int Id{ get; set; }
        private List<Review> Reviews  = new();
        public IEnumerable<Review> reviews=> Reviews;
        public double ReviewAvarage { get; set; }
    }
}
