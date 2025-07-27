using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Department:Base
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public int? ParentId { get; set; }
        public Department? Parent { get; set; }
        public ICollection<Department>? Children { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
