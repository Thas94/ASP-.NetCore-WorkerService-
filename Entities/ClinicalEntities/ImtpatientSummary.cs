using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtpatientSummary
{
    public long PatientSummaryId { get; set; }

    public long? Pmi { get; set; }

    public string? Title { get; set; }

    public string? Firstname { get; set; }

    public string? Surname { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Idnumber { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? ContactNumber { get; set; }

    public string? ContactNumber2 { get; set; }

    public string? Email { get; set; }

    public string? MedicalAidName { get; set; }

    public string? MedicalAidGroupName { get; set; }

    public string? MedicalAidPlan { get; set; }

    public string? PolicyNumber { get; set; }

    public bool? Deceased { get; set; }

    public DateTime? DeceasedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
