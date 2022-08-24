using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentData = "available";


            for (; studentData == "available";)
            {
                Console.WriteLine("Enter 1 to get StudentData");
                Console.WriteLine("Enter 2 to get CustomerData");
                Console.WriteLine("Enter 3 to get Sum of Digits");
                Console.WriteLine("Enter 4 to get Even and Odd Number");


                Console.WriteLine("Enter the choice :");
                int P = int.Parse(Console.ReadLine());

                switch (P)
                {
                    case 1:
                        Console.WriteLine("Enter the StudentId is :");
                        int studId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the StudentName is :");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter the StudentAge is:");
                        int Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("studentNumber is :" + studId + "\n" + "StudentName : " + Name + "\n" + "StudentAge :" + Age);
                        break;

                    case 2:
                        Console.WriteLine("Enter the CustomerId is :");
                        int CustId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the CustomerName is :");
                        string CustName = Console.ReadLine();
                        Console.WriteLine("Enter the CustomerEmail is:");
                        string CustEmail = Console.ReadLine();
                        Console.WriteLine("CustomerId is" + CustId + "\n" + "CustomerName : " + CustName + "\n" + "CustomerEmail :" + CustEmail);

                        Console.WriteLine("No Student Data is Available");
                        break;

                    case 3:
                        int number, sum = 0, remainder;
                        Console.Write("Enter a number: ");
                        number = int.Parse(Console.ReadLine());
                        while (number > 0)
                        {
                            remainder = number % 10;
                            sum = sum + remainder;
                            number = number / 10;
                        }
                        Console.WriteLine("Sum is= " + sum);
                        break;

                    case 4:
                        int Input;
                        Console.Write("Enter a Number : ");
                        Input = int.Parse(Console.ReadLine());
                        if (Input % 2 == 0)
                        {
                            Console.Write("Entered Number is an Even Number" +"\n");
                        }
                        else
                        {
                            Console.Write("Entered Number is an Odd Number" +"\n");
                        }
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
