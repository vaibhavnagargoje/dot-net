 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void OddEven()
        {
                Console.WriteLine("Enter Number ");
            int x =Convert.ToInt32(Console.ReadLine());
            if (x%2 == 0)
            {

                Console.WriteLine("Even Number..");
            }

            else
            {
                Console.WriteLine("this number is Odd");
            }
        }

        static void DevisibalByFive(int x)
        {
            if(x%5 == 0)
            {
                Console.WriteLine("number Divisibal by 5");
            }
            else
            {
                Console.WriteLine("number is not divisibal by 5");
            }

        }

        static void Factorial( )
            
        {
            Console.WriteLine("Enter Number for Factorial : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int Facto = 1;
            for(int i = 1; i <= x; i++)
            {
                Facto *= i;
            }
            Console.WriteLine("factorial of " + x + " = " + Facto);
        }

        static void eleLess10()
        {
            int[] x = { 4,3,55,23,21,4,9,7,11};

            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] < 10)
                {
                Console.WriteLine(x[i]);
                    
                }
            }
        }

        static void primeOrNot()
        {
            int num = 17;
            bool isPrime=true;
            for(int i = 2;i < num/2+1;i++)
            {
                if (num%2 == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("number is Prime ..");
            }
            else
            {
                Console.WriteLine("the given number is not Prime");

            }
        }

        static void isPalindrom()
        {
            Console.WriteLine("Enter Number for to chaek is Palindrom or Not ..");
           int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int palindrom = 0;
           while(temp > 0) { 
                int num1 = temp % 10;
                palindrom = palindrom * 10 + num1;
                temp= temp / 10;
                

            }
           if(palindrom == num)
            {
                Console.WriteLine("number is palindrom ");
            }
            else
            {
                Console.WriteLine("number is not palindrom");
            }

        }

        static void squreRoot()
        {
            Console.WriteLine("Enter Number for squre root");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num <= 0)
            {
                Console.WriteLine("Please Enter Positive Number ... ");
            }
            else
            {
                double sqroot = Math.Sqrt(num);
                Console.WriteLine("squre root of "+num +" is : "+sqroot);
            }
            
        }


        static void Shuffl()
        {
            string str = "fergusson";
            Console.WriteLine("String Shuffling : "+str);
            char[] charArray = str.ToCharArray();

            char temp = charArray[0];
            charArray[0] = charArray[str.Length - 1];
            charArray[str.Length - 1] = temp;

            string newString = new string(charArray);
            Console.WriteLine("shuffled string is " + newString);
    }


        static void sumDigit()
        {
            Console.WriteLine("Enter Number for sum Digit :");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            while(num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            Console.WriteLine("sum of digit is : " + sum);
        }
    static void Main(string[] args)
        {
            squreRoot();
            isPalindrom();

            Console.ReadLine();
        }
    }
}
