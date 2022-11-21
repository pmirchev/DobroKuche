namespace DobroKuche.Infrastructure.Data.Models
{
	using DobroKuche.Infrastructure.Data.Common;
	using System.ComponentModel.DataAnnotations;

	public class Tag
	{
		public Tag()
		{
			Articles = new List<Article>();
		}

		[Key]
		public int Id { get; set; }

		[Required(AllowEmptyStrings = false)]
		[MaxLength(DataConstants.TagNameMaxLenght)]
		public string Name { get; set; } = null!;

		public List<Article> Articles { get; set; } = null!;
	}
}
