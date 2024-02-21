using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtIsolateCdcClassification
{
    public int IsolateSymptomClassificationId { get; set; }

    public string Classification { get; set; } = null!;

    public string? Criteria { get; set; }

    public int FkSpecimenGroupId { get; set; }

    public bool? Active { get; set; }

    public virtual ImtspecimenGroup FkSpecimenGroup { get; set; } = null!;
}
