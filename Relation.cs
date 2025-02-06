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
        // constants
        // fields
        //public string relationshipType;

        // properties
        public RelationshipTypes RelationshipType { get; set; }

        // constructor
        public Relation(RelationshipTypes relationshipType)
        {
            RelationshipType = relationshipType;
        }

        // public
        public void showRelationshipType(Person person1, Person person2)
        {
            // Will code this part in once I get a better idea of how this is connected.
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is {RelationshipType}hood\n");
        }
        // private
    }
}

