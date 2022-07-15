using Microsoft.EntityFrameworkCore;
using SweeftDigital.Models;

namespace SweeftDigital.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<TeacherPupil> TeacherPupils { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherPupil>()
                .HasKey(bc => new { bc.TeacherId, bc.PupilId });
            modelBuilder.Entity<TeacherPupil>()
                .HasOne(bc => bc.Teacher)
                .WithMany(b => b.TeachersPupils)
                .HasForeignKey(bc => bc.TeacherId);
            modelBuilder.Entity<TeacherPupil>()
                .HasOne(bc => bc.Pupil)
                .WithMany(c => c.TeachersPupils)
                .HasForeignKey(bc => bc.PupilId);
        }
    }
}
