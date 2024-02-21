using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditActivityTracking
{
    public int Id { get; set; }

    public int AuditId { get; set; }

    public DateTime Date { get; set; }

    public string Reason { get; set; } = null!;

    public int AuditActionTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual ImtabxauditHeader Audit { get; set; } = null!;

    public virtual AbsAuditTrackingActionLookup AuditActionType { get; set; } = null!;
}
