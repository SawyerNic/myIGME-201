namespace PE8Q8
{
    class Program
    {
        public static void Main(string[] args)
        {
            //varibles
            string input;
            string output = "";
            string[] arr;

            //prompt user
            Console.WriteLine("Enter a sentance");

            input = Console.ReadLine();

            //make same case
            input = input.ToLower();

            arr = input.Split(" ");

            foreach(string i in arr)
            {
                if (i == "no")
                {
                    output = output + "yes ";
                }
                else
                {
                    output = output + i + " ";
                }
            }

            Console.WriteLine(output);
        }
    }
}