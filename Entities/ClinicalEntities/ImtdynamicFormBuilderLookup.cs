using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtdynamicFormBuilderLookup
{
    public int LookupId { get; set; }

    public string LookupName { get; set; } = null!;

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? LookupQuery { get; set; }

    public bool? HaslookupParameters { get; set; }
}
