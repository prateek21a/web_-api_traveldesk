﻿namespace TravelDeskNst.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public Request Request { get; set; }
        public int RequestId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
