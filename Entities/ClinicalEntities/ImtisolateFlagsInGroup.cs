using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateFlagsInGroup
{
    public int LogId { get; set; }

    public int IsolateFlagGroupId { get; set; }

    public int IsolateFlagId { get; set; }

    public int? Priority { get; set; }

    public bool? Active { get; set; }
}
