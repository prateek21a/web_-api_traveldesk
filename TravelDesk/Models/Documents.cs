namespace TravelDeskNst.Models
{
    public class Documents
    {
        public int Id { get; set; } 
        public string AdharNumber { get; set; }
        public string AdharPath {get; set; }
        public string VisaNumber { get; set; }  
        public string VisaPath { get; set;}
        public string PassportNumber { get; set; }
        public string PassportPath { get; set;}
        public int TicketId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public bool IsActive { get; set; }



    }
}
