using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorPractClient.DataAccess.Model
{
    public class Service
    {
        [Key]
        
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }

        public long GroupId { get; set; }
        public Group? Group { get; set; }

    }
}
