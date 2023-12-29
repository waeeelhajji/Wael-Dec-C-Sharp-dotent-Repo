// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//! DataTypes

// Javascript

// var name = "hello";

// == or ===

// Python

// name = "hello"

// statically typed Language
// You have a  to specify the type of variables or function you want to declare or Create


string name = "Wael";
int number = 7;
double dec = 3.14;
float floatvalue = 1.2f;
bool isTired = true;

//!-------------------
// Lists and Dictionaries
// Arrays and List
// Arrays are fixed length
string[] groceryList = new string[4];
// [null,null,null,null]
string[] groceryList2 = { "Carrots", "Turkey", "Bread", "Milk" };
//-------------------------0          1         2          3


groceryList2[2] = "Ham";
groceryList[2] = "Ham";
// [null,null,"Ham",null]
Console.WriteLine(groceryList2[1]);
Console.WriteLine(groceryList2.Length);


// Lists are variable length

List<int> numberList = new List<int>();
// add to the array
numberList.Add(3);
numberList.Add(4);
numberList.Add(5);
numberList.Add(6);
// this removes the value of 3
numberList.Remove(5);
// Remove at the location of index
// numberList.RemoveAt(3);
//
numberList.Insert(1, 77);
Console.WriteLine(numberList);
foreach (int i in numberList)
{
    Console.WriteLine(i);

}
// Fun Fact about C#

// string contains multiple letters
string doblequotation = "Hello";

// char uses  or contain one character
// uses one Quotation
char singleChar = 'd';

// Functions

static void HelloCSharp()
{
    Console.WriteLine("Welcome to C#");

}
HelloCSharp();

// ----------------parameters in C#
static int DoMatch(int x, int y)
{
    return x + y;
}

Console.WriteLine(DoMatch(13, 17));

int answer = DoMatch(10, 77);

Console.WriteLine(answer);
