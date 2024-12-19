using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3_.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:1.Write a program that allows the user to enter a number then print it.
            //Console.Write("please enter the number:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("the number is " + num);
            #endregion

            #region Q2:2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string s = "Lojain";
            //int n = int.Parse(s);
            //Console.WriteLine(n);
            //// this will give to me exception : System.FormatException: 'The input string 'Lojain' was not in a correct format.'
            ////A FormatException will be thrown because the string contains non-numeric characters.
            ////we should also put the block in try catch , and i show message when the exception happen 
            //string st = "Lojain";
            //try
            //{
            //    int num = int.Parse(st);
            //    Console.WriteLine(num);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("the input is string cannot convert to int as it is not a numerical string ");
            #endregion

            #region Q3: 3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float num1 = 1.5f;
            //float num2 = 2.5f;
            //float res = num1 * num2;
            //Console.WriteLine(res);
            ////This performs multiply of floating-point numbers and will print the result with decimal
            #endregion

            #region Q4:4.Write C# program that Extract a substring from a given string.
            //string name = "Lojain Emad";
            //string sub = name.Substring(0,6);
            //Console.WriteLine("sub string is : "+ sub);
            #endregion

            #region Q5:5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int num1=2;
            //int num2= num1;
            //num2=4;
            //Console.WriteLine("num1: " + num1); 
            //Console.WriteLine("num2: " + num2);
            /*what will happen
             the output will be : num1=2 , num2=4
             * int is a value type,if a value type is assigned to another variable like y=x,
             * a copy of the value is made. The two variables now operate in dependent way .
             * and value types as int are copied by value, so modifying y does not affect x.
             */
            #endregion

            #region Q6: 6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point obj1 = new Point();
            //obj1.value = 5;
            //Point obj2 = obj1;
            //obj2.value = 6;
            //Console.WriteLine("obj1 Value: " + obj1.value); 
            //Console.WriteLine("obj2 Value: " + obj2.value);
            /*what will happen
             * the output is : obj1.value=6 and obj2.value =6 , as reference types like objects are copied by reference, 
             * so modifying one affects the other 
             * when you assign a reference type variable (obj2 = obj1 ),
             * both variables refer to the same object in memory. any change made through one variable affects the object that both variables reference.
             * obj1 and obj2 are references, not separate objects so modifying the object through one reference affects the other reference to that object
             */

            #endregion

            #region Q7: 7.Write C# program that take two string variables and print them as one variable 
            //string s1 = "LOJAIN ";
            //string s2 = "EMAD";
            //string total = s1 + s2;
            //Console.WriteLine("My Name : " + total);
            #endregion

            #region Q8: 8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.
            //double principal =500;
            //double rate = 3;
            //double time = 2;
            //double interest = (principal* rate*time) / 100;
            //Console.WriteLine("Interest: " + interest);
            //// in this case here we can also use float instead of double without any problems.
            //// but using float could lead to inaccuracies if the values are bigger because float has lower precision ,
            //// float's precision is 7 significant digits and double's precision is 15-16 significant digits.
            #endregion

            #region Q9: 9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI isBMI = (Weight) / (Height * Height)
            //double weight =60;
            //double height = 1.55; //m
            //double bmi = (weight) / (height * height);
            //Console.WriteLine("BMI: " + bmi);
            #endregion

            #region Q10: 10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            //int temp = 9;
            //string result = (temp < 10) ? "Just Cold":(temp> 30)?"Just Hot" : "Just Good";
            //Console.WriteLine("status of the temperature : " + result);
            #endregion

            #region Q11: 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            // here i make user to enter day , nonth , year separatly and then format it
            //Console.WriteLine("Enter the day (dd): ");
            //int day = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the month (mm): ");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the year (yyyy): ");
            //int year = int.Parse(Console.ReadLine());
            //DateTime the_date = new DateTime(year, month, day);
            //Console.WriteLine($"Today's date: {the_date:dd, MM, yyyy}");
            //Console.WriteLine($"Today's date: {the_date:dd/MM/yyyy}");
            //Console.WriteLine($"Today's date: {the_date:dd-MM-yyyy}");

            ///////////////////
            ///
            ///another solution
            //Console.WriteLine("Enter the date in the format (dd-MM-yyyy): ");
            //string input = Console.ReadLine();
            //DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);
            //Console.WriteLine($"Today's date: {date:dd, MM, yyyy}");
            //Console.WriteLine($"Today's date: {date:dd/MM/yyyy}");
            //Console.WriteLine($"Today's date: {date:dd-MM-yyyy}");

            #endregion

            #region Q12: 12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Q13: 13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num< 0)
            //    Console.WriteLine("negative");
            //else
            //    Console.WriteLine("positive");
            #endregion

            #region Q14: 14- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.Write("enter three numbers please: ");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2= int.Parse(Console.ReadLine());
            //int n3= int.Parse(Console.ReadLine());
            //int[] arr= {n1,n2,n3};
            //int max = arr.Max();
            //int min = arr.Min();
            //Console.WriteLine("max element = " + max);
            //Console.WriteLine("min element = " + min);
            #endregion

            #region Q14 another: 14- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("even");
            //else
            //    Console.WriteLine("odd");
            #endregion

            #region Q15: 15- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter a character: ");
            //char c = char.Parse(Console.ReadLine().ToLower());
            //char[] vowels_arr = { 'a', 'e' ,'i','o' ,'u' };
            //if (vowels_arr.Contains(c))
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");
            #endregion

            #region Q16: 16- Write a program to input the month number and print the number of days in that month.
            //Console.Write("enter month number: ");
            //int month = int.Parse(Console.ReadLine());
            //int days = DateTime.DaysInMonth(2024, month);
            //Console.WriteLine("Days in Month: " + days);
            #endregion

            #region Q17: 17- Write a program to create a Simple Calculator.
            //double n1, n2, res;
            //string operation;
            //Console.Write("enter the first number: ");
            //n1 = double.Parse(Console.ReadLine());
            //Console.Write("enter the second number: ");
            //n2 = double.Parse(Console.ReadLine());
            //Console.Write("enter the operation (+, -, *, /): ");
            //operation = Console.ReadLine();
            //switch (operation)
            //{
            //    case "+":
            //        res= n1 + n2;
            //        Console.WriteLine($"Result: {n1} + {n2} = {res}");
            //        break;
            //    case "-":
            //        res = n1 - n2;
            //        Console.WriteLine($"Result: {n1} - {n2} = {res}");
            //        break;
            //    case "*":
            //        res = n1 * n2;
            //        Console.WriteLine($"Result: {n1} * {n2} = {res}");
            //        break;
            //    case "/":
            //        if (n2 == 0)
            //        {
            //            Console.WriteLine("cannot divide by zero");
            //        }
            //        else
            //        {
            //            res = n1 / n2;
            //            Console.WriteLine($"Result: {n1} / {n2} = {res}");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("please enter one of the following: +, -, *, /.");
            //        break;
            //}
            #endregion

            #region Q18: 18.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("enter an integer: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region Q19: 19- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int j = 1; j <= 12; j++)
            //{
            //    Console.Write(num* j+ " ");
            //}
            #endregion

            #region Q20: 20- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //int i = 2;
            //while (i <= num)
            //{
            //    Console.Write(i + " ");
            //    i += 2;
            //}
            #endregion

            #region Q21: 21- Write a program that takes two integers then prints the power.
            //Console.Write("enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Enter the power: ");
            //int pow = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= pow; i++)
            //{
            //    result *= num; 
            //}
            //Console.WriteLine("result: " + result);
            #endregion

            #region Q22: 22- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int reverse_Number = 0;
            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reverse_Number = reverse_Number * 10 + digit; 
            //    number /= 10; 
            //}
            //Console.WriteLine("reversed: " + reverse_Number);
            #endregion

            #region Q23: 23- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("enter first range: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("enter the last range: ");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine("prime numbers between " + start + " and " + end + " are:");
            //for (int i = start; i <= end; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime && i > 1)
            //        Console.Write(i + " ");

            #endregion

            #region Q24: 24- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("enter a decimal number: ");
            //int num = int.Parse(Console.ReadLine());
            //string binary = Convert.ToString(num, 2);
            //Console.WriteLine($"the binary of {num} is " + binary);
            #endregion

            #region Q25: 25- Write a program in C# Sharp to find the sum of all elements of the array.
            //this if i take this from the user
            //Console.Write("enter array size of elements : ");
            //int size = int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];
            //Console.WriteLine($"enter {size} numbers:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"enter number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //foreach (int num in numbers)
            //{
            //    sum += num;
            //}
            //Console.WriteLine("the sum of elements : " + sum);
            ////
            ///this if there are numbers already in the array
            //int[] numbers = { 1, 2, 3, 4};
            //int sum = 0;
            //foreach (int num in numbers)
            //{
            //    sum += num;
            //}
            //Console.WriteLine("the sum of elements: " + sum);
            #endregion







        }

    }



}

