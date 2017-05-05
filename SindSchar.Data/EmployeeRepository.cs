using System.Collections.Generic;
using Sindschar.Core.Interfaces;
using Sindschar.Core.Models;

namespace SindSchar.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            // Get the data from whereever yo want!

            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Thomas", Salary = 10_000 },
                new Employee { Id = 2, Name = "Lisa", Salary = 20_000 },
                new Employee { Id = 3, Name = "Hans", Salary = 30_000 },
                new Employee { Id = 4, Name = "Maria", Salary = 40_000 },
                new Employee { Id = 5, Name = "Luis", Salary = 50_000 },
                new Employee { Id = 6, Name = "Stanislaus", Salary = 60_000 },
                new Employee { Id = 7, Name = "Antonia", Salary = 70_000 },
                new Employee { Id = 8, Name = "Mustafa", Salary = 80_000 },
                new Employee { Id = 9, Name = "Hannes", Salary = 90_000 },
            };
        }
    }
}
