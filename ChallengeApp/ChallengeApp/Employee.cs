using System.Xml.Linq;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }


        public void AddGrade(float grade)
        {
            double valueInInt = (double)grade;


            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }

        }
        public void AddGrade(string grade)
        {
            if (byte.TryParse(grade, out byte result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not a float");
            }
        }
        public void AddGrade(double grade)
        {
            float ValueDouble = (float)grade;
            this.AddGrade(ValueDouble);
        }
        public void AddGrade(short grade)
        {
            float ValueShort = (float)grade;
            this.AddGrade(ValueShort);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }

}
