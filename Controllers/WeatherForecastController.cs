using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EngineersAppWebCore.Data;
using EngineerWebService;

namespace EngineersAppWebCore.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]

    public class WeatherForecastController : ControllerBase
    {
        public Claimsitev2fnolContext db = new Claimsitev2fnolContext();


        [HttpGet]
        public string Service_Login(string username, string password)
                {
            try
            {

                var getuser = db.Users.Where(d => !string.IsNullOrEmpty(d.UserName) && d.UserName.Trim().ToLower() == username.Trim().ToLower()).FirstOrDefault();
                if (getuser != null)
                {
                    if (getuser.Password == Common.CreatePasswordHash(password, getuser.Salt))
                    {                  
                        return getuser.UserGuid.ToString();
                    }
                    else { return "Failed"; }
                }
                else { return "Failed"; }
            }
            catch (Exception e) { return "Failed"; }

        }


        [HttpGet]
        public void Service_GetJobsForAEngineer2(string EngineerID = "", string AppVersion = "")
        {
            //var searchresultdata = new List<JobDetails>();

            if (!string.IsNullOrEmpty(EngineerID))
            {
                Guid engid = new Guid(EngineerID);
                var engineer = db.Engineers.Where(x => x.Id == engid).Select(x => x).FirstOrDefault();
                if (engineer != null)
                {
                    engineer.MobileAppVersion = AppVersion;
                    db.SaveChanges();
                    Guid statWip = new Guid(Constants.STATUS_WIP_Claim);
                    Guid statWipService = new Guid(Constants.STATUS_WIP_Service);
                    Guid statar = new Guid(Constants.STATUS_Authorization_Required);
                    var searchresult = db.Procedures.SP_GetAllJobsForAEngineerAsync(engid, statWip, statWipService, statar);

                    //searchresult = searchresult.OrderByDescending(i => i.JobId).ToList();
                    //TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

                    var searchresultdata = db.Procedures.SP_GetAllJobsForAEngineerAsync(engid, statWip, statWipService, statar).Result.ToList();
                                           
                    
                    
                }
            }
           
        }

        public class JobDetails
        {
            public string CLAIMGUID { get; set; }
            public string CLAIMJOBID { get; set; }
            public string CLAIMRef { get; set; }
            public string CLAIMStatusID { get; set; }
            public string CLAIMStatus { get; set; }
            public string RiskAddress { get; set; }
            public string RiskPostCode { get; set; }
            public string JOBGUID { get; set; }
            public string JOBID { get; set; }
            public string ENGGUID { get; set; }
            public string EngName { get; set; }
            public string CLIENTID { get; set; }
            public string CLIENTNAME { get; set; }
            public string IsHighPriority { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductTypeId { get; set; }
            public string ProductTypeName { get; set; }
            public string BookingDate { get; set; }
            public string AppointmentStartTime { get; set; }
            public string AppointmentEndTime { get; set; }
            public string EndServiceDate { get; set; }
            public string CreatedOn { get; set; }
            public string IsClaim { get; set; }
            public string phone { get; set; }
            public string HomePhone { get; set; }
            public string ListType { get; set; }
            public string BackgroundColour { get; set; }
            public string ContactName { get; set; }

            public string BookingTimeType { get; set; }
            public string TimeType { get; set; }
            public int RouteOrder { get; set; }

            public string ParentJobGuid { get; set; } = "";
        }
    }
}
