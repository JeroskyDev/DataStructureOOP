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
    var employee1 = new SalaryEmployee(1010, "Maria", "Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1970, 4, 12), new Date(2015, 11, 16), 10395876);
    Console.WriteLine(employee1);
    Console.WriteLine(employee2);
} 
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
