using Microsoft.EntityFrameworkCore;
using Education_DataEntities;

namespace Education_DataAccess.Context
{
    public class EducationDbContext : DbContext
    {
        public EducationDbContext(DbContextOptions<EducationDbContext> options)
            : base(options) { }

        public DbSet<Education> Educations => Set<Education>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Education>()
                .HasKey(e => e.EducationId);

            modelBuilder.Entity<Education>()
                .Property(e => e.StudentName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Education>()
                .Property(e => e.CourseName)
                .HasMaxLength(100);

            modelBuilder.Entity<Education>()
                .Property(e => e.InstituteName)
                .HasMaxLength(150);

            modelBuilder.Entity<Education>()
                .Property(e => e.AdmissionDate)
                .HasColumnType("datetime");

            modelBuilder.Entity<Education>()
                .Property(e => e.Fees)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}