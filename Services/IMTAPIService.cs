using AutoMapper;
using IMTSchedulerWorkerService.Entities.ClinicalEntities;
using IMTSchedulerWorkerService.Entities.Helpers;
using IMTSchedulerWorkerService.Models;
using IMTSchedulerWorkerService.Services.Base;
using IMTSchedulerWorkerService.Services.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMTSchedulerWorkerService.Services
{

    public class IMTAPIService : ClinicalServiceBase, IIMTAPIService
    {

        private readonly EntityHelper _entityHelper;

        public IConfiguration _Configuration;

        public IMTAPIService(EntityHelper entityHelper, clinicalHl7IMTntcwebcozadataContext context, IConfiguration Configuration, IMapper mapper) : base(context, mapper)
        {
            _entityHelper = entityHelper;
            _Configuration = Configuration;
        }

        public async Task<string> GetIMAPICredentials()
        {

            //IMTAPITokenCredentialsModel APITokenCredentials = null;

            string TokenCredentials = string.Empty;

            try
            {
                //Getting the API Credentials from the Settings table
                TokenCredentials = _context.ImtschedulerSettingDetails.Where(x => x.SchedulerSettingId == 1).Select(x=> x.SettingValue).FirstOrDefault();    
            }
            catch (Exception ex)
            { 
            
            }

            return TokenCredentials;
        }
        public async Task<string> GetAPIToken(string IMAPICredentials)
        {
            string Token = string.Empty;

            try
            {
                string URL = _context.ImtschedulerSettingDetails.Where(x=> x.SchedulerSettingId == 2).Select(x=>x.SettingValue).FirstOrDefault();

                var client = new RestClient(URL);
                //client.timeout = -1;
                var request = new RestRequest("/Authentication/Token", Method.Post);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");

                request.AddParameter("text/plain", IMAPICredentials, ParameterType.RequestBody);

                var response = client.ExecuteAsync(request);

                if (response.Result.StatusCode == HttpStatusCode.OK)
                {
                    Token = response.Result.Content;
                }

            }
            catch (Exception ex)
            {

            }

            return Token;
        }

        public async Task<bool> RunExceptionScript(int ExceptionScriptID,string Token)
        {
            bool result = false;

            try
            {
                string URL = _context.ImtschedulerSettingDetails.Where(x => x.SchedulerSettingId == 2).Select(x => x.SettingValue).FirstOrDefault();

                var client = new RestClient(URL);
                //client.timeout = -1;
                var request = new RestRequest("/ExceptionScripts/GenerateAndSendExceptionScripts?" + ExceptionScriptID, Method.Post);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer" + Token);

                //request.AddParameter("text/plain", "", ParameterType.RequestBody);

                var response = client.ExecuteAsync(request);

                if (response.Result.StatusCode == HttpStatusCode.OK)
                {
                    //AmroddTokenResponseModel TempToken = JsonConvert.DeserializeObject<AmroddTokenResponseModel>(response.Result.Content);
                    //var IntegrationSettings = _context2.CustomerIntegrationSettings.Where(x => x.CustomerId == CustomerID && x.SettingName == "Amrod Bearer Token").FirstOrDefault();
                    //IntegrationSettings.SettingValue = TempToken.token;
                    //IntegrationSettings.UpdatedDate = DateTime.Now;

                    //_context2.Entry(IntegrationSettings).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    //_context2.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }

            return result;
        }







    }


}
