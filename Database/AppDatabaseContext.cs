using Microsoft.EntityFrameworkCore;

namespace WF_job.Database
{
    public class AppDatabaseContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<LearningModule> LearningModules { get; set; }

        public string DbPath = "C:/Users/S9801G/AppData/Local/students_app.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(x => x.LearningModules)
                .WithMany(x => x.Students)
                .UsingEntity(j => j.ToTable("StudentLearningModule"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
