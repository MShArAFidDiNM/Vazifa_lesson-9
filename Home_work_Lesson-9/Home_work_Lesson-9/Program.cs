using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Home_work_Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Bankomat bankomat = new Bankomat();
            bankomat.Language();
            Console.ReadLine();
        }
    }
    internal class Bankomat
    {
        public string Adress { get; private set; }
        public int Card { get; set; }

        public Bankomat() { }
        public double balanse = 1225000;       
        public void CardType()
        {
            Console.WriteLine("         Select the carat type :\n[1]: UZCARD        [2] : HUMO      [3] : VISA      [4] : MASTER CARD");
            string inputCardType = Console.ReadLine();
            Console.Clear();
            bool checkCardType = int.TryParse(inputCardType, out int cardType);
            if (checkCardType == true && cardType >= 1 && cardType <= 4)
            {
                if (cardType == 1)
                {
                    Console.WriteLine("   --- UZCARD ---");
                    Language();
                }
                if (cardType == 2)
                {
                    Console.WriteLine("   --- HUMO ---");
                    Language();
                }
                if (cardType == 3)
                {
                    Console.WriteLine("   --- VISA ---");
                    Language();
                }
                if (cardType == 4)
                {
                    Console.WriteLine("   --- MASTER CARD ---");
                    Language();
                }
            }
            else Console.WriteLine("   !!! ERROR !!!");
        }
        public void Pincode()
        {
        comebackPinCode:
            Console.Write("     Enter Pasword : ");
            string pincode = Console.ReadLine();
            Console.Clear();
            bool checkpin = int.TryParse(pincode, out int pincodeNumber);
            if ((checkpin) && pincode.Length == 4)
            {
                SelectOperation();
            }
            else
            {
                Console.Write("Please check your password and try again");
                goto comebackPinCode;
            }
        }
        public void Language()
        {
            Console.WriteLine("             Select Langlue  \n      [1]-UZ      [2]-RUS     [3]-ENG");
            string language = Console.ReadLine();
            Console.Clear();
            bool checkLanguage = int.TryParse(language, out int languageNumber);
            if (languageNumber >= 1 && languageNumber <= 3)
            {
               /// Console.WriteLine("         Siz Ingliz tilini tanladingiz\n         Вы выбрали английский\n         You have selected English");
                Pincode();
            }
            else Console.WriteLine("        !!! ERROR !!!");
        }
        public void SelectOperation()
        {
            Console.WriteLine("1 : Transfer money from card to card\n2 : Balance check\n3 : Change password");
            string select = Console.ReadLine();
            Console.Clear();
            bool checkSelect = int.TryParse(select, out int selectNumber);
            if (checkSelect == true && (selectNumber >= 1 && selectNumber <= 3))
            {
                if (selectNumber == 1)
                {
                    Back:
                    Console.Write("Enter the card number : ");
                    string inputCardNumber = Console.ReadLine();
                    Console.Clear();
                    bool check = double.TryParse(inputCardNumber, out double cardNumberNumber);
                    kel:
                    if (check == true && inputCardNumber.Length == 16)
                    {
                        Console.Write("How much money you want to transfer : ");
                        string inputUZS = Console.ReadLine();
                        Console.Clear();
                        bool CheckUZS = int.TryParse(inputUZS, out int inputUZSNumber);
                        if (CheckUZS == true && balanse >= inputUZSNumber)
                        {
                            balanse -= inputUZSNumber;
                            Console.WriteLine($"You transferred money to card number {inputUZSNumber} UZS and you have {balanse} UZS money left in your balance");
                            request();
                        }
                        else
                        {
                            Console.WriteLine("Your balance does not have enough funds, please check and try again");
                            goto kel;
                        }
                    }
                    else
                    {
                        Console.WriteLine("     !!! ERROR !!!");
                        goto Back;
                    }

                }
                if (selectNumber == 2)
                {
                    Console.WriteLine($"You have {balanse} UZS money in your balance");
                    Console.Clear();                 
                    request();
                }
                if (selectNumber == 3)
                {
                ComeBackNewPassword:
                    Console.Write("Enter a new password : ");
                    string inputNewPassword = Console.ReadLine();
                    Console.Clear();
                    bool checkNewPassword = int.TryParse(inputNewPassword, out int newPasswordNumber);
                    if (checkNewPassword == true && inputNewPassword.Length == 4)
                    {
                        Console.WriteLine("The operation was completed successfully");
                        request();
                    }
                    else
                    {
                        Console.WriteLine("Please note that the password you enter must contain at least 4 numbers and must not contain letters or symbols.");
                        goto ComeBackNewPassword;
                    }
                }
            }
            else
            {
                Console.WriteLine("An error has been reported, please be careful and try again");
                SelectOperation();
            }
        }
        public void request()
        {
            Console.WriteLine("Do you want to continue?\n       YES or NO");
            string inputContinue = Console.ReadLine();
            Console.Clear();
            if (inputContinue == "YES") SelectOperation();
            else if (inputContinue == "NO")
            {
                Console.WriteLine("Thank you for using our ATM"); 
                Console.WriteLine("Get your thank you card");
                Thread.Sleep(3000);
                Console.Clear();
                Language();    
            }
            else
            {
                Console.WriteLine("An error has been reported, please be careful and try again");
                request();
            }

        }
    }
}
   
