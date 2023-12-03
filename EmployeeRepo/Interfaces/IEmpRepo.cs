using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepo.Interfaces
{
    public interface IEmpRepo
    {
        public Task<List<Employee>> GetEmps();
        public Task<Employee> AddEmployee(Employee newEmp);
    }
}
