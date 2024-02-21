using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Saphl7message
{
    public int Saphl7msgId { get; set; }

    public int Hl7msgTypeId { get; set; }

    public string Hl7message { get; set; } = null!;

    public bool Processed { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? HasError { get; set; }

    public bool? Locked { get; set; }

    public string? ErrorMessage { get; set; }
}
