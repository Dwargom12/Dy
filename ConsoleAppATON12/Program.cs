using System;

namespace Mathproblem
{

    public class Math
    {
        public void add(int num1, int num2)
        {
            Console.WriteLine("Sum is :" + (num1 + num2));
        }

        public void sub(int num1, int num2)
        {
            Console.WriteLine("Subtraction is :" + (num1 - num2));
        }

        public void multi(int num1, int num2)
        {
            Console.WriteLine("Multiplication is :" + (num1 * num2));
        }
        public void Div(int num1, int num2)
        {
            Console.WriteLine("Division is :" + (num1 / num2));
        }
        class program
        {
            static void Main(String[] args)
            {
                Math math = new Math();

                int num1, num2;

                Console.WriteLine("Enter num1: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2: ");
                num2 = int.Parse(Console.ReadLine());


                math.add(num1, num2);
                math.sub(num1, num2);
                math.multi(num1, num2);
                math.Div(num1, num2);




            }




        }


    }





}