using Lab1;

//create 4 objects
Person person1 = new Person(1,"Ian", "Brooks", "Red", 30, true);
Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

//display Gina’s information: her id, first name, last name and her favorite colour
Console.WriteLine(person2.DisplayPersonInfo());

//Display all of Mike’s information as a list
Console.WriteLine(person3);

//Change Ian’s Favorite Colour to white, and then print his information as a sentence
person1.ChangeFavoriteColour();
Console.WriteLine(person1.DisplayPersonInfo());

//Display Mary’s age after ten years.
Console.WriteLine($"{person4.GetName()}'s Age in 10 years is: {person4.GetAgeInTenYears()}");

//Create two Relation Objects that show that Gina and Mary are sisters, and that Ian and Mike are brothers. Then, display both relationships
Relation sisterHood = new Relation(RelationshipType.Sister);
Console.WriteLine(sisterHood.ShowRelationShip( person2, person4));

Relation brotherHood = new Relation(RelationshipType.Brother);
Console.WriteLine(brotherHood.ShowRelationShip( person1, person3));

//Add all the Person objects to a list
Person[] personList = [person1, person2, person3, person4];

//The average age of the people in the list
double totalAge = 0, averageAge;
foreach (Person person in personList)
{
    totalAge += person.Age;
};
averageAge = totalAge / personList.Length;
Console.WriteLine($"Average age is: {averageAge}");

//display youngest and oldest people
Person youngestPerson = personList.MinBy(person => person.Age);
Console.WriteLine($"The youngest person is: {youngestPerson.FirstName}");

Person oldestPerson = personList.MaxBy(person => person.Age);
Console.WriteLine($"The oldest person is: {oldestPerson.FirstName}");

//display people whose name start with M
foreach (Person person in personList)
{
    if (char.ToUpper(person.FirstName[0]) == 'M' )
    {
        Console.WriteLine(person);
    }
}

//display people whose favorite color is Blue
foreach (Person person in personList)
{
    if (person.FavoriteColor == "Blue") 
    {
        Console.WriteLine(person);
    }
}

Console.WriteLine("Hello world");
