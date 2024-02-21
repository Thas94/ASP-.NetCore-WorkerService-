using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DiagnosisSub
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string? SubCategoryName { get; set; }

    public virtual ICollection<AbsScriptUpdate> AbsScriptUpdates { get; set; } = new List<AbsScriptUpdate>();

    public virtual Diagnosis Category { get; set; } = null!;
}
