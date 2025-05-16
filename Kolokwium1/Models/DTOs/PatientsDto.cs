namespace Kolokwium1.Models.DTOs;



public class PatientDto
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
    private List<ServiceDetailsDto> services { get; set; } = [];
}

public class AppointmentDetailsDto
{
    public DateTime date { get; set; }
    public List<PatientDto> patient { get; set; } = [];
    public List<DoctorDto> doctor { get; set; } = [];
    public List<AppointmentServicesDto> appointmentServices { get; set; } = [];
    
}

public class ServiceDetailsDto
{
    public string serviceName { get; set; }
    public int serviceFee { get; set; }
}

public class AppointmentServicesDto
{
    public string name { get; set; }
    public int serviceFee { get; set; }
    
}

public class DoctorDto
{
    public int doctorId { get; set; }
    public string pwz { get; set; }
}