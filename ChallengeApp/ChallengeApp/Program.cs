using static System.Runtime.InteropServices.JavaScript.JSType;

int numberOfDays = 7856;
Console.WriteLine("liczba dni = " + numberOfDays);
int numberOfYears = numberOfDays / 365;
Console.WriteLine("liczba lat = " + numberOfYears);
int numberOfWeeks = (numberOfDays - numberOfYears * 365) / 7;
Console.WriteLine("liczba tygodni = " + numberOfWeeks);
int remainedNumberOfDays = numberOfDays - numberOfYears * 365 - numberOfWeeks * 7;
Console.WriteLine("pozostała liczba dni = " + remainedNumberOfDays);