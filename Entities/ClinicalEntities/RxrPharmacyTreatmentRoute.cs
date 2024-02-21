using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class RxrPharmacyTreatmentRoute
{
    public int PkRxrId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string? Rxr1Route { get; set; }

    public string? Rxr11RouteIdentifier { get; set; }

    public string? Rxr12RouteText { get; set; }

    public string? Rxr13RouteNameOfCodingSystem { get; set; }

    public string? Rxr14RouteAlternateIdentifier { get; set; }

    public string? Rxr15RouteAlternateText { get; set; }

    public string? Rxr16RouteNameOfAlternateCodingSystem { get; set; }

    public string? Rxr2AdministrationSite { get; set; }

    public string? Rxr21AdministrationSiteIdentifier { get; set; }

    public string? Rxr22AdministrationSiteText { get; set; }

    public string? Rxr23AdministrationSiteNameOfCodingSystem { get; set; }

    public string? Rxr24AdministrationSiteAlternateIdentifier { get; set; }

    public string? Rxr25AdministrationSiteAlternateText { get; set; }

    public string? Rxr26AdministrationSiteNameOfAlternateCodingSystem { get; set; }

    public string? Rxr3AdministrationDevice { get; set; }

    public string? Rxr31AdministrationDeviceIdentifier { get; set; }

    public string? Rxr32AdministrationDeviceText { get; set; }

    public string? Rxr33AdministrationDeviceNameOfCodingSystem { get; set; }

    public string? Rxr34AdministrationDeviceAlternateIdentifier { get; set; }

    public string? Rxr35AdministrationDeviceAlternateText { get; set; }

    public string? Rxr36AdministrationDeviceNameOfAlternateCodingSystem { get; set; }

    public string? Rxr4AdministrationMethod { get; set; }

    public string? Rxr41AdministrationMethodIdentifier { get; set; }

    public string? Rxr42AdministrationMethodText { get; set; }

    public string? Rxr43AdministrationMethodNameOfCodingSystem { get; set; }

    public string? Rxr44AdministrationMethodAlternateIdentifier { get; set; }

    public string? Rxr45AdministrationMethodAlternateText { get; set; }

    public string? Rxr46AdministrationMethodNameOfAlternateCodingSystem { get; set; }

    public string? Rxr5RoutingInstruction { get; set; }

    public string? Rxr51RoutingInstructionIdentifier { get; set; }

    public string? Rxr52RoutingInstructionText { get; set; }

    public string? Rxr53RoutingInstructionNameOfCodingSystem { get; set; }

    public string? Rxr54RoutingInstructionAlternateIdentifier { get; set; }

    public string? Rxr55RoutingInstructionAlternateText { get; set; }

    public string? Rxr56RoutingInstructionNameOfAlternateCodingSystem { get; set; }
}
