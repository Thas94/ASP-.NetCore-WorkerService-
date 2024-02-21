using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateFlagGroup
{
    public int IsolateFlagGroupId { get; set; }

    public string? GroupName { get; set; }

    public bool? Active { get; set; }

    public int? RuleFlagId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
