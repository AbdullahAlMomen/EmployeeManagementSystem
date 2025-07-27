using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastUpdatedAt { get;set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastLoginTime {  get; set; }
        public DateTime? LastLogoutTime { get;set; }
        public bool? IsLocked { get; set; }
        public bool? IsActive { get; set; }
        
    }
}
