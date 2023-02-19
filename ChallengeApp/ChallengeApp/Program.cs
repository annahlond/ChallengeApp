using static System.Runtime.InteropServices.JavaScript.JSType;

char temperatureScale = 'F';
float temperature = 36.7f;
if (temperatureScale == 'C')
{
    float convertedTemperature = temperature * 1.8f +32;
    Console.WriteLine(temperature + "C = " + string.Format("{0:N1}", convertedTemperature) + 'F');
}
else
{
    float convertedTemperature = (temperature - 32) / 1.8f;
    Console.WriteLine(temperature + "F = " + string.Format("{0:N1}", convertedTemperature) + 'C');
}