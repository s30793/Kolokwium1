namespace Kolokwium1.Services;

using Kolokwium1.Models.DTOs;

    public interface IDbService
    {
        Task<AppointmentDetailsDto> GetAppointmentAsync();
        Task<AppointmentDetailsDto> AddAppointmentAsync(int patientId, AppointmentDetailsDto appointment );
    }
