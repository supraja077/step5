using System;

namespace RestaurantAnonmousExample2
{
    /*What is Func Delegate?
     * The Func delegate is a built-in, generic delegate in C# that can take up to 16 input parameters and always returns a value. 
     * It’s commonly used for  doing the calculations, conversions, or data processing.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {

            // Replaced anonymous method with Func delegate and lambda expression
            Func<string, string> takeOrder = (string orderName) =>
            {
                return $"Kitchen: Preparing {orderName}";
            };
            Console.WriteLine(takeOrder("Pasta"));

            Func<int, decimal, decimal> calculateFine = (int daysLate, decimal finePerDay) => {
                return Convert.ToDecimal(daysLate * finePerDay);
            };

            // Func delegate with one input parameter and string return type
            Func<int, string> GetEmployeeName = (int empId) =>
            {
                return $"Employee Name: John (ID: {empId})";
            };
            Console.WriteLine(GetEmployeeName(1));

            // Func delegate with two input parameters and integer output
            Func<int, int, int> Add = (int a, int b) =>
            {
                return a + b;
            };
            Console.WriteLine($"Sum: {Add(1, 2)}");

            // Func delegate with two input parameters and decimal output
            Func<int, string, decimal> GetPrice = (int productId, string productName) =>
            {
                return 100.00m;
            };
            Console.WriteLine($"Price of product (Laptop): {GetPrice(1, "Laptop")}");

            // Func delegate with no input parameters and string output
            Func<string> getRestaurantName = () =>
            {
                return "Pizza Hut";
            };
            Console.WriteLine($"Restaurant Name: {getRestaurantName()}");
        }
    }
}