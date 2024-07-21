using System;
using System.Collections.Generic;
public class Person
{
    private string _fullName;
    private string _nationality;
    private int _yearsOfExperience;

    public Person(string fullName, string nationality, int yearsOfExperience)
    {
        _fullName = fullName;
        _nationality = nationality;
        _yearsOfExperience = yearsOfExperience;
    }

    public string GetFullName()
    {
        return _fullName;
    }

    public string GetNationality()
    {
        return _nationality;
    }

    public int GetYearsOfExperience()
    {
        return _yearsOfExperience;
    }

    public string DisplayPersonInformation()
    {
        return $"Speaker's Full Name: {_fullName}\nSpeaker's Nationality: {_nationality}\nSpeaker's Experience: {_yearsOfExperience} years.";
    }
}