using BeFree.WebService.Domain;
using System.Data.Entity;

namespace BeFree.WebService.Infra
{
	public class BeFreeContext : DbContext
	{
		public BeFreeContext()
		{
		}

		public DbSet<User> User { get; set; }
		public DbSet<Shopping> Shopping { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			
		}
	}
}
