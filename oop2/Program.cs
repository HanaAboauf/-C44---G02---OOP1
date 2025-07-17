using oop2.oop2;

namespace oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HireDate hireDate = new HireDate(1, 10, 2022);

            Employee employee = new Employee(1,"hana",Gender.F,SecurityLevel.Developer,30000, hireDate);

            Console.WriteLine(employee);
        }
    }
}
