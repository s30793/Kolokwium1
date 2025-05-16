namespace Kolokwium1.Services;
using Kolokwium1.Models.DTOs;
using Microsoft.Data.SqlClient;

public class xService : I_x_Service
{
    private readonly string _connectionString;
    
    public xService(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Default") ?? string.Empty;
    }
    
                        //                                  //
    public async Task<CustomerRentalHistoryDto> Get_x(int customerId)
    {
        var query = 
        await using SqlConnection conn = new SqlConnection(_connectionString);
        await using SqlCommand com = new SqlCommand();
        
        com.Connection = conn;
        com.CommandText = query;
        await conn.OpenAsync();
    }

    public async Task AddNewRentalAsync(int customerId, CreateRentalRequestDto rentalRequest)
    {

        await using SqlConnection conn = new SqlConnection(_connectionString);
        await using SqlCommand com = new SqlCommand();

        com.Connection = conn;
        await conn.OpenAsync();

    }