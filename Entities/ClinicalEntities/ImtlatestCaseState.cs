using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtlatestCaseState
{
    public long LatestCaseStatesId { get; set; }

    public string CaseNumber { get; set; } = null!;

    public bool PatientCurrentlyAdmitted { get; set; }

    public bool? PatientCurrentlyDeceased { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? AdmittedDate { get; set; }

    public DateTime? DischargedDate { get; set; }

    public long? Hl7personLogIdcurrentLocation { get; set; }

    public DateTime? PatientDeathDateTime { get; set; }

    public string? PatientLocationPointOfCare { get; set; }

    public string? PatientLocationRoom { get; set; }

    public string? PatientLocationBed { get; set; }

    public string? AdmittingDoctor { get; set; }

    public long? PatientPminumber { get; set; }

    public string? PatientIdnumber { get; set; }

    public DateTime? PatientDob { get; set; }

    public string? PatientMedicalAid { get; set; }

    public string? PatientFullName { get; set; }

    public Guid? Hl7uniqueIdentifierCurrentLocation { get; set; }

    public string? PatientSex { get; set; }

    public string? PatientFirstName { get; set; }

    public string? PatientSurname { get; set; }

    public string? PatientStreetAddress { get; set; }

    public string? PatientMedicalAidPolicyNumber { get; set; }

    public int? InstitutionMasterId { get; set; }

    public string? InstitutionSapIshCode { get; set; }

    public string? PatientClass { get; set; }

    public string? AdmissionType { get; set; }

    public long? AdmissionId { get; set; }

    public virtual Imtadmission? Admission { get; set; }
}
