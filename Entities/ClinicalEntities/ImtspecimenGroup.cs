using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtspecimenGroup
{
    public int SpecimenGroupId { get; set; }

    public string? SpecimenGroupName { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ImtIsolateCdcClassification> ImtIsolateCdcClassifications { get; set; } = new List<ImtIsolateCdcClassification>();

    public virtual ICollection<ImtisolateSpecimenEventType> ImtisolateSpecimenEventTypes { get; set; } = new List<ImtisolateSpecimenEventType>();

    public virtual ICollection<ImtspecimenAndGroupFromTestName> ImtspecimenAndGroupFromTestNames { get; set; } = new List<ImtspecimenAndGroupFromTestName>();

    public virtual ICollection<ImtspecimenInGroup> ImtspecimenInGroups { get; set; } = new List<ImtspecimenInGroup>();
}
