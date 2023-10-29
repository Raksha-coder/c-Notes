using System;
using Dependency_Injection;

namespace MyApp 
{
    /*I am creating person class which is depend on three other classes home,scholl,hospital
     where the object of person class created -- the object of all this three classes is also created 
    by using person constructor . there are also 3 more methods */


    /*There are 3 types of Dependency Injection for implementation: 
     
     - Constructor Injection.
     - Property Injection.
     - Method Injection.



    1. Constructor Injection : Provide Dependency at the time of initialization as a parameter in 
    constructor. (Constructor ke time pe, hum classes ke objects ko create kr sakte h )
    Example : 
    Here there is a class called Person, in his constructor we are passing object initialization 
    of HOME class as a paramer.

    ** Before 
    public Person()
    {
            _home = new Home();
    }


    **After
    public Person(Home home)
    {
          _home = home;
    }


    Note : yaha object khud nhi creater ho rha h (after mai) user object ko provide kr rha h externlly
    means inject kr rha h . 

    like : in main(){
         //Here creating the object of home class and passing it to Person class.
          Home obj_home =  new Home();
          Person obj_person = new Person(obj_home);
    }







    2. Property Injection : Provide Dependency as a Property to the class after initializing it.
    isme hum ek public property bana denge jisme koi bhi value ko set kr sakta h and jo use krna
    chahata h wo apne hisab se value set krke use kre.
    Example :
    **Before 
     public Person()
        {
            //Now because of property injection we do not need below code of line.
            //_school = new School();
        }

    **After
     public School Schools
        {
            set
            {
                //Variable = value given by user.
                _school = value;
            }
        }

    Note : if(_school != null) : there is possiblity ki user property ki value set hi na kre 
    to usko handle krne ke liye hum if statemet use krte h.pehle hum constructor se object bana 
    rhe the but ab hum property ki help se object create kr rhe h(assign kr rhe h).




    3. Method Injection : Provide dependency directly in the method (not the class) needing
    it as a parameter.jab depdendency single method m use ho rhi ho. Jab zarurat ho tab hi method ka
    use ho uske baad nhi.
    Example: person roz school and home jata h but hospital rare case mai jata h.
    yaha just class ko method mai pass kr do
    public void GetTreatment(Hospital obj_hospital)
        {
            obj_hospital.Cure(this);
            //_hospital.Cure(this);  -- no need to write like this(ab constructor mai likhne ki zrurat nhi)
        }







   
    
    ------------------------------------------------------------------------------------------------
     ***** Highly Coupled means ===  both classes depend on each other **********

    😁we use interfaces a lot in dependencies injection kyuki inerfaces kafi had tak coupling kam
    krte h.


     
     */
    public class Program
    {
        static void Main(string[] args)
        {
            Home obj_home = new Home();
            Person obj_person = new Person(obj_home);

            //person object.Schools property = new school object(means value set);
            obj_person.Schools = new School();
            obj_person.Study();


        }
    }
}