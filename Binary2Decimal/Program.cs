using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary2Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a Binary Number up to 4 digits : ");
            AskNumberFromUser();
        }

        static void AskNumberFromUser()
        {
            
            string binary = Console.ReadLine();
            int num = int.Parse(binary);
            CheckIfNumberIsValid(num);
            CalculateDecimal(num);
        }

        static void CheckIfNumberIsValid(int num)
        {

            int counter = 0;
            while(num>0)
            {
                int temp = num % 10;
                if (temp != 0)
                {
                    if (temp != 1)
                    {
                        Console.WriteLine("Wrong Input. Please Provide a 4 digit binary!!!");
                        AskNumberFromUser();
                    }
                }
                num = num / 10;
                counter++;
            }

            if (counter > 4)
            {
                Console.WriteLine("Wrong Input. Please Provide a 4 digit binary");
                AskNumberFromUser();
            }
        }

        static void CalculateDecimal(int num)
        {
            int rem, exponent = 1, digit, dec = 0; //dec = decimal 
            while(num>0)
            {
                rem = num % 10;
                digit = rem * exponent;
                dec += digit;
                exponent *= 2;
                num = num / 10;
            }

            Console.WriteLine("The coresponding Decimal number is {0}",dec);
        }
    }
}
