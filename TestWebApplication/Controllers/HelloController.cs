using Microsoft.AspNetCore.Mvc;

namespace TestWebApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : Controller
{
    private readonly IConfiguration _configuration;

    public HelloController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Gets the value set in the appsettings.json file
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "GetSettingValue")]
    public IActionResult Get()
    {
        var settingValue = _configuration.GetValue<string>("AppSetting:Value");

        return Ok(settingValue);
    }

}