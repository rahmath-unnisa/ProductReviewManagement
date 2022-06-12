using System;
using System.Collections.Generic;
using ProjectReviewManagement;

namespace ProductReviewManagement
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management \n");
            List<ProductReview> reviewList = new List<ProductReview>();
            reviewList.Add(new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 3, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 12, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 2, Rating = 1, Review = "Poor", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 5, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 9, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 23, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 10, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 4, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 6, Rating = 1, Review = "Poor", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 7, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 11, Rating = 2, Review = "NotGood", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 13, UserId = 20, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 14, UserId = 14, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 15, UserId = 8, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId =16, UserId = 12, Rating = 1, Review = "Poor", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId =17, UserId = 22, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 18, UserId = 15, Rating = 2, Review = "NotGood", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 19, UserId = 17, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 20, UserId = 23, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 21, UserId = 16, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 23, UserId = 19, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 24, UserId = 25, Rating = 2, Review = "NotGood", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 22, UserId = 24, Rating = 1, Review = "Poor", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 25, UserId = 18, Rating = 5, Review = "Good", IsLike = true });
            bool check = true;
            Operations operations = new Operations();
            Console.WriteLine("1.Display Product Review\n2.Get top 3 Records \n 3.Retrive Records with Rating>3 and Product Id=1,4,9 \n4.Retrive Records count \n5.Retrive ProductID and Review\n6.Skip Top 5 Records\n7.Create Data Table \n8. Retreiving Records");
            while (check)
            {
                Console.WriteLine("choose an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        operations.Display(reviewList);
                        break;
                    case 2:
                        operations.GetTop3Records(reviewList);
                        break;
                    case 3:
                        operations.RetriveRecordsWithRatingAndProductID(reviewList);
                        break;
                    case 4:
                        operations.RetriveRecordsCount(reviewList);
                        break;
                    case 5:
                        operations.RetriveProductIDAndReview(reviewList);
                        break;
                    case 6:
                        operations.SkipTop5Records(reviewList);
                        break;
                    case 7:
                        operations.CreateDataTable(reviewList);
                        break;
                    case 8:
                        operations.RetriveRecordsForIsTrue(reviewList);
                        break;
                }
            }
        }
    }
}
