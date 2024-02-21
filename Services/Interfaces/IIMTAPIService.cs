using IMTSchedulerWorkerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTSchedulerWorkerService.Services.Interfaces
{
    public interface IIMTAPIService
    {
        Task<string> GetIMAPICredentials();
        Task<string> GetAPIToken(string IMAPICredentials);
        Task<bool> RunExceptionScript(int ExceptionScriptID)
    }

}
