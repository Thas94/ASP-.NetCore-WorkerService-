using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PatientAllergy
{
    public int Id { get; set; }

    public string? Pmi { get; set; }

    public int AllergiesId { get; set; }

    public int PatientAllergiesAndComorbiditiesId { get; set; }

    public DateTime? DateAdded { get; set; }

    public DateTime? DateUpdated { get; set; }

    public virtual Allergy Allergies { get; set; } = null!;

    public virtual PatientAllergiesAndComorbidity PatientAllergiesAndComorbidities { get; set; } = null!;
}
