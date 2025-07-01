using System.Runtime.InteropServices;

namespace oop1
{

    internal class Program


    {
        static double CalculateDistance(Point a, Point b)
        {
            double dx = b.x - a.y;
            double dy = b.y - a.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        static void Main(string[] args)
        {
            #region Question1

            //String[] weekDays = Enum.GetNames(typeof(DayOfWeek));

            //foreach (string day in weekDays)
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Question2

            //Person[] people = new Person[3];

            //for(int i=0; i<people.Length; i++)
            //{
            //    Console.WriteLine("enter the the person name");
            //    people[i].name = Console.ReadLine()!;
            //    Console.WriteLine("enter the the person age");
            //    people[i].age = int.Parse(Console.ReadLine()!);

            //}

            //int count = 1;
            //foreach (Person person in people) {
            //    Console.Write($"Person: {count}");
            //    Console.Write($" Name: {person.name},");
            //    Console.Write($" Age: {person.age}");
            //    count++;
            //    Console.WriteLine();
            //}

            #endregion

            #region Question3

            //SeasOn seasOn;

            //bool flage = Enum.TryParse(Console.ReadLine(), out seasOn);

            //switch (seasOn) {
            //    case SeasOn.Summer:
            //        Console.WriteLine("From June to august");
            //        break;
            //    case SeasOn.Winter:
            //        Console.WriteLine("From December to February");
            //        break;
            //    case SeasOn.Spring:
            //        Console.WriteLine("From March to May");
            //        break;
            //    case SeasOn.Autumn:
            //        Console.WriteLine("From September to November");
            //        break;



            //}



            #endregion

            #region Question4


            //Colors color;

            //bool flag = Enum.TryParse(Console.ReadLine(), out color);

            //if (flag)
            //{
            //    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            //    {
            //        Console.WriteLine($"{color} is a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{color} is secondary color.");
            //}



            #endregion

            #region question5

            //Point point1;
            //Point point2;

            //Console.WriteLine("enter the x axis of the first point");
            //point1.x=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter the y axis of the first point");
            //point1.y = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter the x axis of the second point");
            //point2.x = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter the y axis of the second point");
            //point2.y = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"The distance between the 2 points is: {CalculateDistance(point1,point2)}");

            #endregion

            #region Question6

            //Person[] people = new Person[3];

            //for(int i=0; i<people.Length; i++)
            //{
            //    Console.WriteLine("enter the the person name");
            //    people[i].name = Console.ReadLine()!;
            //    Console.WriteLine("enter the the person age");
            //    people[i].age = int.Parse(Console.ReadLine()!);

            //}

            //int maxAge = int.MinValue;
            //string Name = "";
            //foreach (Person person in people)
            //{
            //    if (person.age >= maxAge)
            //    {
            //        maxAge = person.age;
            //        Name = person.name;
            //    }
            //}
            //Console.WriteLine($"The name of oldest person is: {Name}");



            #endregion



        }

    }
}
