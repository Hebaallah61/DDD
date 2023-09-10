using DDD.Review.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainEventHandlers
{
    public class SubmitReview: IRequest<Review>
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Review { get; set;}


    }

    public class SubmitReviewHandler : IRequestHandler<SubmitReview, Review>
    {
        private readonly IPublisher _publisher;
        //private readonly IReview _reviewReop;
        //private readonly IUnitOfWork _unitOfWork;

        //public SubmitReviewHandler(IPublisher publisher, IReviewReop reviewReop, IUnitOfWork unitOfWork)
        //{
        //    _publisher = publisher;
        //    _reviewReop = reviewReop;
        //    _unitOfWork = unitOfWork;
        //}

        public async Task<Review> Handle(SubmitReview request, CancellationToken cancellationToken)
        {
            var review = new Review(0,request.UserId, request.ProductId,request.Review);
           // await _reviewReop.CreateReview(review);
            await _publisher.Publish(review.Events.First(),cancellationToken);
           //  await _unitOfWork.CommitChangesAsync();
            return review;
        }
    }
}
