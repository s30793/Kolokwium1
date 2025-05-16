namespace Kolokwium1.Controllers;

using Kolokwium1.Exceptions;
using Kolokwium1.Models.DTOs;
using Kolokwium1.Services;
using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class xController : ControllerBase
    {
        private readonly I_x_Service _dbService;

        public xController(I_x_Service dbService)
        {
            _dbService = dbService;
        }
    }
    
    
    
    [HttpGet("{id}/rentals")]           //
    public async Task<IActionResult> Get_x(int id)
    {
        var result = await _dbService.GetPolitycyAsync();
        return Ok(result);
    }


    [HttpPost("{id}/rentals")]      //
    public async Task<IActionResult> Add_x(int id, CreateRentalRequestDto createRentalRequest)
    {
        var result = await _dbService.CreatePartiaAsync(dto);
        return CreatedAtAction(nameof(GetAll), new { id = result.PartiaId }, result);
    }
    }