using System.ComponentModel.DataAnnotations;

namespace BlazorPractClient.DataAccess.Model
{
    public class Kid
    {
        [Key] public long KidId { get; set; }
        public string KidName { get; set; }
        public int KidMoney { get; set; }

        public long GroupId { get; set; }
        public Group? Group { get; set; }
    }
}
