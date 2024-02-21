using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateSurgerySelection
{
    public int SurgerySelectionId { get; set; }

    public string SurgerySelectionDescription { get; set; } = null!;

    public string SurgerySelectionCriteria { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }
}
