/*Write a program in C# Sharp to print numbers from n to 1 using recursion.
 * Test Data :
    * How many numbers to print : 10
    * Expected Output : 10 9 8 7 6 5 4 3 2 1*/

namespace CCAD16_Assignment5_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers to print: ");
            int numSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You chose to print {numSelection} numbers");

            displayNumbers(numSelection);
        }

        static int displayNumbers(int ctr)
        {
            if (ctr < 1)
            {
                return ctr;
            }

            Console.WriteLine(ctr);
            return displayNumbers(ctr - 1);
            
        }
    }
}
