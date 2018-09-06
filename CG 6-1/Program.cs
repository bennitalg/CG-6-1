using System;

namespace CG_6_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine(“What’s In A Name?”);
            Console.Write(“Enter your first name:  “);
            string firstName = Console.Readline();
            Console.Write(“Enter your last name:  “);
            string lastName = Console.ReadLine();
            */


            //Declare a StringBuilder
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("What is your first name? ");
            builder.AppendLine();
            builder.Append("What is your last name? ");
            builder.AppendLine();

            // Get a reference to the StringBuilder's buffer content.
            string innerString = builder.ToString();

            // Display with Debug.
            System.Diagnostics.Debug.WriteLine(innerString);

            Console.ReadLine();
        }
    }
}
