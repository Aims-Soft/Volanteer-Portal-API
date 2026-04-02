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
    [HttpGet("getTopCitiesApplicants")]
    public IActionResult getTopCitiesApplicants(int year, int month)
    {
        try
        {
            cmd = "Select * from fun_TopCitiesApplicants ("+year+", "+month+") order by TotalApplicants desc";
            var response = dapperQuery.Qry<TopCitiesApplicants>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getActiveJob")]
    public IActionResult getActiveJob(int companyID)
    {
        try
        {
            if (companyID == null || companyID == 0)
            {
                cmd = "select * from view_ActiveJobs order by jobID desc";
            }
            else
            {
                cmd = "select * from view_ActiveJobs where companyID=" + companyID + " order by jobID desc";
            }
            var response = dapperQuery.Qry<ActiveJob>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}