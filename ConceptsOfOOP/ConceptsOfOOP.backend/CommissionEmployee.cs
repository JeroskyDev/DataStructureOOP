

namespace ConceptsOfOPP.Backend;

public class CommissionEmployee : Employee
{
    //Fields
    private float _commissionPercentage;
    private decimal _sales;

    //Constructors
    public CommissionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDay, float commissionPercentage, decimal sales) :
       base(id, firstName, lastName, isActive, bornDate, hireDay)
    {
        CommissionPercentage = commissionPercentage;
        Sales = sales;
    }

    //Properties
    public float CommissionPercentage
    {
        get => _commissionPercentage;
        set => _commissionPercentage = ValidateCommissionPercentage(value);
    }
    public decimal Sales
    {
        get => _sales;
        set => _sales = ValidateSales(value);
    }

    //Methods
    public override decimal GetValueToPay() => (decimal)CommissionPercentage * Sales;

    public override string ToString() => base.ToString() + $"\n\t" +
        $"Commission Percentage: {CommissionPercentage,20:P2}\n\t" +
        $"Sales: {Sales,20:C2}";

    private float ValidateCommissionPercentage(float commissionPercentage)
    {
        if (commissionPercentage < 0 || commissionPercentage > 1) 
        {
            throw new ArgumentOutOfRangeException(nameof(commissionPercentage), "Commission percentage must be between 0 and 1");
        }
        return commissionPercentage;
    }

    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be grater than or equal to 0.");
        }
        return sales;
    }
}
