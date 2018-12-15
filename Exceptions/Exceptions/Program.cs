using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                int a = 100;
                int b = a / 0;
                Console.WriteLine(b);
            }
            catch(DivideByZeroException exception)
            {
                Console.WriteLine("Oops, something happend!");
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
            Console.WriteLine("_______________________________________");
            try
            {
                Person person1 = new Person(15);
                //Person person2 = new Person(-5);
                Person person3 = new Person(2);
                Person person4 = new Person(83);
            }
            catch(ArgumentException e)
            {
                
                //this will show all the error
                //Console.WriteLine(e);
                Console.WriteLine(e.Message + e.GetType());
                

            }

            catch (DressCodeException f)
            {
                Console.WriteLine(f.Message + f.GetType());
            }



        }
    }
}
