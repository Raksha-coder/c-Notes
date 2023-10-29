using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Hospital
    {
        //Person class is depend on Hospital class..
        public void Cure(Person p)
        {
            Console.WriteLine("Hospital Method callling");
        }
    }
}
