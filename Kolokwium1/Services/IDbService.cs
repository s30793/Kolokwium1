namespace Kolokwium1.Services;

using Kolokwium1.Models.DTOs;

public class I_x_Service
{
    public interface IDbService
    {
        Task<CustomerRentalHistoryDto> GetRentalsForCustomerByIdAsync(int customerId);
        Task AddNewRentalAsync(int customerId, CreateRentalRequestDto rentalRequest);
    }
}