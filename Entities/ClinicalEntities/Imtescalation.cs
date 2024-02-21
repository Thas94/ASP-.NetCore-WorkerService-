using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtescalation
{
    public int EscalationId { get; set; }

    public string EscalationDescription { get; set; } = null!;

    public int EscalationDurationValue { get; set; }

    public string EscalationDurationUnitOfMeasurement { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
