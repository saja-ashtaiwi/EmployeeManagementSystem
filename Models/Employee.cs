using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EmployeesManagement.Models
{
    public class Employee : UserActivity
    {
        private object Record;

        public int  Id { get; set; }
        public int EmpNo { get; set; }
        public string  FirstName { get; set; }
        public string  MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName}{MiddleName}{LastName}";
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }


        //public string Skills => string.Join("<br>", Record.Department?.Select(dp => dp.Employee?.FirstName + " " + dp.Employee?.LastName));

        //public List <int>  Ids 
        //{ 
            //get => Record.Employees?.Select(em => em.Employees).ToList(); 
            //set => Record.Employees? = value.Select (v => new Employee() { Id = v}).ToList; 
        //}

    }
}
