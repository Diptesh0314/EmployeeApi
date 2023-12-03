using EmployeeRepo.Interfaces;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepo.Repos
{
    public class EmpRepo : IEmpRepo
    {
        private readonly EmployeeContext _empContext;
        public EmpRepo(EmployeeContext empContext)
        {
                this._empContext = empContext;
        }

        public async Task<Employee> AddEmployee(Employee newEmp)
        {
            _empContext.Employees.Add(newEmp);
           await _empContext.SaveChangesAsync();
           Employee rtnEmp = await _empContext.Employees.SingleOrDefaultAsync(x=>x.EmpAddress==newEmp.EmpAddress);
            return rtnEmp;
        }

        public async Task<List<Employee>> GetEmps()
        {
            return await _empContext.Employees.ToListAsync();
        }
    }
}
