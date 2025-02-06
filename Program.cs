namespace creatingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tinder for lazy people.");

            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            person1.displayPersonInfo();
            person3.toString();
            person1.changeFavoriteColor();
            person1.displayPersonInfo();
            person4.getAgeInTenYears();

            Relation relation1 = new Relation(RelationshipTypes.Sister);
            Relation relation2 = new Relation(RelationshipTypes.Brother);

            relation1.showRelationshipType(person2, person4);
            relation1.showRelationshipType(person1, person3);

            Console.ReadLine();
        }
    }
}
