Console.Title = "MY FizzBuzz Game";

// Question
// Area of a Triangle
// parameters: double base, double height
// formula : 1/2*b*h

// FizzBuzz
// description: 
// using a for loop determine 
// if the number(userinput) 
// is divisible by 3 and 5 without remainder it should print 'FizzBuzz'.
//if the Number is divisible by 3, it should print 'Fizz'.
// If the number is divisible by 5, it should  just print 'Buzz'.
// ---------------------------------------------
// i < userinput,i++
// Note:This should be implemented using Methods
// */

// Solution

Console.Title = "Fizzbuzz Project";
Console.WriteLine("Input number: ");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("note: number should be form 1-100");
Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Cyan;
        int number = int.Parse(Console.ReadLine()!);
        Console.ResetColor();
     FizzBuzz(number);

void FizzBuzz(int number)
{
    for (int m = 0; m < number; m++)
    {
        if (m % 3==0 && m % 5==0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if(m % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if(m % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(m);
        }

    }
 Console.WriteLine("Thanks For Playing");
}


