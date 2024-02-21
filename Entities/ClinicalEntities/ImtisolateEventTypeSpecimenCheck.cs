using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateEventTypeSpecimenCheck
{
    public int EventTypeSpecimenId { get; set; }

    public int SpecimenGroupId { get; set; }

    public int EventTypeId { get; set; }

    public string FieldCheck { get; set; } = null!;

    public string? FieldValue { get; set; }

    public int? FieldCheckCount { get; set; }

    public int OrderOfCheck { get; set; }

    public string? Criteria { get; set; }

    public bool IsActive { get; set; }
}
