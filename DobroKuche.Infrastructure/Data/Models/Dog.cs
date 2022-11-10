namespace DobroKuche.Infrastructure.Data.Models
{
    using DobroKuche.Infrastructure.Data.Common;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Dog
    {
        public Dog()
        {
            CreatedOn = DateTime.Now;
            IsDeleted = false;
        }

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.DogNameMaxLenght)]
        public string Name { get; set; } = null!;

        public DateTime? Birthday { get; set; }

        public int? Age
        {
            get 
            { 
                if (Birthday == null)
                {
                    return null;
                }

                var result = (int)(DateTime.Now - Birthday).Value.TotalDays % 365;

                return result; 
            }
        }

        [Required(AllowEmptyStrings = false)]
        public string Breed { get; set; } = null!;

        [MaxLength(DataConstants.DogDescriptionMaxLenght)]
        public string? Description { get; set; }

        [Required]
        public string OwnerId { get; set; } = null!;
        [ForeignKey(nameof(OwnerId))]
        public AppUser Owner { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
