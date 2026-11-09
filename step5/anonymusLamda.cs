using System;

namespace AnonymousToLambda
{
    // Define a delegate for restaurant tasks
    delegate void RestaurantTask(string taskDetail);
    class Program
    {
        static void Main(string[] args)
        {
            // Anonymous method for taking orders
            //RestaurantTask takeOrder = delegate (string orderName)
            //{
            //    Console.WriteLine("Waiter: Taking order for " + orderName);
            //};

            RestaurantTask takeOrder = (string orderName) =>       // => Lambda expression for taking orders
            {
                Console.WriteLine("Waiter: Taking order for " + orderName);
            };



            // Anonymous method for preparing food
            //RestaurantTask prepareFood = delegate (string orderName)
            //{
            //    Console.WriteLine("Kitchen: Preparing " + orderName);
            //};

            RestaurantTask prepareFood = (string orderName) =>    // => Lambda expression for preparing food
            {
                Console.WriteLine("Kitchen: Preparing " + orderName);
            };

            // Anonymous method for serving food
            //RestaurantTask serveFood = delegate (string orderName)
            //{
            //    Console.WriteLine("Waiter: Serving " + orderName);
            //};

            RestaurantTask serveFood = (string orderName) =>  // => Lambda expression for serving food
            {
                Console.WriteLine("Waiter: Serving " + orderName);
            };

            // Example order
            string order = "Pasta";

            // Perform restaurant tasks
            takeOrder(order);
            prepareFood(order);
            serveFood(order);

            Console.ReadLine();
        }
    }
}
