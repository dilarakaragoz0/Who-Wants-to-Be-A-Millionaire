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
        }
    }
}