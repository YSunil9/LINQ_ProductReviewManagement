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
            Console.WriteLine("Display The FeedBack of The Product\n");
            //Print products
            foreach (var feedback in reviewList)
            {
                Console.WriteLine($"ProductID: {feedback.ProductId},UserId: {feedback.UserId}Rating: {feedback.Rating},Review: {feedback.Review}");
            }
        }
    }
}
