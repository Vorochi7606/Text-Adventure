namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static string PromptPlayer()
        {
            string input;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            input = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            return input;
        }
    }
}
