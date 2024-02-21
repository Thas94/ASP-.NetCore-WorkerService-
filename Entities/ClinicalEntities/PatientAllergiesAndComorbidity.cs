using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PatientAllergiesAndComorbidity
{
    public int Id { get; set; }

    public string? PmiNumber { get; set; }

    public int? InstitutionMasterId { get; set; }

    public decimal? Weight { get; set; }

    public string? OtherAllergy { get; set; }

    public string? OtherComobidity { get; set; }

    public virtual ICollection<PatientAllergy> PatientAllergies { get; set; } = new List<PatientAllergy>();

    public virtual ICollection<PatientComorbidity> PatientComorbidities { get; set; } = new List<PatientComorbidity>();
}
