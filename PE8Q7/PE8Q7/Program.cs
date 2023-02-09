namespace PE8Q7
{
    class Program
    {
        public static void Main(string[] args)
        {
            //variables
            string input;
            char[] arr;
            string output = "";

            //get user input
            Console.WriteLine("Enter a sentence");
            input = Console.ReadLine();

            arr = input.ToCharArray();

            Console.WriteLine(arr.Length);

            foreach(char i in arr)
            {
                output = i + output;
            }

            Console.WriteLine(output);
        }
    }
}
