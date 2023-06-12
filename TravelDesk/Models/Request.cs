namespace TravelDeskNst.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public string ReasonForTravelling { get; set; }

        public virtual User? Manager { get; set; }
        public int ManagerId { get; set; }  
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
