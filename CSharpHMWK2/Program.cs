using System;

namespace CSharpHMWK2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Matrices");
            Console.WriteLine("Choose a pill!");
            Console.WriteLine("1. Red, 2. Blue, 3. Black");
            string pill = Console.ReadLine().ToLower();

            switch (pill)
            {
                case "1":
                case "red":
                    {
                        Console.WriteLine("You've choosen the Red pill.  You will now know the future.");
                        Console.WriteLine("What do you do next?");
                        Console.WriteLine("1. Go to the Casino 2. Buy a Lottery Ticket 3. Tell the president about a planned terroist attack ");
                        string next = Console.ReadLine();
                        if (next == "1")
                        {
                            Console.WriteLine("Too bad the casino always win.  Game Over!");
                        }
                        else if (next == "2")
                        {
                            Console.WriteLine("The butterfly effect changes the outcome of the numbers.  Of course you were able to predict that.  You become a Gazillionaire.  Game Over!");
                        }
                        else if (next == "3")
                        {
                            Console.WriteLine("You forsee that the government locks you up for participating in terroist attacks.  So you remain quite and buy a lottery ticket.  Game Over!");
                        }
                        else
                        {
                            Console.WriteLine("How about saving the World?");
                          
                         }
                        gameOver();
                        Console.ReadLine();
                        
                        break;
                       
                    }
                case "2":
                case "blue":
                   
                    Console.WriteLine("You've choosen the Blue pill.  You can never die.");
                    Console.WriteLine("What do you do next?");
                    Console.WriteLine("1. Fight the good fight 2. Become a dummy for a bullet business");
                    string nextone = Console.ReadLine().ToLower();
                    if (nextone == "1")
                    {
                        Console.WriteLine("That's the spirit.  Become the shield for your country!");
                        Console.WriteLine("Here is your fight!");
                    }
                    else if (nextone == "2")
                    {
                        Console.WriteLine("Awesome choice. Winchester needed a live person to test their product on");
                        Console.WriteLine("Here is your fight!");
                    }
                    else
                    {
                        Console.WriteLine("How about saving the World?");  
                    }
                    Console.ReadLine();
                    gameOver();
                    break;                                  
                                       
                case "3":
                case "black":
                    Console.WriteLine("You've choosen the Black pill.  You can turn travel back in time.");
                    Console.WriteLine("What do you do next?");
                    Console.WriteLine("1. Save yourself from that embrassing moment, 2. Spend time with a loved one");
                    string nexttwo = Console.ReadLine().ToLower();
                    if (nexttwo == "1")
                    {
                        Console.WriteLine("Remember that booger in your nose.  Remove it and talk to your future spouse!");
                        Console.WriteLine("Now travel back into 2003 and tell me about my booger.");
                    }
                    else if (nexttwo == "2")
                    {
                        Console.WriteLine("Excellent choice.  You can also never die.");
                        Console.WriteLine("Prepare for Mars.");
                    }
                    else
                    {
                        Console.WriteLine("How about saving the World?");
                    }
                    Console.ReadLine();
                    second();
                    break;

                default:
                    Console.WriteLine("Pop a dang pill!");
                break;
            }
        }
        public static void second()
        {
            Console.WriteLine("You're invincible.  I need you to fight off The Goblin Attack Force");
            Console.WriteLine("They're equipped with huge incisors, that'll rip you apart." );
            string[] outcomes= {"You're trapped with two rocks", "You're on the ledge with a stick", "You're surrounded by Goblins" };
            Console.WriteLine(outcomes[1]);

            for (int i = 0; i < outcomes.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Here is your situation {0}", outcomes[i]);
            }
            Console.ReadLine();
            third();

        }
        public static void third()
        {
            Console.WriteLine("You've defeated the Goblins.  You will forever be a Champion");
            gameOver();

        }
        public static void gameOver()
        {
            Console.WriteLine("Game Over Loozer!");
           

        }
    }
}