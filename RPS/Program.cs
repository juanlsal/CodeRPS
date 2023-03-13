using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rock Paper Scissors: The Game \nCreated by: Juan Lopez Salamanca \n\nPlayer, please type your name.");
        string player1 = Console.ReadLine();
        Console.WriteLine("\nWelcome to RPS: The Coding Game!\n\nEnter points needed to win game:");
        int target = int.Parse(Console.ReadLine());
        int s1 = 0;
        int s2 = 0;
        while (s1 < target && s2 < target)
        {
            int newscore = Newscore(s1);
            Console.WriteLine($"\nScoreboard \n{player1} : {newscore}  \nComputer:  {s2} \n");
            Console.WriteLine("\nLets play!\nremember...\nr = Rock\np = Paper\ns = Scissors\n\nSelect Attack Then Press Enter!");
            string attack = Console.ReadLine();
            //Console.WriteLine("\n");
            string enemyrock = "ROCK";
            string enemypaper = "PAPER";

            string enemyscissors = "SCISSORS";
            string[] selectableStrings = new string[3] { enemyrock, enemypaper, enemyscissors };
            Random rand = new Random();
            string Eattack = selectableStrings[rand.Next(0, selectableStrings.Length)];
            Console.WriteLine("\nyour Opponent selected... " + Eattack);
            switch (attack)
            {
                case "r":


                    Console.WriteLine("You have selected... ROCK");
                    switch (Eattack)
                    {
                        case "ROCK":
                            {
                                Console.WriteLine("There has been a draw.");
                                break;
                            }
                        case "PAPER":
                            {
                                Console.WriteLine("You have LOST.");
                                ++s2;
                                break;
                            }
                        case "SCISSORS":
                            {
                                Console.WriteLine("You have WON");
                                ++s1;
                                break;
                            }
                    }
                    break;
                case "p":
                    Console.WriteLine("You have selected... PAPER");
                    switch (Eattack)
                    {
                        case "ROCK":
                            {
                                Console.WriteLine("You have WON");
                                ++s1;
                                QA("Distributed", "Centralized", "Intrisic", "None of the above", player1, s1, s2);
                                if (Addpoint() == "correct")
                                {
                                    ++s1;
                                }
                                break;
                            }
                        case "PAPER":
                            {
                                Console.WriteLine("There has been a DRAW.");
                                break;
                            }
                        case "SCISSORS":
                            {
                                Console.WriteLine("You have LOST.");
                                ++s2;
                                break;
                            }
                    }
                    break;
                case "s":
                    Console.WriteLine("You have selected... SCISSORS");
                    switch (Eattack)
                    {
                        case "ROCK":
                            {
                                Console.WriteLine("You have LOST.");
                                ++s2;
                                break;
                            }
                        case "PAPER":
                            {
                                Console.WriteLine("You have WON");
                                ++s1;
                                break;
                            }
                        case "SCISSORS":
                            {
                                Console.WriteLine("There has been a draw.");
                                break;
                            }
                    }
                    break;
                default:
                    Console.WriteLine("try again");
                    break;
            }
        }
        if (s1 == target)
        {
            Console.WriteLine($"{player1} Won The Game!");
        }
        if (s2 == target)
        {
            Console.WriteLine("Your Opponent Won The Game");
        }
    }



    static void QA(string Aa, string Qb, string Qc, string Qd, string player1, int s1, int s2)
    {
        //Console.Clear();
        Console.WriteLine("\n\nIts your turn! Answer the question right and recieve an extra point\n");
        Console.WriteLine("What type of Version Control System is git?");
        string answer = "a";
        //question
        Console.WriteLine($"A) {Aa}:");
        Console.WriteLine($"B) {Qb}:");
        Console.WriteLine($"C) {Qc}:");
        Console.WriteLine($"D) {Qd}:");
        Console.WriteLine("\n");
        Console.WriteLine("type in letter that represents your answer:");
        string r = Console.ReadLine();
        if (Answer(r, answer) == true)
        {
            Console.WriteLine("\nYou Are Correct!!");
        }
        else
        {
            Console.WriteLine("\nWrong");
        }
    }
    static Boolean Answer(string response, string answer)
    {
        if (answer == response)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    static int Newscore(int oldscore)
    {
        int newscore = 0;
        newscore = oldscore;
        return newscore;
    }

    static string Addpoint()
    {
        return ("correct");
    }
}
    