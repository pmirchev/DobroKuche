namespace DobroKuche.Infrastructure.Data.Models
{
    using DobroKuche.Infrastructure.Data.Common;
    using DobroKuche.Infrastructure.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Article
    {
        public Article()
        {
            Tags = new List<Tag>();
            CreatedOn = DateTime.Now;
            LastUpdatedOn = CreatedOn;
            IsDeleted = false;

        }

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.ArticleTitleMaxLeght)]
        public string Title { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.ArticleTitleMaxLeght)]
        public string Description { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        public string AuthorId { get; set; } = null!;
        [ForeignKey(nameof(AuthorId))]
        public AppUser Author { get; set; } = null!;

        public AgeGroup? AgeGroup { get; set; }

        public Type? Type { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
