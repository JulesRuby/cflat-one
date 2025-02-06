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
        //public int personId;
        //public string firstName;
        //public string lastName;
        //public string favoriteColour;
        //public int age;
        //public bool isWorking;

        // Properties
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

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
        //public void displayPersonInfo(int personId, string firstName, string lastName, string firstColor)
        public void displayPersonInfo()
        {
            // Instructions feel a little bit unclear here, better ask mehdi to clarify
            string fullName = $"{FirstName} {LastName}";

            Console.WriteLine($"{PersonId}: {fullName}'s favorite color is {FavoriteColor}\n");
        }

        // Setting a default to white, so it fulfills the rubric if nohing is passed in but has the potential to be useful otherwise
        public void changeFavoriteColor(string newColor = "White") 
        {
            //string changeOuputString = $"Favorite color changed from {FavoriteColor} to {newColor}!";
            FavoriteColor = newColor;
        }

        public void getAgeInTenYears()
        {
            // This may throw an error because I'm not certain that string interpolation will implicitly cast other data types to strings
            Console.WriteLine($"{FirstName} {LastName}'s age in ten years will be {Age + 10}\n");
        }

        // I could also override the Object.ToString() method here, but it says for the function itself to display the properties,
        // So I won't bother as ToString requires that I actually return a string, which will be an extra step
        public void toString()
        {
            Console.WriteLine(
                $"PersonId: {PersonId}\n" +
                $"FirstName: {FirstName}\n" +
                $"LastName: {LastName}\n" +
                $"FavoriteColor: {FavoriteColor}\n" +
                $"Age: {Age}\n" +
                $"IsWorking: {IsWorking}\n"
                );
            
        }

        // Private Methods
        }

   
}
