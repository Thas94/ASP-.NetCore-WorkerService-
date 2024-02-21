using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtexceptionScriptDristribustionList
{
    public int ListId { get; set; }

    public int DristribustionGroupId { get; set; }

    public string Email { get; set; } = null!;

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ImtexceptionScriptDristribustionGroup DristribustionGroup { get; set; } = null!;
}
