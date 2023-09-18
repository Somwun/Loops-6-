namespace Loops___6_
{
    internal class Program
    {
        class Global
        {
            public static string userInput;
        }
        static void Main(string[] args)
        {
            Scores();
        }
        static void Prompt()
        {
            string gabe = "Gabe's Head";
            Console.WriteLine(gabe);
        }
        static void Scores()
        {
            bool isNumber;
            Console.WriteLine("Give me some scores out of 100, and I'll tell you what percent of them are above 70\nAlso you don't have to type out #/100, I'll just asumme the /100");
            Console.WriteLine("So first off, how many scores do you have to give me?");
            Global.userInput = Console.ReadLine();
            if (isNumber  = Global.userInput.All(char.IsDigit))
            {
                UseParams();
            }
            else
            {

            }
        }
        static void UseParams(params object[] list)
        {
            for (Convert.ToInt32(Global.userInput); Convert.ToInt32(Global.userInput) < list.Length; Global.userInput += 1)
            {
                Console.WriteLine(list[Convert.ToInt32(Global.userInput)]);

            }
            Console.ReadLine();
        }
        static void OddSum()
        {
            int num = 0, numInput;
            Console.WriteLine("Giv numbur");
            numInput = Convert.ToInt32(Console.ReadLine());
            if (numInput >= 0)
            {
                for (int i = 1; i < numInput + 1; i+=2)
                {
                    num += i;
                }
            }
            else
            {
                for (int i = -1; i > numInput - 1; i -= 2)
                {
                    num += i;
                }
            }
            Console.WriteLine(num + "\nPress enter to continue");
            Console.ReadLine();
        }
        static void RandomNumbers()
        {
            int min, max;
            bool repeat = true;
            Random genorator = new Random();
            while (repeat)
            {
                Console.WriteLine("Give me a minimum number");
                if (int.TryParse(Console.ReadLine(), out min))
                {
                    Console.WriteLine("Now give me a maximum");
                    if (int.TryParse(Console.ReadLine(), out max))
                    {
                        for ( int i = 0; i < 25; i++)
                        {
                            Console.WriteLine(genorator.Next(min, max));
                        }
                        Console.WriteLine("Press Enter to continue");
                        repeat = false;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input\nPress enter to retry");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input\nPress enter to retry");
                    Console.ReadLine();
                }
            }
        }
        static void DiceGame()
        {
            bool isNumber;
            string bet = "0", userInput = "help";
            int result = 0, value1, value2;
            Die die1 = new Die(), die2 = new Die();
            double money = 100;
            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                if (!(isNumber = bet.All(char.IsDigit)) || userInput != "help" & userInput != "double" & userInput != "doubles" & userInput != "single" & userInput != "singles" & userInput != "even" & userInput != "evens" & userInput != "odd" & userInput != "odds" & userInput != "exit")
                {
                    Console.WriteLine("Invalid Input");
                    bet = "0";
                }
                if (money <= 0)
                {
                    Console.WriteLine("Oops, you have no money, get out");
                    repeat = false;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Welcome to the definately not shady casino in the alley");
                    Console.WriteLine("Rules of the game are simple.\nI roll two dice and you bet on the outcome, whether you think they'll be doubles, singles, even, or odd");
                    Console.WriteLine("If you need help, just type Help\nAnd if you'd like to leave, just type Exit");
                    userInput = Console.ReadLine().ToLower().Trim();
                }
                if (userInput == "help")
                {
                    Console.Clear();
                    Console.WriteLine("Here's the gist, I'll roll two dice, and there are 4 options for you to pick as to what you think they'll be\n1. Doubles\n  Pick this if you think both of the dice will be the same number\n  If you win this I'll give you back double your bet\n\n2. Singles\n  Pick this if you think both of the dice will be different numbers\n  If you win this I'll give you back half of your bet\n\n3. Even\n  Pick this if you think their sum will be even\n  If you win this I'll give you back your bet\n\n4. Odd\n  Pick this if you think their sum will be odd\n  If you win this I'll give you back your bet\n\nIn order to choose simply type your choice\nSo what do you want to bet on? (Type Exit if you'd like to leave)");
                    userInput = Console.ReadLine().ToLower();
                }
                else if (userInput == "exit")
                    repeat = false;
                else if (userInput != "help" & userInput != "exit" & money > 0)
                {
                    Console.Clear();
                    Console.WriteLine($"How much do you want to bet on that?\nBy the way you have {money.ToString("C")} Left");
                    bet = Console.ReadLine().Trim();
                    if (Convert.ToDouble(bet) > money)
                        bet = Convert.ToString(money);
                    else if (Convert.ToDouble(bet) < 0)
                        bet = "0";
                    if (userInput == "double" || userInput == "doubles")
                    {
                        Console.Clear();
                        if (isNumber = bet.All(char.IsDigit))
                        {
                            Console.Clear();
                            die1.RollDie();
                            die2.RollDie();
                            if (die1.CurrentRoll == die2.CurrentRoll)
                            {
                                money += Convert.ToDouble(bet);
                                Console.WriteLine($"Congrats you won, you now have {money.ToString("C")}\nPress enter to continue");
                                Console.ReadLine();
                            }
                            else
                            {
                                money -= Convert.ToDouble(bet);
                                Console.WriteLine($"Well we can't all be winners, you know have {money.ToString("C")} left\nPress enter to continue");
                                Console.ReadLine();
                            }
                        }
                        else
                            Console.Clear();
                    }
                    else if (userInput == "single" || userInput == "singles")
                    {
                        Console.Clear();
                        if (isNumber = bet.All(char.IsDigit))
                        {
                            Console.Clear();
                            die1.RollDie();
                            die2.RollDie();
                            if (die1.CurrentRoll != die2.CurrentRoll)
                            {
                                money += Convert.ToDouble(bet);
                                Console.WriteLine($"Congrats you won, you now have {money.ToString("C")}\nPress enter to continue");
                                Console.ReadLine();
                            }
                            else
                            {
                                money -= Convert.ToDouble(bet);
                                Console.WriteLine($"Well we can't all be winners, you know have {money.ToString("C")} left\nPress enter to continue");
                                Console.ReadLine();
                            }
                        }
                    }
                    else if (userInput == "odd" || userInput == "odds")
                    {
                        Console.Clear();
                        if (isNumber = bet.All(char.IsDigit))
                        {
                            Console.Clear();
                            die1.RollDie();
                            die2.RollDie();
                            if ((die1.CurrentRoll + die2.CurrentRoll / 2) % 1 == 0)
                            {
                                money += Convert.ToDouble(bet);
                                Console.WriteLine($"Congrats you won, you now have {money.ToString("C")}\nPress enter to continue");
                                Console.ReadLine();
                            }
                            else
                            {
                                money -= Convert.ToDouble(bet);
                                Console.WriteLine($"Well we can't all be winners, you know have {money.ToString("C")} left\nPress enter to continue");
                                Console.ReadLine();
                            }
                        }
                    }
                    else if (userInput == "even" || userInput == "evens")
                    {
                        Console.Clear();
                        if (isNumber = bet.All(char.IsDigit))
                        {
                            Console.Clear();
                            die1.RollDie();
                            die2.RollDie();
                            if ((die1.CurrentRoll + die2.CurrentRoll / 2) % 1 != 0)
                            {
                                money += Convert.ToDouble(bet);
                                Console.WriteLine($"Congrats you won, you now have {money.ToString("C")}\nPress enter to continue");
                                Console.ReadLine();
                            }
                            else
                            {
                                money -= Convert.ToDouble(bet);
                                Console.WriteLine($"Well we can't all be winners, you know have {money.ToString("C")} left\nPress enter to continue");
                                Console.ReadLine();
                            }
                        }
                    }
                }
            }
        }
    }
}