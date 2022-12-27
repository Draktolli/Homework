using System.ComponentModel.DataAnnotations.Schema;

namespace Hw_2.Entities
{
	[Table("Classes")]
	internal class Class
	{
		public Guid Id { get; set; }
		public int number { get; set; }
		public string liter { get; set; }
		public School? School { get; set; }
		public Teacher? Teacher { get; set; }
	}
}
