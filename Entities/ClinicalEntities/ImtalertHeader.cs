using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtalertHeader
{
    public int AlertId { get; set; }

    public int InstitutionId { get; set; }

    public int ApplicationTypeId { get; set; }

    public int AlertStatusId { get; set; }

    public int FlagId { get; set; }

    public int EscalationId { get; set; }

    public string? PatientFullName { get; set; }

    public string? PatientIdnumber { get; set; }

    public string? Pminumber { get; set; }

    public string? CaseNo { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public Guid? Hl7uniqueIdentifier { get; set; }

    public int? LabId { get; set; }

    public bool? Adt { get; set; }

    public string? InstitutionName { get; set; }

    public long? Hl7personLogId { get; set; }

    public long? Hl7AssociatedPersonLogId { get; set; }

    public string? OrganismIdentified { get; set; }

    public DateTime? ReconciledDate { get; set; }

    public int? ReconciledStatusId { get; set; }

    public virtual ICollection<AlertSelectedResolveReason> AlertSelectedResolveReasons { get; set; } = new List<AlertSelectedResolveReason>();

    public virtual ICollection<ImtalertDetail> ImtalertDetails { get; set; } = new List<ImtalertDetail>();

    public virtual ICollection<ImtdurationNotificationTracking> ImtdurationNotificationTrackings { get; set; } = new List<ImtdurationNotificationTracking>();
}
