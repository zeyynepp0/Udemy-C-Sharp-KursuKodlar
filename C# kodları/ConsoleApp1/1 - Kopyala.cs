// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Text-displ ay ing app.
/*using System;
class Welcomel1
{
    // Main method begins execution of C# app
    static void Main()
    {
        zeynep can 
        Console.Write("Welcome \t to C# Programming! ");
        Console.WriteLine("Welcome to C# \n Programming! ");
        Console.WriteLine("Welcome to \"C#\" C# Programming! ");
        Console.WriteLine("Welcome to  C# Programming! ");
        Console.WriteLine("Zeynep \r Programming! ");
        string metin = "Bu bir metin dosyasına yazılacak bir satırdır zeynep can. \r Bu satır, başa dönüp üzerine yazılacaktır.";

        Console.WriteLine(metin);

        string person = "Paul";
        Console.WriteLine("naber {person}! "); //naber {person}!
        Console.WriteLine($"Welcome to  C# Programming, {person}!! ");//Welcome to  C# Programming, Paul!!

    }
}*/
// end Main
// end class Wel comel


/*using System;

class Account
{
    private string name; // Üye değişkeni private olarak tanımlayın

    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    static void Main()
    {
        Account myAccount = new Account();
        Console.WriteLine($"Initial name is: {myAccount.GetName()}");

        Console.Write("Enter the name: ");
        string theName = Console.ReadLine();
        myAccount.SetName(theName);

        Console.WriteLine($"myAccount name is: {myAccount.GetName()}");
    }
}
*/


/*using System;


class Account { 
public string Name { get; set; } 
public Account(string accountName)
{
    Name = accountName;
}
//class AccountTest
//{ 
static void Main() { 

Account account1 =new Account(" Jane");
Account account2 =new Account(" John");

Console.WriteLine($"account1 name is:{ account1.Name}");
Console.WriteLine($"account2 name is:{ account2.Name}");
    }
    }*/



/*using System;

class Comparison
{
    // Main method begins execution of C# app
    static void Main()
    {
        // prompt user and read first number
        Console.Write("Enter first integer: ");
        int number1 = int.Parse(Console.ReadLine());

        // prompt user and read second number
        Console.Write("Enter second integer: ");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine($"{number1} is equal to {number2}");
        }

        if (number1 != number2)
        {
            Console.WriteLine($"{number1} is not equal to {number2}");
        }

        if (number1 < number2)
        {
            Console.WriteLine($"{number1} is less than {number2}");
        }

        if (number1 > number2)
        {
            Console.WriteLine($"{number1} is greater than {number2}");
        }

        if (number1 <= number2)
        {
            Console.WriteLine($"{number1} is less than or equal to {number2}");
        }

        if (number1 >= number2)
        {
            Console.WriteLine($"{number1} is greater than or equal to {number2}");
        }
    }
}*/

/*using System;

namespace _deneme
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("merhabalar ");
            string isim;
            Console.WriteLine("İsminizi giriniz:");
            isim = Console.ReadLine();
            Console.WriteLine($"Hosgeldiniz {isim}");
            Console.WriteLine("Soyadınızı giriniz:");
            string soyad = Console.ReadLine();
            Console.WriteLine($" Sayın {soyad}");
            Console.WriteLine("yasınızı giriniz:");
            string yas = Console.ReadLine();
            Console.WriteLine(" yasınız:" + yas);

            Console.WriteLine(" merhaba \n Duman");
            Console.WriteLine("merhaba\\ Yaz");
            Console.WriteLine("nasılsın");
        }
    }
}
*/

/*using System;

class Addition
{
    // Execution of app starts here
    static void Main()
    {
        int number1;
        int number2;
        int sum;

        Console.Write("Enter first integer: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine($"Sum is {sum}");
    }
}

*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine($"{sayi} çift bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} tek bir sayıdır.");
        }
    }
}*/

/*using System;
class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        if (IsAsal(sayi))
        {
            Console.WriteLine($"{sayi} asal bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} asal bir sayı değildir.");
        }
    }
    static bool IsAsal(int sayi)
    {
        if (sayi < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        if (IsAsal(sayi))
        {
            Console.WriteLine($"{sayi} asal bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} asal bir sayı değildir.");
        }
    }

    static bool IsAsal(int sayi)
    {
        if (sayi < 2)
        {
            return false;
        }

        for (int i = 2; i <= sayi / 2; i++)
        {
            if (sayi % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
*/

/*using System;

public class Account
{
    public string Name { get; set; }

    // auto-implemented property
    private decimal balance;

    // Account constructor that receives two parameters
    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance; // Changed to use the property to ensure validation
    }

    // Balance property with validation
    public decimal Balance
    {
        get { return balance; }
        private set
        {
            if (value >= 0.0m)
            {
                balance = value;
            }
        }
    }

    // Method that deposits (adds) a valid amount to the balance
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            Balance += depositAmount;
        }
    }
}
class Program
{
    static void Main()
    {
        Account myAccount = new Account("John Doe", 1000.0m);

        Console.WriteLine($"Initial balance of {myAccount.Name}: {myAccount.Balance}");

        myAccount.Deposit(500.0m);
        Console.WriteLine($"Balance after deposit: {myAccount.Balance}");
    }
}*/

