namespace ChallengeApp.Tests
{
    public class Tests
    {
       
        [Test]
        public void Test1()
        {
            //arrange
            var employee = new Employee("Adam", "Niedzielski", 23);
            employee.AddScore(0);
            employee.AddScore(6);
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(-21);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(4, result);
            
        }
       
    }
}