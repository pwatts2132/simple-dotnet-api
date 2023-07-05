using FootballPlayerAPI.Models;
using FootballPlayerAPI.Services.FootballPlayerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballPlayerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FootballPlayerController : ControllerBase
{
    private readonly IFootballPlayerService _footballPlayerService;

    public FootballPlayerController(IFootballPlayerService footballPlayerService)
    {
        _footballPlayerService = footballPlayerService;
    }

    [HttpGet]
    public async Task<ActionResult<List<FootballPlayer>>> GetFootballPlayers()
    {
        return _footballPlayerService.GetFootballPlayers();
    }

    [HttpGet("Id")]
    public async Task<ActionResult<FootballPlayer>> GetFootballPlayer(int Id)
    {
        var result = _footballPlayerService.GetFootballPlayer(Id);
        if (result == null)
        {
            return NotFound("Football Player Was Not Found.");
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<FootballPlayer>> CreateFootballPlayer(FootballPlayer footballPlayer)
    {
        var result = _footballPlayerService.CreateFootballPlayer(footballPlayer);
        return Ok(result);
    }

    [HttpPut("Id")]
    public async Task<ActionResult<FootballPlayer>> UpdateFootballPlayer(int Id, FootballPlayer request)
    {
        var result = _footballPlayerService.UpdateFootballPlayer(Id, request);
        if (result == null)
        {
            return NotFound("Football Player Was Not Found");
        }
        return Ok(result);
    }

    [HttpDelete("Id")]
    public async Task<ActionResult<List<FootballPlayer>>> DeleteFootballPlayer(int Id)
    {
        var result = _footballPlayerService.DeleteFootballPlayer(Id);
        if (result == null)
        {
            return NotFound("Football Player Was Not Found");
        }
        return Ok(result);
    }
}
