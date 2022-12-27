using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_2.Entities
{
	internal class School
	{
		public Guid Id { get; set; }
		public int Number { get; set; }
		public Guid Director_id	{ get; set; }
		public Director Director { get; set; }
		public List<Class> Classes { get; set; }  = new();
		public List<Teacher> Teachers { get; set; } = new();

	}
}
