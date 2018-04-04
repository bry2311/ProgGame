using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            Console.Write("Player Name : ");
            string name = Console.ReadLine();
            while (play)
            {
                Deck d = new Deck();
                d.Shuffle();
                //d.ShowDeckCard();
                Player p1 = new Player();
                Player p2 = new Player();
                for (int i = 0; i < 2; i++)
                {
                    p1.DrawCard(d.TopCard);
                    p2.DrawCard(d.TopCard);
                }
                //Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(name + "'s Cards : ");
                p1.ShowPlayerCard();
                Console.WriteLine("Your Point : " + p1.CountCardNumber());
                Console.WriteLine();
                //Console.WriteLine("Computer's Cards : ");
                //p2.ShowPlayerCard();
                //Console.WriteLine("Computer Point : " + p2.CountCardNumber());
                //Console.WriteLine();
                bool menuUtama = true;
                bool menuUtama2 = true;
                while(menuUtama || menuUtama2)
                {
                    bool menu = true;
                    while (menu)
                    {
                        Console.WriteLine("Do you want to take card again ?");
                        Console.WriteLine("1. Take Card ");
                        Console.WriteLine("0. No ");
                        Console.Write("Your Choice : ");
                        string strchoice = Console.ReadLine();
                        if (strchoice == "1")
                        {
                            Console.WriteLine();
                            p1.DrawCard(d.TopCard);
                            Console.WriteLine(name + "'s Cards : ");
                            p1.ShowPlayerCard();
                            Console.WriteLine("Your Point : " + p1.CountCardNumber());
                            menu = false;
                        }
                        else if (strchoice == "0")
                        {
                            menu = false;
                            menuUtama = false;
                        }
                        else
                            Console.WriteLine("Please Choice between 1/0 !");
                        Console.WriteLine();
                    }

                    bool menu2 = true;
                    while (menu2)
                    {
                        p2.CountCardNumber();
                        int intchoice = p2.ComputerChoice();
                        Console.WriteLine("Computer Choice : " + intchoice);
                        Console.WriteLine();
                        if (intchoice == 1)
                        {
                            p2.DrawCard(d.TopCard);
                            menu2 = false;
                        }
                        else
                        {                           
                            menu2 = false;
                            menuUtama2 = false;
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Computer's Cards : ");
                p2.ShowPlayerCard();
                Console.WriteLine("Computer Point : " + p2.CountCardNumber());
                Console.WriteLine();
                if (p1.countNumber > 21 && p2.countNumber <= 21)
                    Console.WriteLine("-------- You Lose ! --------");
                else if (p1.countNumber <= 21 && p2.countNumber > 21)
                    Console.WriteLine("-------- You Win ! --------");
                else if (p1.CalculateWinner() < p2.CalculateWinner())
                    Console.WriteLine("-------- You Win ! --------");
                else if (p1.CalculateWinner() > p2.CalculateWinner())
                    Console.WriteLine("-------- You Lose ! --------");
                else
                    Console.WriteLine("-------- Tie ! --------");
                Console.WriteLine();
                bool play2 = true;
                while (play2)
                {
                    Console.WriteLine("Do you want to play again ? ");
                    Console.WriteLine("1. Continue ");
                    Console.WriteLine("0. Exit ");
                    Console.Write("Your Choice :  ");
                    string strplay = Console.ReadLine();
                    if (strplay == "1")
                    {
                        Console.WriteLine("------------------------------");
                        play2 = false;
                    }
                    else if (strplay == "0")
                    {
                        play = false;
                        play2 = false;
                    }
                    else
                        Console.WriteLine("Input only 1/0 !!");
                    Console.WriteLine();
                }
            }
        }
    }
}
