namespace Text_Adventure
{
    internal class Program
    {
        internal struct Stats
        {
            public int strength;
            public int defense;
            public int wisdom;
            public int charisma;
        }

        internal struct GeneralInfo
        {
            public string name;
            public string favoriteColor;
            public string yourQuest;
        }
        static string answer;

        static Stats stats;
        static GeneralInfo info;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Thread.Sleep(1000);
            PlayerName();
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
        static void PlayerName()
        {
            Console.WriteLine("What is your name?");
            Thread.Sleep(1000);

            info.name = PromptPlayer();
            Console.WriteLine("Your name is " + info.name + "?");
            Console.WriteLine("YES | NO");
            answer = PromptPlayer();

            if (answer == "YES")
            {
                Console.WriteLine("Welcome, " + info.name + ".");

                PlayerColor();
            }
            else
            {
                PlayerName();
            }
        }

        static void PlayerColor()
        {
            Console.WriteLine("What is your favorite color?");
            Thread.Sleep(1000);
            info.favoriteColor = PromptPlayer();
            Console.WriteLine("Your favorite color is " + info.favoriteColor + "?");
            Console.WriteLine("YES | NO");
            answer = PromptPlayer();

            if (answer == "YES")
            {
                Console.WriteLine(info.favoriteColor + " is a good color.");

                PlayerQuest();
            }
            else
            {
                PlayerColor();
            }
        }
        static void PlayerQuest()
        {
            Console.WriteLine("What is your quest? (An object)");
            Thread.Sleep(1000);
            info.yourQuest = PromptPlayer();
            Console.WriteLine("Your are seeking the mythical " + info.yourQuest + "?");
            Console.WriteLine("YES | NO");
            answer = PromptPlayer();

            if (answer == "YES")
            {
                Console.WriteLine("Then the " + info.yourQuest + " you shall seek.");

                OpeningScene();
            }
            else
            {
                PlayerQuest();
            }
        }
        static void OpeningScene()
        {
            Console.WriteLine("Opening Scene");
        }
    }
}
