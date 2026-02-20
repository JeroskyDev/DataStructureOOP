using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptsOfOPP.Backend;

public class SalaryEmployee : Employee
{
    //fields 
    private decimal _salary;

    //constructor
    public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDay, decimal salary) : 
        base(id, firstName, lastName, isActive, bornDate, hireDay)
    {
        Salary = salary;
    }

    //properties
    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalary(value); 
    }

    //methods
    //public methods
    public override decimal GetValueToPay() => Salary; //arrow notation, same as return and it does the process in just one line

    public override string ToString() => base.ToString();

    //private methods
    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 2000000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $2,000,000.");
        }
        return salary;
    }

}
