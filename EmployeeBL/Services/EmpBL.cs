using EmployeeBL.Interfaces;
using EmployeeRepo.Interfaces;
using Entity;

namespace EmployeeBL.Services
{
    public class EmpBL : IEmpBL
    {
        private readonly IEmpRepo _empRepo;
        public EmpBL(IEmpRepo empRepo)
        {
            this._empRepo = empRepo; 
        }

        public async Task<Employee> AddEmp(Employee newEmp)
        {
          return await _empRepo.AddEmployee(newEmp);
        }

        public async Task<List<Employee>> GetEmps()
        {
            return await _empRepo.GetEmps();
        }
    }
}