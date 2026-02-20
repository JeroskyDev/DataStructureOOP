//create frontend for date app with the class we already created
using ConceptsOfOPP.Backend;

/*
try
{
    var date1 = new Date();
    var date2 = new Date(2028, 2, 29);
    var date3 = new Date(2012, 11, 30);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/

try
{
    var employees = new List<Employee>();
    decimal payroll = 0;
    var employee1 = new SalaryEmployee(1010, "Maria", "Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    employees.Add(employee1);
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1970, 4, 12), new Date(2015, 11, 16), 10395876);
    employees.Add(employee2);
    var employee3 = new HourlyEmployee(3030, "Ána", "Lopez", true, new Date(1995, 8, 20), new Date(2022, 6, 1), 18000, 95);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee(4040, "Kevin", "Rúa", true, new Date(1998, 5, 25), new Date(2021, 6, 1), 10000, 112);
    employees.Add(employee4);
    var employee5 = new CommissionEmployee(5050, "Sofia", "Gómez", true, new Date(1992, 12, 19), new Date(2018, 3, 15), 0.03f, 600000000);
    employees.Add(employee5);
    var employee6 = new CommissionEmployee(6060, "Diego", "Martinez", true, new Date(1985, 12, 19), new Date(2010, 3, 15), 0.03f, 120000000);
    employees.Add(employee6);
    var employee7 = new BaseCommisionEmployee(7070, "Laura", "Garcia", true, new Date(1993, 11, 25), new Date(2019, 5, 20), 0.015f, 250000000, 550000);
    employees.Add(employee7);
    var employee8 = new BaseCommisionEmployee(8080, "Carlos", "Rodriguez", true, new Date(1988, 4, 10), new Date(2026, 2, 10), 0.015f, 0, 550000);
    employees.Add(employee8);


    foreach (var employee in employees)
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();
    }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"Payroll: {payroll,20:C2}");
} 
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
