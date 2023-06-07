using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace TravelDesk.Models
{
    public class MasterDataReference
    {
        
        public int MasterDataReferenceId { get; set; }
        public string Type  { get; set; }
        public string Value { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

    }
}
