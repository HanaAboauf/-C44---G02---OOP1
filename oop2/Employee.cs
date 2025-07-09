
using System.Globalization;

namespace oop2
{
    using System.Globalization;

    namespace oop2
    {
        public class Employee
        {
            private int id;
            private string name;
            private int salary;
            private SecurityLevel securityLevel;
            private Gender gender;
            private HireDate hireDate;

          
            public Employee(int id, string name, Gender gender, SecurityLevel securityLevel, int salary, HireDate hireDate)
            {
                this.id = id;
                this.name = name;
                this.gender = gender;
                this.securityLevel = securityLevel;
                this.salary = salary;
                this.hireDate = hireDate;
            }

      
            public Employee()
            {
                id = 0;
                name = "Unknown";
                gender = Gender.F;
                securityLevel = SecurityLevel.guest;
                salary = 0;
                hireDate = new HireDate(1, 1, 2000);
            }

    
            public int GetId() => id;
            public void SetId(int value) => id = value;

            public string GetName() => name;
            public void SetName(string value) => name = !string.IsNullOrWhiteSpace(value) ? value : "Unknown";

            public int GetSalary() => salary;
            public void SetSalary(int value) => salary = value >= 0 ? value : 0;

            public SecurityLevel GetSecurityLevel() => securityLevel;
            public void SetSecurityLevel(SecurityLevel level) => securityLevel = level;

            public Gender GetGender() => gender;
            public void SetGender(Gender g) => gender = g;

            public HireDate GetHireDate() => hireDate;
            public void SetHireDate(HireDate date) => hireDate = date;

          
            public override string ToString()
            {
                return $"ID: {id}\n" +
                       $"Name: {name}\n" +
                       $"Gender: {gender}\n" +
                       $"Security Level: {securityLevel}\n" +
                       $"Salary: {salary}\n" +
                       $"Hire Date: {hireDate}";
            }
        }

        public enum SecurityLevel
        {
            guest,
            Developer,
            secretary,
            DBA,
            securityOfficer
        }

        public enum Gender
        {
            F,
            M
        }
    }

}
