namespace TravelDesk.Models
{
    public class UserRoleMapping
    {
        public int UserRoleMappingId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsActive { get; set; }
       
       
       

        public Role Role { get; set; }
        public int RoleId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
