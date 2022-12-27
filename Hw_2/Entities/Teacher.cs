

namespace Hw_2.Entities
{
	internal class Teacher
	{
		public Guid Id { get; set; }
		public string name { get; set; }
		public string surname { get; set; }
		public School? School { get; set; }
		public List<Class> Сlasses { get; set; } = new();

	}
}
