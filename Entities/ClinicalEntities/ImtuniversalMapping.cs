using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtuniversalMapping
{
    public int UniversalMappingIdentifierId { get; set; }

    public int LabId { get; set; }

    public string LabCode { get; set; } = null!;

    public string LabDescription { get; set; } = null!;

    public int IsolateGroupTypeId { get; set; }

    public bool Active { get; set; }

    public string UniversalOrganismName { get; set; } = null!;

    public bool IsMarkedAsOrganism { get; set; }

    public bool IsDohnotifiableCondition { get; set; }

    public int DohnotifiableConditionId { get; set; }
}
