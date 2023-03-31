namespace Who_Wants_to_Be_A_Millionaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who Wants to Be A Millionaire");

            Console.WriteLine("Who Wants to Be A Millionaire\n");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("\n1.Enter the phone wildcard: ");
            string phoneWildcard1 = Console.ReadLine();
            Console.Write("2.Enter the phone wildcard: ");
            string phoneWildcard2 = Console.ReadLine();
            Console.Write("3.Enter the phone wildcard: ");
            string phoneWildcard3 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Welcome " + name + " " + lastName);

            Console.Write("Do you know the rules?: ");
            char ruleAnswer = char.Parse(Console.ReadLine().ToUpper());

            if (ruleAnswer != 'Y')
            {
                // TODO: Add rules.
                Console.WriteLine("Rules: ...");
            }

            Console.Write("Are you ready?: ");
            char readyAnswer = char.Parse(Console.ReadLine().ToUpper());

            if (readyAnswer != 'Y')
            {
                Console.WriteLine("You are expected to be ready.");
                Console.WriteLine("When ready press 'enter'");
                Console.ReadLine();
            }

            bool audienceRight = true, percentRight = true, phoneRight = true;
            int safe = 0;

            int questionNo = 1, prize, dam;
            int audiencePercentageA, audiencePercentageB, audiencePercentageC, audiencePercentageD;
            bool hideA, hideB, hideC, hideD;
            string question, a, b, c, d;
            char answer;

            #region Question Information
            questionNo = 1;
            question = "Where is the capital of Turkey?";
            a = "Ankara";
            b = "Bursa";
            c = "Van";
            d = "Denizli";
            answer = 'A';
            prize = 1000;
            dam = 0;// TODO: Relationship between questionNo and dam.

            // TODO: There should be random values associated with QuestionNo.
            audiencePercentageA = 80; audiencePercentageB = 10;
            audiencePercentageC = 5; audiencePercentageD = 5;

            // TODO: Daha iyi olabirlir mi? Her seferinde bunu tekrarlamaya gerek yok gibi.
            hideA = false; hideB = false;
            hideC = false; hideD = false;
            #endregion
        }
    }
}