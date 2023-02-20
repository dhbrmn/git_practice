using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exquisite Corpse!");
            Console.WriteLine("Here you can build your own creature by selecting its body parts or have one generated randomly!");
            Console.WriteLine("Which one do you choose? Random or manual?");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "random":
                    RandomMode();
                    break;
                case "manual":
                    Console.WriteLine("The body parts you can select from are \"ghost\", \"bug\" and \"monster\".");
                    Console.WriteLine("What should the head of a creature look like?");
                    string head = Console.ReadLine().ToLower();
                    Console.WriteLine("What should the body of a creture look like?");
                    string body = Console.ReadLine().ToLower();
                    Console.WriteLine("And lastly, what should the creature feet look like?");
                    string feet = Console.ReadLine().ToLower();
                    Console.WriteLine("Here is your creature: ");
                    BuildACreature(head, body, feet);
                    break;
                default:
                    RandomMode();
                    break;
            }

        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
        static void BuildACreature(string head, string body, string feet)
        {
            int headNum;
            int bodyNum;
            int feetNum;

            if (head == "")
            {
                headNum = RandomHeadPart();
            }
            else
            {
                headNum = TranslateToNumber(head);
            }
            if (body == "")
            {
                bodyNum = RandomBodyPart();
            }
            else
            {
                bodyNum = TranslateToNumber(body);
            }
            if (feet == "")
            {
                feetNum = RandomFeetPart();
            }
            else
            {
                feetNum = TranslateToNumber(feet);
            }
            SwitchCase(headNum, bodyNum, feetNum);
        }
        static int RandomHeadPart()
        {
            Random randomNumber = new Random();
            int randOut = randomNumber.Next(1, 4);
            return randOut;
        }
        static int RandomBodyPart()
        {
            Random randomNumber = new Random();
            int randOut = randomNumber.Next(1, 4);
            return randOut;
        }
        static int RandomFeetPart()
        {
            Random randomNumber = new Random();
            int randOut = randomNumber.Next(1, 4);
            return randOut;
        }
        static void RandomMode()
        {
            Random randomNumber = new Random();
            int randHead = randomNumber.Next(1, 4);
            int randBody = randomNumber.Next(1, 4);
            int randFeet = randomNumber.Next(1, 4);
            SwitchCase(randHead, randBody, randFeet);
        }
        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
            }
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
            }
        }
        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }
        }
    }
}
