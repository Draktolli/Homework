using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Hw_2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hw_2.DB
{
	internal class ApplicationContext : DbContext
	{
		public DbSet<Director> Directors { get; set; } = null!;
		public DbSet<School> Schools { get; set; } = null!;
		public DbSet<Class> Classs { get; set; } = null!;
		public DbSet<Teacher> Teachers { get; set; } = null!;
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Director>()
				.HasOne(b => b.School)
				.WithOne(i => i.Director)
				.HasForeignKey<School>(b => b.Director_id);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ScholDB;Trusted_Connection=True;TrustServerCertificate=true;");
		}
	}
}
