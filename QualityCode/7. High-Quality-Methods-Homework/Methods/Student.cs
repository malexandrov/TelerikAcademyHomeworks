using System;

public class Student
{
    private string firstName;
    private string lastName;
    public DateTime dateOfBirth;
    public string Comment { get; set; }

    // Constructors
    public Student(string firstName, string lastName, DateTime dateOfBirth, string comment)
        : this(firstName, lastName, dateOfBirth)
    {
        this.Comment = comment;
    }

    public Student(string firstName, string lastName, DateTime dateOfBirth)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.dateOfBirth = dateOfBirth;
    }

    // Properties
    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(firstName, "Student first name cannot be null!");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(lastName, "Student last name cannot be null!");
            }
            this.lastName = value;
        }
    }

    // Methods
    public bool IsOlderThan(Student other)
    {
        return this.dateOfBirth < other.dateOfBirth;
    }
}