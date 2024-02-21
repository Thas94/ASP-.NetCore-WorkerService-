using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtorganism
{
    public int OrganismId { get; set; }

    public string? Organism { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? LabId { get; set; }

    public string? Mnemonic { get; set; }

    public string? LabCode { get; set; }

    public string? UniversalOrganismName { get; set; }
}
