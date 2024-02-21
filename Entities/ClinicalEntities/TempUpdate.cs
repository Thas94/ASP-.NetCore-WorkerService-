using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class TempUpdate
{
    public int Id { get; set; }

    public int LogId { get; set; }

    public Guid? Hl7uniqueIdentifier { get; set; }

    public string? CaseNo { get; set; }
}
