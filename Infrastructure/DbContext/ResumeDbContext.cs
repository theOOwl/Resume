using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Domain.Models.Entities.Education;
using Domain.Models.Entities.Experience;
using Domain.Models.Entities.MySkills;
using Domain.Entities.ContactMe;

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

    #region Resume Db Sets

    public DbSet<Experience> Experiences { get; set; }

    public DbSet<MySkills> MySkills { get; set; }

    public DbSet<Education> Educations { get; set; }

    #endregion

    #region ContactMe Db Sets
    public DbSet<ContactMe> ContactMe { get; set; }
    #endregion
}