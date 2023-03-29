using ChallengeApp;


var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade("2000");
employee.AddGrade(3);
employee.AddGrade(6);
employee.AddGrade("Adam");
employee.AddGrade(1000);
employee.AddGrade(60);
employee.AddGrade(-9223372036854775808);
employee.AddGrade(60.2587858455452528777770000055);
employee.AddGrade(60);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");




