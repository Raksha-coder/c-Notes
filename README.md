# c# Notes

🤩🤩 All Shortcuts of Visual Studio
ctrl + r = to select multiple word and edit them.

🤩Exception handling 

string mynum = Console.ReadLine();   // "abcd" = false : not converted to int

int convertedtoInt;
bool ans = int.TryParse(mynum, out convertedtoInt);
if(!ans){   //if the conversion fails
	throw new Exception("conversion is unsuccessful");
 			//it(Exception("some")) is the constructor .
}

note : exception is actually a class which we use to made our custom exception. the above is the unhandled exception , so we will use try,catch.



🤩TRY CATCH FINALLY

try{

	string mynum = Console.ReadLine();   // "abcd" = false : not converted to int

	int convertedtoInt;
	bool ans = int.TryParse(mynum, out convertedtoInt);
	if(!ans){   //if the conversion fails
		throw new Exception("conversion is unsuccessful");
	 			//it(Exception("some")) is the constructor .
	}
}catch(Exception ex){

	Console.WriteLine("There is an Exception : {0}",ex.Message);

}
//console.WriteLine("the rest of the application will still runs");
finally{

 	console.WriteLine("the rest of the application will still runs");

}

note : if we do not use try catch , then the last console.writeLine() will not execute or the rest of the application will get crash. 
- finally will run the rest of the code whethere it will get the error or not.
note : https://www.tutorialsteacher.com/csharp/csharp-exception-handling , https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements  for more documentation.




->>>> A when exception filter :
try
{
    var result = Process(-3, 4);
    Console.WriteLine($"Processing succeeded: {result}");
}
catch (Exception e) when (e is ArgumentException || e is DivideByZeroException)
{
    Console.WriteLine($"Processing failed: {e.Message}");
}






🤩 string builder
- strings are immutable(unchangable), if we create another string , it will be created on heap(new memory location),so add,remove is difficult . to solve this problem we have stringBuilder , it is a dynamic Object . if we add, remove or moade some changes in the string , it will refer to the same location .

StringBuilder FullName = new StringBuilder();
FullName.Append("Raksha");
FullName.Append(" ");
FullName.Append("Jaiswal");

-  it will improve the performance.



🤩String Manipulation,Formatting.

1) Equals = return the type of bool
-- In C#, Equals(String, String) is a String method. It is used to determine whether two String objects have the same value or not. Basically, it checks for equality. If both strings have the same value, it returns true otherwise returns false.

   
string one = "sometext";
string two = "sometext";
bool isEqual = one.Equals(two);   
bool isEqual = one.Equals(two,StringComparison.Ordinal);    // (i == I) false
bool isEqual = one.Equals(two,StringComparison.OrdinalIgnoreCase); // it will ignore the (i == I) is true here;


Input:          string str1 = "ProGeek 2.0";
                string str2 = "ProGeek 2.0";
                string.Equals(str1, str2)
Output:         True

Input:          string str3 = "GFG";
                string str4 = "others";
                string.Equals(str3, str4)
Output: 	False



Note : Equals(String, StringComparison)
- A parameter specifies the culture, case, and sort rules used in the comparison.
- we have two more optons in place of second parameter like StringComparison.CurrentCulture , StringComparison.InvariantCulture.

2) Concate strings

string firstname = "Raksha";
string lastname = "jaiswal";
string Formatted = string.Format("{0} {1} some text here ",firstname, lastname);
console.WriteLine(Formatted);

3)string Length and index and substring(part of string)

string firstname = "Raksha";
console.WriteLine(firstname.Length); length start from 1
console.WriteLine(firstname[0]);     index start from 0


string sometext = "hello i am Raksha";
console.WriteLine(sometext.Substring(11,6) );      
o/p : Raksha
//substring(startindex,length);


note : string have length and indexes.

4) ToLower() and ToUpper()
string firstname = "Raksha";
console.WriteLine(firstname.ToLower() );
console.WriteLine(firstname.ToUpper() );

5) string.Empty

string one= "";
string one = string.Empty;

6) string Replace()

string one = "One is the zerooo";
console.WriteLine(one.Replace("zerooo","best"));
 //     oldsubstring, newsubstring





🤩Methods to convert String into int
- Basically there are 3 methods and TryParse is the best method to use.
- int.Parse(), int.TryParse(), and Convert.ToInt32() methods.

#Method1:
string numberString = “8”;
int i = int.Parse(numberString); 
Console.WriteLine("Value of i: {0}", i);

