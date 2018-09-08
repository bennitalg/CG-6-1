using System;
using System.Text;

namespace CG_6_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create a program that asks the user to enter their first name. 
             * Then have it enter their last name. Create a method that combines the first and last name and 
             * returns it as a new value. Print the new value. This is like the previous class, but this time use StringBuilder.
            */

            //Create a program that asks the user to enter their first name. Then have it enter their last name            
            string firstName;
            string middleInit;
            string lastName;
            //string fullName;
            
            //Request user input of name
            Console.WriteLine("Hey You!");

            Console.Write("Tell me your first name: ");

            firstName = Console.ReadLine();

            Console.Write("Tell me your middle initial: ");

            middleInit = Console.ReadLine();

            Console.Write("Tell me your last name: ");

            lastName = Console.ReadLine();

            Console.WriteLine(FullName(firstName, middleInit, lastName));
            Console.ReadLine();
            //Print the new value. This is like the previous class, but this time use StringBuilder - 
            //it's like a class

            
        }

        //Create a method that combines the first and last name and returns it as a new value.
        public static string FullName( string firstName, string middleInit, string lastName)
        {
                      

            StringBuilder builder = new StringBuilder();
            builder.Append(firstName).Append(" ").Append(middleInit).Append(" ").Append(lastName);
            return builder.ToString();

            //string fullName;
            //fullName = firstName + "" + lastName;
            //return fullName;


        }
    }
}
