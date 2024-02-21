using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CapauditSelectableOption
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual CapauditQuestion? Question { get; set; }
}
