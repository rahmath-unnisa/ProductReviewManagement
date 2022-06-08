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
            reviewList.Add(new ProductReview() { ProductId = 1, UserId = 3, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 12, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 2, Rating = 1, Review = "Poor", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 5, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 9, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 23, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 10, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 4, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 6, Rating = 1, Review = "Poor", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 7, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 11, Rating = 2, Review = "NotGood", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 20, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 14, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 8, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 12, Rating = 1, Review = "Poor", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 22, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 15, Rating = 2, Review = "NotGood", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 17, Rating = 4, Review = "NotBad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 23, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 16, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 19, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 25, Rating = 2, Review = "NotGood", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 24, Rating = 1, Review = "Poor", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 13, UserId = 18, Rating = 5, Review = "Good", IsLike = true });
            foreach (var item in reviewList)
            {
                Console.WriteLine(item.ProductId + "\t" + item.UserId + "\t" + item.Rating + "\t" + item.Review + "\t" + item.IsLike);
                Console.WriteLine(" ");
            }
        }
    }
}
