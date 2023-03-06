using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //Title
        Console.WriteLine("Rock Paper Sciccors: The Game \nCreated by: Juan Lopez Salamanca \n\n");

        //Data Collection
        Console.WriteLine("Player, please type your name.");
        string player1 = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("Welcome to RPS: The Game\n");

        //Scoreboard

        int score1 = 0;
        int score2 = 0;


        //instructions
        Console.WriteLine("Lets play!\nremember...\nr = Rock\np = Paper\ns = Sciccors\n\nSelect Attack Then Press Enter!\n");

        //varaibles for user
        string Rock = "r";
        string Paper = "p";
        string Sciccors = "s";
        string attack = Console.ReadLine();

        Console.WriteLine("\n");

        //user selection
        {
            if (attack == Rock)
            {
                Console.WriteLine("You have selected... ROCK");
            }
            else if (attack == Paper)
            {
                Console.WriteLine("You have selected... PAPER");
            }
            else if (attack == Sciccors)
            {
                Console.WriteLine("You have selected... SCICCORS");
            }
            else
            {
                Console.WriteLine("Try Again");
            }

        }

        //varaibles for opponent
        string enemyrock = "ROCK";
        string enemypaper = "PAPER";
        string enemysciccors = "SCISSORS";
        string[] selectableStrings = new string[3] { enemyrock, enemypaper, enemysciccors };
        Random rand = new Random();
        string randomValue = selectableStrings[rand.Next(0, selectableStrings.Length)];


        Console.WriteLine("your Opponent selected... " + randomValue);


        //opponent selection/ results/ scorboard update
        {
            if (attack == Rock)
            {
                {
                    if (randomValue == enemyrock)
                    {
                        Console.WriteLine("\nYou have DRAWN\n\n");
                        Console.WriteLine("SCORE");
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");

                    }
                    else if (randomValue == enemypaper)
                    {
                        Console.WriteLine("\nYou have LOST\n\n");
                        Console.WriteLine("SCORE");
                        score2++;
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");

                    }
                    else if (randomValue == enemysciccors)
                    {
                        Console.WriteLine("\nYou have WON\n\n");
                        Console.WriteLine("SCORE");
                        score1++;
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");
                    }

                }
            }
            else if (attack == Paper)
            {
                {
                    if (randomValue == enemyrock)
                    {
                        Console.WriteLine("\nYou have WON\n\n");
                        Console.WriteLine("SCORE");
                        score1++;
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");
                    }
                    else if (randomValue == enemypaper)
                    {
                        Console.WriteLine("\nYou have DRAWN\n\n");
                        Console.WriteLine("SCORE");
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");
                    }
                    else if (randomValue == enemysciccors)
                    {
                        Console.WriteLine("\nYou have LOST\n\n");
                        Console.WriteLine("SCORE");
                        score2++;
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");
                    }

                }
            }
            else if (attack == Sciccors)
            {
                {
                    if (randomValue == enemyrock)
                    {
                        Console.WriteLine("\nYou have LOST\n\n");
                        Console.WriteLine("SCORE");
                        score2++;
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");
                    }
                    else if (randomValue == enemypaper)
                    {
                        Console.WriteLine("\nYou have WON\n\n");
                        Console.WriteLine("SCORE");
                        score1++;
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");
                    }
                    else if (randomValue == enemysciccors)
                    {
                        Console.WriteLine("\nYou have DRAWN\n\n");
                        Console.WriteLine("SCORE");
                        Console.WriteLine(player1 + ": " + score1);
                        Console.WriteLine("Opponent: " + score2 + "\n");
                    }
                }
            }
        }
    }
}



