using static System.Runtime.InteropServices.JavaScript.JSType;

char znak = '/';
int wartość = (int)znak;
Console.WriteLine(wartość + " " + znak);
if ((64 < wartość && wartość < 91) || (96 < wartość && wartość < 123))
{
    Console.WriteLine("znak jest literą");
}
else if (48 <= wartość && wartość <= 57)
{
    Console.WriteLine("znak jest liczbą");
}
else
{
    Console.WriteLine("znak specjalny");
}

