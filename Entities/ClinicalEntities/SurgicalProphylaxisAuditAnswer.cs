using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class SurgicalProphylaxisAuditAnswer
{
    public int Id { get; set; }

    public string CaseNo { get; set; } = null!;

    public int QuestionId { get; set; }

    public int SelectedOptionId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int? MinProcedureId { get; set; }
}
