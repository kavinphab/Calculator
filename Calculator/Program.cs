using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        //    , 'average', 
        static int add(int[] numbers)
        {
            int answer = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }
            return answer;

        }

        static int subtract(int[] numbers)
        {
            int answer = numbers[0] - numbers[1];
            return answer;
        }

        static int max(int[] numbers)
        {

            int max = 0;
            //loop through, if element is greater than max (max = element)
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i]; 
                }
                
            }
            return max;

        }

        static int min(int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static int multiply(int[] numbers)
        {
            int answer = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                answer *= numbers[i];
            }
            return answer;
        }

        static int divide(int[] numbers)
        {
            int answer = numbers[0] / numbers[1];
            return answer;
        }

        static int[] square(int[] numbers)
        {
            //square each element in the array

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)Math.Pow(numbers[i], 2); 
            }

            return numbers;

        }

        static int[] squareroot(int[] numbers)
        {
            for(int i = 0;  i < numbers.Length; i++)
            {
                numbers[i] = (int)Math.Sqrt(numbers[i]);

            } 
            return numbers;
        }

        static void DisplayArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
         
        static int average(int[] numbers)
        {
            int answer = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }
           answer =  answer / numbers.Length;
            return  answer;

        }
          
        //static int average(int[] numbers)
        //{
        //    for(int i = 0; i < numbers)
        //}
        static void Main(string[] args)
        {
            // create a calculator with functions to add, subtract, multiply, divide, square, square root, find average, find min, find max, sum
            Console.WriteLine("Would you like to 'add', 'subtract', 'multiply', 'divide', 'square', 'square root', 'average', or find 'min', 'max'");
            string function = Console.ReadLine();
            int[] numbers = { 9, 9 };

            if (function == "add")
            {
                Console.WriteLine(add(numbers));
            }
            if (function == "subtract")
            {
                Console.WriteLine(subtract(numbers));
            }
            if (function == "max")
            {
                Console.WriteLine(max(numbers));
            }

            if (function == "min")
            {
                Console.WriteLine(min(numbers));
            }

            if (function == "multiply")
            {
                Console.WriteLine(multiply(numbers));
            }

            if (function == "divide")
            {
                Console.WriteLine(divide(numbers));
            }

            if(function == "square root")
            {
                DisplayArray(squareroot(numbers));

                
            }

            if(function == "square")
            {
                DisplayArray(square(numbers));
            }
            Console.ReadKey();

            if(function == "average")
            {
                Console.WriteLine(average(numbers));
            }
        }
    }
}
