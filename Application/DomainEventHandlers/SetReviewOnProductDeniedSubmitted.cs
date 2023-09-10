//using DDD.Review.Domain.Events;
//using MediatR;
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Application.DomainEventHandlers
//{
//    public class SetReviewOnProductDeniedSubmitted:INotification<ReviewSubmittedEvent>
//    {
//        private readonly IProductRepo _productRepo;

//        public SetReviewOnProductDeniedSubmitted(IProductRepo productRepo)
//        {
//            _productRepo = productRepo;
//        }

//        public async Task Hndle(ReviewSubmittedEvent notification, CancellationToken cancellationToken)
//        {
//            await _productRepo.SetReviewDeniedAsync(notification.ProductId);
//        }

//    }
//}
