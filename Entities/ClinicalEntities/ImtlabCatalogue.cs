using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtlabCatalogue
{
    public int CatalogueId { get; set; }

    public string LabCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public int LabId { get; set; }

    public bool Active { get; set; }

    public int CatalogueTypeId { get; set; }
}
