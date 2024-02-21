using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateDetail
{
    public int IsolateDetailId { get; set; }

    public int IsolateDetailHeaderId { get; set; }

    public string? Obx31ObservationIdentifier { get; set; }

    public string? Obx32ObservationIdentifierText { get; set; }

    public string? Obx33ObservationIdentifierNameOfCodingSystem { get; set; }

    public string? Obx5ObservationValue { get; set; }

    public string? Obx61UnitsIdentifier { get; set; }

    public string? Obx7ReferenceRange { get; set; }

    public string? Obx8AbnormalFlags { get; set; }

    public DateTime? Obx141DateTimeOfObservationTimeOfEvent { get; set; }

    public virtual ImtisolateDetailHeader IsolateDetailHeader { get; set; } = null!;
}
