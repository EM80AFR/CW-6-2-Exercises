namespace CW_6_2_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            PrintMassage(inputString);

        }
        public static void PrintMassage(string? inputStr)
        {
            if (string.IsNullOrEmpty(inputStr) || inputStr.Length < 5)
            {
                Console.WriteLine("Invalid string provided");
                return;
            }

            Console.WriteLine($"*{inputStr}*");
        }
    }
   
}


