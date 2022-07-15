namespace SweeftDigital.Models
{
    public class Pupil
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public ICollection<TeacherPupil> TeachersPupils { get; set; }
    }
}
