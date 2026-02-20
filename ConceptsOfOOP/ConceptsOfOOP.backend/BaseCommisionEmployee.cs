using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptsOfOPP.Backend;

public class BaseCommisionEmployee : CommissionEmployee
{
    //fields
    private decimal _salary;

    //constructors
    public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDay, float commissionPercentage, decimal sales, decimal salary) : 
        base(id, firstName, lastName, isActive, bornDate, hireDay, commissionPercentage, sales)
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
    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

    public override string ToString() => $"{base.ToString()}\n\t" + 
        $"- Salary base: {Salary,20:C2}";

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 500000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary base must be greater than ot equal to $500,000.");
        }
        return salary;
    }
}
