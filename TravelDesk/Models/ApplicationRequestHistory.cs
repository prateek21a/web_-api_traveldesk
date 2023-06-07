using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;



namespace TravelDesk.Models
{
    public class ApplicationRequestHistory
    {
        public int ApplicationRequestHistoryId { get; set; }
        public string RequestStatus { get; set; }


 
        public ApplicationRequest ApplicationRequest { get; set; }
        public int ApplicationRequestId { get; set; }


        //Getting User Id from User table
        //Getting Date from ApplicationRequest table
        //By Default RequestStatus is Pending 
        //All the Comments are Coming from the Comment table

    





    }
}