using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtpatientEventSummary
{
    public long EventSummaryId { get; set; }

    public string CaseNumber { get; set; } = null!;

    public string EventTypeCode { get; set; } = null!;

    public string EventTypeDescription { get; set; } = null!;

    public DateTime EventRecordedDateTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
