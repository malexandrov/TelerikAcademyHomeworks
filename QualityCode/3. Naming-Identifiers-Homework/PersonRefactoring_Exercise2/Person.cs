using System;

enum Sex { Male, Female, Unknown };

class Person
{
    private Sex Sex { get; set; }
    private string PersonName { get; set; }
    private int? Age { get; set; }

    public Person(string name, int? age, Sex sex)
    {
        this.PersonName = name;
        this.Age = age;
        this.Sex = sex;
    }

    public Person()
        : this(string.Empty, null, Sex.Unknown)
    {
    }

    public string GetPersonData()
    {
        string personData = string.Format("Name: {0} Age: {1} Sex: {2}", this.PersonName, this.Age, this.Sex);
        return personData;
    }
}