using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Person
    {
        //Creating all three Classes Variables.
        private Home _home;

        //Propert Injection : ye niche variable ki value property injection se set hongi.
        private School _school;

        //Method Injection.
        //private Hospital _hospital;

        //Creating Property for Property Injection.
        public School Schools
        {
            set
            {
                //Variable = value given by user.
                _school = value;
            }
        }

        //Constructor.
        public Person(Home home_obj)
        {
            //Creating Objects of all three classes.
            _home = home_obj;



            //Method Injection : no need of below code of line.
            //_hospital = new Hospital();

            //Now because of property injection we do not need below code of line.
            //_school = new School();
        }


        //Home Method.
        public void TakeRefug()
        {
            //Here this is refering to Person class.
            _home.ProvideShelter(this);
        }

        //School Method.
        public void Study()
        {
            //Ho sakta h ki value set hi nhi hui ho to ..wo warning handle krne ke liye 
            //humne ye if statement use kiya.
            if(_school != null)
            {
                _school.Teach(this);
            }
            
        }


        //Hospial Method.
        //Applying Method Injection : jis method ko mujhe use krna h bas wahi method injection ka
        //use kr rhe h.
        public void GetTreatment(Hospital obj_hospital)
        {
            obj_hospital.Cure(this);
            //_hospital.Cure(this);  -- no need to write like this
        }




    }
}
