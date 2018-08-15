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

           /*
            * Initally this is how I did the assignment, but I was so scared I would get points 
            * off for not including it in a method and returning a new value that I went ahead and 
            * put it inside a method. Just wanted to know if this was a correct way of 
            * tackling the assignment as well, so I left it in.
            
            //create StringBuilder to format name string
             StringBuilder fullName = new StringBuilder();

            //appends input to StringBuilder to create a full name string
             fullName.AppendFormat($"{firstName} {lastName}");

            //prints result, using FullName method
            Console.WriteLine($"Hello, {fullName}!");
            Console.ReadLine();
            
            */

            string name = FullName(firstName, lastName);
            Console.WriteLine($"Hello, {name}!");
            Console.ReadLine();
            
        }
            private static string FullName(string firstName, string lastName)
            {
                //creates a string builder to combine strings 
                 StringBuilder fullName = new StringBuilder();

                //combines strings and formats full name
                 fullName.AppendFormat($"{firstName} {lastName}");

                 //returns new StringBuilder value as string  
                 return fullName.ToString();
             }
         
        }

    }



    

