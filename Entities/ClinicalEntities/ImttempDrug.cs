using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImttempDrug
{
    public int Id { get; set; }

    public string? Drug { get; set; }

    public string? DrugCode { get; set; }

    public string? MaterialText { get; set; }

    public string? ActiveIngredientText { get; set; }

    public string? NappiCode { get; set; }

    public string? Activeingredient2 { get; set; }

    public string? Activeingredient3 { get; set; }

    public string? Activeingredient4 { get; set; }

    public string? Activeingredient5 { get; set; }

    public string? Activeingredient6 { get; set; }

    public string? Activeingredient7 { get; set; }

    public string? Activeingredient8 { get; set; }

    public bool? Active { get; set; }
}
