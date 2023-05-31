// See https://aka.ms/new-console-template for more information
/*****Important Things to Know About C#*******
* 
* 
* C# curly braces are used to define the scope of something. They say, all of the content inside of them relates to this one thing. Here all the code inside of the curly 
* braces relates to the Main(). 
* 
* A semicolon is used like a period to show the end of a line of code
* 
* C# largely ignores whitespace, except when inside of string (i.e. "Hello, world!" above)
* 
* C# is case sensitive meaning that example and Example could refer to different things. 
* 
* C# is type-safe which means when something is created you define what type of thing it is and it stays that type forever.
*/


//*******Variables******//
//A variable is just a container to hold information. When a container is created, you must define what type of data it will hold (type-safety).
//The data stored in a container can be changed. 
//Variables are traditionally defined using the camelCase naming convention. 
//Variable names can ....
//   - only begin with alphabetic characters or underscores
//   - cannot contain spaces
//   - must contain at least 1 alpha or numeric character
//   - cannot be a reserved keyword (i.e. class, static, void...all shown in dark blue)
//   - be unique within their scope {}

//When making a variable you go through three steps: Declaration, Initialization, and Assignment
//1. Declaration: this is when the container is created. It is given a name and a data type. 
string firstName;
int age = 34;
//2. Initialization: this is when the container is given a value for the first time. 
firstName = "Chris";
Console.WriteLine(firstName + " is " + age);
//3. Assignment: giving the container a new value, after the first time
firstName = "Kevin";
Console.WriteLine(firstName + " is " + age);


//***Creating Variables***//
//declaration - data type then name (camelCase) 


//initialization 


//assignment




//*****Declaring Multiple Variables****//
//You can make many variables at one time but have to use the same type (string or int)
string myName, lastName, order, time;

myName = "Chris";
lastName = "Randall";
order = "Bacon Burger";
time = "11p";

Console.WriteLine (myName + " " + lastName + " order a " + order + " @ " + time);
//You can also declare and initialize many variables at the same time or do a mix of both




//*****Constants****//
//You can declare variables whose value never changes. These are called constants and they must be declared and initialized at the same time.
int myInt = 3;
myInt = 4;
/*the default data type for decimals is double so if you want to store a decimal
in a different type you have to explicitly call it what it is */

float myFloat = 4.4f;
double myDouble = 5.5;
decimal myDecimal = 7.5m;
bool myBool = false;

char myChar = 'A'; //char must be in single quotes


//If you try to redefine a const it will crash the program
const int myNumber = 1;
// myNumber = 2; (this will crash the program because the const has already been declared.


//****Literal Values****//
//difference between variables and literal values
Console.WriteLine(myNumber + 2) //This will add the variable number and 2 and output the sum which is 3.
Console.WriteLine(myNumber + "2") //this will combine the numbers to create a string resulting in the output being 12


//***Difference Between String and Int***//
//Strings store an unlimited number of text characters (alpha, numeric, and symbols)
//Ints store only numeric values 


//Add two ints together



//***Generating Output***//
Console.WriteLine("Hello, World!");

