using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtspecimenAndGroupFromTestName
{
    public long Id { get; set; }

    public int LabId { get; set; }

    public string Obr42UniversalServiceIdentifierText { get; set; } = null!;

    public int SpecimenSitesFriendlyId { get; set; }

    public int SpecimenGroupId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public bool? Active { get; set; }

    public virtual Imtlab Lab { get; set; } = null!;

    public virtual ImtspecimenGroup SpecimenGroup { get; set; } = null!;

    public virtual ImtspecimenSitesFriendly SpecimenSitesFriendly { get; set; } = null!;
}
