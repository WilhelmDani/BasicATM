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
            #region ATM Instructions
            /*
             * When thinking about how to structure this application, 
             * break it down into smaller problems. 
             * Every programming application is just a bunch of 
             * small problems put together into one larger solution. 
             * Look at what each requirement is asking from you. 
             * 
             * Start small - think about what you’ve learned that can solve that one problem 
             * (i.e. branching, looping, parsing, etc.), 
             * then build for that problem and integrate it into the application. 
             * Looking at the overall requirements, think about, “What can I do first?"
             * "What do I need to happen as soon as the application runs? What after that?” 
             * and continue to evaluate each step before you code it. 
             * Consider how a real ATM works and the order that events occur. 
             * 
             * 
             * 1.Write a program that will: 
             * 
             * a.)Ask the user to enter an account number for their account.
             * Continue to ask the user for their account number until they get it right 
             * (the correct account number should be hard coded in your code. Example: Login lab).
             * 
             * Optionally, consider locking them out after a certain number of failed attempts. 
             * 
             * b.)Once they get the correct account number, ask them for a pin number 
             * (you can use the additionalLogin functionality as a reference). 
             * Just as you did for their account number, 
             * continue to prompt the user for their pin until they get it correct. 
             * (The correct value will be hard coded just as it was for the account number) 
             * 
             * c.)Once the user has successfully given their account and pin numbers, 
             * prompt the user with a menu and ask them if they want to do a deposit, 
             * a withdrawal, or exit the application. 
             * 
             * d.)If they choose to do a deposit, ask them for the amount to deposit, 
             * and display the amount deposited. 
             * i. Ex. “$500.00 has been deposited into account number 12345”e.
             * If they choose to withdraw money, 
             * ask them for the amount to withdraw and display the amount withdraw.
             * i. Ex. “$500.00 has been withdrawn from account number 12345”
             * 
             * f.) After each transaction (deposit or withdrawl), 
             * ask the user if they want to do another deposit,
             * withdraw, or exit the application. 
             * 
             * g.) When the user exits the application, thank them for their business.
             * 
             * Additional Optional Features:  
             * • Keep a running total of the account balance, assuming that the account starts at $0. 
             * • Every time the user makes a deposit to or withdraw from the account, 
             * the balance should be updated and displayed. 
             * •Add a feature for the user to make a balance request that will display their current balance 
             * (without needing to make a deposit or withdrawal).  
             * 
             * 
             * 
             * */
            #endregion

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
