namespace DobroKuche.Infrastructure.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Appointment
	{
		[Key]
		public int Id { get; set; }

		[Required(AllowEmptyStrings = false)]
		public string UserId { get; set; } = null!;
		[ForeignKey(nameof(UserId))]
		public AppUser User { get; set; } = null!;

		[Required]
		public DateTime Date { get; set; }

		public bool? Confirmed { get; set; }
	}
}
