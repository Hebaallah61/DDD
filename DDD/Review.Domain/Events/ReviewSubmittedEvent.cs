using SharedKernal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Review.Domain.Events
{
    public class ReviewSubmittedEvent:DomainEvent
    {
        public int ProductId { get; set; }
        public string Review { get; set; }
        public int UserId { get; set; }

        public ReviewSubmittedEvent(int productId, string review, int userId)
        {
            ProductId = productId;
            Review = review;
            UserId = userId;
        }
    }

   

}
