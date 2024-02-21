using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace IMTSchedulerWorkerService.Services.Base
{
	public class BaseService
	{
		public readonly IMapper _mapper;

		public BaseService(IMapper mapper)
		{
			_mapper = mapper;
		}
	}
}
