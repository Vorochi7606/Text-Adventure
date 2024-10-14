namespace Text_Adventure
{
    internal class Program
    {
        enum Items
        {
            None,
            Excalibur,
            BlackKnightArm,
            SplitCoconut,
            HolyHandGrenade
        }
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
            public string[] inventory;
        }
        static string answer;

        static Stats stats;
        static GeneralInfo info;
        static Items playerItem;

        static void WriteLetterByLetter(string text, int delay = 15)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            info.inventory = new string[] { "Excalibur", "Split Coconut", "", "" };
            PlayerName();
            //StatsSetup();
        }

        static string PromptPlayer() // Asks player question, returns input to original location
        {
            string input;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            input = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            return input;
        }

        static int RollNumber(int min, int max) //rolls random number, returns number after rollCount rolls
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int diceRoll;
            diceRoll = 0;

            for (int i = 0; i < 20; ++i)
            {
                Random rng = new Random();
                diceRoll = rng.Next(min, max);

                Console.Write("> " + diceRoll + "\r");
                Thread.Sleep(50);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            return diceRoll;

        }
        static void PlayerName() // Asks player name, and saves the answer
        {
            WriteLetterByLetter("What is your name?");
            Thread.Sleep(1000);

            info.name = PromptPlayer();
            WriteLetterByLetter("Your name is " + info.name + "?");
            WriteLetterByLetter("YES | NO");
            answer = PromptPlayer();

            if (answer == "YES") // Continue scene or ask again
            {
                WriteLetterByLetter("Welcome, " + info.name + ".");

                PlayerColor();
            }
            else
            {
                PlayerName();
            }
        }

        static void PlayerColor() // Asks player favorite color, and saves the answer
        {
            WriteLetterByLetter("What is your favorite color?");
            Thread.Sleep(1000);
            info.favoriteColor = PromptPlayer();
            WriteLetterByLetter("Your favorite color is " + info.favoriteColor + "?");
            WriteLetterByLetter("YES | NO");
            answer = PromptPlayer();

            if (answer == "YES") // Continue scene or ask again
            {
                WriteLetterByLetter(info.favoriteColor + " is a good color.");

                PlayerQuest();
            }
            else
            {
                PlayerColor();
            }
        }
        static void PlayerQuest() // Asks object player seeks, and saves the answer
        {
            WriteLetterByLetter("What is your quest? (An object)");
            Thread.Sleep(1000);
            info.yourQuest = PromptPlayer();
            WriteLetterByLetter("Your are seeking the mythical " + info.yourQuest + "?");
            WriteLetterByLetter("YES | NO");
            answer = PromptPlayer();

            if (answer == "YES") // Continue scene or ask again
            {
                WriteLetterByLetter("Then the " + info.yourQuest + " you shall seek.");

                StatsSetup();
            }
            else
            {
                PlayerQuest();
            }
        }
        static void StatsSetup()
        {
            Console.WriteLine();
            WriteLetterByLetter("Roll for your strength:");
            Console.ReadKey(true);
            stats.strength = RollNumber(1, 7);
            WriteLetterByLetter("You rolled a " + stats.strength + ".");
            Thread.Sleep(1000);

            Console.WriteLine();
            WriteLetterByLetter("Roll for your defense:");
            Console.ReadKey(true);
            stats.defense = RollNumber(1, 7);
            WriteLetterByLetter("You rolled a " + stats.defense + ".");
            Thread.Sleep(1000);

            Console.WriteLine();
            WriteLetterByLetter("Roll for your wisdom:");
            Console.ReadKey(true);
            stats.wisdom = RollNumber(1, 7);
            WriteLetterByLetter("You rolled a " + stats.wisdom + ".");
            Thread.Sleep(1000);

            Console.WriteLine();
            WriteLetterByLetter("Roll for your charisma:");
            Console.ReadKey(true);
            stats.charisma = RollNumber(1, 7);
            WriteLetterByLetter("You rolled a " + stats.charisma + ".");
            Thread.Sleep(1000);
        }
        static void OpeningScene()
        {
            WriteLetterByLetter("Opening Scene");
        }
    }
}
