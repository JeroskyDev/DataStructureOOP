//create frontend for date app with the class we already created
using ConceptsOfOPP.Backend;

try
{
    var date1 = new Date();
    var date2 = new Date(2026, 2, 29);
    var date3 = new Date(2012, 13, 41);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

