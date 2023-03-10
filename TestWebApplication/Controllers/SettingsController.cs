using Microsoft.AspNetCore.Mvc;

namespace TestWebApplication.Controllers;

[ApiController]
//[Route("api/[controller]")]
public class SettingsController : Controller
{
    private readonly IConfiguration _configuration;

    public SettingsController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    [Route("[controller]/server")]
    public IActionResult GetDbServerConfig()
    {
        var settingValue = _configuration.GetValue<string>("Database:Server");

        return Ok(settingValue);
    }
    
    [HttpGet]
    [Route("[controller]/model")]
    public IActionResult GetDbModelConfig()
    {
        var settingValue = _configuration.GetValue<string>("Database:Model");

        return Ok(settingValue);
    }
    
    [HttpGet]
    [Route("[controller]/user")]
    public IActionResult GetDbUserConfig()
    {
        var settingValue = _configuration.GetValue<string>("Database:User");

        return Ok(settingValue);
    }
    
    [HttpGet]
    [Route("[controller]/admin")]
    public IActionResult GetDbAdminConfig()
    {
        var settingValue = _configuration.GetValue<string>("Database:Admin");

        return Ok(settingValue);
    }

}