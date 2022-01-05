using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Server.Data
{
	public class AspNetIdentityDbContext : IdentityDbContext
	{
		public AspNetIdentityDbContext(DbContextOptions<AspNetIdentityDbContext> options)
		  : base(options)
		{
		}
	}
}
