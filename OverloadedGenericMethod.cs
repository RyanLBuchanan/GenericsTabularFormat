namespace GenericsTabularFormat
{
    internal class OverloadeGenericMethod
    {
        static void Main(string[] args)
        {
            // Create arrays of int, double and char
            string[] stringArray = { "one", "two", "three", "four", "five", "six", "seven", "eight" };

            Console.WriteLine("Array stringArray contains:");
            DisplayArray(stringArray, 8);
        }

        // Output array of all types
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        private static void DisplayArray(string[] inputArray, int n)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{inputArray[i].PadRight(n)} ");
            }
            Console.WriteLine();

            for (int i = 4; i < 8; i++)
            {
                Console.Write($"{inputArray[i].PadRight(n)} ");
            }

            Console.WriteLine();
        }
    }
}