/*using System;

class Account
{
    public string Name { get; set; }
    private decimal balance;

    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance;
    }

    public decimal Balance
    {
        get { return balance; }
        private set
        {
            if (value >= 0.0m)
            {
                balance = value;
            }
        }
    }

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            Balance += depositAmount;
        }
    }
}

class AccountTest
{
    static void Main()
    {
        Account account1 = new Account("Jane Green", 50.0m);
        Account account2 = new Account("John Blue", -7.53m);
        // Display initial balances of each object
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
        // Prompt for then read input
        Console.Write("Enter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"\nAdding {depositAmount:C} to account1 balance\n");
        account1.Deposit(depositAmount); // Add to account1's balance
        // Display balances
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
        // Prompt for then read input
        Console.Write("\nEnter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"\nAdding {depositAmount:C} to account2 balance\n");
        account2.Deposit(depositAmount); // Add to account2's balance
        // Display balances
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
    }
}
*/
/*
using System;

class Student
{
    public string Name { get; set; }
    private int average;

    public Student(string studentName, int studentAverage)
    {
        Name = studentName;
        Average = studentAverage;
    }

    public int Average
    {
        get { return average; }
        set
        {
            // Validate that value is between 0 and 100
            if (value >= 0 && value <= 100)
            {
                average = value;
            }
        }
    }

    public string LetterGrade
    {
        get
        {
            string letterGrade = string.Empty;

            // Determine letter grade based on the average
            if (average >= 90)
            {
                letterGrade = "A";
            }
            else if (average >= 80)
            {
                letterGrade = "B";
            }
            else if (average >= 70)
            {
                letterGrade = "C";
            }
            else if (average >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
    }
}

class StudentTest
{
    static void Main()
    {
        Student student1 = new Student("Jane Green", 93);
        Student student2 = new Student("John Blue", 72);

        Console.Write($"{student1.Name}'s letter grade equivalent of {student1.Average} is {student1.LetterGrade}");
        Console.WriteLine();
        Console.Write($"{student2.Name}'s letter grade equivalent of {student2.Average} is {student2.LetterGrade}");
    }
}
*/

/*
using System;

class ClassAverage
{
    static void Main()
    {
        // Initialization phase
        int total = 0;      // Initialize sum of grades entered by the user
        int gradeCounter = 1; // Initialize grade # to be entered next

        // Processing phase: Use counter-controlled iteration with a while loop
        while (gradeCounter <= 10) // Loop 10 times
        {
            // Prompt and input grade
            Console.Write("Enter grade: ");
            int grade = int.Parse(Console.ReadLine());

            total += grade; // Add the grade to total
            gradeCounter++; // Increment the counter by 1
        }

        // Termination phase
        int average = total / 10; // Integer division yields integer result

        // Display total and average of grades
        Console.WriteLine($"Total of all 10 grades is: {total}");
        Console.WriteLine($"Class average is: {average}");
    }
}
*/

/*using System;
class ClassAverage
{
    static void Main()
    {
        // Initialization phase
        int total = 0;      // Initialize sum of grades
        int gradeCounter = 0; // Initialize count of grades so far
        // Processing phase
        // Prompt for input and read grade from user
        Console.Write("Enter grade or -1 to quit: ");
        int grade = int.Parse(Console.ReadLine());
        // Loop until sentinel value is read from the user
        while (grade != -1)
        {
            total += grade; // Add grade to total
            gradeCounter++; // Increment counter

            // Prompt for input and read grade from user
            Console.Write("Enter grade or -1 to quit: ");
            grade = int.Parse(Console.ReadLine());
        }
        // Termination phase
        // If the user entered at least one grade
        if (gradeCounter > 0)
        {
            // Use number with decimal point to calculate average of grades
            double average = (double)total / gradeCounter;

            // Display the total and average with two digits of precision
            Console.WriteLine($"Total of the {gradeCounter} grades entered is: {total}");
            Console.WriteLine($"Class average is: {average:F}");
        }
        else
        {
            // No grades entered, so output error message
            Console.WriteLine("No grades were entered");
        }
    }
}
*/
/*
using System;
class Analysis
{
    static void Main()
    {
        // Initialize variables in declarations
        int passes = 0; // number of passes
        int failures = 0; // number of failures
        int studentCounter = 1; // student counter

        // Process 10 students using counter-controlled iteration
        while (studentCounter <= 10)
        {
            // Prompt user for input and obtain a value from the user
            // result (1 - pass, 2 - fail):
            Console.Write("Enter result (1 = pass, 2 = fail): ");
            int result = int.Parse(Console.ReadLine());

            // Increment appropriate counter based on user input
            if (result == 1)
            {
                passes++;
            }
            else
            {
                failures++;
            }

            // Increment studentCounter so loop eventually terminates
            studentCounter++;
        }

        // Termination phase; prepare and display results
        Console.WriteLine($"Passed: {passes}\nFailed: {failures}");

        // Determine whether more than 8 students passed
        if (passes > 8)
        {
            Console.WriteLine("Bonus to instructor!");
        }
    }
}
*/

