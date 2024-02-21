using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateGroupClassification
{
    public int IsolateClassificationId { get; set; }

    public string Description { get; set; } = null!;

    public int Type { get; set; }

    public string TypeDesciption { get; set; } = null!;

    public string FullDescription { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }
}
