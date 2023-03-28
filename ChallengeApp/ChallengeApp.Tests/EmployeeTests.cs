namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
       
        [Test]
        public void GetStatisticsShouldGiveCorrectMax()
        {
            //arrange
            var employee = new Employee("Adam", "Niedzielski");
            employee.AddGrade(0);
            employee.AddGrade(6);
            employee.AddGrade(10);
            employee.AddGrade(9);
            employee.AddGrade(5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(10, statistics.Max);
            
        }
        [Test]
        public void GetStatiscticsShouldGiveCorrectMin()
        {
            //arrange
            var employee = new Employee("Adam", "Niedzielski");
            employee.AddGrade(0);
            employee.AddGrade(6);
            employee.AddGrade(10);
            employee.AddGrade(9);
            employee.AddGrade(5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(0, statistics.Min);

        }
        [Test]
        public void GetStatisticsShouldGiveCorrectAverage()
        {
            //arrange
            var employee = new Employee("Adam", "Niedzielski");
            employee.AddGrade(0);
            employee.AddGrade(6);
            employee.AddGrade(10);
            employee.AddGrade(9);
            employee.AddGrade(5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Average);

        }

    }
}