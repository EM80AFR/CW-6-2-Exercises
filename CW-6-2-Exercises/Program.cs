namespace CW_6_2_Exercises
{
    internal class Program
    {
        /// <summary>
        /// The main entry of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            PrintMassage(inputString);

        }
        public static void PrintMassage(string? inputStr)
        {
            if (string.IsNullOrEmpty(inputStr))
                return;

            Console.WriteLine($"{inputStr}");
        }
    }
   
}


