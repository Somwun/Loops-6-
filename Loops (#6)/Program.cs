﻿using System.Drawing;

namespace Loops___6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool repeat = true;
            while (repeat)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("MENU\nType 1 for Prompts\nType 2 for Scores\nType 3 for OddSum\nType 4 for Random Number\nType 5 for Dice Game\nOr type 0 to Quit");
                while (!Int32.TryParse(Console.ReadLine(), out num) || num < 0 || num > 5)
                {
                    Console.WriteLine("Woops, you're stupid. Please try again (And this time don't be stupid)");
                }
                switch (num)
                {
                    case 1:
                        Prompt();
                        break;
                    case 2:
                        Scores();
                        break;
                    case 3:
                        OddSum();
                        break;
                    case 4:
                        RandomNumbers();
                        break;
                    case 5:
                        DiceGame();
                        break;
                    case 0:
                        Console.WriteLine("Ok, you can go now");
                        repeat = false;
                        break;
                }
            }
        }
        static void Prompt()
        {
            bool repeat = true, isNumber;
            while (repeat)
            {
                string userInput;
                int min, max, userNum;
                Console.Clear();
                Console.WriteLine("Give me a minimum number\n(Or type exit to exit)");
                userInput = Console.ReadLine().ToLower().Trim();
                if (userInput == "exit")
                {
                    repeat = false;
                }
                else if (int.TryParse(userInput, out min))
                {
                    Console.Clear();
                    Console.WriteLine("Now give me a maximum");
                    while (!(int.TryParse(Console.ReadLine().Trim(), out max)) || max <= min)
                    {
                        Console.WriteLine("NO, again.");
                    }
                    Console.Clear();
                    Console.WriteLine($"Now choose a number that's inbetween {min} & {max}");
                    if (int.TryParse(Console.ReadLine(), out userNum))
                    {
                        bool correct = userNum >= min & userNum <= max;
                        while (!correct)
                        {
                            Console.WriteLine("NO, again");
                            correct = int.TryParse(Console.ReadLine(), out userNum);
                            if (correct)
                                correct = userNum >= min & userNum <= max;
                        }
                        Console.WriteLine("Good, now press enter to do it again (Or type exit to exit)");
                        if (Console.ReadLine().ToLower().Trim() == "exit")
                            repeat = false;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWRONG");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Make sure your input is a number\n(Or exit)");
                    userInput = Console.ReadLine();
                }
            }
        }
        static void Scores()
        {
            int userInput;
            bool repeat = true;
            Console.Clear();
            Console.WriteLine("Give me some scores out of 100, and I'll tell you what percent of them are above 70\nAlso you don't have to type out #/100, I'll just asumme the /100");
            Console.WriteLine("So first off, how many scores do you have to give me?\n(You can also type exit to exit)");
            int[] scores;
            while (repeat)
            {
                string temp;
                temp = Console.ReadLine().ToLower().Trim();
                while (!int.TryParse(temp, out userInput))
                {
                    if (temp == "exit")
                    {
                        repeat = false; break;
                    }
                    Console.WriteLine("No, again");
                    temp = Console.ReadLine().Trim().ToLower();
                }
                if (!repeat)
                    break;
                scores = new int[userInput];
                for (int i = 0; i < userInput; i++)
                {

                    if (i == 0)
                        Console.WriteLine("Please input the 1st score");
                    else if (i == 1)
                        Console.WriteLine("Please input the 2nd score");
                    else if (i == 2)
                        Console.WriteLine("Please input the 3rd score");
                    else
                        Console.WriteLine($"Please input the {i + 1}th score");
                    while (!Int32.TryParse(Console.ReadLine(), out scores[i]) || scores[i] < 0 || scores[i] > 100)
                    {
                        Console.WriteLine("Bad");
                    }
                }
                Console.Write("The scores above 70 are: ");
                double above70 = 0;
                for (int i = 0; i < userInput; i++)
                {
                    if (scores[i] >= 70)
                    {
                        Console.Write(scores[i] + " ");
                        above70 += 1;
                    }
                }
                above70 = Math.Round(above70 / userInput * 100, 1);
                Console.WriteLine($"\nThe amount of scores above 70% is {above70}%\nPress enter to continue or type exit to exit");
                if (Console.ReadLine().ToLower().Trim() == "exit")
                    repeat = false;
            }
        }
        static void OddSum()
        {
            int num = 0, numInput;
            string exit;
            bool repeat = true, isNumber;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Give me a number\n(Or type exit to exit)");
                exit = Console.ReadLine().ToLower().Trim();
                if (exit == "exit")
                {
                    repeat = false;
                    break;
                }
                while (!int.TryParse(exit, out numInput))
                {
                    Console.WriteLine("Make sure our input is a number");
                    exit = Console.ReadLine();
                }
                if (numInput >= 0)
                {
                    for (int i = 1; i < numInput + 1; i += 2)
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
                Console.WriteLine($"The sum of all of the odd numbers in that number is {num}\nPress enter to continue\n(Or type exit to exit)");
                if (Console.ReadLine().ToLower().Trim() == "exit")
                    repeat = false;
            }
        }
        static void RandomNumbers()
        {
            int min, max;
            string exit;
            bool repeat = true;
            Random genorator = new Random();
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Here's what's gonna happen, you're gonna give me a min and max number and I'll genorate 25 random numbers in between those values");
                Console.WriteLine("Now give me a minimum number\n(Or type exit to exit)");
                exit = Console.ReadLine().ToLower().Trim();
                if (exit == "exit")
                {
                    repeat = false;
                    break;
                }
                while (!int.TryParse(exit, out min))
                {
                    Console.WriteLine("Please make sure your minimum number is a number");
                    exit = Console.ReadLine();
                }
                Console.WriteLine("Now give me a maximum");
                while (!int.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("Please make sure your maximum number is a number");
                }
                for (int i = 0; i < 25; i++)
                {
                    Console.Write(genorator.Next(min, max) + " ");
                }
                Console.WriteLine("\nPress Enter to continue\n(Or type exit to exit)");
                if (Console.ReadLine().ToLower().Trim() == "exit")
                    repeat = false;
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
                    Console.WriteLine($"How much do you want to bet on that?\nBy the way you have {money.ToString("C")} left");
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
                                Console.WriteLine($"Well we can't all be winners, you now have {money.ToString("C")} left\nPress enter to continue");
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
                                Console.WriteLine($"Well we can't all be winners, you now have {money.ToString("C")} left\nPress enter to continue");
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
                                Console.WriteLine($"Well we can't all be winners, you now have {money.ToString("C")} left\nPress enter to continue");
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
                                Console.WriteLine($"Well we can't all be winners, you now have {money.ToString("C")} left\nPress enter to continue");
                                Console.ReadLine();
                            }
                        }
                    }
                }
            }
        }
    }
}