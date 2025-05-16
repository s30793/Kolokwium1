using Microsoft.AspNetCore.Http.HttpResults;

namespace Kolokwium1.Services;
using Kolokwium1.Models.DTOs;
using Microsoft.Data.SqlClient;
using System.Data.Common;

public class DbService : IDbService
{
    private readonly string _connectionString;

    public DbService(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Default") ?? string.Empty;
    }

    //                                  //
    public async Task<AppointmentDetailsDto> GetAppointmentAsyc()
    {
        var results = new List<AppointmentDetailsDto>();
        var query = @"Select p.patient_id, p.first_name,p.last_name," +
                    "p.date_of_birth, d.doctor_id, d.PWZ, s.name,aps.service_fee from Patients p " +
                    "JOIN Appointment a ON p.patient_id = a.patient_id " +
                    "JOIN Doctor d ON d.doctor_id = a.doctor_id " +
                    "JOIN Appointment_Service aps ON a.appointment_id = aps.appointment_id " +
                    "JOIN Service s ON s.service_id =aps.service_id";

        await using SqlConnection connection = new SqlConnection(_connectionString);
        await using SqlCommand com = new SqlCommand();
        com.Connection = connection;
        com.CommandText = query;
        await connection.OpenAsync();

        // com.Parameters.AddWithValue("@patientId", patientId);
        var reader = await com.ExecuteReaderAsync();
        AppointmentDetailsDto? app = null;

        while (await reader.ReadAsync())
        {
            if (app == null)
                results.Add(new AppointmentDetailsDto
                {
                    date = reader.GetDateTime(0),
                    patient = new List<PatientDto>(),
                    doctor = new List<DoctorDto>(),
                    appointmentServices = new List<AppointmentServicesDto>()

                });
            await reader.CloseAsync();
        }

        return app;
    }

    public Task<AppointmentDetailsDto> GetAppointmentAsync()
    {
        return GetAppointmentAsyc();
    }

    public async Task<AppointmentDetailsDto> AddAppointmentAsync(int patientId, AppointmentDetailsDto dto)
    {

        await using SqlConnection connection = new SqlConnection(_connectionString);
        await using SqlCommand command = new SqlCommand();

        command.Connection = connection;
        await connection.OpenAsync();

        DbTransaction transaction = await connection.BeginTransactionAsync();
        command.Transaction = transaction as SqlTransaction;

        command.Parameters.AddWithValue("@patientId", patientId);

        command.Parameters.AddWithValue("@StatusId", 1);


//
        return null;

    }
}