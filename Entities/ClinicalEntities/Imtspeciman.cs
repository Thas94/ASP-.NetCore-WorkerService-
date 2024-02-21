using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtspeciman
{
    public int SpecimenId { get; set; }

    public string Specimen { get; set; } = null!;

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UniversalDetailId { get; set; }

    public virtual ICollection<ImtspecimenInGroup> ImtspecimenInGroups { get; set; } = new List<ImtspecimenInGroup>();

    public virtual ICollection<ImtspecimenSiteSourceMapping> ImtspecimenSiteSourceMappings { get; set; } = new List<ImtspecimenSiteSourceMapping>();

    public virtual ImtspecimenUniversalDetail? UniversalDetail { get; set; }
}
