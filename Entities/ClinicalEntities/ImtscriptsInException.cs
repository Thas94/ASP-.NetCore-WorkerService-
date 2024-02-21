using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtscriptsInException
{
    public int ScriptId { get; set; }

    public int ExceptionScriptId { get; set; }

    public string? TabName { get; set; }

    public string ScriptName { get; set; } = null!;

    public int QueryId { get; set; }

    public int DisplaySequence { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ImtexceptionScript ExceptionScript { get; set; } = null!;
}
