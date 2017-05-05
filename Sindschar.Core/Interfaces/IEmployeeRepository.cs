using Sindschar.Core.Models;
using System.Collections.Generic;

namespace Sindschar.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
    }
}
