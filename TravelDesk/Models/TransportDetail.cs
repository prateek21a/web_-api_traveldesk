namespace TravelDeskNst.Models
{
    public class TransportDetail
    {
        public int TransportDetailId { get; set; }
        public Request Request { get; set; }
        public int RequestId { get; set; } 
        public Documents Documents { get; set; }
        public int DocumentId { get; set; } 
        public bool InternationalTravel { get ; set; }  
        public bool DomesticTravel { get; set; }
        public DateTime TravelDateFrom { get; set; } 
        public DateTime TravelDateTo { get; set; }  
        public string TravelFrom { get; set; }    
        public string TravelTo { get; set; }
        public int VisaNo { get; set; }
        public int AdharCardNo { get; set; } 
        public int PassportNo { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }


    }
}
