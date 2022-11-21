namespace DobroKuche.Infrastructure.Seeders
{
	using DobroKuche.Infrastructure.Data;

	public interface ISeeder
	{
		Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider);
	}
}
