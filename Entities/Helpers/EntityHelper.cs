using AutoMapper;
using IMTSchedulerWorkerService.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTSchedulerWorkerService.Entities.Helpers
{
	public class EntityHelper : BaseService
	{

		private readonly ClinicalEntityHelper _clinicalEntityHelper;

		public EntityHelper(ClinicalEntityHelper clinicalEntityHelper, IMapper mapper) : base(mapper)
		{
			_clinicalEntityHelper = clinicalEntityHelper;
		}

		public async Task<List<T>> ExecuteCommandDataTable<T>(string SQL) where T : class
		{
			try
			{
				return await _clinicalEntityHelper.ExecuteCommandDataTableAsync<T>(SQL);

			}
			catch (Exception)
			{
				return null;
			}
		}

		public int ExecuteCommandScalar(string SQL)
		{
			try
			{
				return _clinicalEntityHelper.ExecuteCommandScalar(SQL);
			}
			catch (Exception)
			{
				return 0;
			}
		}
	}
}
