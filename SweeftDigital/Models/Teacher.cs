﻿namespace SweeftDigital.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public ICollection<TeacherPupil> TeachersPupils { get; set; }
    }
}
