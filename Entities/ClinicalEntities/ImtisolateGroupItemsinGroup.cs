using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateGroupItemsinGroup
{
    public int LogId { get; set; }

    public int IsolateGroupListId { get; set; }

    public int IsolateGroupId { get; set; }
}
