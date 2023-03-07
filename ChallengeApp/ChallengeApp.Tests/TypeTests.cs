namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        //TESTY REFERENCYJNE
        [Test]

        public void WhenTwoUsersAreNotTheSamePersonGiveResult()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            //act


            //assert
            Assert.AreNotEqual(user1, user2);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
        //TESTY WARTOŚCIOWE
        [Test]

        public void WhenTwoNumbersAreTheSameGiveResult()
        {
            //arrange
            float check1 = 2.4f;
            double check2 = 2.4f;
            //act


            //assert
            Assert.AreEqual(check1, check2);
        }
        [Test]

        public void WhenTwoStringsAreTheSameGiveResult()
        {
            //arrange
            string string1 = "Wojciech";
            string string2 = "Wojciech";
            //act


            //assert
            Assert.AreEqual(string1, string2);
        }

    }
}
