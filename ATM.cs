using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            
            //Example Account Number:  6666
            //Example Pin Number: 333



            bool stay = true;
            bool repeat = true;
            int userAttempts = 0;
            int userPinAttempts = 0;
            double money = 0;

            while (repeat && stay)
            {

                Console.WriteLine("Enter your Account Number:");
                string userAccount = Console.ReadLine();

                if (userAccount == "6666")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome!");

                    while (repeat)
                    {


                        Console.WriteLine("Enter your 3-Digit Pin Number:");
                        string userPin = Console.ReadLine();
                        if (userPin == "333")
                        {
                            while (stay)
                            {
                                Console.Clear();
                                Console.WriteLine("What would you like to do?\n1)Deposit\n2)Withdraw\n3)Exit Account\n");
                                string userAnswer = Console.ReadLine().ToLower();
                                

                                switch (userAnswer)
                                {
                                    case "1":
                                    case "d":
                                    case "deposit":
                                        Console.Write("How much would you like to deposit into your account?\n$");
                                        double depositAmount = double.Parse(Console.ReadLine());
                                        Console.WriteLine($"{depositAmount:c} has been added to your account.\n");
                                        Console.WriteLine($"you now have {money += depositAmount:c}");
                                        Console.WriteLine("Press any Key to continue...");
                                        Console.ReadKey();
                                        break;

                                    case "2":
                                    case "w":
                                    case "withdraw":
                                        Console.Write("How much would you like to withdraw from your account?\n$");
                                        double withdrawAmount = double.Parse(Console.ReadLine());
                                        Console.WriteLine($"{withdrawAmount:c} has been removed from your account.\n");
                                        Console.WriteLine($"you now have {money -= withdrawAmount:c}");
                                        Console.WriteLine("Press any Key to continue...");
                                        Console.ReadKey();
                                        break;

                                    case "3":
                                    case "e":
                                    case "exit":
                                        stay = false;
                                        break;

                                    default:
                                        Console.WriteLine($"{userAnswer} was not a valid option. Please try again~!");
                                        break;
                                }
                            }

                        }
                        //Invalid User Pin
                        else
                        {
                            Console.WriteLine("Invalid Number. Try Again:");
                            userPinAttempts++;
                        }
                        //Attempts Failed for Pin
                        if (userPinAttempts == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Too many attempts were made to access this account. Please try again later.");
                            repeat = false;
                        }
                    }
                }

                //Invalid User account number 
                else
                {
                    Console.WriteLine("Invalid Number. Try Again:");
                    userAttempts++;
                }

                //Failed attempts if
                if (userAttempts == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Too many attempts were made to access this account. Please try again later.");
                    repeat = false;
                }

                //If user decides to exit the program
                if (stay == false)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for your business! Have a nice day.");
                }
            } 

        }
    }
}
