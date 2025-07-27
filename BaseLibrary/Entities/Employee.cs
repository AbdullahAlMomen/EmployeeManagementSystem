using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Employee:Base
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Code { get; set; }
        public string? Address { get; set; }  
        public DateTime? JoiningDate { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string? ProfileImage { get; set; }
        public long? NID { get; set; }
        public int? ParentId { get; set; }
        public bool? IsActive { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }
        public Employee? Parent { get; set; }
        public ICollection<Employee>? Subordinates { get; set; }

    }
}
