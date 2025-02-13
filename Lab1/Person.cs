using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        //private data
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor; 
        private int age;
        private bool isWorking;

        //public properties
        public string FirstName { get { return firstName; } }
        public double Age { get { return age; } }
        public string FavoriteColor { get { return favoriteColor; } }

        //constructor
        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }


        //public methods

        /// <summary>
        /// Methods for getting name = first name + last name
        /// </summary>
        public string GetName()
        {
            return firstName + " " + lastName;
        }

        /// <summary>
        /// display information: personID, name(first name + last name), favorite color 
        /// </summary>
        public string DisplayPersonInfo()
        {
            string name = this.GetName();
            return $"{personId}: {name}'s favorite colour is {favoriteColor}";
        }

        /// <summary>
        /// change the object's favorite color to white
        /// </summary>
        public void ChangeFavoriteColour()
        {
            favoriteColor = "White";   
        }

        /// <summary>
        /// return object's age after 10 years
        /// </summary>
        public int GetAgeInTenYears()
        {
            return age + 10;
        }

        public override string ToString()
        {
            string name = this.GetName();
            return  $"PersonId: {personId}\n" +
                    $"FirstName: {firstName}\n" +
                    $"LastName: {lastName}\n" +
                    $"FavoriteColour: {favoriteColor}\n" +
                    $"Age: {age}\n" +
                    $"IsWorking: {isWorking}";
        }
    }
}
