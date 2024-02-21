using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ConsolidatedPatientDetail
{
    public string Pminumber { get; set; } = null!;

    public string Sapnumber { get; set; } = null!;

    public Guid? Hl7uniqueIdentifier { get; set; }

    public string OriginalMessage { get; set; } = null!;

    public string OriginatingHospitalSapcode { get; set; } = null!;

    public DateTime DateTimeOfMessage { get; set; }

    public string TriggerEvent { get; set; } = null!;

    public string EventType { get; set; } = null!;

    public string PatientSurname { get; set; } = null!;

    public string PatientName { get; set; } = null!;

    public string? PatientTitle { get; set; }

    public DateTime? PatientDateOfBirth { get; set; }

    public string? PatientSex { get; set; }

    public string? PatientAddressLine1 { get; set; }

    public string? PatientAddressLine2 { get; set; }

    public string? PatientAddressLine3 { get; set; }

    public string? PatientAddressLine4 { get; set; }

    public string? PatientAddressPostalCode { get; set; }

    public string? PatientPhoneNumber1 { get; set; }

    public string? PatientPhoneNumber2 { get; set; }

    public string? PatientPhoneNumberBusiness { get; set; }

    public string? PatientEmail { get; set; }

    public string? PatientPrimaryLanguage { get; set; }

    public string? PatientMaritialStatus { get; set; }

    public string? PatientIdnumber { get; set; }

    public DateTime? PatientDeathDateTime { get; set; }

    public string? PatientDeathIndicator { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}
