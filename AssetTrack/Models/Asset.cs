using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetTrack.Models
{
    public class Asset
    {
        public int Id { get; set; }

       
        public DateTime Date { get; set; }
        public string Location { get; set; }

        [DisplayName("Part Type")]
        public string PartType { get; set; }

        public string MSF { get; set; }

        [DisplayName("Part Number")]
        public string PartNumber { get; set; }

        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }

        [DisplayName("Task Number")]
        public string TaskNumber { get; set; }

        public string Notes { get; set; }
        public string User { get; set; }
       
        
    }
}
