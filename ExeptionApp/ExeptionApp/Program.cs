using System;

namespace ExeptionApp
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
    internal class Program
    {
        private static void Testthrow()
        {
            throw new CustomException("custom exception is testthrow()");
        }
        static void Main(string[] args)
        {
            try
            {
                Testthrow();
            }
            catch 
            (CustomException ex)
            {
                Console.WriteLine($"caught it : the message is {ex.Message}");
                Console.WriteLine()
            }
        }
    }
}
