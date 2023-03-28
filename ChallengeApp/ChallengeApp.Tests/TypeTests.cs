
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void IsUser1EqualUser2()
        {
            //arrange
            var user1 = GetUser("Adam", "haslo1");
            var user2 = GetUser("Monika", "haslo2");

            //act
            

            //assert
            Assert.AreEqual(user1.Login, user2.Login);

        }
        private User GetUser(string login, string password)
        {
            return new User(login, password);
        }

    }
}
