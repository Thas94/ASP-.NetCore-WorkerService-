using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PharmacyStockMaster
{
    public string NappiCode { get; set; } = null!;

    public string? NappiNine { get; set; }

    public string? NappiSix { get; set; }

    public string? ProductDescript { get; set; }

    public string? RouteOfAdmin { get; set; }

    public decimal? PackSize { get; set; }

    public string? DosageForm { get; set; }

    public decimal? MetricStrength { get; set; }

    public string? StrengthUnitMeasure { get; set; }

    public decimal? CostPrice { get; set; }

    public string? TempCostpriceDate { get; set; }

    public DateTime? CostPriceDate { get; set; }

    public decimal? CostPriceHist1 { get; set; }

    public string? TempCosthist1Date { get; set; }

    public DateTime? CostHist1Date { get; set; }

    public decimal? CostPriceHist2 { get; set; }

    public string? TempCosthist2Date { get; set; }

    public DateTime? CostHist2Date { get; set; }

    public string? Schedule { get; set; }

    public string? GenericInd { get; set; }

    public string? MmapInd { get; set; }

    public string? ChronicInd { get; set; }

    public string? TempTClass { get; set; }

    public string? TherapeuticClass { get; set; }

    public string? TherapeuticClassDescr { get; set; }

    public string? ManufacturerName { get; set; }

    public decimal? SellPrice { get; set; }

    public string? TempSellpriceDate { get; set; }

    public DateTime? SellPriceDate { get; set; }

    public decimal? SellPriceHist1 { get; set; }

    public string? TempSellhist1Date { get; set; }

    public DateTime? SellHist1Date { get; set; }

    public decimal? SellPriceHist2 { get; set; }

    public string? TempSellhist2Date { get; set; }

    public DateTime? SellHist2Date { get; set; }

    public string? ProductStatus { get; set; }

    public string? TempEffectiveDate { get; set; }

    public string? EffectiveDate { get; set; }

    public string? NewNappi { get; set; }

    public string? GenericProductNumber { get; set; }

    public string? GenericProductDescription { get; set; }

    public string? AtcCode { get; set; }

    public int? ImportTrackingId { get; set; }

    public int PharmacyStockMasterId { get; set; }
}
