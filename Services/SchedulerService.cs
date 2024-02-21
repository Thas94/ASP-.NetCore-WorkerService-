using AutoMapper;
using IMTSchedulerWorkerService.Entities.ClinicalEntities;
using IMTSchedulerWorkerService.Services.Base;
using IMTSchedulerWorkerService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTSchedulerWorkerService.Services
{

	public class SchedulerService : ClinicalServiceBase, ISchedulerService
	{
		private readonly IIMTAPIService _IMTAPIService;

		public SchedulerService(IIMTAPIService IMTAPIService, clinicalHl7IMTntcwebcozadataContext context, IMapper mapper) : base(context, mapper)
		{
			_IMTAPIService = IMTAPIService;
		}

        public async Task<bool> RunExceptions()
        {
            try
            {

                // Get the Current Day
                string DayName = System.DateTime.Now.ToString("dddd");
                

                //Get the Token Credentials 
                string TokenCredentails = await _IMTAPIService.GetIMAPICredentials();

                string Token = await _IMTAPIService.GetAPIToken(TokenCredentails);


                //Get All Active Exception Scripts
                List <ImtexceptionScript> ActiveExceptions = await GetActiveExceptionScript();

                //Loop Through the active Exception Scripts and Run the Exception
                foreach (var Exception in ActiveExceptions)
                {

                    //Getting the Schedule for the Exception Script
                    Imtscheduler exceptionschedule = await GetExceptionSchedule(Exception.ExceptionScriptId);

                    if (exceptionschedule != null)
                    {
                        //to determine if the exception script is run weelky and for each day of the week
                        if (exceptionschedule.RunWeekly == true)
                        {
                            //Runs regardless of the current Day
                            if (exceptionschedule.RunEveryDay == true)
                            {
                                await _IMTAPIService.RunExceptionScript(exceptionschedule.ItemId);
                            }
                            else if (exceptionschedule.Monday == true)
                            {

                            }
                            else if (exceptionschedule.Tuesday == true)
                            {

                            }
                            else if (exceptionschedule.Wednesday == true)
                            {

                            }
                            else if (exceptionschedule.Thursday == true)
                            {

                            }
                            else if (exceptionschedule.Friday == true)
                            {

                            }
                            else if (exceptionschedule.Saturday == true)
                            {

                            }
                            else if (exceptionschedule.Sunday == true)
                            {

                            }
                        }
                    }
                }


               
              
                return true;
            }
            catch (Exception e)
            {
                return true;
            }
        }
        public async Task<List<ImtexceptionScript>> GetActiveExceptionScript()
        {
            List<ImtexceptionScript> exceptionScript = null; 

            try
            {
                exceptionScript = _context.ImtexceptionScripts.Where(x=> x.Active == true).ToList();
              
                return exceptionScript;
            }
            catch (Exception e)
            {
                return exceptionScript;
            }
        }
        public async Task<Imtscheduler> GetExceptionSchedule(int ExceptionScriptID)
        {
            Imtscheduler schedule = null; 

            try
            {
                schedule = _context.Imtschedulers.Where(x=> x.ItemId == ExceptionScriptID && x.SchedulerTypeId == 1).FirstOrDefault();
              
                return schedule;
            }
            catch (Exception e)
            {
                return schedule;
            }
        }




    }
}
