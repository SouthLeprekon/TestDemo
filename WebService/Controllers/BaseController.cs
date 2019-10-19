using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebService.Controllers
{
	public abstract class BaseController : Controller
	{
		protected BaseController(WebServiceDbContext context)
		{
			if (context == null) throw new ArgumentNullException(nameof(context));

			Context = context;
		}

		protected WebServiceDbContext Context { get; }

		protected async Task<IActionResult> DeleteEntity<T>(DbSet<T> dbSet, long id) where T : class
		{
			if (dbSet == null) throw new ArgumentNullException(nameof(dbSet));

			var entity = await dbSet.FindAsync(id);
			dbSet.Remove(entity);
			await Context.SaveChangesAsync();
			return NoContent();
		}
	}
}