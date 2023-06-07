using System.ComponentModel.DataAnnotations;



namespace TravelDesk.Models
{
    public class HistoryDetails
    {
        //RequestNo
        //Employee Name
        //Request Date
        //Tour From Date
        //Tour To Date
        //Departure City
        //Destination City
        //Travel Type
        //Request 
        //Comments

        [Key]
        public int HistoryId { get; set; }
        public ApplicationRequest ApplicationRequest { get; set; }
        public int ApplicationRequestId { get; set; }

    }
}