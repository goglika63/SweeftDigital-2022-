using SweeftDigital.Data;
using SweeftDigital.Interfaces;
using SweeftDigital.Models;

namespace SweeftDigital.Repository
{
    public class PupilRepository : IPupilRepository
    {
        public readonly DataContext _context;
        public PupilRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Pupil> GetPupils()
        {
            return _context.Pupils.OrderBy(G => G.Id).ToList();
        }

        public ICollection<Teacher> GetTeacherByPupilName(string pupilName)
        {
            return _context.TeacherPupils.Where(t => t.Pupil.FirstName == pupilName).Select(p => p.Teacher).ToList();
        }

        public bool PupilExists(int pupilId)
        {
            return _context.Pupils.Any(g => g.Id == pupilId);
        }
    }
}
