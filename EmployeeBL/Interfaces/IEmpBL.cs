using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBL.Interfaces
{
    public interface IEmpBL
    {
        public Task<List<Employee>> GetEmps();
        public Task<Employee> AddEmp(Employee newEmp);
    }
}
