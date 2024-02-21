using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtdynamicFormBuilder
{
    public int QuestionId { get; set; }

    public int ParentQuestionId { get; set; }

    public string? ParentQuestionContainer { get; set; }

    public string? ParentQuestionSelection { get; set; }

    public int? QuestionSequence { get; set; }

    public string Question { get; set; } = null!;

    public string? QuestionDesc { get; set; }

    public string ControlId { get; set; } = null!;

    public string ControlType { get; set; } = null!;

    public string? ControlIcon { get; set; }

    public int? LookupId { get; set; }

    public string? LookupDefaultValue { get; set; }

    public string? ImtlookUpField { get; set; }

    public int StyleId { get; set; }

    public int FormId { get; set; }

    public int SectionId { get; set; }

    public int? HasWorkFlow { get; set; }

    public string? WorkFlowContainer { get; set; }

    public int? ValidationId { get; set; }

    public int? Ismandatory { get; set; }

    public bool Active { get; set; }

    public int? ControlIsReadOnly { get; set; }

    public int? QueryId { get; set; }

    public int? AddButtonRequired { get; set; }

    public string? ControlSpecialContainer { get; set; }

    public int? GrouplookQueryId { get; set; }

    public int? GroupNotSelectedlookupQueryId { get; set; }
}
