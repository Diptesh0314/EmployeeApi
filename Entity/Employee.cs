using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? EmpAddress { get; set; }
        public int GenderId { get; set; }
        public string? Gender { get; set; }
    }
}
