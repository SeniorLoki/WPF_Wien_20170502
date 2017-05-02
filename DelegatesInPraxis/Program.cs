using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesInPraxis
{
    public delegate bool MyDelegate(Employee e);
    // Action    -> void
    // Predicate -> bool
    // Func

    class Program
    {
        static void Main(string[] args) 
        {
            var employees = GetData();

            //MyDelegate del = new MyDelegate(Bedingung);
            //Func<Employee, bool> del = new Func<Employee, bool>(Bedingung);
            //var del = new Func<Employee, bool>(Bedingung);
            //Func<Employee, bool> del = Bedingung;
            //var query = Abfrage(employees, del);

            //var query = Abfrage(employees, Bedingung);

            //var query = Abfrage(employees, delegate(Employee e)
            //{
            //    return e.Experience > 10;
            //});

            //var query = Abfrage(employees, (Employee e) =>
            //{
            //    return e.Experience > 10;
            //});

            //var query = Abfrage(employees, (e) =>
            //{
            //    return e.Experience > 10;
            //});

            //var query = Abfrage(employees, (e) => e.Experience > 10);
            var query = MyExtentions.Abfrage(employees, e => e.Experience > 10);
            var linqQuery = employees.Where(e => e.Name.Contains("T"));
            query = employees.Abfrage(e => e.Experience < 10);

            Func<Employee, bool> del = new Func<Employee, bool>(Bedingung);
            var linqQuery2 = employees.Where(del);


            var namen = new [] { "Sepp", "Franz", "Lisa" };
            var gefiltert = MyExtentions.Abfrage(namen, n => n.Length < 5);
            gefiltert = namen.Abfrage(n => n.Length > 5);

            foreach (var e in query)
            {
                //Console.WriteLine("{0} - {1,20} - {2}", e.Id, e.Name, e.Experience);
                // String Interpolation (ab VS2015 / C#6)
                Console.WriteLine($"{e.Id} - {e.Name, 15} - {e.Experience}");
            }
            Console.ReadLine();
        }

        private static bool Bedingung(Employee e)
        {
            return e.Name.Contains("a");
        }

        private static IEnumerable<Employee> GetData()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Sepp", Experience = 5},
                new Employee { Id = 2, Name = "Peter", Experience = 15},
                new Employee { Id = 3, Name = "Luis", Experience = 8},
                new Employee { Id = 4, Name = "Maria", Experience = 7},
                new Employee { Id = 5, Name = "Anke", Experience = 3},
                new Employee { Id = 6, Name = "Heinrich", Experience = 10},
                new Employee { Id = 7, Name = "Franz", Experience = 13},
                new Employee { Id = 8, Name = "Lena", Experience = 2},
                new Employee { Id = 9, Name = "Thomas", Experience = 9},
            };
        }
    }

    public static class MyExtentions
    {
        public static IEnumerable<T> Abfrage<T>(
           this IEnumerable<T> source,
           Func<T, bool> predicate)
        {
            foreach (var e in source)
            {
                if (predicate(e))
                    yield return e;
            }
        }
    }
}
