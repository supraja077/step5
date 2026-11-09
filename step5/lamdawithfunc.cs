using System;

namespace LambdasWithActionDelegate
{
    class Program
    {
        // Custom delegate that returns void (for learning purpose)
        delegate void OrderConfirmation(string orderDetail);

        static void Main(string[] args)
        {
            //1. Action also expects the 16 parameters do't have the any out paramter . Here we wo't expect the any return type 
            // Replaced anonymous method with lambda expression using Action delegate
            Action<string> confirmOrder = (string orderName) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed.");
            };
            confirmOrder("Pasta");

            Console.WriteLine("\n--- Using Action with Two Parameters ---");
            // Action with two input parameters
            Action<string, string> action = (string orderName, string orderDetail) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed. Details: {orderDetail}");
            };
            action("Pasta", "Extra Cheese");

            Console.WriteLine("\n--- Using Action with Three Parameters ---");
            // Action with three input parameters
            Action<string, string, int> action1 = (string orderName, string orderDetail, int quantity) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed. Details: {orderDetail} Quantity: {quantity}");
                Console.WriteLine($"Total Price: {quantity * 100}");
                Console.WriteLine("Order Confirmed");
            };
            action1("Pasta", "Extra Cheese", 2);

            Console.WriteLine("\n--- Using Action with No Parameters ---");
            Action action2 = () =>
            {
                Console.WriteLine("Order Confirmed");
                Console.WriteLine("Please Wait for the order");
            };
            action2();

            Console.ReadLine();
        }
    }
}