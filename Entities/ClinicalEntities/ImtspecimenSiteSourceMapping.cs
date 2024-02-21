using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtspecimenSiteSourceMapping
{
    public long Id { get; set; }

    public int SpecimenSiteId { get; set; }

    public int SpecimenSourceId { get; set; }

    public int SpecimenSiteFriendlyId { get; set; }

    public int SpecimenSourceFriendlyId { get; set; }

    public bool? Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Imtspeciman SpecimenSite { get; set; } = null!;

    public virtual ImtspecimenSitesFriendly SpecimenSiteFriendly { get; set; } = null!;

    public virtual ImtspecimenSource SpecimenSource { get; set; } = null!;

    public virtual ImtspecimenSourcesFriendly SpecimenSourceFriendly { get; set; } = null!;
}
