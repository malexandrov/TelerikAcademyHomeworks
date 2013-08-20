using System;

class PersonDemo
{
    public static void Main()
    {
        Person newMalePerson = new Person("Pesho", 25, Sex.Male);
        Person newFemalePerson = new Person("Mona", 24, Sex.Female);

        Console.WriteLine(newFemalePerson.GetPersonData());
        Console.WriteLine(newMalePerson.GetPersonData());
    }
}

