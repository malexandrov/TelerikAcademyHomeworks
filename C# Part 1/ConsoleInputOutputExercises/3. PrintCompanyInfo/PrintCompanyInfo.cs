using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Enter Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter Company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter Company fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Enter Company website: ");
        string companyWeb = Console.ReadLine();
        Console.Write("Enter the first name of the manager: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter the last name of the manager: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter the age of the manager: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter phone number of the manager: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0,-22} | {1,-20} |", "Company name:", companyName);
        Console.WriteLine("{0,-22} | {1,-20} |", "Company address:", companyAddress);
        Console.WriteLine("{0,-22} | {1,-20} |", "Company phone number:", companyPhone);
        Console.WriteLine("{0,-22} | {1,-20} |", "Company fax number:", companyFax);
        Console.WriteLine("{0,-22} | {1,-20} |", "Company website:", companyWeb);
        Console.WriteLine("{0,-22} | {1,-20} |", "Company manager:", managerFirstName +" "+ managerLastName);
        Console.WriteLine("{0,-22} | {1,-20} |", "Company manager age:", managerAge);
        Console.WriteLine("{0,-22} | {1,-20} |", "Company manager phone:", managerPhone);
    }
}
