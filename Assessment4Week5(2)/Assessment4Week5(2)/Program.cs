using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4Week5_2_
{
    class Program
    {
        static void Main(string[] args)
        {
        }/*S - both the interface and the Square class only hold values and
               methods related directly to the use of that object. they are
               single use
           O - the fields and methods used within interfaces ensure that implementing
               them means that you are restricted in what you can do. In addition,
               having private fields makes sure that you can only access them as 
               needed, yet you can always extend either class. this is open and closed
           L - any class that is derived from the square can be substituted for 
               another
           I - The interface here does not contain any methods that would not be
               applicable to the classes that implement it
           D - and our hierachy at the moment is good such that we have no
               dependent children classes and all could be substituted, we can think of
               the interface as the abstraction*/
    }
}
