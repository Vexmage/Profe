using System;
using System.Text.RegularExpressions;

public class Professor
{
    // Attributes --  underscore prefix is used here to indicate that these variables are private fields
    private string _lNumber;
    private string _firstName;
    private string _lastName;
    private string _department;

    // Properties
    public string LNumber
    {
        get { return _lNumber; }
        set
        {
            while (true)
            {
                // Use regex to validate the LNumber format L########
                if (Regex.IsMatch(value, @"^L\d{8}$"))
                {
                    _lNumber = value;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid LNumber. LNumber must be in the format L########. Please try again:");
                    value = Console.ReadLine();
                }
            }
        }
    }

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name cannot be blank.");
            }
            else
            {
                _firstName = value;
            }
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Last name cannot be blank.");
            }
            else
            {
                _lastName = value;
            }
        }
    }

    public string Department
    {
        get { return _department; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Department name cannot be blank.");
            }
            else
            {
                _department = value;
            }
        }
    }


    // Constructors
    public Professor()
    {
        // Default constructor
    }

    public Professor(string lNumber, string firstName, string lastName, string department)
    {
        LNumber = lNumber;
        FirstName = firstName;
        LastName = lastName;
        Department = department;
    }

    // Methods
    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}\nLNumber: {LNumber}\nDepartment: {Department}";
    }
}
