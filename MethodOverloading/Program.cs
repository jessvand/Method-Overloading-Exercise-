using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var intAdd = Add(2, 6);
            Console.WriteLine(intAdd);

            var decimalAdd = Add(5.0m, 3.0m);

            var addWithBool = Add(1, 0, true);
            Console.WriteLine(addWithBool);
        }

        public static int Add(int numOne , int numTwo) 
        {
            return numOne + numTwo;
        }
        
        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isChecked)
        {
            var sum = numOne + numTwo;

            if (isChecked && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(isChecked && sum ==1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }


    }
}
