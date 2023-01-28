using System;
using System.IO;

namespace practice_34
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            // Coffee Shop  & Pizaa Shop
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int TotalCoffee = 0;
            int TortalPizaa = 0;
            Console.WriteLine("Hello Guyz Welcome To Our New Pizaa & Coffee Shop");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter Your Name :");
            string Username = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\"Hello! {0} Welcome Our MENU CARD :",Username);
            Console.WriteLine("---------------------------------------------");
            Start:
            StreamReader Readnew = new StreamReader("C:\\ShopMenu.txt");
            Console.WriteLine(Readnew.ReadToEnd());
            int UserSelection = Convert.ToInt32(Console.ReadLine());
            switch (UserSelection)
            {
                case 1:
                    Console.WriteLine("Added 1 Pizza Your Bill {0}", TortalPizaa += 100);
                    break;
                case 2:
                    Console.WriteLine("Added 1 Pizza Your Bill {0}", TortalPizaa += 130);
                    break;
                case 3:
                    Console.WriteLine("Added 1 Pizza Your Bill {0}", TortalPizaa += 180);
                    break;
                case 4:
                    Console.WriteLine("Added 1 Pizza Your Bill {0}", TortalPizaa += 200);
                    break;
                case 5:
                    Console.WriteLine("Added 1 Coffee Your Bill {0}",TotalCoffee+=50);
                    break;
                case 6:
                    Console.WriteLine("Added 1 Coffee Your Bill {0}", TotalCoffee += 100);
                    break;
                case 7:
                    Console.WriteLine("Added 1 Coffee Your Bill {0}", TotalCoffee += 150);
                    break;
                default:
                    Console.WriteLine("You Enterd {0} Invalid Choice ",UserSelection);
                    goto Start;
            }
            Decision:
            Console.WriteLine("Do you want to Buy More Coffee press \"Yes\" or \"No\" ");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("You Enterd Invalid Choice {0} Please Enter Valid Choice",UserDecision);
                    goto Decision;
            }
            Console.WriteLine("Thank You For The Visiting Our Coffee Shop");
            int TotalFood = TotalCoffee + TortalPizaa;
            Console.WriteLine("Your All Food Bill Is :{0}", TotalFood);
            AboutInfo:
            Console.WriteLine("Do You Want to Check Information About Shop press \" Yes \" Or \"No\"");
            string UserDecisionForAbout = Console.ReadLine();
            switch (UserDecisionForAbout.ToUpper())
            {
                case "YES":
                    StreamReader Readnew1 = new StreamReader("C:\\Shop.txt");
                    Console.WriteLine(Readnew1.ReadToEnd());
                    break;
                case "NO":
                    Console.WriteLine("Ok No Problem Byy");
                    break;
                default:
                    Console.WriteLine("Enter Valid Input {0}",UserDecisionForAbout);
                    goto AboutInfo;
            }
            Console.WriteLine("Hope You Are Enjoy");
            Console.ReadLine();
        }
    }
}
