using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateLrtPnuDiagnosis
{
    public int PnuId { get; set; }

    public string PnuDescription { get; set; } = null!;

    public string? ImagingTestCriteria { get; set; }

    public string? SignSymptomsCriteria { get; set; }

    public string? LaboratoryCriteria { get; set; }
}
