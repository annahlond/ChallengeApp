namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
       
        [Test]
        public void SumOfGradesShouldGetCorrectResult()
        {
            //arrange
            var employee = new Employee("Adam", "Niedzielski");
            employee.AddGrade(0);
            employee.AddGrade(6);
            employee.AddGrade(10);
            employee.AddGrade(9);
            employee.AddGrade(-25);

            //act
            

            //assert
           // Assert.AreEqual(0, result);
            
        }
       
    }
}