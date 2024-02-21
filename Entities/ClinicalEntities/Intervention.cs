using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Intervention
{
    public int InterventionId { get; set; }

    public int InterventionTypeId { get; set; }

    public int? InterventionAdditionalTypeId { get; set; }

    public int? PatientId { get; set; }

    public int InstitutionMasterId { get; set; }

    public int DrugId { get; set; }

    public string? Ward { get; set; }

    public string? Pminumber { get; set; }

    public string? CaseNo { get; set; }

    public string? Abx { get; set; }

    public int InterventionGroupId { get; set; }

    public string? Indication { get; set; }

    public string? Prescriber { get; set; }

    public string? Recommendation { get; set; }

    public bool? Status { get; set; }

    public string? Reason { get; set; }

    public int PharmId { get; set; }

    public int CommunicationTypeId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? QuestionId { get; set; }

    public int? ContentType { get; set; }

    public int? ContentId { get; set; }

    public string? InterventionTypeNoneOther { get; set; }

    public long? PersonLogId { get; set; }

    public string? DoctorName { get; set; }

    public virtual CommunicationType CommunicationType { get; set; } = null!;
}
