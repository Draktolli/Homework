using Hw_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Hw_2.DB
{
	internal class DirectorsCommands
	{

		public void Create(string name, string surname)
		{
			using (ApplicationContext db = new ApplicationContext())
			{
				db.Database.EnsureDeleted();
				db.Database.EnsureCreated();
				Director director = new Director { Id = new Guid(), Name = name, SurName = surname };
				db.Directors.Add(director);
				db.SaveChanges();
			}
		}

		public void Read()
		{
			using (ApplicationContext db = new ApplicationContext())
			{
				var directors = (from d in db.Directors
								 select d).ToList();
				foreach(var director in directors)
				{
					Console.WriteLine($"{director.Id} {director.Name} {director.SurName}");
				}
			}
		}

		public void Update(Guid id, string name, string surname)
		{
			using (ApplicationContext db = new ApplicationContext())
			{
				Director director = (from d in db.Directors
								 where d.Id == id
								 select d
								 ).First();
				director.Name = name;
				director.SurName = surname;
				db.SaveChanges();
			}
		}

		public void Delete(Guid id)
		{
			using (ApplicationContext db = new ApplicationContext())
			{
				Director director = (from d in db.Directors
									 where d.Id == id
									 select d
								 ).First();
				db.Remove(director);
				db.SaveChanges();
			}
		}
	}
}
