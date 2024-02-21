using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Hl7messageSplitLog
{
    public int SplitLogId { get; set; }

    public int Saphl7msgId { get; set; }

    public int Hl7msgTypeId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public bool Processed { get; set; }

    public bool? HasError { get; set; }

    public bool? Locked { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsolateCreated { get; set; }

    public bool? Abxcreated { get; set; }

    public bool? AbxdrugCorrection { get; set; }

    public int? InstitutionId { get; set; }

    public string? InstitutionName { get; set; }

    public int? LabId { get; set; }

    public bool? ProcessedAbs { get; set; }

    public bool? ProcessedIpp { get; set; }

    public string? CaseNo { get; set; }

    public bool? Unreconciled { get; set; }

    public string? UnreconciledCase { get; set; }
}
