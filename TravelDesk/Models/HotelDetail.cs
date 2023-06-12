namespace TravelDeskNst.Models
{
    public class HotelDetail
    {
        public int Id { get; set; }    
        public Request Request { get; set; }
        public int RequestId { get; set; } 
        
        public DateTime StayDateFrom { get; set; }
        public DateTime StayDateTo { get; set; }
        public int MealPreferenceId { get; set; }
        public int NoMealPrefernece { get; set; }   
       

    }
}
