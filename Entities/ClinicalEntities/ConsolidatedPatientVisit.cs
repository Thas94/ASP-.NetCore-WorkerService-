using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ConsolidatedPatientVisit
{
    public string Pminumber { get; set; } = null!;

    public string Sapnumber { get; set; } = null!;

    public Guid Hl7uniqueIdentifier { get; set; }

    public string? PatientClass { get; set; }

    public string? LastKnownWard { get; set; }

    public string? LastKnownRoom { get; set; }

    public string? LastKnownBed { get; set; }

    public string? LastKnownFloorOrWardName { get; set; }

    public string? AdmissionType { get; set; }

    public string? LastKnownAttendingDoctorMpnumber { get; set; }

    public string? LastKnownAttendingDoctorLastName { get; set; }

    public string? LastKnownAttendingDoctorFirstName { get; set; }

    public string? ReferringDoctorMpnumber { get; set; }

    public string? ReferringDoctorLastName { get; set; }

    public string? ReferringDoctorFirstName { get; set; }

    public string? LastKnownConsultingDoctorMpnumber { get; set; }

    public string? LastKnownConsultingDoctorLastName { get; set; }

    public string? LastKnownConsultingDoctorFirstName { get; set; }

    public DateTime? AdmitDateTime { get; set; }

    public DateTime? DischargeDateTime { get; set; }

    public byte? Discharged { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}
