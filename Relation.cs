using System;

namespace creatingClasses
{
    internal class Relation
    {
        // constants
        // fields
        public string relationshipType;

        // properties
        public string RelationshipType { get; set; }

        // constructor
        public Relation(string relationshipType)
        {
            RelationshipType = relationshipType;
        }

        // public
        public void showRelationshipType(Person person1, Person person2)
        {
            // Will code this part in once I get a better idea of how this is connected.
        }
        // private
    }
}

