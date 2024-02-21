using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CapauditQuestionOptionLookup
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual ICollection<CapauditQuestionOption> CapauditQuestionOptions { get; set; } = new List<CapauditQuestionOption>();
}
