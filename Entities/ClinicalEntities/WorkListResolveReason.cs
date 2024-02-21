using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class WorkListResolveReason
{
    public int WorkListResolveReasonId { get; set; }

    public int ContentTypeId { get; set; }

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public int? FlagId { get; set; }

    public int? OverrideSequenceOrder { get; set; }

    public bool? IsVisibleOnUi { get; set; }

    public virtual ICollection<AlertSelectedResolveReason> AlertSelectedResolveReasons { get; set; } = new List<AlertSelectedResolveReason>();
}
