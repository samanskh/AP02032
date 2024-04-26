public class University:IUni,IPlace
{
    string Name;
    string Country;
    Teachers Presidency;
    List<Department> Departments;
    List<Administration> Administrations;
    public University(string name,string country,Teachers head)
    {
        this.Name = name;
        this.Country = country;
        this.Presidency = head;
        Departments = new List<Department>();
        Administrations = new List<Administration>();

    }
    public void AddDepartment(Department New)
    {
        Departments.Add(New);
    }
    public void RemoveDepartment(Department Old)
    {
        Departments.Remove(Old);
    }
    public void AddAdministration(Administration New)
    {
        Administrations.Add(New);
    }
    public void RemoveAdministration(Administration Old)
    {
        Administrations.Remove(Old);
    }
    public void PrintAllMembers()
    {
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine(this.Name);
        System.Console.WriteLine($"Presidency : {Presidency.FirstName} {Presidency.LastName} {Presidency.BirthYear}");
        System.Console.WriteLine("Departments:");
        foreach(var a in Departments)
        {
            a.PrintAllMembers();
        }
        System.Console.WriteLine("Administrations:");
        foreach(var a in Administrations)
        {
            a.PrintAllMembers();
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
    public int ToltalSalary()
    {
        int sum = 0;
        foreach(var i in Departments)
        {
            sum+=i.ToltalSalary();
        }
        foreach(var j in Administrations)
        {
            sum+=j.ToltalSalary();
        }
        return sum+Presidency.salary;
    }
}