using System.ComponentModel.DataAnnotations;
namespace Domain.Models.Entities.Education;

public class Education
    {
        public int Id { get; set; }

        public string EducationTitle { get; set; }

        public string EducationDuration { get; set; }

        public string? Description { get; set; }
    }

