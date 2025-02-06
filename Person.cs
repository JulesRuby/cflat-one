using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingClasses
{
    internal class Person
    {
        // Constants (if applciable)
        // Fields
        // Do I need to place these in here, if they are implcitly generated when I declare the properties?
        int personId;
        string firstName;
        string lastName;
        string favoriteColour;
        int age;
        bool isWorking;

        // Properties
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }
        public int Age{ get; set; }
        public bool IsWorking{ get; set; }

        // Constructors
        public Person (int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColor = favoriteColor;
            Age = age;
            IsWorking = isWorking;
        }


        // Public Methods

        // Do I really need to make it accept these attributes when they are literally already in the object??
        public void displayPersonInfo(int personId, string firstName, string lastName, string firstColor)
        {
            // Instructions feel a little bit unclear here, better ask mehdi to clarify
            string fullName = firstName + lastName;

            Console.WriteLine($"{personId}: {fullName}'s favorite color is {favoriteColour}");
        }

        // Setting a default to white, so it fulfills the rubric if nohing is passed in but has the potential to be useful otherwise
        public void changeFavoriteColor(string newColor = "White") 
        {
            string changeOuputString = $"Favorite color changed from {favoriteColour} to {newColor}!";
            FavoriteColor = newColor;
        }

        public void getAgeInTenYears()
        {
            // This may throw an error because I'm not certain that string interpolation will implicitly cast other data types to strings
            Console.WriteLine($"{firstName + lastName}'s age in ten years will be {age + 10}");
        }

        // Asks to display all the person's Object information as a list. I need to ask a couple of question about this also:
        // Do they just mean a cvomma separated list? or like a List class object.
        // Also, when they ask to display all "Person Object Information", do they mean for me to include the methods?
        public void toString()
        {
            Console.WriteLine(this.ToString); // Lol will this do?
        }

        // Private Methods
        }

    }
}
