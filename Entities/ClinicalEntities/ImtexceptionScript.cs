using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtexceptionScript
{
    public int ExceptionScriptId { get; set; }

    public string ExceptionScriptName { get; set; } = null!;

    public int DristribustionGroupId { get; set; }

    public string ExceptionScriptSubject { get; set; } = null!;

    public bool HasHtmlbody { get; set; }

    public bool HasAttachment { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ImtscriptsInException> ImtscriptsInExceptions { get; set; } = new List<ImtscriptsInException>();
}
