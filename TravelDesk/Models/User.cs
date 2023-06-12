namespace TravelDeskNst.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }    
        public string Email { get; set; }   
        public string Password { get; set; }
        public int ContactNumber { get; set; }   
        public virtual User ? Manager { get; set; } 
        public int ManagerId { get; set; }

        public CommonTypeRef ? Role { get; set; }
        public int RoleId { get; set; }
        public CommonTypeRef? Department { get; set; }
        public int DepartmentId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
