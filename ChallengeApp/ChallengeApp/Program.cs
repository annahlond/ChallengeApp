int number = 1340024;
string numberAsString = number.ToString();
int backwardNumber = 0;
Console.WriteLine(number);

for (int i = 0; i < numberAsString.Length; i++)
{
    int digit = number % 10;
    number = number / 10;
    backwardNumber = backwardNumber * 10 + digit;

}
Console.WriteLine(backwardNumber);

