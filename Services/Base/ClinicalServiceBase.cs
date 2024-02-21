using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IMTSchedulerWorkerService.Entities.ClinicalEntities;


namespace IMTSchedulerWorkerService.Services.Base
{
	public class ClinicalServiceBase : BaseService
	{
		public readonly clinicalHl7IMTntcwebcozadataContext _context;

		public ClinicalServiceBase(clinicalHl7IMTntcwebcozadataContext context, IMapper mapper) : base(mapper)
		{
			//	context.ChangeTracker.AutoDetectChangesEnabled = false;
			_context = context;
			//	_context.ChangeTracker.AutoDetectChangesEnabled = false;
		}
	}
}
