using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserColletTwoSetOfPoints_ShouldReturnCorrectSumAsResult()
        {
            //arrange
            var user = new User("Adam", "sdsds");
            var user2 = new User("Ewa", "sdsds");
            user.AddScore(5);
            user2.AddScore(6);
            //act
            var result = user.Result;
            var result2 = user2.Result;

            //assert
            Assert.AreEqual(5, result);
            Assert.AreEqual(6, result2);

        }
        [Test]
        public void WhenUserColletTwoSetOfPoints_ShouldReturnCorrectSumAsResult2()
        {
            //arrange
            var user = new User("Adam", "sdsds");
 
            user.AddScore(5);
            user.AddScore(-8);
            user.AddScore(2);
            //act
            var result = user.Result;
            //assert
            Assert.AreEqual(-1, result);
            

        }

    }
}