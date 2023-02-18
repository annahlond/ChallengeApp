string name = "Ewa";
int age = 33;
char plec = 'K';

if (plec == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Nie jesteś kobietą poniżej 30 lat");
}

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("Nie jesteś 33 letnią Ewą");
}

if (plec == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Nie jesteś niepełnoletnim mężczyzną");
}

Console.WriteLine("Poniżej drugie rozwiązanie, bo nie byłam pewna czego oczekujesz:");

if (plec == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        if (plec == 'M' && age < 18)
        {
            Console.WriteLine("Niepełnoletni mężczyzna");
        }
        else
        {
            Console.WriteLine("Nie jesteś ani niepełnoletnim mężczyzną");
            Console.WriteLine("ani 33-letnią Ewą ani kobietą poniżej 30");
        }

    }
}

