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

        #region Question Form
        questionPoint:
            Console.Clear();
            Console.WriteLine(questionNo + "-)" + question);
            Console.WriteLine("A) " + (!hideA ? a : ""));
            Console.WriteLine("B) " + (!hideB ? b : ""));
            Console.WriteLine("C) " + (!hideC ? c : ""));
            Console.WriteLine("D) " + (!hideD ? d : ""));

        answerPoint:
            bool wildcardRight = audienceRight || percentRight || phoneRight;

            Console.Write("Enter your answer or");
            if (wildcardRight) Console.Write(" press 'enter' for wildcard,");
            Console.Write(" press 'L' for leave: ");
            char election = char.Parse(Console.ReadLine().ToUpper());

            if (election == 'J')
            {
                if (!wildcardRight)
                {
                    Console.WriteLine("Your wildcard rights are over..");
                    goto answerPoint;
                }

                Console.WriteLine("1-) " + (audienceRight ? "Audience" : ""));
                Console.WriteLine("2-) " + (percentRight ? "%50" : ""));
                Console.WriteLine("3-) " + (phoneRight ? "Phone" : ""));
                Console.Write("Make your choice: ");
                int wildcardAnswer = int.Parse(Console.ReadLine());

                if (wildcardAnswer == 1 && audienceRight)
                {
                    Console.WriteLine("A) %" + audiencePercentageA);
                    Console.WriteLine("B) %" + audiencePercentageB);
                    Console.WriteLine("C) %" + audiencePercentageC);
                    Console.WriteLine("D) %" + audiencePercentageD);
                    audienceRight = false;
                }
                else if (wildcardAnswer == 2 && percentRight)
                {
                    // TODO: This section should be used independently of the question.
                    hideB = true;
                    hideC = true;

                    percentRight = false;
                    goto questionPoint;
                }
                else if (wildcardAnswer == 3 && phoneRight)
                {
                    Console.WriteLine("1-) " + phoneWildcard1);
                    Console.WriteLine("2-) " + phoneWildcard2);
                    Console.WriteLine("3-) " + phoneWildcard3);
                    Console.Write("Who do you want to call? : ");
                    int phoneAnswer = int.Parse(Console.ReadLine());

                    if (questionNo <= 7 || phoneAnswer == 3) Console.WriteLine("Absolutely " + answer);
                    else if (phoneAnswer == 1)// TODO: The choices will be random. 1 right and 1 wrong answer.
                        Console.WriteLine("A or B");
                    else if (phoneAnswer == 2)
                        Console.WriteLine("I don't know. I am sorry.");
                    phoneRight = false;
                }
                else
                    Console.WriteLine("This wildcard has been used before.");

                goto answerPoint;
            }
            else if (election == 'R')
            {
                Console.WriteLine("You'll earn" + safe + "dollars.");
                Console.Write("Are you sure he wants to leave? : ");
                char leaveAnswer = char.Parse(Console.ReadLine());

                if (leaveAnswer == 'Y')
                {
                    Console.WriteLine("Congratulations, " +"You've won" + safe + "dollars");
                    Console.WriteLine("Finish game");
                    //return;
                    Environment.Exit(0);
                }
                goto questionPoint;
            }
            else if (election != answer)
            {
                Console.WriteLine("Eliminated, Amount Won: " + dam + " $");
                Console.WriteLine("Finish game");
                //return;
                Environment.Exit(0);
            }

            safe = prize;
            Console.WriteLine("Congratulations, " + "You've won" + safe + "dollars");
            Console.WriteLine("\nPress 'enter' to move to the next question.");
            Console.ReadLine();
            #endregion
        }
    }
}