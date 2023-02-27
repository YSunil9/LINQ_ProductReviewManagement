using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ProductReviewManagement
{
    public class ManageReview
    {
        public void Display(List<ProductReviewModel> reviewList)
        {
            //Console.WriteLine("Display The FeedBack of The Product\n");
            //Print products
            foreach (var feedback in reviewList)
            {
                Console.WriteLine($"ProductID: {feedback.ProductId},UserId: {feedback.UserId}Rating: {feedback.Rating},Review: {feedback.Review}");
            }
        }
        public void PrintTopThreeRecords(List<ProductReviewModel> reviewList)
        {
            //top 3 recors whose ratings are high
            Console.WriteLine("Print top three records");
            var result = reviewList.OrderByDescending(x => x.Rating).Take(3).ToList();
            Display(result);
        }
        public void GetRecordsRatingsGreaterThanThree(List<ProductReviewModel> reviewList)
        {
            //fetch record whose rating greater than three and product id 1,4,9
            Console.WriteLine("Display record whose rating > 3 and product id are 1,4,9");
            var result = reviewList.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9)).ToList();
            Display(result);
        }
        public void GetCountOfProductId(List<ProductReviewModel> reviewList)
        {
            //Retrieve count of review present for each productID
            var result = reviewList.GroupBy(x => x.ProductId).ToList();
            foreach (var productReview in result)
            {
                Console.WriteLine($"ProductId = {productReview.Key}, count of product = {productReview.Count()}");
            }
        }
    }
}
