using SweeftDigital.Models;

namespace SweeftDigital.Interfaces
{
    public interface IPupilRepository
    {
        ICollection<Pupil> GetPupils();
        ICollection<Teacher> GetTeacherByPupilName(string pupilName);
        bool PupilExists(int pupilId);
    }
}
