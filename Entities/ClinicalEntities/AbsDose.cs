using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsDose
{
    public int DoseId { get; set; }

    public string? DoseDescription { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<AbsScriptUpdate> AbsScriptUpdates { get; set; } = new List<AbsScriptUpdate>();
}
