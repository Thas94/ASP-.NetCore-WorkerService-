using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtpatientVisitSummary
{
    public long VisitSummaryId { get; set; }

    public string CaseNumber { get; set; } = null!;

    public string? Pv12PatientClass { get; set; }

    public string? Pv14AdmissionType { get; set; }

    public string? Pv130AssignedPatientLocationPointOfCare { get; set; }

    public string? Pv131AssignedPatientLocationRoom { get; set; }

    public string? Pv132AssignedPatientLocationBed { get; set; }

    public string? Pv170AttendingDoctorIdnumber { get; set; }

    public string? Pv171AttendingDoctorFamilyName { get; set; }

    public string? Pv172AttendingDoctorGivenName { get; set; }

    public string? Pv180ReferringDoctorIdnumber { get; set; }

    public string? Pv181ReferringDoctorFamilyName { get; set; }

    public string? Pv182ReferringDoctorGivenName { get; set; }

    public string? Pv190ConsultingDoctorIdnumber { get; set; }

    public string? Pv191ConsultingDoctorFamilyName { get; set; }

    public string? Pv192ConsultingDoctorGivenName { get; set; }

    public string? Pv1170AdmittingDoctorIdnumber { get; set; }

    public string? Pv1171AdmittingDoctorFamilyName { get; set; }

    public string? Pv1172AdmittingDoctorGivenName { get; set; }

    public DateTime CreatedDate { get; set; }

    public long Hl7personLogId { get; set; }
}
