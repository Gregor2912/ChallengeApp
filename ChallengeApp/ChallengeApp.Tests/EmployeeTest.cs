namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void ResultShouldCheckOperationMinMaxAverage()
        {
            var klient = new Employee("Ewa", "Soroka");
            var klient2 = new Employee("Adam", "Soroka");
            klient.AddGrade(5);
            klient.AddGrade(-4);
            klient2.AddGrade(4);
            klient2.AddGrade(10);


            var klientM = klient.GetStatistics();
            var klientW = klient2.GetStatistics();
            Assert.AreNotEqual(klientM.Min, klientW.Max);
            Assert.AreEqual(klientW.Min, 4);
            Assert.AreEqual(klientW.Average, 7);
        }

    }
}
