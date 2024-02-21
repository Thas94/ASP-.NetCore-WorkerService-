using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CreassessmentQuestion
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public bool Required { get; set; }

    public int FieldType { get; set; }

    public bool IsDeleted { get; set; }
}
