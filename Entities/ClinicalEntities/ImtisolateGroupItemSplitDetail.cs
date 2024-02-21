using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateGroupItemSplitDetail
{
    public int ImtisolateGroupItemSplitDetailId { get; set; }

    public int ImtisolateGroupItemSplitId { get; set; }

    public string Obx31ObservationIdentifier { get; set; } = null!;

    public string Obx32ObservationIdentifierText { get; set; } = null!;

    public string UniversalOrganismName { get; set; } = null!;
}
