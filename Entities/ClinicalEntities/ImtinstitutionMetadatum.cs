using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtinstitutionMetadatum
{
    public int Id { get; set; }

    public int InstitutionMasterId { get; set; }

    public string SapIshCode { get; set; } = null!;

    public string AbbreviatedInstitutionDescription { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
