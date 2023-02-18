// liczby całkowite
var myAge = 120;
int newAge = myAge + 4;
int newAge1 = myAge + 5;
int newAge2 = newAge + 4;
Console.WriteLine(newAge1);
Console.WriteLine(newAge2);
int myVar = int.MinValue;
int myVar2 = int.MaxValue;
Console.WriteLine(myVar);
Console.WriteLine(myVar2);
uint myVar3 = uint.MaxValue;
uint myVar4 = uint.MinValue;
Console.WriteLine(myVar3);
Console.WriteLine(myVar4);
long myVar5 = long.MinValue;
ulong myVar6 = ulong.MaxValue;
Console.WriteLine(myVar5);
Console.WriteLine(myVar6);
//liczby zmiennoprzecinkowe
float myNumber1 = float.MinValue;
double myNumber2 = double.MaxValue;
Console.WriteLine(myNumber1);
Console.WriteLine(myNumber2);
decimal myNumber3 = decimal.MinValue;
Console.WriteLine(myNumber3);

// tekst
string name = "Anna ";
string surname = "Hlond ";
string result = name + surname + myAge;
Console.WriteLine(result);
char myVar7 = 'c';
Console.WriteLine(myVar7);


char var10 = 'a';
Console.WriteLine(var10);

var result2 = name.ToArray();
Console.WriteLine(result2);

// zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);

var number1 = 5;
var number2 = 10;
if (number1 < number2)
{   
    Console.WriteLine("Jestem tutaj w linii 5");
 
}
else
{
    Console.WriteLine("Jestem tutaj w linii 58");

}
