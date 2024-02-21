using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditTrackingActionLookup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AbsAuditActivityTracking> AbsAuditActivityTrackings { get; set; } = new List<AbsAuditActivityTracking>();
}
