using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtexceptionScriptDristribustionGroup
{
    public int DristribustionGroupId { get; set; }

    public string DristribustionGroupName { get; set; } = null!;

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ImtexceptionScriptDristribustionList> ImtexceptionScriptDristribustionLists { get; set; } = new List<ImtexceptionScriptDristribustionList>();
}
