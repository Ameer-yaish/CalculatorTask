using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Calculator
    {
        //this function calculate the result of the operation that user choose on two numbers the user enter 
        public static double Calculate(double firstNumber, double secondNumber, char opreator)
        {

            double result = 0;
            try
            {

                //based on the operation the user enter the code will calculate
                switch (opreator)
                {
                    case '+': result = firstNumber + secondNumber; break;
                    case '-': result = firstNumber - secondNumber; break;
                    case '*': result = firstNumber * secondNumber; break;
                    case '/':
                        if (secondNumber == 0)
                        {
                            throw new ArithmeticException("the secound number cant be 0");
                        }
                        else
                        {
                            result = firstNumber / secondNumber; break;
                        }
                    default:
                        Console.WriteLine("Please choose from the opreation from the allowed list");
                        result = 0; break;

                }

                return result;



            }
            catch (Exception e)

            {
                Console.WriteLine(e.Message);
                return 0;



            }






        }

    }
}
