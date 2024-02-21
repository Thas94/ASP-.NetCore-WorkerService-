using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateAlternativeSpecimenGroup
{
    public int LogId { get; set; }

    public int? LabId { get; set; }

    public int SpecimenGroupId { get; set; }

    public string Obr42UniversalServiceIdentifierText { get; set; } = null!;
}
