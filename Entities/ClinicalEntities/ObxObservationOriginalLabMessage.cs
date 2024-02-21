using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ObxObservationOriginalLabMessage
{
    public int LogId { get; set; }

    public int FkObrId { get; set; }

    public long? Hl7personLogId { get; set; }

    public string? LabOriginalMessage { get; set; }

    public DateTime? DateTimeInserted { get; set; }

    public long? StorageApiFileId { get; set; }

    public bool? StorageApiArchiveFailed { get; set; }

    public Guid? Hl7uniqueIdentifier { get; set; }

    public string? CaseNo { get; set; }

    public virtual ObrObservationRequest FkObr { get; set; } = null!;
}
