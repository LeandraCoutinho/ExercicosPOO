using ExercicioFixacaoLinq.Entities;

namespace ExercicioFixacaoLinq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();
        Console.WriteLine("Enter salary: ");
        double salaryBase = double.Parse(Console.ReadLine());

        List<Employee> list = new List<Employee>();

        using (StreamReader sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                string email = fields[1];
                double salary = double.Parse(fields[2]);
                list.Add(new Employee(name, email, salary));
            }
        }

        Console.WriteLine("Email of people whose salary is more than 2000.00: ");
        var emails = list.Where(p => p.Salary > salaryBase).OrderBy(p => p.Email).Select(p => p.Email);
        foreach (string name in emails)
        {
            Console.WriteLine(name);
        }
        
        var somaSalary = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
        Console.WriteLine($"Sum of salary of people whose name starts with 'M': {somaSalary}");

    }
}