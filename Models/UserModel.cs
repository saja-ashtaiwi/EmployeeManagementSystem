using System.ComponentModel;

namespace EmployeesManagement.Models
{
    public class UserModel
     
    {
        public DAL.User  Record { get; set; }
        [DisplayName("User Name")]
        public string UserName => Record.UserName;
        public string Password => Record.Password;
        public string IsActive => Record.IsActive ? "Active" : "Not Active";
        public string Role => Record.Role?.Name;

    }
}
