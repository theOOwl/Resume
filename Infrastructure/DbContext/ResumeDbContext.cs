using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Domain.Models.Entities.Education;
using Domain.Models.Entities.Experience;
using Domain.Models.Entities.MySkills;



namespace Resume.Presenation.Models.ResumeDbContext;


public class ResumeDbContext : DbContext
{
    #region Ctor

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=POURIA\\SQLEXPRESS;Initial Catalog=ResumeDaneshkar;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    #endregion

    #region Db Sets

    public DbSet<Experience> Experiences { get; set; }

    public DbSet<MySkills> MySkills { get; set; }

    public DbSet<Education> Educations { get; set; }

    #endregion
}