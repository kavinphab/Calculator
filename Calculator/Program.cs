using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static int add(int[] numbers)
        {
          
            for(int i = 0; i < numbers.Length; i++)
            {
                int answer = 0;
                numbers[i] += answer;
                return answer;
            }
           
        }

        static int max(int [] numbers)
        {

           int max = numbers.Max();
            return max;
            
        }
        static void Main(string[] args)
        {
            // create a calculator with functions to add, subtract, multiply, divide, square, square root, find average, find min, find max, sum


        }
    }
}
