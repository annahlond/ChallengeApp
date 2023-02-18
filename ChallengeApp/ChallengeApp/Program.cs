// lista, tablica, for, foreach
int[] grades = new int[365];
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "Monday";
dayOfWeek[1] = "Tuesday";
dayOfWeek[2] = "Wednesday";
dayOfWeek[3] = "Thursday";
dayOfWeek[4] = "Friday";
dayOfWeek[5] = "Saturday";
dayOfWeek[6] = "Sunday";
Console.WriteLine(dayOfWeek[2]);

string[] dayOfWeek1 = {"poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela"};
Console.WriteLine(dayOfWeek1[3]);

List<string> dayOfWeek2 = new List<string>();
dayOfWeek2.Add("poniedziałek");
dayOfWeek2.Add("wtorek");
dayOfWeek2.Add("środa");
dayOfWeek2.Add("czwarek");
dayOfWeek2.Add("piątek");
dayOfWeek2.Add("sobota");
dayOfWeek2.Add("niedziela");

for (var i = 0; i < 7; i = i + 2)
{
    Console.WriteLine(dayOfWeek2[i]);
}


for (int i = 0; i < dayOfWeek.Length; i++)
{
    Console.WriteLine(i);
    Console.WriteLine(dayOfWeek[i]);
    Console.WriteLine(dayOfWeek1[i]);

}

Console.WriteLine("poniżej foreach");

foreach (var day in dayOfWeek2)
{
    Console.WriteLine(day);

}
