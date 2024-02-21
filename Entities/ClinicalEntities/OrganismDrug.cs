using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class OrganismDrug
{
    public int Id { get; set; }

    public int? AlertId { get; set; }

    public int? IsolateId { get; set; }

    public string? CaseNumber { get; set; }

    public string? PatientIdNumber { get; set; }

    public DateTime ObservationDate { get; set; }

    public string OrganismName { get; set; } = null!;

    public string SpecimenSite { get; set; } = null!;

    public string UniversalServiceIdentifier42 { get; set; } = null!;

    public string ObservationIdentifier31 { get; set; } = null!;

    public string ObservationText32 { get; set; } = null!;

    public string Sensitivity { get; set; } = null!;

    public bool Final { get; set; }

    public bool Repeats { get; set; }
}
