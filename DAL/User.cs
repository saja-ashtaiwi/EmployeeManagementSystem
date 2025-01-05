using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.DAL
{
    public class User
    {
        public int  Id { get; set; }
        [Required, StringLength(20, ErrorMessage ="User Name must be maximum {1}characters!")]
   
        public string  UserName { get; set; }
        [Required, StringLength(10)]
        public string Password { get; set; }
        public bool  IsActive { get; set; }
        public int RoleId { get; set; }
        
        public Role Role { get; set; }
    }
}
