using IMTSchedulerWorkerService.Entities.ClinicalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTSchedulerWorkerService.Services.Interfaces
{
  
    public interface ISchedulerService
    {

        Task<bool> RunExceptions();

        Task<List<ImtexceptionScript>> GetActiveExceptionScript();

        Task<Imtscheduler> GetExceptionSchedule(int ExceptionScriptID);

    }

}
