namespace DobroKuche.Infrastructure.Data.Models
{
    using DobroKuche.Infrastructure.Data.Common;
    using DobroKuche.Infrastructure.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        public Course()
        {
            Participants = new List<AppUser>();
            Types = new List<TypeOfExercise>();
            CreatedOn = DateTime.Now;
            LastUpdatedOn = CreatedOn;
            IsDeleted = false;
		}

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.CourseTitleMaxLenght)]
        public string Title { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.CourseDescriptionMaxLenght)]
        public string Description { get; set; } = null!;

        [Required]
        public AgeGroup AgeGroup { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public List<TypeOfExercise> Types { get; set; }

        public List<AppUser> Participants { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
