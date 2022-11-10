namespace DobroKuche.Infrastructure.Data.Models
{
    using DobroKuche.Infrastructure.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.TagNameMaxLenght)]
        public string Name { get; set; } = null!;
    }
}
