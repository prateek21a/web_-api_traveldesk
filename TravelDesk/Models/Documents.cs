namespace TravelDeskNst.Models
{
    public class Documents
    {

        public int Id { get; set; }
        public string AadharPath { get; set; }
        public string? VisaPath { get; set; }
        public string? PassportPath { get; set; }
        public string? TicketId { get; set; }
        public string? TicketPath { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Boolean IsActive { get; set; } = true;

    }



    }

