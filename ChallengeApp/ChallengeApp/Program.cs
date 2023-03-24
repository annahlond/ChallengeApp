
using ChallengeApp;


Employee employee1 = new Employee("Adam", "Michalski", 34);
Employee employee2 = new Employee("Anna", "Hlond", 53);
Employee employee3 = new Employee("Michał", "Polański", 41);



employee1.AddScore(1); 
employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(9);
employee1.AddScore(10);
employee2.AddScore(10);
employee2.AddScore(1);
employee2.AddScore(8);
employee2.AddScore(4);
employee2.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(8);
employee3.AddScore(7);
employee3.AddScore(2);
employee3.AddScore(1);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};


int maxResult = 0;
Employee employeeWithMaxResult= null;

foreach(var employee in employees)
{
    
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult= employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Najwyższy wynik osiągnął: ");
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age);
Console.WriteLine("z wynikiem: " + maxResult);




