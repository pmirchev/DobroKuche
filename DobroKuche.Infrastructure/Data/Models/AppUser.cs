namespace DobroKuche.Infrastructure.Data.Models
{
    using DobroKuche.Infrastructure.Data.Common;
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Dogs = new List<Dog>();
            Cources = new List<Cource>();
            Articles = new List<Article>();
            CreatedOn = DateTime.Now;
            IsDeleted = false;
        }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.UserFirstNameMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.UserLastNameMaxLenght)]
        public string LastName { get; set; } = null!;

        public List<Dog> Dogs { get; set; }

        public List<Cource> Cources { get; set; }

        public List<Article> Articles { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
