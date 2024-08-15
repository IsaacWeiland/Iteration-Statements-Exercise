namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature:void PrintNumbers()
        public static void PrintNumbers()
        {
            
            for (int to1K = 1000; to1K >= -1000; to1K--)
            {
                Console.WriteLine(to1K);
            }
        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumber()
        {
            for (int third = 3; third <= 999; third += 3 )
            {
                Console.WriteLine(third);
            }
        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive(int number)
        {
            while (number == 0)
            {
                Console.WriteLine("Exception 0 enter new number");
                number = int.Parse(Console.ReadLine());
            }
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int number)
        {
            if (number >= -10 && number <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {number * i}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            Console.WriteLine("Select Method");
            string selection = null;
            while (selection != "exit")
            {
                selection = Console.ReadLine();

                switch (selection.ToLower())
                {
                    case "print numbers":
                        PrintNumbers();
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                    case "print every third number":
                        PrintEveryThirdNumber();
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                    case "are numbers equal":
                        Console.WriteLine("Choose two numbers.");
                        Console.WriteLine(AreNumbersEqual(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine())));
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                    case "is even":
                        Console.WriteLine("Please choose a number.");
                        Console.WriteLine(IsEven(int.Parse(Console.ReadLine())));
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                    case "is positive":
                        Console.WriteLine("Please choose a number.");
                        Console.WriteLine(IsPositive(int.Parse(Console.ReadLine())));
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                    case "can vote":
                        Console.WriteLine("Please enter an age.");
                        Console.WriteLine(CanVote(int.Parse(Console.ReadLine())));
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                    case "is in range":
                        Console.WriteLine("Please choose a number.");
                        Console.WriteLine(IsInRange(int.Parse(Console.ReadLine())));
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                    case "display multiplication table":
                        Console.WriteLine("Please choose a number.");
                        DisplayMultiplicationTable(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Invalid method.");
                        Console.WriteLine("Choose another method.\nExit to close");
                        break;
                }
            }
        } 
        
    }
}
