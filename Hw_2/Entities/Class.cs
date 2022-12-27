using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
