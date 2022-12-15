using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void TopRecords(List<ProductReview> review)
        {
            var recordData = (from productReview in review
                              orderby productReview.Rating descending
                              select productReview).Take(3);
        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordData = from productReviews in listProductReview
                             where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                             && productReviews.Rating > 3
                             select productReviews;



            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }
        }
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.GroupBy(y => y.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });


        }
    }
}
    