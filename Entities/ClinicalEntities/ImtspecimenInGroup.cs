using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtspecimenInGroup
{
    public int SpecimenInGroupsId { get; set; }

    public int? SpecimenGroupId { get; set; }

    public int? SpecimenId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Imtspeciman? Specimen { get; set; }

    public virtual ImtspecimenGroup? SpecimenGroup { get; set; }
}
