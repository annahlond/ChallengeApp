﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname= surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100) 
            {
                this.grades.Add(grade);
            }
            else
            { 
                Console.WriteLine("Ta liczba nie mieści  sie w przedziale od 0 do 100");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("This string is not a float");
            }
        }

        public void AddGrade(double grade)
        {
            var value = Convert.ToSingle(grade);
            this.AddGrade(value);
        }
        public void AddGrade(long grade)
        {
            var value = Convert.ToSingle(grade);
            this.AddGrade(value);
        }


        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max= float.MinValue;
            statistics.Min= float.MaxValue;

            foreach(var grade in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average+= grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
            
      

    }
}
