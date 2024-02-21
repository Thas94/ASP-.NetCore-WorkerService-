using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtabxauditHeader
{
    public int AbxauditId { get; set; }

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

    public bool? IsTargetedDrug { get; set; }

    public string? InstitutionName { get; set; }

    public bool? IsinTracking { get; set; }

    public long? Hl7personLogId { get; set; }

    public long? Hl7AssociatedPersonLogId { get; set; }

    public int? IsActiveBeforeDischarge { get; set; }

    public DateTime? UpdatedDateBeforeDischarge { get; set; }

    public string? UpdatedByBeforeDischarge { get; set; }

    public int? OriginalAbxauditId { get; set; }

    public virtual ICollection<AbsAuditActivityTracking> AbsAuditActivityTrackings { get; set; } = new List<AbsAuditActivityTracking>();

    public virtual ICollection<AbsAuditAnswer> AbsAuditAnswers { get; set; } = new List<AbsAuditAnswer>();

    public virtual ICollection<CapauditAnswer> CapauditAnswers { get; set; } = new List<CapauditAnswer>();

    public virtual ImtabxauditDetail? ImtabxauditDetail { get; set; }
}
