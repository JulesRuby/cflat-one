using System;

namespace creatingClasses
{
    // Let's try to use an enum for valid RelationshipTypes
    enum RelationshipTypes
    {
        Sister,
        Brother,
        Mother,
        Father
    }

    internal class Relation
    {
        public RelationshipTypes RelationshipType { get; set; }

        public Relation(RelationshipTypes relationshipType)
        {
            RelationshipType = relationshipType;
        }

        public void showRelationshipType(Person person1, Person person2)
        {
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is {RelationshipType}hood\n");
        }
        // private
    }
}

