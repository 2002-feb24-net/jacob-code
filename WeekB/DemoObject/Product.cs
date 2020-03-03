using System;
namespace DemoObject
{
    class Product
    {
        string ProductId;
        int Stock;
        double StarRating;
        
        public void SetDefaultValues()
        {
            ProductId = "1";
            Stock = 0;
            StarRating = 5;
        }
        public override string ToString()
        {
            return "product " + ProductId + ", " + Stock + " in stock, " + StarRating + " star rating";
        }
        public void SetValues(string id, int quantity, double rating)
        {
            //business logic like "no product can have more than 50 quanitty"
            //belongs in the classes that represent those entities.
            if(quantity > 50)
            {
                Console.WriteLine("Error: too much quantity ");
            }
            else if(quantity < 50)
            {
                Console.WriteLine("Error: can't have negative quantity ");
            }
            ProductId = id;
            Stock = quantity;
            StarRating = rating;
        }
    }
}