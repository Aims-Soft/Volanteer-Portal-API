using System;
using Microsoft.AspNetCore.Mvc;
using VolunteerPortalApi.Services;
using VolunteerPortalApi.Entities;
using Microsoft.Extensions.Options;
using VolunteerPortalApi.Configuration;

namespace VolunteerPortalApi.Controllers;

[ApiController]
[Route("[controller]")]

public class DashboardController : ControllerBase
{
    private readonly IOptions<conStr> _dbCon;
    private string cmd;

    public DashboardController(IOptions<conStr> dbCon)
    {
        _dbCon = dbCon;
    }
    [HttpGet("getDashboardCount")]
    public IActionResult getDashboardCount()
    {
        try
        {
            cmd = "select distinct * from view_dashboardCount";
            var response = dapperQuery.Qry<DashboardCount>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getVolunteerByDomain")]
    public IActionResult getVolunteerByDomain()
    {
        try
        {
            cmd = "select distinct * from view_volunteerByDomain";
            var response = dapperQuery.Qry<VolunteerByDomain>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getCrisesByPriorty")]
    public IActionResult getCrisesByPriorty()
    {
        try
        {
            cmd = "Select * from view_crisesByPriorty";
            var response = dapperQuery.Qry<CrisesByPriorty>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getProvinceCount")]
    public IActionResult getProvinceCount()
    {
        try
        {
            cmd = "Select * from view_provinceCount";
            var response = dapperQuery.Qry<ProcinceName>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getRecentRegistration")]
    public IActionResult getRecentRegistration()
    {
        try
        {
            cmd = "Select * from view_user_Registration";
            var response = dapperQuery.Qry<UserRegistration>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getRecentCrises")]
    public IActionResult getRecentCrises()
    {
        try
        {
            cmd = "Select * from view_recent_Crises";
            var response = dapperQuery.Qry<RecentCrises>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    //[HttpGet("getActiveJob")]
    // public IActionResult getActiveJob(int companyID)
    // {
    //     try
    //     {
    //         if (companyID == null || companyID == 0)
    //         {
    //             cmd = "select * from view_ActiveJobs order by jobID desc";
    //         }
    //         else
    //         {
    //             cmd = "select * from view_ActiveJobs where companyID=" + companyID + " order by jobID desc";
    //         }
    //         var response = dapperQuery.Qry<ActiveJob>(cmd, _dbCon);
    //         return Ok(response);
    //     }
    //     catch (Exception e)
    //     {
    //         return BadRequest(e.Message);
    //     }
    // }
}