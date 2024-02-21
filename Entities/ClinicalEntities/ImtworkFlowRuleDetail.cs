using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtworkFlowRuleDetail
{
    public int WorkFlowRuleDetailId { get; set; }

    public int WorkFlowId { get; set; }

    public int WorkFlowResultTypeGroupId { get; set; }

    public int WorkFlowResultTypeGroupNameId { get; set; }

    public int WorkFlowMicroTestId { get; set; }

    public int WorkFlowMicroTestGroupId { get; set; }

    public int WorkFlowSpecimenId { get; set; }

    public int WorkFlowSpecimenGroupId { get; set; }

    public int WorkFlowEnzymeGroupId { get; set; }

    public int WorkFlowOrganismId { get; set; }

    public int WorkFlowOrganismGroupId { get; set; }

    public int WorkFlowAtcdrugId { get; set; }

    public int WorkFlowAtcdrugGroupId { get; set; }

    public int WorkFlowAtccustomDrugFilterId { get; set; }

    public int WorkFlowLabDrugId { get; set; }

    public int WorkFlowLabDrugGroupId { get; set; }

    public int WorkFlowWorkFlowId { get; set; }

    public int WorkFlowValidationWorkFlowId { get; set; }

    public int WorkFlowUnitOfMeasurementId { get; set; }

    public int WorkFlowHl7tableId { get; set; }

    public int WorkFlowHl7tableColumnId { get; set; }

    public int WorkFlowCriteriaOpporatorId { get; set; }

    public int WorkFlowRuleCriteriaValueGroupId { get; set; }

    public decimal WorkFlowRuleCriteriaValue { get; set; }

    public int WorkFlowQueryId { get; set; }

    public string? ReturnType { get; set; }

    public string? ReturnLookupValue { get; set; }

    public string? ConditionColumn { get; set; }

    public bool? IsMainQuery { get; set; }

    public string? MainQueryReturnLookupValue { get; set; }

    public bool? UnionQueries { get; set; }

    public string? ExternalLookupValue { get; set; }

    public int? HasExternalReturnFields { get; set; }

    public string? ExternalLookupValueDataType { get; set; }

    public int? RequiredRecords { get; set; }

    public string? WorkFlowCriteriaOpp { get; set; }

    public int? IdentifiesOrganism { get; set; }
}
