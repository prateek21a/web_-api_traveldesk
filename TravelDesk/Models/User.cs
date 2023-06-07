namespace TravelDesk.Models
{
    public class User
    {
        public int UserId { get; set; }  //primary key
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; } 
        public DateTime ModifiedDate { get; set; } 
        public string Designation { get; set; }
        public bool IsActive { get; set; }
        public bool? Block { get; set; }   

        public Role Role { get; set; }
        public  int RoleId { get; set; }    
       
    }




}