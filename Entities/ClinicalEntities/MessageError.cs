using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class MessageError
{
    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string OriginalMessage { get; set; } = null!;

    public string? ErrorMessage { get; set; }

    public DateTime DateTimeInserted { get; set; }
}