disadvantage : The downside of using the int.Parse() method is that an exception will be thrown if it cannot be successfully parsed to an integer. To avoid this issue, you can use a try-catch block while using int.Parse().

#Method2:
string numString = "123";
int num = Convert.ToInt32(numString);

Convert.ToInt32() is a static method provided by C# to convert a string to a 32-bit signed integer. This method takes a string variable as input and returns an integer.

disadvantage : this method has two exceptions, FormatException and OverflowException and is able to convert a null variable to 0 without throwing an exception.

#Method3:
Compared to the int.Parse() method, int.TryParse() is a safer way to convert a string to a 32-bit signed integer.This method takes in a string variable and an out parameter and returns a bool of value true if the parsing is successful. The result of the parsing is stored in an out parameter.
string numString = "12";

if (int.TryParse(numString, out int num))
{
	// Conversion successful, do something with num.
    Console.WriteLine("Successful");
    Console.WriteLine(num);
}
else
{
	// Conversion failed, handle the error.
    Console.WriteLine("Unsuccessful..");
}
note here : if the coversion fails then it return zero(0) or use input some letter instead of "123" then it will return zero.






🤩Dependency Injection 

what is dependency ? what is coupling? why do we use dependency injection?
When One class depend on another class for their properties and Methods,this leads to Coupling. In coupling there is high maintenance cost because if I change something in parent class, the changes should be visible in all other classes that are depend on that parent class so developer introduce dependency injection design pattern to reduce coupling between classes. It provide dependencies to classes without high coupling and it can be implemented without any third party library.

/*I am creating person class which is depend on three other classes home,scholl,hospital
     where the object of person class created -- the object of all this three classes is also created 
    by using person constructor . there are also 3 more methods */


    There are 3 types of Dependency Injection for implementation: 
     
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




    => Highly Coupled means ===  both classes depend on each other 
    =>we use interfaces a lot in dependencies injection kyuki inerfaces kafi had tak coupling kam
    krte h.














-----------------------------------------------------------------------Web API in .NET Core:


var builder = WebApplication.CreateBuilder(args);



//Adding Controller : add services(business logic) and API 
/*
 
The AddController method(actually it is MvcServiceCollectionExtensions.
AddControllers) registers everything that is needed for Web API Development. 
The services include Support for Controllers(API's), 
Model Binding, API Explorer, Authorization, CORS, Validations, Formatter Mapping, etc.
 
AddControllers(){


        AddMvcCore()
        --AddApiExplorer()
        AddAuthorization()
        AddCors()
        AddDataAnnotations()
        AddFormatterMappings()
}


All these methods are chained and called inside 
the parent wrapper extension method that is AddControllersCore() 
which is called from the AddControllers() method.
 





//Register everything that is needed for WEB API  WITH DEPENDENCY injection.
//Add services to container.
builder.Services.AddControllers();


//In APIs, an endpoint is typically a uniform resource locator (URL)
//that provides the location of a resource on the server.
//Configuring swagger
builder.Services.AddEndpointsApiExplorer();  //support minimal API.
builder.Services.AddSwaggerGen();





var app = builder.Build();

//This line checks if your web application is running in a "development" environment
//there are different environments like development, production, and testing
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //If the application is in the development environment, this line enables Swagger.
    //Swagger is a framework for API documentation. It generates a user-friendly interface that
    //allows developers to explore, test, and understand the APIs exposed by your application.

    app.UseSwaggerUI();
    //provides a ***web page**** where you can see and interact with your API documentation.

}




app.UseHttpsRedirection();
//it will automaticatically change http to https protocol for security purpose.





app.UseAuthorization();
//this will check if the user have permission for accessing the website or not
//this include authentication and authorization




app.MapControllers();
// This line is crucial for routing HTTP requests to the right parts of your application.
// When a user makes a request (e.g., opening a webpage or submitting a form),
// this line ensures that the request goes to the appropriate code in your application 


app.Run();
//it will run the application





 */



    //it marks a class as a special class that handle http request and response 
    //this is where we handle web request.
    [ApiController]


    // it defines how the controller can be accessed through a URL.
    //The [controller] placeholder is replaced with the name of the controller
    //class. For example, if you have a controller named "ProductsController,"
    //it would be accessible at a URL like "/Products."

    [Route("[controller]")]


    /*
     |^^^^^^^|
     So, together, these  above attributes are saying, "This class is a controller(API), 
    and it can be accessed at a URL based on its name."
     */





     
    
