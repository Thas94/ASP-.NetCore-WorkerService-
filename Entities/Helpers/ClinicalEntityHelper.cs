using IMTSchedulerWorkerService.Entities.ClinicalEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTSchedulerWorkerService.Entities.Helpers
{
	public class ClinicalEntityHelper
	{

		public async Task<List<T>> ExecuteCommandDataTableAsync<T>(string SQL) where T : class
		{
			try
			{
				using (clinicalHl7IMTntcwebcozadataContext db = new clinicalHl7IMTntcwebcozadataContext())
				{
					List<T> result = await db.Set<T>().FromSqlRaw(SQL).ToListAsync();

					return result;
				}
			}
			catch (Exception e)
			{
				return null;
			}
		}

		public int ExecuteCommandScalar(string SQL)
		{
			try
			{
				using (clinicalHl7IMTntcwebcozadataContext db = new clinicalHl7IMTntcwebcozadataContext())
				{
					return db.Database.ExecuteSqlInterpolated($"{SQL}");
				}
			}
			catch (Exception e)
			{
				return 0;
			}
		}
	}
}
