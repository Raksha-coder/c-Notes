using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Home
    {
        //Person class is depend on Home class.

        public void ProvideShelter(Person p)
        {
            Console.WriteLine("Home building");
        }
    }
}
