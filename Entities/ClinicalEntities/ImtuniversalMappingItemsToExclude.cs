using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtuniversalMappingItemsToExclude
{
    public int ExcludedUniversalMappingIdentifierId { get; set; }

    public int LabId { get; set; }

    public string LabCode { get; set; } = null!;

    public string LabDescription { get; set; } = null!;

    public int IsolateGroupTypeId { get; set; }
}
