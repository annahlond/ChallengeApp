int number = 43556160;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int[] countOfCyfra = new int[10];

for (int i = 0; i < letters.Length; i++)
{
    if (letters[i] == '0')
    {
        countOfCyfra[0]++;
    }
    if (letters[i] == '1')
    {
        countOfCyfra[1]++;
    }
    if (letters[i] == '2')
    {
        countOfCyfra[2]++;
    }
    if (letters[i] == '3')
    {
        countOfCyfra[3]++;
    }
    if (letters[i] == '4')
    {
        countOfCyfra[4]++;
    }
    if (letters[i] == '5')
    {
        countOfCyfra[5]++;
    }
    if (letters[i] == '6')
    {
        countOfCyfra[6]++;
    }
    if (letters[i] == '7')
    {
        countOfCyfra[7]++;
    }
    if (letters[i] == '8')
    {
        countOfCyfra[8]++;
    }
    if (letters[i] == '9')
    {
        countOfCyfra[9]++;
    }
    
}

for (int cyfra = 0; cyfra < 10; cyfra++)
{
    Console.WriteLine(cyfra + "=>" + countOfCyfra[cyfra]);
}

