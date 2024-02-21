using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtworkFlowReturnField
{
    public int WorkFlowReturnFieldId { get; set; }

    public int WorkFlowId { get; set; }

    public string WorkFlowReturnField { get; set; } = null!;

    public string WorkFlowReturnFieldDataType { get; set; } = null!;

    public bool Active { get; set; }

    public string WorkFlowQueryLookupValue { get; set; } = null!;

    public int ReturnQueryId { get; set; }
}
