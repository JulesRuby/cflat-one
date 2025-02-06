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


        // Public Methods

        public void displayPersonInfo(int personId, string firstName, string lastName, string firstColor)
        {
            // Instructions feel a little bit unclear here, better ask mehdi to clarify
            string name = firstName + lastName;

            Console.WriteLine(
                $"Name: {name}\n" +
                $"Person ID: {personId}\n" +
                $"{name}'s favorite color is {favoriteColor}"
                );
        }

        // Setting a default to white, so it fulfills the rubric if nohing is passed in but has the potential to be useful otherwise
        public void changeFavoriteColor(string newColor = "white") 
        {

        }

        // Private Methods
        }

    }
}
