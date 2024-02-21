using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtvalidationFlagsInGroup
{
    public int LogId { get; set; }

    public int ValidationGroupId { get; set; }

    public int FlagId { get; set; }
}
