using SharedKernal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Review.Domain
{
    public class Review: AggregateRoot<int>
    {
        public Review(int id, int userId, int productId, string reviewBody) : base(id)
        {
            Id = id;
            UserId = userId;
            ReviewBody = reviewBody;
            ProductId = productId;
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ReviewBody { get; set; }

        //public Review(int id, int userId, int productId, string reviewBody)
        //{
        //    Id = id;
        //    UserId = userId;
        //    ReviewBody = reviewBody;
        //    ProductId = productId;
        //}
    }
}
