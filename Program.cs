using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            // Prompt the user for input
            Console.WriteLine("Enter the professor's LNumber:");
            string lNumber = Console.ReadLine();

            Console.WriteLine("Enter the professor's first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the professor's last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the professor's department:");
            string department = Console.ReadLine();

            // Create a new Professor object with the user's input
            Professor p = new Professor(lNumber, firstName, lastName, department);

            // Print out the Professor object's information
            Console.WriteLine(p.ToString());

            // Ask the user if they want to play again
            Console.WriteLine("Do you want to enter another Professor? (Y/N)");
            string playAgain = Console.ReadLine().ToUpper();

            if (playAgain != "Y")
            {
                break;
            }
        } while (true);
    }
}
