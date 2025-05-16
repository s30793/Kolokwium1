namespace Kolokwium1.Controllers;

using Kolokwium1.Exceptions;
using Kolokwium1.Models.DTOs;
using Kolokwium1.Services;
using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public AppointmentsController(IDbService dbService)
        {
            _dbService = dbService;
        }
    }
    
    
    
    /*
    [HttpGet("appointments/{id}")]           
    public async Task<IActionResult> GetAllPatients(int id)
    {
        var result = await _dbService.GetPatientsAsync(id);
        return Ok(result);
    }


    [HttpPost("appointments")]     
    public async Task<IActionResult> AddAppointment(int id, AppointmentDetailsDto dto)
    {
      
    }*/
    