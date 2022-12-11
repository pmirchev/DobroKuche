namespace DobroKuche.WebApp.Models
{
    using DobroKuche.Infrastructure.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(DataConstants.UserNameMaxLenght, MinimumLength = DataConstants.UserNameMinLenght)]
        public string UserName { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        [EmailAddress]
        [StringLength(DataConstants.EmailMaxLenght, MinimumLength = DataConstants.EmailMinLenght)]
        public string Email { get; set; } = null!;

        [StringLength(DataConstants.UserFirstNameMaxLenght, MinimumLength = DataConstants.UserFirstNameMinLenght)]
        public string? FirstName { get; set; }

        [StringLength(DataConstants.UserLastNameMaxLenght, MinimumLength = DataConstants.UserLastNameMinLenght)]
        public string? LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [StringLength(DataConstants.PasswordMaxLenght, MinimumLength = DataConstants.PasswordMinLenght)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
