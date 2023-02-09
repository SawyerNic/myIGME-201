namespace PE8
{
    class Program
    {
        public static void Main(string[] args)
        {
            //variables
            string input;
            string output = "";
            string[] arr;

            //get input
            input = Console.ReadLine();

            arr = input.Split(" ");

            foreach(string i in arr)
            {
                output = output + " \"" + i + "\"";
            }

            Console.WriteLine(output);

        }
    }
}