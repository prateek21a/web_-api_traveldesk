namespace TravelDeskNst.Models
{
    public class CommonTypeRef
    {
        public int CommonTypeRefId { get; set; }   
        public string Type { get; set; }
        public string Value { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
