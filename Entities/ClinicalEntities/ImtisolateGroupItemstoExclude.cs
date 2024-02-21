using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateGroupItemstoExclude
{
    public int IsolateGroupListExcludeId { get; set; }

    public int LabId { get; set; }

    public string? IsolateExcludegroupItem { get; set; }

    public string? IsolateExcludeGroupItemDescription { get; set; }

    public int IsolateGroupTypeId { get; set; }

    public bool? Active { get; set; }
}
