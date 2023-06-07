using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;



namespace TravelDesk.Models
{
    public class ApplicationRequest
    {
 
        [Key]

        //We have top take reson for travelling as a dropdown with some specific
        // reason and a column with others, when user click on others he'll
        //get a box in which he can write his reason for travelling.


        public int ApplicationRequestId { get; set; }


        public string Location { get; set; }
        public string ReasonForTravelling { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime? DepartureDate { get; set; }
        public int? DurationOfTravel { get; set; }

        public Boolean? HotelRequired { get; set; }   

         
        public Boolean? MealNeeded { get; set; }
        public string TravelMode { get; set; }


        public User User { get; set; }
       

        public int UserId { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
        public Comment Comment { get; set; }
        public int CommentId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

    }




 

}