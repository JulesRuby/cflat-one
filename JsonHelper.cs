using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

//  Not using this, too much trouble right now, will try to make it work later, for science.
namespace creatingClasses
{
    internal class JsonHelper
    {

        //public static string ConvertJsonToPeople(string fileName)
        public static List<Person> ConvertJsonToPeople(string fileName)
        {
            string filePath = $@"..\..\..\{fileName}";
            Console.WriteLine("filePath");
            Console.WriteLine(filePath);
            string data = File.ReadAllText(filePath);

            Console.WriteLine(data);
            List<Person> people = JsonSerializer.Deserialize<List<Person>>(data);

            Console.WriteLine(people);
            //return "people";
            return people;
        }  
    }
}
