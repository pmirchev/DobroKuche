namespace DobroKuche.Infrastructure.Data.Models
{
    using DobroKuche.Infrastructure.Data.Common;
    using DobroKuche.Infrastructure.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Cource
    {
        public Cource()
        {
            Participants = new List<AppUser>();
            CreatedOn = DateTime.Now;
            LastUpdatedOn = CreatedOn;
            IsDeleted = false;
        }

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.CourceTitleMaxLenght)]
        public string Title { get; set; } = null!;

        [Required]
        public AgeGroup AgeGroups { get; set; }

        [Required]
        public Category Categories { get; set; }

        [Required]
        public Type Types { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.CourceDescriptionMaxLenght)]
        public string Description { get; set; } = null!;

        public List<AppUser> Participants { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
