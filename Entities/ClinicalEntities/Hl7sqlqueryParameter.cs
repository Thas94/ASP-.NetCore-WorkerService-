using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Hl7sqlqueryParameter
{
    public int ParameterId { get; set; }

    public int Hl7sqlqueryId { get; set; }

    public string ParameterName { get; set; } = null!;

    public string ParameterValue { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
