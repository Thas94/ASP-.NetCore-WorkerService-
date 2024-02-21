using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ConsolidatedMappingIdentifier
{
    public Guid? Hl7uniqueIdentifier { get; set; }

    public string Pminumber { get; set; } = null!;

    public string Sapnumber { get; set; } = null!;

    public DateTime EventDateTime { get; set; }

    public DateTime DateTimeInserted { get; set; }
}
