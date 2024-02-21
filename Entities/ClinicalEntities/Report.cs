using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Report
{
    public int ReportId { get; set; }

    public bool Active { get; set; }

    public string? ReportLink { get; set; }

    public string? Title { get; set; }

    public int? ContentType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
