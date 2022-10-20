/*
//TASK 1: Write a code that by given name prints on the console "Hello, <name>!"
string name;
Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Hello " + name + "!");
Console.ReadKey();


TASK 2: Create a method GetMax() with two integer (int) parameters, that returns 
maximal of the two numbers. Write a program that reads three numbers 
from the console and prints the biggest of them. Use the GetMax() method 
you  just  created.  Write  a  test  program  that  validates  that  the  methods 
works correctly.


void GetMax();
{
    Console.WriteLine("Please enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter a number");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
}
GetMax();
Console.ReadKey();
*/


/*
TASK 3:
Write a method Letterize(number), which reads an integer and 
prints it in words in English according to the conditions below:
Print in words the hundreds, the tens and the ones (and the 
eventual minus) according to the rules of the English language.
If the number is larger than 999, you must print "too large".
If the number is smaller than -999, you must print "too small".
If the number is negative, you must print "minus" before it.
If the number is not built up of three digits, you shouldn't print it.
*/

/*
int numberHundreds;

String convert(int numberHundreds)
{
    String[] numbers = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
    int hundreds = numberHundreds / 100;
    numberHundreds = numberHundreds % 100;
    int tens = numberHundreds / 10;
    numberHundreds = numberHundreds % 10;

    return numbers[hundreds - 1] + " " +numbers[tens - 1]+ " " +numbers[numberHundreds - 1];
}

Console.WriteLine("Please enter a three digit number between -999 and 999");
numberHundreds = Convert.ToInt32(Console.ReadLine());
if (numberHundreds > 99)
{
    Console.WriteLine("Number is " + convert(numberHundreds));

}
else if (numberHundreds > 999)
{
    Console.WriteLine("That number is too large");
}
else if (numberHundreds < -99)
{
    Console.WriteLine("Number is " + convert(numberHundreds));

}
else if (numberHundreds < -999)
{
    Console.WriteLine("That number is too small");
}
else
{
    Console.WriteLine("That number is too small");
}

Console.ReadKey();
*/
//Timer example

int update=0;
Timer myTimer = new Timer(test,null,0,2000);

void test(object o)
{
    Console.WriteLine(update);
    update++;
}

Console.ReadKey();