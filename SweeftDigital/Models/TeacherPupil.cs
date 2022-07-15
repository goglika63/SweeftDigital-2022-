namespace SweeftDigital.Models
{
    public class TeacherPupil
    {
        public int TeacherId { get; set; }
        public int PupilId { get; set; }
        public Teacher Teacher { get; set; }
        public Pupil Pupil { get; set; }
    }
}
