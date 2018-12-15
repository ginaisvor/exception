using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class DressCodeException : ApplicationException
    {
       private readonly string message = "You are not wearing an Elf costume and you are underaged.";

        public DressCodeException()
        {
            Console.WriteLine(message);
        }
    }


}
