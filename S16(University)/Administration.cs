public class Administration:IAdministration,IPlace
{
    string Name;
    Teachers Presidency;
    List<Employees> employees;
    public Administration(string name,Teachers head)
    {
        this.Name = name;
        this.Presidency = head;
        employees = new List<Employees>();

    }
    public void AddEmployee(Employees NewEmployee)
    {
        employees.Add(NewEmployee);
    }
    public void RemoveEmployee(Employees unwanted)
    {
        employees.Remove(unwanted);
    }
    public int ToltalSalary()
    {
        int sum = 0;
        foreach(var a in employees)
        {
            sum += a.salary;
        }
        return sum + Presidency.salary;
    }
    public void PrintAllMembers()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(this.Name);
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine($"Presidency : {Presidency.FirstName} {Presidency.LastName} {Presidency.BirthYear}");
        Console.ForegroundColor = ConsoleColor.Red;
        string outEmployees = "Employees:";
        foreach(var a in employees)
        {
            outEmployees += $"{a.FirstName} {a.LastName} {a.BirthYear} / ";
        }
        System.Console.WriteLine(outEmployees);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public override bool Equals(object obj)
    {
        var item = obj as Administration;
        if (obj == null){
            
            return false; 
        }
        return this.Name.Equals(item.Name);
    }
}