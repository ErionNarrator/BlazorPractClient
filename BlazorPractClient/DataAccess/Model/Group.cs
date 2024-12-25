using BlazorPractClient.Pages;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace BlazorPractClient.DataAccess.Model
{
    public class Group
    {
        [Key] public long GroupId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal TotalCost { get; set; }
        public long TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<Kid>? Kids { get; set; }
    }
}
