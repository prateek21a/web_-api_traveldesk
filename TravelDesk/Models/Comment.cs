namespace TravelDesk.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public string CommentGivenBy { get; set; }
        public DateTime? CommentTime { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}