using System.Runtime.CompilerServices;

namespace creatingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tinder for families... wait, gross nevermind.");

            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //List<Person> people = JsonHelper.ConvertJsonToPeople("people.json");

            //string people = JsonHelper.ConvertJsonToPeople("morbo");

            person1.displayPersonInfo();
            person3.toString();
            person1.changeFavoriteColor();
            person1.displayPersonInfo();
            person4.getAgeInTenYears();

            Relation sisters = new Relation(RelationshipTypes.Sister);
            Relation brothers = new Relation(RelationshipTypes.Brother);

            sisters.showRelationshipType(person2, person4);
            brothers.showRelationshipType(person1, person3);


            // Have to table my fun idea and just do a normal List<> thing
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            double averageAge = people.Average(person => person.Age);
            Console.WriteLine($"The average age of these people is {averageAge}\n");

            Person oldest = people.OrderByDescending(person => person.Age).First();
            Person youngest = people.OrderByDescending(person => person.Age).Last();
            Console.WriteLine($"The oldest person is: {oldest.FirstName}\n");
            Console.WriteLine($"The youngest person is: {youngest.FirstName}\n");

            //List<Person> mNames = people.Where(person => person.FirstName[0] == "M");
            List<Person> mNames = people.Where(person => person.FirstName.StartsWith("M")).ToList();
            mNames[0].displayPersonInfo();

            foreach (Person person in mNames)
            {
                person.toString();
            }

            List<Person> blueLovers = people.Where(person => person.FavoriteColor == "Blue").ToList();

            foreach (Person person in blueLovers)
            {
                person.toString();
            }

            Console.WriteLine("Okay press buttons and I'll go away...");
            Console.ReadLine();
        }
    }
}
