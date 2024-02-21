using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtruleDetail
{
    public int RuleDetailId { get; set; }

    public int FlagId { get; set; }

    public int Seq { get; set; }

    public int ResultTypeGroupId { get; set; }

    public int ResultTypeGroupNameId { get; set; }

    public int MicroTestId { get; set; }

    public int MicroTestGroupId { get; set; }

    public int SpecimenId { get; set; }

    public int SpecimenGroupId { get; set; }

    public int EnzymeGroupId { get; set; }

    public int OrganismId { get; set; }

    public int OrganismGroupId { get; set; }

    public int AtcdrugId { get; set; }

    public int AtcdrugGroupId { get; set; }

    public int AtccustomDrugFilterId { get; set; }

    public int LabDrugId { get; set; }

    public int LabDrugGroupId { get; set; }

    public int WorkFlowId { get; set; }

    public int ValidationWorkFlowId { get; set; }

    public int UnitOfMeasurementId { get; set; }

    public int Hl7tableId { get; set; }

    public int Hl7tableColumnId { get; set; }

    public int CriteriaOpporatorId { get; set; }

    public int RuleCriteriaValueGroupId { get; set; }

    public decimal RuleCriteriaValue { get; set; }

    public int QueryId { get; set; }

    public int? IdentifiesOrganism { get; set; }

    public int? CheckForDuplicate { get; set; }

    public int? UsesBaseQuery { get; set; }
}