/*using System;

class Increment
{
    static void Main()
    {
        // demonstrate post increment operator
        int c = 5; // assign 5 to c
        Console.WriteLine($"c before postincrement: {c}"); // displays 5
        Console.WriteLine($"postincrementing c: {c++}"); // displays 5, then increments c
        Console.WriteLine($"c after postincrement: {c}"); // displays 6

        // demonstrate prefix increment operator
        c = 5; // assign 5 to c
        Console.WriteLine($"c before preincrement: {c}"); // displays 5
        Console.WriteLine($"preincrementing c: {++c}"); // increments c, then displays 6
        Console.WriteLine($"c after preincrement: {c}"); // displays 6
    }
}
*/

/*using System;

class WhileCounter
{
    static void Main()
    {
        int counter = 1; // declare and initialize control variable

        while (counter <= 10) // loop-continuation condition
        {
            Console.Write($"{counter} ");
            ++counter;
        }

        Console.WriteLine(); // move to the next line after the loop
    }
}
*/
/*using System;

class ForCounter
{
    static void Main()
    {
        // for statement header includes initialization,
        // loop-continuation condition, and increment
        for (int counter = 1; counter <= 10; ++counter)
        {
            Console.Write($"{counter} ");
        }

        Console.WriteLine(); // move to the next line after the loop
    }
}
*/

/*using System;

class Sum
{
    static void Main()
    {
        int total = 0; // initialize total

        // total even integers from 2 through 20
        for (int number = 2; number <= 20; number += 2)
        {
            total += number;
        }

        // display result
        Console.WriteLine($"The sum of even integers from 2 through 20 is: {total}");
    }
}
*/
/*
using System;

class Interest
{
    static void Main()
    {
        decimal principal = 1000; // initial amount before interest
        double rate = 0.05; // interest rate

        // display headers
        Console.WriteLine("Year\tAmount on Deposit");

        // calculate amount on deposit for each of ten years
        for (int year = 1; year <= 10; ++year)
        {
            // calculate new amount for specified year
            decimal amount = principal * (decimal)Math.Pow(1.0 + rate, year);

            // display the year and the amount
            Console.WriteLine($"{year,4}\t{amount,20:C}");
        }
    }
}
*/

/*using System;

class DoWhileTest
{
    static void Main()
    {
        int counter = 1; // initialize counter

        do
        {
            Console.Write($"{counter} ");
            ++counter ; 
        } while (counter <= 10); // required semicolon

        Console.WriteLine();
    }
}
*/
/*
using System;

class LetterGrades
{
    static void Main()
    {
        int total = 0; // sum of grades
        int gradeCounter = 0; // number of grades entered
        int aCount = 0; // count of A grades
        int bCount = 0; // count of B grades
        int cCount = 0; // count of C grades
        int dCount = 0; // count of D grades
        int fCount = 0; // count of F grades

        Console.WriteLine("Enter the integer grades in the range 0-100.");
        Console.WriteLine("Type 'Ctrl' + 'Z' and press 'Enter' to terminate input:");

        string input = Console.ReadLine(); // read user input

        // loop until user enters the end-of-file indicator (Ctrl + Z)
        while (input != null)
        {
            int grade = int.Parse(input);
            total += grade; // add grade to total
            ++gradeCounter; // increment number of grades

            // read grade off user input
            switch (grade / 10)
            {
                case 10:
                    ++aCount;
                    break;
                case 9:
                case 8:
                    ++bCount;
                    break;
                case 7:
                    ++cCount;
                    break;
                case 6:
                    ++dCount;
                    break;
                default:
                    ++fCount;
                    break;
            }

            input = Console.ReadLine(); // read user input
        }

        // if user entered at least one grade
        if (gradeCounter > 0)
        {
            // calculate average of all grades entered
            double average = (double)total / gradeCounter;

            // output summary of results
            Console.WriteLine($"Total of the {gradeCounter} grades entered is {total}");
            Console.WriteLine($"Class average is {average:F}");

            // display number of students who received each grade
            Console.WriteLine($"Number of students who received each grade:");
            Console.WriteLine($"A: {aCount}");
            Console.WriteLine($"B: {bCount}");
            Console.WriteLine($"C: {cCount}");
            Console.WriteLine($"D: {dCount}");
            Console.WriteLine($"F: {fCount}");
        }
        else
        {
            // no grades were entered, so output appropriate message
            Console.WriteLine("No grades were entered.");
        }
    }
}
*/

