using System.ComponentModel.DataAnnotations;

namespace BlazorPractClient.DataAccess.Model
{
    public class Teacher
    {
        [Key] public long TeacherId { get; set; }
        public string TeacherName { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
