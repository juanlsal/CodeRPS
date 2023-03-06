using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rock Paper Scissors: The Game \nCreated by: Juan Lopez Salamanca \n\n");
        Console.WriteLine("Player, please type your name.");
        string player1 = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("Welcome to RPS: The Game\n");
        int score1 = 0;
        int score2 = 0;
        while (score1 < 5 || score2 < 5)
        {
            Console.WriteLine("Lets play!\nremember...\nr = Rock\np = Paper\ns = Scissors\n\nSelect Attack Then Press Enter!\n");
            string attack = Console.ReadLine();
            Console.WriteLine("\n");
            switch (attack)
            {
                case "r":
                    Console.WriteLine("You have selected... ROCK");
                    break;
                case "p":
                    Console.WriteLine("You have selected... PAPER");
                    break;
                case "s":
                    Console.WriteLine("You have selected... SCISSORS");
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;
            }
            string enemyrock = "ROCK";
            string enemypaper = "PAPER";
            string enemysciccors = "SCISSORS";
            string[] selectableStrings = new string[3] { enemyrock, enemypaper, enemysciccors };
            Random rand = new Random();
            string Eattack = selectableStrings[rand.Next(0, selectableStrings.Length)];
            Console.WriteLine("your Opponent selected... " + Eattack);
            switch (attack)
            {
                case "r":
                    {
                        switch (Eattack)
                        {
                            case "ROCK":
                                {
                                    Console.WriteLine("There has been a draw. \n");
                                    Console.WriteLine("Scoreboard");
                                    Console.WriteLine(player1 + " : " + score1);
                                    Console.WriteLine("Computer: " + score2 + "\n");
                                    break;
                                }
                            case "PAPER":
                                {
                                    Console.WriteLine("You have LOST. \n");
                                    score2++;
                                    Console.WriteLine("Scoreboard");
                                    Console.WriteLine(player1 + " : " + score1);
                                    Console.WriteLine("Computer: " + score2 + "\n");
                                    break;
                                }
                            case "SCISSORS":
                                {
                                    Console.WriteLine("You have WON \n");
                                    score1++;
                                    Console.WriteLine("Scoreboard");
                                    Console.WriteLine(player1 + " : " + score1);
                                    Console.WriteLine("Computer: " + score2 + "\n");
                                    break;
                                }
                        }
                        break;
                    }
                case "p":
                    {
                        switch (Eattack)
                        {
                            case "ROCK":
                                {
                                    Console.WriteLine("You have WON \n");
                                    score2++;
                                    Console.WriteLine("Scoreboard");
                                    Console.WriteLine(player1 + " : " + score1);
                                    Console.WriteLine("Computer: " + score2 + "\n");
                                    break;
                                }
                            case "PAPER":
                                {
                                    Console.WriteLine("There has been a DRAW. \n");
                                    Console.WriteLine("Scoreboard");
                                    Console.WriteLine(player1 + " : " + score1);
                                    Console.WriteLine("Computer: " + score2 + "\n");
                                    break;
                                }
                            case "SCISSORS":
                                {
                                    Console.WriteLine("You have LOST. \n");
                                    score1++;
                                    Console.WriteLine("Scoreboard");
                                    Console.WriteLine(player1 + " : " + score1);
                                    Console.WriteLine("Computer: " + score2 + "\n");
                                    break;
                                }
                        }
                        break;
                    }
                case "s":
                    {
                        {
                            switch (Eattack)
                            {
                                case "ROCK":
                                    {
                                        Console.WriteLine("You have LOST. \n");
                                        score2++;
                                        Console.WriteLine("Scoreboard");
                                        Console.WriteLine(player1 + " : " + score1);
                                        Console.WriteLine("Computer: " + score2 + "\n");
                                        break;
                                    }
                                case "PAPER":
                                    {
                                        Console.WriteLine("You have WON \n");
                                        score1++;
                                        Console.WriteLine("Scoreboard");
                                        Console.WriteLine(player1 + " : " + score1);
                                        Console.WriteLine("Computer: " + score2 + "\n");
                                        break;
                                    }
                                case "SCISSORS":
                                    {
                                        Console.WriteLine("There has been a draw. \n");
                                        Console.WriteLine("Scoreboard");
                                        Console.WriteLine(player1 + " : " + score1);
                                        Console.WriteLine("Computer: " + score2 + "\n");
                                        break;
                                    }
                            }
                            break;
                        }
                    }
                default:
                    break;
            }
        }
    }
}



