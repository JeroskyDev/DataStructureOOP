using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptsOfOPP.Backend;

public abstract class Employee
{
    //constructors
    protected Employee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDay)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
        BornDate = bornDate;
        HireDay = hireDay;
    }

    //properties
    public int Id { get; set; }
    //public string? FirstName { get; set; } // ? suggest that a property can be null
    public string FirstName { get; set; } = null!; //better suggestion
    public string LastName { get; set; } = null!;
    public bool IsActive { get; set; }

    //properties from date class
    public Date BornDate {  get; set; } = null!;
    public Date? HireDay {  get; set; } = null!;

    //methods
    //ovewrite ToString function
    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" + 
            $"Value to pay: {GetValueToPay(),20:C2}";
    }

    public abstract decimal GetValueToPay(); //abstract method (can have polimorfism
}
