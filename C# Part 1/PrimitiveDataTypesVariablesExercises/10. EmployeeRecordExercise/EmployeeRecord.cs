using System;

class EmployeeRecord
{
    static void Main()
    {
        string firstName = "Pesho";
        string lastName = "Peshov";
        byte age = 32;
        char gender = 'm';
        uint idNumber = 1997234;
        uint employeeNumber = 27560001;

        Console.WriteLine("{0} {1} \nAge: {2} \nGender:{3} \nIdentification number: {4} \nEmployee number: {5}",
                         firstName, lastName, age, gender, idNumber, employeeNumber);
    }
}

