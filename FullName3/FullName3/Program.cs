using System;
using System.Text;




namespace FullName3
{
    class Program
    {
        static void Main(string[] args)
        {


            //ask user for first name
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();


            //ask user for last name
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            //create StringBuilder to format name string
             StringBuilder fullName = new StringBuilder();

            //appends input to StringBuilder to create a full name string
             fullName.AppendFormat("{0} {1}", firstName, lastName);

            //prints result, using FullName method
            Console.WriteLine($"Hello, {fullName}!");
            Console.ReadLine();


            /*ok, I'm not sure if i'm complete the assignment correctly because...
            do I need to put the string builder inside a method? 
            I did this just to make sure that I'm creating a method that combines the name 
            and returns a new value (so I don't get points off) .
            I've tested this and it works; the only thing I would need to do (besides uncommenting the method)
            is remove an extra curly brace below the method.

            This is basically what the program would look like without line 25,28,31, & 32.
            
            
            string name = FullName(firstName, lastName);
            Console.WriteLine($"Hello, {name}!");
            Console.ReadLine();
            
        }
            private static string FullName(string firstName, string lastName)
            {
                 StringBuilder fullName = new StringBuilder();
                 fullName.AppendFormat("{0} {1}", firstName, lastName);

                 //returns new StringBuilder value as string  
                 return fullName.ToString();
             }
         
               
            */
        }

    }
}


    

