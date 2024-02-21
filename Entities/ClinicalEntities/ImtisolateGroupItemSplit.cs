using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateGroupItemSplit
{
    public int ImtisolateGroupItemSplitId { get; set; }

    public int LabId { get; set; }

    public string Obx31ObservationIdentifier { get; set; } = null!;

    public string Obx32ObservationIdentifierText { get; set; } = null!;

    public bool Active { get; set; }
}
