using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateGroupItem
{
    public int IsolateGroupListId { get; set; }

    public int LabId { get; set; }

    public string? IsolategroupItem { get; set; }

    public string? IsolateGroupItemDescription { get; set; }

    public int IsolateGroupTypeId { get; set; }

    public bool? Active { get; set; }

    public string? UniversalOrganismName { get; set; }
}
