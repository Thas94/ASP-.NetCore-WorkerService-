using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class SurgicalProphylaxisScriptUpdate
{
    public int Id { get; set; }

    public string CaseNo { get; set; } = null!;

    public int? DoseId { get; set; }

    public string? DoseValue { get; set; }

    public int? DoseCount { get; set; }

    public int? FrequencyId { get; set; }

    public int SurgicalDisciplineId { get; set; }

    public string? FrequencyValue { get; set; }

    public string? SurgicalDisciplineValue { get; set; }

    public string? DoseIdValue { get; set; }

    public string? LoadingDose { get; set; }

    public string AntibioticName { get; set; } = null!;

    public string? AntibioticNameOther { get; set; }

    public string DoctorName { get; set; } = null!;

    public DateTime? AdministrationTime { get; set; }

    public DateTime? IncisionTime { get; set; }

    public DateTime? DiscontinuationTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public int? MinProcedureId { get; set; }
}
