namespace DobroKuche.Infrastructure.Models
{
    using DobroKuche.Infrastructure.Common;
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class WebAppUser : IdentityUser
    {
        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.FirstNameMaxLenght)]
        public string FirstName { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        [MaxLength(DataConstants.LastNameMaxLenght)]
        public string LastName { get; set; } = null!;
    }
}
