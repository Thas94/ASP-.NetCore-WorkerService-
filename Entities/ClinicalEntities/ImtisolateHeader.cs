using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateHeader
{
    public int IsolateId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public int? InstitutionId { get; set; }

    public string? PatientFullName { get; set; }

    public string? PatientIdnumber { get; set; }

    public string? Pminumber { get; set; }

    public string? CaseNo { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? LabId { get; set; }

    public bool? IsPositive { get; set; }

    public int? IsolateGroupId { get; set; }

    public int? SpecimenGroupId { get; set; }

    public bool? IsFinal { get; set; }

    public string? InstitutionName { get; set; }

    public int? ResultTypeGroupId { get; set; }

    public long? Hl7personLogId { get; set; }

    public long? Hl7AssociatedPersonLogId { get; set; }

    public string? OrganismIdentified { get; set; }

    public bool? Adt { get; set; }

    public int? Obrid { get; set; }

    public DateTime? CollectionDate { get; set; }

    public DateTime? SpecimenReceivedDate { get; set; }

    public string? SpecimenSite { get; set; }

    public string? SpecimenSource { get; set; }

    public string? PatientLocationBed { get; set; }

    public string? PatientLocationRoom { get; set; }

    public string? PatientLocationWard { get; set; }

    public string? LabSpecimenSite { get; set; }

    public string? LabSpecimenSource { get; set; }

    public bool? NoLink { get; set; }

    public DateTime? ReconciledDate { get; set; }

    public int? ReconciledStatusId { get; set; }

    public virtual ICollection<ImtisolateDetailHeader> ImtisolateDetailHeaders { get; set; } = new List<ImtisolateDetailHeader>();
}
