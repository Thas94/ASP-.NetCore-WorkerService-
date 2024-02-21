using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Comorbidity
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<PatientComorbidity> PatientComorbidities { get; set; } = new List<PatientComorbidity>();
}
