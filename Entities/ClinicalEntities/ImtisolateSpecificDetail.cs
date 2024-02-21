using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateSpecificDetail
{
    public int IsolateSpecificDetailId { get; set; }

    public int IsolateId { get; set; }

    public bool IsMicroOrganism { get; set; }

    public bool BloodStreamInfection { get; set; }

    public bool MixedGrowth { get; set; }

    public bool MoreTahn15MicroIdentified { get; set; }

    public bool IsDiagnosed { get; set; }

    public string? DiagnosedDescription { get; set; }

    public string? Surgery { get; set; }

    public string? TbClassifcation { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
