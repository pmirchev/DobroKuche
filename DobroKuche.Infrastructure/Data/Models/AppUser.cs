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
            Courses = new List<Course>();
            Articles = new List<Article>();
			Appointments = new List<Appointment>();
            Roles = new List<IdentityUserRole<string>>();
			CreatedOn = DateTime.Now;
            IsDeleted = false;
        }

        [MaxLength(DataConstants.UserFirstNameMaxLenght)]
        public string? FirstName { get; set; }

        [MaxLength(DataConstants.UserLastNameMaxLenght)]
        public string? LastName { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public List<Dog> Dogs { get; set; }

        public List<Course> Courses { get; set; }

        public List<Article> Articles { get; set; }

        public List<Appointment> Appointments { get; set; }

        public List<IdentityUserRole<string>> Roles { get; set; }
    }
}
