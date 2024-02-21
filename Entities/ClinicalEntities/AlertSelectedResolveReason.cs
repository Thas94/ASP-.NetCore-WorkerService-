using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AlertSelectedResolveReason
{
    public int AlertSelectedResolveReasonId { get; set; }

    public int WorkListResolveReasonId { get; set; }

    public int AlertId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public bool? IsActive { get; set; }

    public virtual ImtalertHeader Alert { get; set; } = null!;

    public virtual WorkListResolveReason WorkListResolveReason { get; set; } = null!;
}
