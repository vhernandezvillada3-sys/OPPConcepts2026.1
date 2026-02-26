using OPPConcepts.Backend;

try
{

    var employees = new List<Employee>();
    decimal payroll = 0;
    var employee1 = new SalaryEmployee(1010, "María", "Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    employees.Add(employee1);
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1990, 5, 15), new Date(2016, 1, 1), 10395876);
    employees.Add(employee2);
    var employee3 = new HourlyEmployee(2023, "Ana", "lopez", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 15000, 10);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee(2024, "Carlos", "Garcia", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 10000, 160);
    employees.Add(employee4);
    var employee5 = new CommisionEmployee(2025, "Sofia", "Martinez", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 0.03f, 600000000);
    employees.Add(employee5);
    var employee6 = new CommisionEmployee(2026, "Diego", "Rodriguez", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 0.03f, 120000000);
    employees.Add(employee6);
    var employee7 = new BaseCommisionEmployee(2027, "Laura", "Gomez", true, new Date(1995, 5, 15), new Date(2022, 1, 1), 0.015f, 250000000, 550000);
    employees.Add(employee7);
    var employee8 = new BaseCommisionEmployee(2028, "Andres", "Sanchez", true, new Date(1995, 5, 15), new Date(2026, 2, 10), 0.015f, 0, 550000);
    employees.Add(employee8);


    foreach (var employee in employees)
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();

    }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"payroll..................: {payroll,20:C2}");
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}