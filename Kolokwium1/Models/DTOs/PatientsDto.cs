namespace Kolokwium1.Models.DTOs;



public class PatientsDto
{
    public int patientId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime dateOfBirth { get; set; }
    
}


public class CreateAppointmentDto
{
    public int appointmentId { get; set; }
    public int patientId { get; set; }
    public string pwz { get; set; }
    private List<> services { get; set; } = [];
}

public class AppointmentDetailsDto
{
    public DateTime date { get; set; }
    List<PatientsDto> patients { get; set; } = [];
}

public class ServiceDetailsDto
{
    public string name { get; set; }
    public int serviceFee { get; set; }
} 