using System;
using Microsoft.AspNetCore.Mvc;
using VolunteerPortalApi.Services;
using VolunteerPortalApi.Entities;
using Microsoft.Extensions.Options;
using VolunteerPortalApi.Configuration;

namespace VolunteerPortalApi.Controllers;

[ApiController]
[Route("[controller]")]

public class AdminController : ControllerBase
{
    private readonly IOptions<conStr> _dbCon;
    private string cmd;

    public AdminController(IOptions<conStr> dbCon)
    {
        _dbCon = dbCon;
    }
    [HttpGet("getJobCountAdmin")]
    public IActionResult getJobCountAdmin()
    {
        try
        {
            cmd = "select * from view_JobCountAdmin";
            var response = dapperQuery.Qry<TotalJobAdmin>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("CompanyJobs")]
    public IActionResult CompanyJobs(int companyID)
    {
        try
        {
            if (companyID == null || companyID == 0)
            {
                cmd = "select * from view_CompanyJobs order by jobTitle";
            }
            else
            {
                cmd = "select * from view_CompanyJobs where companyID=" + companyID + " order by jobTitle";
            }
            
            var response = dapperQuery.Qry<CompanyJob>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("AllJobs")]
    public IActionResult AllJobs(int companyID)
    {
        try
        {
            if (companyID == null || companyID == 0)
            {
                cmd = "select distinct * from view_alljobs";
            }
            else
            {
                cmd = "select distinct * from view_alljobs where companyID="+companyID+"";
            }
            var response = dapperQuery.Qry<AllJobs>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getCompanyDetail")]
    public IActionResult getCompanyDetail()
    {
        try
        {
            cmd = "select * from view_companyDetails order by companyID desc";
            var response = dapperQuery.Qry<CompanyDetails>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getAllTrainer")]
    public IActionResult getAllTrainer()
    {
        try
        {
            cmd = "select * from view_getAllTrainers";
            var response = dapperQuery.Qry<AllTrainer>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getTrainerCareer")]
    public IActionResult getTrainerCareer()
    {
        try
        {
            cmd = "select * from view_getTrainersCareer";
            var response = dapperQuery.Qry<AllTrainer>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getAllUser")]
        public IActionResult getAllUser()
        {
            try
            {
                cmd = "select * from view_getAllUsers";
                var response = dapperQuery.Qry<AllTrainer>(cmd, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    [HttpGet("getUserJobDetails")]
    public IActionResult getUserJobDetails(int userID)
    {
        try
        {
            cmd = "select * from view_userJobDetails where userID="+userID+"";
            var response = dapperQuery.Qry<UserJobDetails>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getUserJobDomain")]
    public IActionResult getUserJobDomain(int userID)
    {
        try
        {
            cmd = "select * from view_userJobDomain where userID="+userID+"";
            var response = dapperQuery.Qry<UserJobDomains>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getConfigration")]
    public IActionResult getConfigration()
    {
        try
        {
            cmd = "select * from view_getConfigration";
            var response = dapperQuery.Qry<GetConfigration>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getIncidents")]
    public IActionResult getIncidents()
    {
        try
        {
            cmd = "select distinct * from view_getIncidents order by createdOn desc";
            var response = dapperQuery.Qry<GetAllIncidents>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getCategory")]
    public IActionResult getCategory()
    {
        try
        {
            cmd = "select categoryID,categoryTitle from tbl_category where isdeleted=0";
            var response = dapperQuery.Qry<Category>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost("saveCategory")]
    public IActionResult saveCategory(SaveCategory model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveCategory", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveConfigration")]
    public IActionResult saveConfigration(SaveConfigration model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveConfigration", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    // [HttpPost("saveIncident")]
    // public IActionResult saveIncident(SaveIncident model)
    // {
    //     try
    //     {
    //         var response = dapperQuery.SPReturn("sp_saveIncident", model, _dbCon);
    //         return Ok(response);
    //     }
    //     catch (Exception e)
    //     {
    //         return Ok(e.Message);
    //     }
    // }
    [HttpPost("saveIncident")]
        public IActionResult saveIncident(SaveIncident model)
        {
            try
            {
                 model.eDocPath = "C:\\inetpub\\wwwroot\\YouthPortal\\YouthPortal-app\\browser\\assets\\Incident-images\\Incidents";
                var response = dapperQuery.SPReturn("sp_saveIncident", model, _dbCon);
                var data = response.Select(row => new { res = row.ToString() });
                bool result = data.First().res.Contains("Success");
               // var response = dapperQuery.SPReturn("sp_saveUserAcadmicInfo",model,_dbCon);
               
                if (result == true && (string.IsNullOrEmpty(model.eDocPath) && string.IsNullOrEmpty(model.eDocPath) && string.IsNullOrEmpty(model.eDocPath)))
                {
                    var userID = data.First().res.Split("|||")[1];
                    dapperQuery.saveImageFile(
                        model.eDocPath,
                        userID,
                        model.eDoc,
                        model.eDocExt);
                }
                return Ok(response);

            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    [HttpPost("saveTrainerByAdmin")]
    public IActionResult saveTrainerByAdmin(TrainerByAdmin model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveTrainerByAdmin", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveSessionByAdmin")]
    public IActionResult saveSessionByAdmin(SessionByAdmin model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveSessionByAdmin", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
}