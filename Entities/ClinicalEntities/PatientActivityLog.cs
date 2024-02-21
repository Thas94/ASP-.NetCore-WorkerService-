using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PatientActivityLog
{
    public int Id { get; set; }

    public int ContentId { get; set; }

    public int LogTypeId { get; set; }

    public string CaseNumber { get; set; } = null!;

    public string PmiNumber { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? ColumnName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int? ForeignKeyTypeId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}
