using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_input;

            do
            {
                Console.WriteLine("Enter your name!");
                string name = Console.ReadLine();
                Console.WriteLine("Hi, Good Day " + name + "!"); 

                while (true)
                {
                    Console.WriteLine("Would you like to greet as someone else?  (yes/no)");

                    user_input = Console.ReadLine().ToLower();

                    if (user_input == "yes")
                    {
                        Console.WriteLine();
                        break;
                    }
                    else if (user_input == "no")
                    {
                        Console.WriteLine("Bye Bye");
                        return;

                    }
                    else { 
                        Console.WriteLine("You need to type yes/no only idiot!");
                        Console.WriteLine("___________________________________");
                        Console.WriteLine();
                    }
                    
                }
                


            }


            while (true);
        }
    }
}

            



           
            
       

