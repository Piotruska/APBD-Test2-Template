using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Test2Template.Api.Services;

namespace Test2Template.Api.Controllers;

public class MyController : ControllerBase
{
    private ImyService _service;
    
    public MyController(ImyService service)
    {
        _service = service;
    }

    /// <summary>
    /// Endpoints used to .
    /// </summary>
    /// <returns>...</returns>
    /// HttpGet - Get data
    /// HttpPost - Add data
    /// HttpPut - Update Data
    /// HttpDelete - Selete Data

    [HttpPost("api/")]
    public async Task<IActionResult> GetAsync()
    {
        var a = await _service.GetAsync();
        return Ok(a);
    }

}