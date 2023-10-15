using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Entities.MySkills;
public class MySkills
    {
        public int Id { get; set; }

        public string SkillTille { get; set; }

        public int Percentage { get; set; }
    }

