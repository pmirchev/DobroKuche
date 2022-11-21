namespace DobroKuche.Infrastructure.Data
{
    using DobroKuche.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dog> Dogs { get; set; } = null!;

        public DbSet<Course> Courses { get; set; } = null!;

        public DbSet<Article> Articles { get; set; } = null!;

        public DbSet<Tag> Tags { get; set; } = null!;

        public DbSet<TypeOfExercise> TypesOfExercise { get; set; } = null!;

        public DbSet<Appointment> Appointments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}