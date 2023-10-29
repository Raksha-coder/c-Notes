using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class School
    {
        //Person class is depend on School class.
        //Highly Coupled means ===  both classes depend on each other
        //Here Person class is highly depend on all three classes.
        public void Teach(Person p)
        {
            Console.WriteLine("Study");
        }
    }
}
