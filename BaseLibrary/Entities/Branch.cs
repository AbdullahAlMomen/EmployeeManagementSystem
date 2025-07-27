using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Branch:Base
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
