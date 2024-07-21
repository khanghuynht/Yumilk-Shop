using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET1814_MilkShop.API.CoreHelpers.ActionFilters;
using NET1814_MilkShop.API.CoreHelpers.Extensions;
using NET1814_MilkShop.Repositories.Models.ReportModels;
using NET1814_MilkShop.Repositories.Models.ReportTypeModels;
using NET1814_MilkShop.Services.Services.Interfaces;
using ILogger = Serilog.ILogger;

namespace NET1814_MilkShop.API.Controllers;

[ApiController]
[Route("api/reports")]
public class ReportController : Controller
{
    private readonly ILogger _logger;
    private readonly IReportService _reportService;

    public ReportController(ILogger logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _reportService = serviceProvider.GetRequiredService<IReportService>();
    }

    #region Report Types

    [HttpGet("report-types")]
    // [Authorize(AuthenticationSchemes = "Access")]
    public async Task<IActionResult> GetReportTypes([FromQuery] ReportTypePageModel model)
    {
        _logger.Information("Get report types");
        var response = await _reportService.GetReportTypes(model);
        return ResponseExtension.Result(response);
    }

    [HttpPost("report-types")]
    [Authorize(AuthenticationSchemes = "Access", Roles = "1,2")]
    public async Task<IActionResult> CreateReportType([FromBody] CreateReportTypeModel model)
    {
        _logger.Information("Create report type");
        var response = await _reportService.CreateReportType(model);
        return ResponseExtension.Result(response);
    }

    [HttpPatch("report-types/{id}")]
    [Authorize(AuthenticationSchemes = "Access", Roles = "1,2")]
    public async Task<IActionResult> UpdateReportType(int id, [FromBody] UpdateReportTypeModel model)
    {
        _logger.Information("Update report type");
        var response = await _reportService.UpdateReportType(id, model);
        return ResponseExtension.Result(response);
    }

    [HttpDelete("report-types/{id}")]
    [Authorize(AuthenticationSchemes = "Access", Roles = "1,2")]
    public async Task<IActionResult> DeleteReportType(int id)
    {
        _logger.Information("Delete report type");
        var response = await _reportService.DeleteReportType(id);
        return ResponseExtension.Result(response);
    }

    #endregion

    #region Report

    // Handle reports by customer
    [HttpGet]
    [Authorize(AuthenticationSchemes = "Access", Roles = "1,2")]
    public async Task<IActionResult> GetReport([FromQuery] ReportQueryModel queryModel)
    {
        _logger.Information("Get report");
        var response = await _reportService.GetReportAsync(queryModel);
        return ResponseExtension.Result(response);
    }

    [HttpGet("{id}")]
    [Authorize(AuthenticationSchemes = "Access", Roles = "1,2")]
    public async Task<IActionResult> GetReportById(Guid id)
    {
        _logger.Information("Get report by id");
        var response = await _reportService.GetReportByIdAsync(id);
        return ResponseExtension.Result(response);
    }

    [HttpPost]
    [Authorize(AuthenticationSchemes = "Access")]
    [ServiceFilter(typeof(UserExistsFilter))]
    public async Task<IActionResult> CreateReport([FromBody] CreateReportModel model)
    {
        var userId = (HttpContext.Items["UserId"] as Guid?)!.Value;
        _logger.Information("User {userId} create a report", userId);
        var res = await _reportService.CreateReportAsync(userId, model);
        return ResponseExtension.Result(res);
    }
    /// <summary>
    /// Update the resolve status of a report
    /// </summary>
    /// <param name="id"></param>
    /// <param name="isResolved"></param>
    /// <returns></returns>
    [HttpPatch("{id}")]
    [Authorize(AuthenticationSchemes = "Access", Roles = "1,2")]
    [ServiceFilter(typeof(UserExistsFilter))]
    public async Task<IActionResult> UpdateResolveStatus(Guid id, [FromBody] bool isResolved)
    {
        var userId = (HttpContext.Items["UserId"] as Guid?)!.Value;
        _logger.Information(
            isResolved ? "User {userId} mark report as resolved" : "User {userId} mark report as unresolved", userId);
        var res = await _reportService.UpdateResolveStatusAsync(userId, id, isResolved);
        return ResponseExtension.Result(res);
    }

    [HttpDelete("{id}")]
    [Authorize(AuthenticationSchemes = "Access", Roles = "1,2")]
    public async Task<IActionResult> DeleteReport(Guid id)
    {
        _logger.Information("Delete report");
        var res = await _reportService.DeleteReportAsync(id);
        return ResponseExtension.Result(res);
    }

    #endregion
}