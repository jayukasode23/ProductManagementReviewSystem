using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management problem statement");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="bas",isLike=true},
                new ProductReview(){ProductID=8,UserID=1,Rating=10,Review="Good",isLike=false},
                new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=11,UserID=1,Rating=3,Review="nice",isLike=true}

            };
            Console.WriteLine("1.Check The Record In The List");
            Console.WriteLine("2.Retrive Top Three Record");
            Console.WriteLine("3.Retrive The records For Product Id 1,4 and 9 And Check The Rating Is greater than 3");
            Console.WriteLine("4.Retrive Count Of Review For Each Product ID");
            int CHECK = Convert.ToInt32(Console.ReadLine());
            switch (CHECK)
            {

                case 1:
                    foreach (var list in productReviewList)
                    {
                        Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                            + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                    }
                    break;
                case 2:
                    Management management = new Management();
                    management.TopRecords(productReviewList);
                    break;

                case 3:
                    Management management1 = new Management();
                    management1.SelectedRecords(productReviewList);
                    break;
                case 4:
                    Management management2 = new Management();
                    management2.RetrieveCountOfRecords(productReviewList);
                    break;
            }
        }
    }
}