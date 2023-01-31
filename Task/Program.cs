// See https://aka.ms/new-console-template for more information
using Task;

bool flag = true;
double num1 = 0;
double num2 = 0;
char op = '\0';
double result = 0;
bool yes = false;
while (flag)
{
    try
    {
        
        if (yes)
        {
            num1 = result;
            yes = false;
        }
        else {
            Console.WriteLine("Welcome to calculator \n Please enter the first number :");
            num1 = Convert.ToDouble(Console.ReadLine());

        }
        Console.WriteLine(" \n Please enter the secound number :");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" \n Please select  operation from (+,-,*,/) :");
        string operation = Console.ReadLine();
        //check if the user enter more than on operation
        if(operation.Length>1)
        {
            throw new Exception("please choose one operation");
        }
        else
        {
            op = Convert.ToChar(operation);
            //calculate the result of the two number based on which operation used
            result= Calculator.Calculate(num1, num2, op);
            Console.WriteLine($"result is:{result}");
            Console.WriteLine("choose from the following \n If you want to do a cumulative process on the result, enter (yes) \n If you want to do calculations on new numbers, enter (no) \n If you want to exit the program, enter (exit)\n");
            string choice = Console.ReadLine().ToLower();
            switch(choice)
            {
                case "yes":
                    yes = true;
                    break;
                case "no":
                     break;
                case "exit":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("the choice you enter is not valid");
                    break;



            }

        }

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        

    }
   
}
