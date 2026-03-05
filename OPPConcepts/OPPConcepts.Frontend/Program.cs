using OPPConcepts.Backend;

try
{

    var expenses = new List<IPay>();
    decimal total = 0;
    var employee1 = new SalaryEmployee(1010, "María", "Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    expenses.Add(employee1);
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1990, 5, 15), new Date(2016, 1, 1), 10395876);
    expenses.Add(employee2);
    var employee3 = new HourlyEmployee(2023, "Ana", "lopez", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 15000, 10);
    expenses.Add(employee3);
    var employee4 = new HourlyEmployee(2024, "Carlos", "Garcia", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 10000, 160);
    expenses.Add(employee4);
    var employee5 = new CommisionEmployee(2025, "Sofia", "Martinez", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 0.03f, 600000000);
    expenses.Add(employee5);
    var employee6 = new CommisionEmployee(2026, "Diego", "Rodriguez", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 0.03f, 120000000);
    expenses.Add(employee6);
    var employee7 = new BaseCommisionEmployee(2027, "Laura", "Gomez", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 0.015f, 250000000, 550000);
    expenses.Add(employee7);
    var employee8 = new BaseCommisionEmployee(2028, "Andres", "Sanchez", true, new Date(1995, 5, 15), new Date(2026, 2, 10), 0.015f, 0, 550000);
    expenses.Add(employee8);
    var invoice1 = new Invoice(2029, "Iphone 14 Pro Max",new Date(2024,6,3),  2, 500000m);
    expenses.Add(invoice1);
    var invoice2 = new Invoice(2030, "Samsung Galaxy S23 Ultra",new Date (2026,7,2), 1, 450000m);
    expenses.Add(invoice2);


    foreach (var expense in expenses)
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine(expense);
        total += expense.GetValueToPay();

    }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"TOTAL..................: {total,20:C2}");
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}