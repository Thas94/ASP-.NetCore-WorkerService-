using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class clinicalHl7IMTntcwebcozadataContext : DbContext
{
    public clinicalHl7IMTntcwebcozadataContext()
    {
    }

    public clinicalHl7IMTntcwebcozadataContext(DbContextOptions<clinicalHl7IMTntcwebcozadataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AbsAuditActivityTracking> AbsAuditActivityTrackings { get; set; }

    public virtual DbSet<AbsAuditAnswer> AbsAuditAnswers { get; set; }

    public virtual DbSet<AbsAuditDay> AbsAuditDays { get; set; }

    public virtual DbSet<AbsAuditDrugDefaultQuestion> AbsAuditDrugDefaultQuestions { get; set; }

    public virtual DbSet<AbsAuditQuestion> AbsAuditQuestions { get; set; }

    public virtual DbSet<AbsAuditQuestionDrug> AbsAuditQuestionDrugs { get; set; }

    public virtual DbSet<AbsAuditQuestionMandatoryValidation> AbsAuditQuestionMandatoryValidations { get; set; }

    public virtual DbSet<AbsAuditQuestionOption> AbsAuditQuestionOptions { get; set; }

    public virtual DbSet<AbsAuditQuestionOptionLink> AbsAuditQuestionOptionLinks { get; set; }

    public virtual DbSet<AbsAuditQuestionOptionLookup> AbsAuditQuestionOptionLookups { get; set; }

    public virtual DbSet<AbsAuditSelectableOption> AbsAuditSelectableOptions { get; set; }

    public virtual DbSet<AbsAuditTrackingActionLookup> AbsAuditTrackingActionLookups { get; set; }

    public virtual DbSet<AbsDose> AbsDoses { get; set; }

    public virtual DbSet<AbsFrequency> AbsFrequencies { get; set; }

    public virtual DbSet<AbsRouteDoseGrouping> AbsRouteDoseGroupings { get; set; }

    public virtual DbSet<AbsScriptUpdate> AbsScriptUpdates { get; set; }

    public virtual DbSet<AbxAdhoc> AbxAdhocs { get; set; }

    public virtual DbSet<AlertSelectedResolveReason> AlertSelectedResolveReasons { get; set; }

    public virtual DbSet<Allergy> Allergies { get; set; }

    public virtual DbSet<ApplicationLog> ApplicationLogs { get; set; }

    public virtual DbSet<AtccustomDrugQuery> AtccustomDrugQueries { get; set; }

    public virtual DbSet<AuditChecklistCategory> AuditChecklistCategories { get; set; }

    public virtual DbSet<CapauditAnswer> CapauditAnswers { get; set; }

    public virtual DbSet<CapauditDetail> CapauditDetails { get; set; }

    public virtual DbSet<CapauditQuestion> CapauditQuestions { get; set; }

    public virtual DbSet<CapauditQuestionCategory> CapauditQuestionCategories { get; set; }

    public virtual DbSet<CapauditQuestionOption> CapauditQuestionOptions { get; set; }

    public virtual DbSet<CapauditQuestionOptionLookup> CapauditQuestionOptionLookups { get; set; }

    public virtual DbSet<CapauditSelectableOption> CapauditSelectableOptions { get; set; }

    public virtual DbSet<CommunicationType> CommunicationTypes { get; set; }

    public virtual DbSet<Comorbidity> Comorbidities { get; set; }

    public virtual DbSet<ConsolidatedEmployerDetail> ConsolidatedEmployerDetails { get; set; }

    public virtual DbSet<ConsolidatedInsurance> ConsolidatedInsurances { get; set; }

    public virtual DbSet<ConsolidatedMappingIdentifier> ConsolidatedMappingIdentifiers { get; set; }

    public virtual DbSet<ConsolidatedPatientDetail> ConsolidatedPatientDetails { get; set; }

    public virtual DbSet<ConsolidatedPatientVisit> ConsolidatedPatientVisits { get; set; }

    public virtual DbSet<CreassessmentAnswer> CreassessmentAnswers { get; set; }

    public virtual DbSet<CreassessmentQuestion> CreassessmentQuestions { get; set; }

    public virtual DbSet<CreassessmentQuestionOption> CreassessmentQuestionOptions { get; set; }

    public virtual DbSet<CreassessmentSelectableOption> CreassessmentSelectableOptions { get; set; }

    public virtual DbSet<CtiPatientDetail> CtiPatientDetails { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DeviceBcaauditAnswer> DeviceBcaauditAnswers { get; set; }

    public virtual DbSet<DeviceBcaauditHeading> DeviceBcaauditHeadings { get; set; }

    public virtual DbSet<DeviceBcaauditQuestion> DeviceBcaauditQuestions { get; set; }

    public virtual DbSet<DeviceType> DeviceTypes { get; set; }

    public virtual DbSet<DeviceTypeIndication> DeviceTypeIndications { get; set; }

    public virtual DbSet<DeviceTypeIndicationLink> DeviceTypeIndicationLinks { get; set; }

    public virtual DbSet<DeviceTypeSide> DeviceTypeSides { get; set; }

    public virtual DbSet<DeviceTypeSideLink> DeviceTypeSideLinks { get; set; }

    public virtual DbSet<DeviceTypeSite> DeviceTypeSites { get; set; }

    public virtual DbSet<DeviceTypeSiteLink> DeviceTypeSiteLinks { get; set; }

    public virtual DbSet<DeviceTypeSubType> DeviceTypeSubTypes { get; set; }

    public virtual DbSet<Dg1DiagnosisPrimary> Dg1DiagnosisPrimaries { get; set; }

    public virtual DbSet<Dg1DiagnosisPrimaryImportHistory> Dg1DiagnosisPrimaryImportHistories { get; set; }

    public virtual DbSet<Diagnosis> Diagnoses { get; set; }

    public virtual DbSet<DiagnosisSub> DiagnosisSubs { get; set; }

    public virtual DbSet<DohnotifiableCondition> DohnotifiableConditions { get; set; }

    public virtual DbSet<DrugClassAmpath> DrugClassAmpaths { get; set; }

    public virtual DbSet<DrugClassLancet> DrugClassLancets { get; set; }

    public virtual DbSet<DrugClassPathcare> DrugClassPathcares { get; set; }

    public virtual DbSet<DrugClassVermaak> DrugClassVermaaks { get; set; }

    public virtual DbSet<EvnEventType> EvnEventTypes { get; set; }

    public virtual DbSet<Fix> Fixes { get; set; }

    public virtual DbSet<FlagsInOrganism> FlagsInOrganisms { get; set; }

    public virtual DbSet<Hl7importlog> Hl7importlogs { get; set; }

    public virtual DbSet<Hl7messageSplitLog> Hl7messageSplitLogs { get; set; }

    public virtual DbSet<Hl7messageSplitLogProcess> Hl7messageSplitLogProcesses { get; set; }

    public virtual DbSet<Hl7messageSplitLogProcessError> Hl7messageSplitLogProcessErrors { get; set; }

    public virtual DbSet<Hl7sqlquery> Hl7sqlqueries { get; set; }

    public virtual DbSet<Hl7sqlqueryParameter> Hl7sqlqueryParameters { get; set; }

    public virtual DbSet<Htmltemplate> Htmltemplates { get; set; }

    public virtual DbSet<ImtIsolateCdcClassification> ImtIsolateCdcClassifications { get; set; }

    public virtual DbSet<ImtIsolateUrineInfectionCriterion> ImtIsolateUrineInfectionCriteria { get; set; }

    public virtual DbSet<Imtabsmonitoring> Imtabsmonitorings { get; set; }

    public virtual DbSet<ImtabxauditDetail> ImtabxauditDetails { get; set; }

    public virtual DbSet<ImtabxauditHeader> ImtabxauditHeaders { get; set; }

    public virtual DbSet<ImtabxtargetedDrug> ImtabxtargetedDrugs { get; set; }

    public virtual DbSet<Imtadmission> Imtadmissions { get; set; }

    public virtual DbSet<ImtalertCategory> ImtalertCategories { get; set; }

    public virtual DbSet<ImtalertDetail> ImtalertDetails { get; set; }

    public virtual DbSet<ImtalertHeader> ImtalertHeaders { get; set; }

    public virtual DbSet<ImtalertHeaderExcludeFlagsOnUi> ImtalertHeaderExcludeFlagsOnUis { get; set; }

    public virtual DbSet<ImtalertResolveOption> ImtalertResolveOptions { get; set; }

    public virtual DbSet<ImtalertStatus> ImtalertStatuses { get; set; }

    public virtual DbSet<Imtapirole> Imtapiroles { get; set; }

    public virtual DbSet<Imtapiuser> Imtapiusers { get; set; }

    public virtual DbSet<ImtapplicationType> ImtapplicationTypes { get; set; }

    public virtual DbSet<ImtatccodesInLabDrug> ImtatccodesInLabDrugs { get; set; }

    public virtual DbSet<Imtcmlgroup> Imtcmlgroups { get; set; }

    public virtual DbSet<Imtcmlresult> Imtcmlresults { get; set; }

    public virtual DbSet<Imtcmlresultstemp> Imtcmlresultstemps { get; set; }

    public virtual DbSet<Imtcomment> Imtcomments { get; set; }

    public virtual DbSet<ImtcommentType> ImtcommentTypes { get; set; }

    public virtual DbSet<ImtcontentType> ImtcontentTypes { get; set; }

    public virtual DbSet<ImtcriteriaOpporator> ImtcriteriaOpporators { get; set; }

    public virtual DbSet<ImtdeviceAuditing> ImtdeviceAuditings { get; set; }

    public virtual DbSet<ImtdohNotifcation> ImtdohNotifcations { get; set; }

    public virtual DbSet<ImtdohNotifcationsTemp> ImtdohNotifcationsTemps { get; set; }

    public virtual DbSet<Imtdrug> Imtdrugs { get; set; }

    public virtual DbSet<ImtdrugGroup> ImtdrugGroups { get; set; }

    public virtual DbSet<ImtdrugStatus> ImtdrugStatuses { get; set; }

    public virtual DbSet<ImtdrugsInGroup> ImtdrugsInGroups { get; set; }

    public virtual DbSet<ImtdurationNotificationTracking> ImtdurationNotificationTrackings { get; set; }

    public virtual DbSet<ImtdynamicFormBuilder> ImtdynamicFormBuilders { get; set; }

    public virtual DbSet<ImtdynamicFormBuilderLookup> ImtdynamicFormBuilderLookups { get; set; }

    public virtual DbSet<ImtdynamicFormBuilderLookupValue> ImtdynamicFormBuilderLookupValues { get; set; }

    public virtual DbSet<ImtdynamicFormBuilderLookupsParameter> ImtdynamicFormBuilderLookupsParameters { get; set; }

    public virtual DbSet<Imtescalation> Imtescalations { get; set; }

    public virtual DbSet<ImtexceptionScript> ImtexceptionScripts { get; set; }

    public virtual DbSet<ImtexceptionScriptDristribustionGroup> ImtexceptionScriptDristribustionGroups { get; set; }

    public virtual DbSet<ImtexceptionScriptDristribustionList> ImtexceptionScriptDristribustionLists { get; set; }

    public virtual DbSet<ImtexcludedDrugsInGroup> ImtexcludedDrugsInGroups { get; set; }

    public virtual DbSet<Imtflag> Imtflags { get; set; }

    public virtual DbSet<ImtflagAlertType> ImtflagAlertTypes { get; set; }

    public virtual DbSet<ImtglobalFlag> ImtglobalFlags { get; set; }

    public virtual DbSet<Imthl7table> Imthl7tables { get; set; }

    public virtual DbSet<Imthl7tableColumn> Imthl7tableColumns { get; set; }

    public virtual DbSet<ImtinstitutionMetadatum> ImtinstitutionMetadata { get; set; }

    public virtual DbSet<ImtisolateAdhoc> ImtisolateAdhocs { get; set; }

    public virtual DbSet<ImtisolateAlternativeSpecimenGroup> ImtisolateAlternativeSpecimenGroups { get; set; }

    public virtual DbSet<ImtisolateDetail> ImtisolateDetails { get; set; }

    public virtual DbSet<ImtisolateDetailHeader> ImtisolateDetailHeaders { get; set; }

    public virtual DbSet<ImtisolateDohMarker> ImtisolateDohMarkers { get; set; }

    public virtual DbSet<ImtisolateDohMarkerTemp> ImtisolateDohMarkerTemps { get; set; }

    public virtual DbSet<ImtisolateDohMarkerTemp2> ImtisolateDohMarkerTemp2s { get; set; }

    public virtual DbSet<ImtisolateEventTypeSpecimenCheck> ImtisolateEventTypeSpecimenChecks { get; set; }

    public virtual DbSet<ImtisolateFlagGroup> ImtisolateFlagGroups { get; set; }

    public virtual DbSet<ImtisolateFlagsInGroup> ImtisolateFlagsInGroups { get; set; }

    public virtual DbSet<ImtisolateGroup> ImtisolateGroups { get; set; }

    public virtual DbSet<ImtisolateGroupClassification> ImtisolateGroupClassifications { get; set; }

    public virtual DbSet<ImtisolateGroupItem> ImtisolateGroupItems { get; set; }

    public virtual DbSet<ImtisolateGroupItemSplit> ImtisolateGroupItemSplits { get; set; }

    public virtual DbSet<ImtisolateGroupItemSplitDetail> ImtisolateGroupItemSplitDetails { get; set; }

    public virtual DbSet<ImtisolateGroupItemsinGroup> ImtisolateGroupItemsinGroups { get; set; }

    public virtual DbSet<ImtisolateGroupItemstoExclude> ImtisolateGroupItemstoExcludes { get; set; }

    public virtual DbSet<ImtisolateGroupWorkflow> ImtisolateGroupWorkflows { get; set; }

    public virtual DbSet<ImtisolateHeader> ImtisolateHeaders { get; set; }

    public virtual DbSet<ImtisolateInfectionType> ImtisolateInfectionTypes { get; set; }

    public virtual DbSet<ImtisolateInflag> ImtisolateInflags { get; set; }

    public virtual DbSet<ImtisolateLrtPnuDiagnosis> ImtisolateLrtPnuDiagnoses { get; set; }

    public virtual DbSet<ImtisolateOrigin> ImtisolateOrigins { get; set; }

    public virtual DbSet<ImtisolateQuestion> ImtisolateQuestions { get; set; }

    public virtual DbSet<ImtisolateQuestionAnswer> ImtisolateQuestionAnswers { get; set; }

    public virtual DbSet<ImtisolateSerologyMapping> ImtisolateSerologyMappings { get; set; }

    public virtual DbSet<ImtisolateSpecificDetail> ImtisolateSpecificDetails { get; set; }

    public virtual DbSet<ImtisolateSpecimenEventType> ImtisolateSpecimenEventTypes { get; set; }

    public virtual DbSet<ImtisolateSpecimenQuestion> ImtisolateSpecimenQuestions { get; set; }

    public virtual DbSet<ImtisolateSubQuestion> ImtisolateSubQuestions { get; set; }

    public virtual DbSet<ImtisolateSurgerySelection> ImtisolateSurgerySelections { get; set; }

    public virtual DbSet<ImtisolateSymptom> ImtisolateSymptoms { get; set; }

    public virtual DbSet<Imtlab> Imtlabs { get; set; }

    public virtual DbSet<ImtlabCatalogue> ImtlabCatalogues { get; set; }

    public virtual DbSet<ImtlabDrug> ImtlabDrugs { get; set; }

    public virtual DbSet<ImtlabDrugGroup> ImtlabDrugGroups { get; set; }

    public virtual DbSet<ImtlabDrugsInGroup> ImtlabDrugsInGroups { get; set; }

    public virtual DbSet<ImtlabWardMapping> ImtlabWardMappings { get; set; }

    public virtual DbSet<ImtlatestCaseState> ImtlatestCaseStates { get; set; }

    public virtual DbSet<ImtmicroTest> ImtmicroTests { get; set; }

    public virtual DbSet<ImtmicroTestGroup> ImtmicroTestGroups { get; set; }

    public virtual DbSet<ImtmicroTestInGroup> ImtmicroTestInGroups { get; set; }

    public virtual DbSet<ImtnotifiableDisease> ImtnotifiableDiseases { get; set; }

    public virtual DbSet<ImtnotificationFlag> ImtnotificationFlags { get; set; }

    public virtual DbSet<ImtnotificationFlagGroup> ImtnotificationFlagGroups { get; set; }

    public virtual DbSet<Imtorganism> Imtorganisms { get; set; }

    public virtual DbSet<ImtorganismGroup> ImtorganismGroups { get; set; }

    public virtual DbSet<ImtorganismsInGroup> ImtorganismsInGroups { get; set; }

    public virtual DbSet<ImtpatientEventSummary> ImtpatientEventSummaries { get; set; }

    public virtual DbSet<ImtpatientSummary> ImtpatientSummaries { get; set; }

    public virtual DbSet<ImtpatientVisitSummary> ImtpatientVisitSummaries { get; set; }

    public virtual DbSet<ImtreconciledStatus> ImtreconciledStatuses { get; set; }

    public virtual DbSet<ImtresultTypeGroup> ImtresultTypeGroups { get; set; }

    public virtual DbSet<ImtresultTypeInGroup> ImtresultTypeInGroups { get; set; }

    public virtual DbSet<ImtruleCriteriaValueGroup> ImtruleCriteriaValueGroups { get; set; }

    public virtual DbSet<ImtruleCriteriaValuesInGroup> ImtruleCriteriaValuesInGroups { get; set; }

    public virtual DbSet<ImtruleDetail> ImtruleDetails { get; set; }

    public virtual DbSet<ImtruleEngineService> ImtruleEngineServices { get; set; }

    public virtual DbSet<ImtruleExecutionLog> ImtruleExecutionLogs { get; set; }

    public virtual DbSet<ImtrulesInFlag> ImtrulesInFlags { get; set; }

    public virtual DbSet<ImtrulesInFlagsGroup> ImtrulesInFlagsGroups { get; set; }

    public virtual DbSet<Imtscheduler> Imtschedulers { get; set; }

    public virtual DbSet<ImtschedulerExecutionLog> ImtschedulerExecutionLogs { get; set; }

    public virtual DbSet<ImtschedulerSetting> ImtschedulerSettings { get; set; }

    public virtual DbSet<ImtschedulerSettingDetail> ImtschedulerSettingDetails { get; set; }

    public virtual DbSet<ImtschedulerType> ImtschedulerTypes { get; set; }

    public virtual DbSet<ImtscriptsInException> ImtscriptsInExceptions { get; set; }

    public virtual DbSet<Imtspeciman> Imtspecimen { get; set; }

    public virtual DbSet<ImtspecimenAndGroupFromTestName> ImtspecimenAndGroupFromTestNames { get; set; }

    public virtual DbSet<ImtspecimenGroup> ImtspecimenGroups { get; set; }

    public virtual DbSet<ImtspecimenGroupMarker> ImtspecimenGroupMarkers { get; set; }

    public virtual DbSet<ImtspecimenInGroup> ImtspecimenInGroups { get; set; }

    public virtual DbSet<ImtspecimenSiteSourceMapping> ImtspecimenSiteSourceMappings { get; set; }

    public virtual DbSet<ImtspecimenSitesFriendly> ImtspecimenSitesFriendlies { get; set; }

    public virtual DbSet<ImtspecimenSource> ImtspecimenSources { get; set; }

    public virtual DbSet<ImtspecimenSourcesFriendly> ImtspecimenSourcesFriendlies { get; set; }

    public virtual DbSet<ImtspecimenUniversalDetail> ImtspecimenUniversalDetails { get; set; }

    public virtual DbSet<ImttempDrug> ImttempDrugs { get; set; }

    public virtual DbSet<Imttrace> Imttraces { get; set; }

    public virtual DbSet<ImtunitOfMeasurement> ImtunitOfMeasurements { get; set; }

    public virtual DbSet<ImtuniversalMapping> ImtuniversalMappings { get; set; }

    public virtual DbSet<ImtuniversalMappingItemsToExclude> ImtuniversalMappingItemsToExcludes { get; set; }

    public virtual DbSet<ImtvalidationFlagsInGroup> ImtvalidationFlagsInGroups { get; set; }

    public virtual DbSet<ImtvalidationGroup> ImtvalidationGroups { get; set; }

    public virtual DbSet<ImtworkFlow> ImtworkFlows { get; set; }

    public virtual DbSet<ImtworkFlowQueriesInGroup> ImtworkFlowQueriesInGroups { get; set; }

    public virtual DbSet<ImtworkFlowReturnField> ImtworkFlowReturnFields { get; set; }

    public virtual DbSet<ImtworkFlowRuleDetail> ImtworkFlowRuleDetails { get; set; }

    public virtual DbSet<In1Insurance> In1Insurances { get; set; }

    public virtual DbSet<In1InsuranceImportHistory> In1InsuranceImportHistories { get; set; }

    public virtual DbSet<In2InsuranceAdditionalInformation> In2InsuranceAdditionalInformations { get; set; }

    public virtual DbSet<In2InsuranceAdditionalInformationImportHistory> In2InsuranceAdditionalInformationImportHistories { get; set; }

    public virtual DbSet<Intervention> Interventions { get; set; }

    public virtual DbSet<InterventionAdditionalType> InterventionAdditionalTypes { get; set; }

    public virtual DbSet<InterventionAdditionalTypeGroup> InterventionAdditionalTypeGroups { get; set; }

    public virtual DbSet<InterventionGroup> InterventionGroups { get; set; }

    public virtual DbSet<InterventionType> InterventionTypes { get; set; }

    public virtual DbSet<InterventionTypeContentTypeLink> InterventionTypeContentTypeLinks { get; set; }

    public virtual DbSet<IsolateEventType> IsolateEventTypes { get; set; }

    public virtual DbSet<IsolateSwab> IsolateSwabs { get; set; }

    public virtual DbSet<MessageError> MessageErrors { get; set; }

    public virtual DbSet<MshMessageHeaderEvnEventType> MshMessageHeaderEvnEventTypes { get; set; }

    public virtual DbSet<MshMessageHeaderEvnEventTypeImportHistory> MshMessageHeaderEvnEventTypeImportHistories { get; set; }

    public virtual DbSet<NotificationDetailDuplicateWorkFlow> NotificationDetailDuplicateWorkFlows { get; set; }

    public virtual DbSet<NteNotesAndComment> NteNotesAndComments { get; set; }

    public virtual DbSet<ObrObservationRequest> ObrObservationRequests { get; set; }

    public virtual DbSet<ObxObservationOriginalLabMessage> ObxObservationOriginalLabMessages { get; set; }

    public virtual DbSet<ObxObservationResult> ObxObservationResults { get; set; }

    public virtual DbSet<OrcCommonOrder> OrcCommonOrders { get; set; }

    public virtual DbSet<OrderDrugClass> OrderDrugClasses { get; set; }

    public virtual DbSet<OrganismDrug> OrganismDrugs { get; set; }

    public virtual DbSet<PatientActivityLog> PatientActivityLogs { get; set; }

    public virtual DbSet<PatientActivityLogType> PatientActivityLogTypes { get; set; }

    public virtual DbSet<PatientAllergiesAndComorbidity> PatientAllergiesAndComorbidities { get; set; }

    public virtual DbSet<PatientAllergy> PatientAllergies { get; set; }

    public virtual DbSet<PatientComorbidity> PatientComorbidities { get; set; }

    public virtual DbSet<PatientWardDevice> PatientWardDevices { get; set; }

    public virtual DbSet<PersonLog> PersonLogs { get; set; }

    public virtual DbSet<PharmacyAtcCode> PharmacyAtcCodes { get; set; }

    public virtual DbSet<PharmacyStockMaster> PharmacyStockMasters { get; set; }

    public virtual DbSet<PidPatientIdentification> PidPatientIdentifications { get; set; }

    public virtual DbSet<PidPatientIdentificationImportHistory> PidPatientIdentificationImportHistories { get; set; }

    public virtual DbSet<Pr1Procedure> Pr1Procedures { get; set; }

    public virtual DbSet<Pv1PatientVisit> Pv1PatientVisits { get; set; }

    public virtual DbSet<Pv1PatientVisitImportHistory> Pv1PatientVisitImportHistories { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<RxcPharmacyTreatmentComponentOrder> RxcPharmacyTreatmentComponentOrders { get; set; }

    public virtual DbSet<RxePharmacyTreatmentEncodedOrder> RxePharmacyTreatmentEncodedOrders { get; set; }

    public virtual DbSet<RxoPharmacyTreatmentOrder> RxoPharmacyTreatmentOrders { get; set; }

    public virtual DbSet<RxrPharmacyTreatmentRoute> RxrPharmacyTreatmentRoutes { get; set; }

    public virtual DbSet<Saphl7message> Saphl7messages { get; set; }

    public virtual DbSet<Saphl7msgType> Saphl7msgTypes { get; set; }

    public virtual DbSet<SapstockMasterWeekly> SapstockMasterWeeklies { get; set; }

    public virtual DbSet<SapwardDevice> SapwardDevices { get; set; }

    public virtual DbSet<SurgicalBcaauditAnswer> SurgicalBcaauditAnswers { get; set; }

    public virtual DbSet<SurgicalBcaauditHeading> SurgicalBcaauditHeadings { get; set; }

    public virtual DbSet<SurgicalBcaauditQuestion> SurgicalBcaauditQuestions { get; set; }

    public virtual DbSet<SurgicalDiscipline> SurgicalDisciplines { get; set; }

    public virtual DbSet<SurgicalProphylaxisAntibiotic> SurgicalProphylaxisAntibiotics { get; set; }

    public virtual DbSet<SurgicalProphylaxisAuditAnswer> SurgicalProphylaxisAuditAnswers { get; set; }

    public virtual DbSet<SurgicalProphylaxisAuditQuestion> SurgicalProphylaxisAuditQuestions { get; set; }

    public virtual DbSet<SurgicalProphylaxisQuestionOption> SurgicalProphylaxisQuestionOptions { get; set; }

    public virtual DbSet<SurgicalProphylaxisScriptUpdate> SurgicalProphylaxisScriptUpdates { get; set; }

    public virtual DbSet<SurgicalProphylaxisSelectableOption> SurgicalProphylaxisSelectableOptions { get; set; }

    public virtual DbSet<TempUpdate> TempUpdates { get; set; }

    public virtual DbSet<TmpLancetCatelogue> TmpLancetCatelogues { get; set; }

    public virtual DbSet<TransplantRegion> TransplantRegions { get; set; }

    public virtual DbSet<TransplantType> TransplantTypes { get; set; }

    public virtual DbSet<TransplantUserNotification> TransplantUserNotifications { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VwAbxCurrentAuditDay> VwAbxCurrentAuditDays { get; set; }

    public virtual DbSet<VwAbxautoClosedAuditDay> VwAbxautoClosedAuditDays { get; set; }

    public virtual DbSet<VwImtlatestCaseStatesWithAdmissionDetail> VwImtlatestCaseStatesWithAdmissionDetails { get; set; }

    public virtual DbSet<WorkListResolveReason> WorkListResolveReasons { get; set; }

    public virtual DbSet<XiEvnEventTypeCode> XiEvnEventTypeCodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=NCDCNSQLDEV01;Initial Catalog=clinical_Hl7IMT_ntcweb.co.za_data;User ID=ntcmasterdb;Password=anGAe5NgTe0bgLZwC1z; ;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AbsAuditActivityTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC077A9B1148");

            entity.ToTable("AbsAuditActivityTracking", "IMT");

            entity.HasIndex(e => e.AuditId, "NCI_AuditID").IsDescending();

            entity.HasIndex(e => e.AuditId, "NCI_AuditId_ActionTypeDateId").IsDescending();

            entity.HasIndex(e => e.AuditId, "NCI_AuditId_AuditActionTypeId");

            entity.HasIndex(e => e.AuditId, "NCI_AuditId_AuditActionTypeIdAndDate");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(500);

            entity.HasOne(d => d.AuditActionType).WithMany(p => p.AbsAuditActivityTrackings)
                .HasForeignKey(d => d.AuditActionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditActivityTracking_AbsAuditActivityTracking");

            entity.HasOne(d => d.Audit).WithMany(p => p.AbsAuditActivityTrackings)
                .HasForeignKey(d => d.AuditId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditActivityTracking_IMTABXAuditHeader");
        });

        modelBuilder.Entity<AbsAuditAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC07E49A13C1");

            entity.ToTable("AbsAuditAnswer", "IMT");

            entity.HasIndex(e => new { e.AuditId, e.IsDeleted }, "NCI_AuditId_QuestionIdTextOptionSelectable");

            entity.HasIndex(e => new { e.DayId, e.IsDeleted }, "NCI_DayIdISDeleted");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SelectableOptionId).HasMaxLength(50);
            entity.Property(e => e.Text).HasMaxLength(200);

            entity.HasOne(d => d.Audit).WithMany(p => p.AbsAuditAnswers)
                .HasForeignKey(d => d.AuditId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditAnswer_IMTABXAuditHeader");

            entity.HasOne(d => d.Day).WithMany(p => p.AbsAuditAnswers)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditAnswer_AbsAuditDay");

            entity.HasOne(d => d.Question).WithMany(p => p.AbsAuditAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditAnswer_AbsAuditQuestion");
        });

        modelBuilder.Entity<AbsAuditDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC07EEF5722A");

            entity.ToTable("AbsAuditDay", "IMT");

            entity.HasIndex(e => new { e.Day, e.IsDeleted }, "NCI_DayDeleted_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<AbsAuditDrugDefaultQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC071E339995");

            entity.ToTable("AbsAuditDrugDefaultQuestion", "IMT");

            entity.HasIndex(e => new { e.DayId, e.IsDeleted }, "NCI_IsDeletedDayId_QuestionID");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDefaultAndPerDrugQestion)
                .IsRequired()
                .HasDefaultValueSql("('FALSE')");
            entity.Property(e => e.RxPurpose)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Day).WithMany(p => p.AbsAuditDrugDefaultQuestions)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditQuestionDay_AbsAuditDay");

            entity.HasOne(d => d.Question).WithMany(p => p.AbsAuditDrugDefaultQuestions)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditQuestionDay_AbsAuditQuestion");
        });

        modelBuilder.Entity<AbsAuditQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC07637F137A");

            entity.ToTable("AbsAuditQuestion", "IMT");

            entity.HasIndex(e => new { e.Id, e.IsDeleted }, "NCI_IdDeleted_QuestionRequires")
                .IsDescending(false, true)
                .HasFillFactor(90);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Question)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AbsAuditQuestionDrug>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC077FBC2A2D");

            entity.ToTable("AbsAuditQuestionDrug", "IMT");

            entity.HasIndex(e => new { e.DrugAtccode, e.QuestionId, e.DayId, e.IsDeleted }, "NCI_AllButId_Id").HasFillFactor(90);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DrugAtccode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DrugATCCode");
            entity.Property(e => e.RxPurpose)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Day).WithMany(p => p.AbsAuditQuestionDrugs)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditQuestionDrug_AbsAuditDay");

            entity.HasOne(d => d.Question).WithMany(p => p.AbsAuditQuestionDrugs)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditDrugQuestion_AbsAuditQuestion");
        });

        modelBuilder.Entity<AbsAuditQuestionMandatoryValidation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC0765B4C8EF");

            entity.ToTable("AbsAuditQuestionMandatoryValidation", "IMT");

            entity.HasOne(d => d.MandatoryQuestion).WithMany(p => p.AbsAuditQuestionMandatoryValidations)
                .HasForeignKey(d => d.MandatoryQuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AbsAuditQ__Manda__33D580EF");

            entity.HasOne(d => d.QuestionOption).WithMany(p => p.AbsAuditQuestionMandatoryValidations)
                .HasForeignKey(d => d.QuestionOptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AbsAuditQ__Quest__32E15CB6");
        });

        modelBuilder.Entity<AbsAuditQuestionOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC073D6B700C");

            entity.ToTable("AbsAuditQuestionOption", "IMT");

            entity.HasIndex(e => new { e.DefaultQuestionId, e.IsDeleted }, "NCI_DeletedDefaultQuestion_All")
                .IsDescending(false, true)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.QuestionDrugId, e.IsDeleted }, "NCI_DeletedQuestions_All2").HasFillFactor(90);

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Day).WithMany(p => p.AbsAuditQuestionOptions)
                .HasForeignKey(d => d.DayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditQuestionOption_AbsAuditQuestion");

            entity.HasOne(d => d.DefaultQuestion).WithMany(p => p.AbsAuditQuestionOptions)
                .HasForeignKey(d => d.DefaultQuestionId)
                .HasConstraintName("FK_AbsAuditQuestionOption_AbsAuditDrugDefaultQuestion");

            entity.HasOne(d => d.QuestionDrug).WithMany(p => p.AbsAuditQuestionOptions)
                .HasForeignKey(d => d.QuestionDrugId)
                .HasConstraintName("FK_AbsAuditQuestionOption_AbsAuditQuestionDrug");

            entity.HasOne(d => d.QuestionOptionLookup).WithMany(p => p.AbsAuditQuestionOptions)
                .HasForeignKey(d => d.QuestionOptionLookupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbsAuditQuestionOption_AbsAuditQuestionOptionLookup");
        });

        modelBuilder.Entity<AbsAuditQuestionOptionLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC071051548B");

            entity.ToTable("AbsAuditQuestionOptionLink", "IMT");

            entity.HasIndex(e => e.QuestionOptionId, "NCI_QuestionsOptionsId_HideQuestionId");
        });

        modelBuilder.Entity<AbsAuditQuestionOptionLookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC0756457368");

            entity.ToTable("AbsAuditQuestionOptionLookup", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<AbsAuditSelectableOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC078176AB67");

            entity.ToTable("AbsAuditSelectableOption", "IMT");

            entity.HasIndex(e => new { e.DefaultQuestionId, e.IsDeleted }, "NCI_DefaultQuestionIdIsDeleted_IdDescription");

            entity.HasIndex(e => new { e.QuestionDrugId, e.IsDeleted }, "NCI_QuestionDrugIdDeleted_IdDescription");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(200);
        });

        modelBuilder.Entity<AbsAuditTrackingActionLookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AbsAudit__3214EC0729A18B77");

            entity.ToTable("AbsAuditTrackingActionLookup", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<AbsDose>(entity =>
        {
            entity.HasKey(e => e.DoseId).HasName("PK__AbsDose__F03E00A2EF436A08");

            entity.ToTable("AbsDose", "IMT");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DoseDescription).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbsFrequency>(entity =>
        {
            entity.HasKey(e => e.FrequencyId).HasName("PK__AbsFrequ__592474984DA8F1F3");

            entity.ToTable("AbsFrequency", "IMT");

            entity.Property(e => e.FrequencyId).ValueGeneratedNever();
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FrequencyDescription).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbsRouteDoseGrouping>(entity =>
        {
            entity.HasKey(e => e.AbsRouteDoseGroupingId).HasName("PK__AbsRoute__46BBDDA9131C8C64");

            entity.ToTable("AbsRouteDoseGrouping", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbsScriptUpdate>(entity =>
        {
            entity.HasKey(e => e.AbsScriptUpdatesId).HasName("PK__AbsScrip__A3B78AC1D5153418");

            entity.ToTable("AbsScriptUpdates", "IMT");

            entity.HasIndex(e => e.AbsAuditId, "NCI_AbsAuditId_AdministrationTime").IsUnique();

            entity.HasIndex(e => e.AbsAuditId, "NCI_AuditId").IsUnique();

            entity.HasIndex(e => e.AbsAuditId, "NCI_AuditId_RouteValue_PurposOfPrescr").IsUnique();

            entity.Property(e => e.AdministrationTime).HasColumnType("datetime");
            entity.Property(e => e.AlternativeDoseValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AlternativeFrequencyValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AlternativeLoadingDose)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AlternativeRouteValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Diagnosis).HasMaxLength(100);
            entity.Property(e => e.DoctorName).HasMaxLength(255);
            entity.Property(e => e.DoseValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FrequencyValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LoadingDose)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MedicationName).HasMaxLength(100);
            entity.Property(e => e.PrescriptionTime).HasColumnType("datetime");
            entity.Property(e => e.PurposOfPrescription).HasMaxLength(100);
            entity.Property(e => e.RouteValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SubDiagnosisOther).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.DiagnosisNavigation).WithMany(p => p.AbsScriptUpdates)
                .HasForeignKey(d => d.DiagnosisId)
                .HasConstraintName("FK_AbsScriptUpdates_Diagnosis");

            entity.HasOne(d => d.Dose).WithMany(p => p.AbsScriptUpdates)
                .HasForeignKey(d => d.DoseId)
                .HasConstraintName("FK_AbsScriptUpdates_AbsDose");

            entity.HasOne(d => d.SubDiagnosis).WithMany(p => p.AbsScriptUpdates)
                .HasForeignKey(d => d.SubDiagnosisId)
                .HasConstraintName("FK_AbsScriptUpdates_SubDiagnosis");
        });

        modelBuilder.Entity<AbxAdhoc>(entity =>
        {
            entity.HasKey(e => e.AbxAdhocId).HasName("PK__AbxAdhoc__FA7E66420586966F");

            entity.ToTable("AbxAdhoc", "IMT");

            entity.Property(e => e.AdministrationTime).HasColumnType("datetime");
            entity.Property(e => e.CaseNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Diagnosis).HasMaxLength(100);
            entity.Property(e => e.Dose).HasMaxLength(50);
            entity.Property(e => e.Drug).HasMaxLength(255);
            entity.Property(e => e.Loading).HasMaxLength(50);
            entity.Property(e => e.MedicationName).HasMaxLength(100);
            entity.Property(e => e.PrescriptionTime).HasColumnType("datetime");
            entity.Property(e => e.PurposOfPrescription).HasMaxLength(100);
            entity.Property(e => e.SubDiagnosis).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlertSelectedResolveReason>(entity =>
        {
            entity.ToTable("AlertSelectedResolveReason", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Alert).WithMany(p => p.AlertSelectedResolveReasons)
                .HasForeignKey(d => d.AlertId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertSelectedResolveReason_IMTAlertHeader");

            entity.HasOne(d => d.WorkListResolveReason).WithMany(p => p.AlertSelectedResolveReasons)
                .HasForeignKey(d => d.WorkListResolveReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertSelectedResolveReason_WorkListResolveReasons");
        });

        modelBuilder.Entity<Allergy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Allergie__3214EC07310EC354");

            entity.ToTable("Allergies ", "IMT");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApplicationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Log");

            entity.ToTable("ApplicationLog", "IMT");

            entity.Property(e => e.Level).HasMaxLength(128);
            entity.Property(e => e.Properties).HasColumnType("xml");
        });

        modelBuilder.Entity<AtccustomDrugQuery>(entity =>
        {
            entity.HasKey(e => e.AtccustomDrugQueryFilterId).HasName("PK__ATCCusto__DB6B7432E7606A70");

            entity.ToTable("ATCCustomDrugQueries", "IMT");

            entity.Property(e => e.AtccustomDrugQueryFilterId).HasColumnName("ATCCustomDrugQueryFilterID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Sqlname)
                .HasMaxLength(255)
                .HasColumnName("SQLName");
            entity.Property(e => e.Sqlquery).HasColumnName("SQLQuery");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<AuditChecklistCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AuditChe__3214EC07E1CFA749");

            entity.ToTable("AuditChecklistCategory", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CategoryName)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CapauditAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAPAudit__3214EC07AF3C5756");

            entity.ToTable("CAPAuditAnswer", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DynamicSelectableOption).HasMaxLength(255);
            entity.Property(e => e.SelectableOptionId).HasMaxLength(200);
            entity.Property(e => e.Text).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Audit).WithMany(p => p.CapauditAnswers)
                .HasForeignKey(d => d.AuditId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapAuditAnswer_IMTABXAuditHeader");

            entity.HasOne(d => d.CapAuditDetail).WithMany(p => p.CapauditAnswers)
                .HasForeignKey(d => d.CapAuditDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapAuditAnswer_CAPAuditDetails");

            entity.HasOne(d => d.Category).WithMany(p => p.CapauditAnswers)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapAuditAnswer_AuditChecklistCategory");

            entity.HasOne(d => d.Question).WithMany(p => p.CapauditAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapAuditAnswer_CapAuditQuestion");
        });

        modelBuilder.Entity<CapauditDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAPAudit__3214EC072AB12B16");

            entity.ToTable("CAPAuditDetails", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PatientIdNumber).HasMaxLength(200);
            entity.Property(e => e.PmiNumber).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CapauditQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAPAudit__3214EC0788AF9F87");

            entity.ToTable("CAPAuditQuestion", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Question)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CapauditQuestionCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAPAudit__3214EC07A02E6DEA");

            entity.ToTable("CAPAuditQuestionCategory", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.AuditChecklist).WithMany(p => p.CapauditQuestionCategories)
                .HasForeignKey(d => d.AuditChecklistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPAuditQuestionCategory_AuditChecklistCategory");

            entity.HasOne(d => d.Question).WithMany(p => p.CapauditQuestionCategories)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPAuditQuestionCategory_CAPAuditQuestion");
        });

        modelBuilder.Entity<CapauditQuestionOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CAPAuditQuestionDetail");

            entity.ToTable("CAPAuditQuestionOption", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CapquestionOptionLookupId).HasColumnName("CAPQuestionOptionLookupId");

            entity.HasOne(d => d.AuditChecklist).WithMany(p => p.CapauditQuestionOptions)
                .HasForeignKey(d => d.AuditChecklistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPAuditQuestionOption_CAPAuditChecklistCategory");

            entity.HasOne(d => d.CapquestionOptionLookup).WithMany(p => p.CapauditQuestionOptions)
                .HasForeignKey(d => d.CapquestionOptionLookupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPAuditQuestionOption_CAPAuditQuestionOptionLookup");

            entity.HasOne(d => d.Question).WithMany(p => p.CapauditQuestionOptions)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_CAPAuditQuestionOption_CAPAuditQuestion");
        });

        modelBuilder.Entity<CapauditQuestionOptionLookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IMT.CAPAuditQuestionLookups");

            entity.ToTable("CAPAuditQuestionOptionLookup", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<CapauditSelectableOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAPAudit__3214EC0794905E87");

            entity.ToTable("CAPAuditSelectableOption", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(200);

            entity.HasOne(d => d.Question).WithMany(p => p.CapauditSelectableOptions)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_CAPAuditSelectableOption_CAPAuditQuestion");
        });

        modelBuilder.Entity<CommunicationType>(entity =>
        {
            entity.HasKey(e => e.CommunicationId).HasName("PK__Communic__53E565EFF7895EAC");

            entity.ToTable("CommunicationType", "IMT");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Comorbidity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comorbid__3214EC070F5FAE27");

            entity.ToTable("Comorbidities", "IMT");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConsolidatedEmployerDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConsolidatedEmployerDetails", "HL7");

            entity.HasIndex(e => e.Sapnumber, "idx_ConsolidatedEmployerDetails")
                .IsClustered()
                .HasFillFactor(80);

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");
            entity.Property(e => e.Employer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber3)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pminumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PMINumber");
            entity.Property(e => e.Sapnumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SAPNumber");
        });

        modelBuilder.Entity<ConsolidatedInsurance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConsolidatedInsurance", "HL7");

            entity.HasIndex(e => e.Sapnumber, "idx_ConsolidatedInsurance")
                .IsClustered()
                .HasFillFactor(80);

            entity.Property(e => e.AccountResponsibleAddressLine1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountResponsibleAddressLine2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountResponsibleAddressLine3)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountResponsibleAddressLine4)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountResponsibleAddressPostalCode)
                .HasMaxLength(210)
                .IsUnicode(false);
            entity.Property(e => e.AccountResponsibleIdnumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AccountResponsibleIDNumber");
            entity.Property(e => e.AccountResponsibleName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountResponsibleSurname)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountResponsibleTitle)
                .HasMaxLength(110)
                .IsUnicode(false);
            entity.Property(e => e.AuthorisationNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.MedicalAidAdministrator)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MedicalAidIdnumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MedicalAidIDNumber");
            entity.Property(e => e.MedicalAidMemberDigit)
                .HasMaxLength(210)
                .IsUnicode(false);
            entity.Property(e => e.MedicalAidName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MedicalAidNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MedicalAidPlan)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Pminumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PMINumber");
            entity.Property(e => e.Sapnumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SAPNumber");
        });

        modelBuilder.Entity<ConsolidatedMappingIdentifier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConsolidatedMappingIdentifiers", "HL7");

            entity.HasIndex(e => new { e.Sapnumber, e.EventDateTime, e.Hl7uniqueIdentifier }, "idx_MappingIdentifiers")
                .IsDescending(false, true, false)
                .IsClustered()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "idx_MappingIdentifiers_HL7UniqueIdentifier").HasFillFactor(80);

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Pminumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PMINumber");
            entity.Property(e => e.Sapnumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SAPNumber");
        });

        modelBuilder.Entity<ConsolidatedPatientDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConsolidatedPatientDetails", "HL7");

            entity.HasIndex(e => e.Sapnumber, "idx_ConsolidatedPatientDetails")
                .IsClustered()
                .HasFillFactor(80);

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateTimeOfMessage).HasColumnType("datetime");
            entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");
            entity.Property(e => e.EventType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.OriginalMessage).HasColumnType("text");
            entity.Property(e => e.OriginatingHospitalSapcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OriginatingHospitalSAPCode");
            entity.Property(e => e.PatientAddressLine1)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientAddressLine2)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientAddressLine3)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientAddressLine4)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientAddressPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatientDateOfBirth).HasColumnType("date");
            entity.Property(e => e.PatientDeathDateTime).HasColumnType("datetime");
            entity.Property(e => e.PatientDeathIndicator)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatientEmail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PatientIDNumber");
            entity.Property(e => e.PatientMaritialStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatientName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientPhoneNumber1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientPhoneNumber2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientPhoneNumberBusiness)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientPrimaryLanguage)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientSex)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatientSurname)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientTitle)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pminumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PMINumber");
            entity.Property(e => e.Sapnumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SAPNumber");
            entity.Property(e => e.TriggerEvent)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConsolidatedPatientVisit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConsolidatedPatientVisit", "HL7");

            entity.HasIndex(e => e.Sapnumber, "idx_ConsolidatedPatientVisit")
                .IsClustered()
                .HasFillFactor(80);

            entity.Property(e => e.AdmissionType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.AdmitDateTime).HasColumnType("datetime");
            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");
            entity.Property(e => e.DischargeDateTime).HasColumnType("datetime");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.LastKnownAttendingDoctorFirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastKnownAttendingDoctorLastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastKnownAttendingDoctorMpnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LastKnownAttendingDoctorMPNumber");
            entity.Property(e => e.LastKnownBed)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastKnownConsultingDoctorFirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastKnownConsultingDoctorLastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastKnownConsultingDoctorMpnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LastKnownConsultingDoctorMPNumber");
            entity.Property(e => e.LastKnownFloorOrWardName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastKnownRoom)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastKnownWard)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientClass)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Pminumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PMINumber");
            entity.Property(e => e.ReferringDoctorFirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReferringDoctorLastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReferringDoctorMpnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ReferringDoctorMPNumber");
            entity.Property(e => e.Sapnumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SAPNumber");
        });

        modelBuilder.Entity<CreassessmentAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CREAsses__3214EC07BE37A07A");

            entity.ToTable("CREAssessmentAnswers", "IMT");

            entity.Property(e => e.CaseNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SelectedOptionId).HasMaxLength(50);
        });

        modelBuilder.Entity<CreassessmentQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CREAsses__3214EC079A261D31");

            entity.ToTable("CREAssessmentQuestions", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Text)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CreassessmentQuestionOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CREAsses__3214EC0700F0347B");

            entity.ToTable("CREAssessmentQuestionOptions", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CreassessmentSelectableOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CREAsses__3214EC07EFDCC2D4");

            entity.ToTable("CREAssessmentSelectableOptions", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Text).HasMaxLength(400);
        });

        modelBuilder.Entity<CtiPatientDetail>(entity =>
        {
            entity.ToTable("CTI_PatientDetail", "HL7");

            entity.HasIndex(e => e.CellNo, "IDX_CellNo");

            entity.Property(e => e.CellNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PmiNo)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Device__3214EC07C6EF4918");

            entity.ToTable("Device", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceSerialNumber).HasMaxLength(50);

            entity.HasOne(d => d.DeviceType).WithMany(p => p.Devices)
                .HasForeignKey(d => d.DeviceTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Device_Device");
        });

        modelBuilder.Entity<DeviceBcaauditAnswer>(entity =>
        {
            entity.HasKey(e => e.AnswerId).HasName("PK__DeviceBC__D4825004013B29C9");

            entity.ToTable("DeviceBCAAuditAnswer", "IMT");

            entity.Property(e => e.BcaauditDeviceId).HasColumnName("BCAAuditDeviceId");
            entity.Property(e => e.BedNo).HasMaxLength(50);
            entity.Property(e => e.CaseNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Question).WithMany(p => p.DeviceBcaauditAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeviceBCAAuditAnswer_DeviceBCAAuditQuestion");
        });

        modelBuilder.Entity<DeviceBcaauditHeading>(entity =>
        {
            entity.HasKey(e => e.AuditHeadingId);

            entity.ToTable("DeviceBCAAuditHeading", "IMT");

            entity.Property(e => e.AuditHeadingId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Text).HasMaxLength(500);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeviceBcaauditQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__DeviceBC__0DC06FAC01573938");

            entity.ToTable("DeviceBCAAuditQuestion", "IMT");

            entity.Property(e => e.QuestionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeviceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DeviceTy__3214EC07B34B64C9");

            entity.ToTable("DeviceType", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<DeviceTypeIndication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DeviceTy__3214EC07C47322E9");

            entity.ToTable("DeviceTypeIndication", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<DeviceTypeIndicationLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DeviceTy__3214EC0717715CD5");

            entity.ToTable("DeviceTypeIndicationLink", "IMT");
        });

        modelBuilder.Entity<DeviceTypeSide>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DeviceTy__3214EC0772B38AE4");

            entity.ToTable("DeviceTypeSide", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<DeviceTypeSideLink>(entity =>
        {
            entity.ToTable("DeviceTypeSideLink", "IMT");
        });

        modelBuilder.Entity<DeviceTypeSite>(entity =>
        {
            entity.ToTable("DeviceTypeSite", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<DeviceTypeSiteLink>(entity =>
        {
            entity.ToTable("DeviceTypeSiteLink", "IMT");
        });

        modelBuilder.Entity<DeviceTypeSubType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DeviceSubType");

            entity.ToTable("DeviceTypeSubType", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Dg1DiagnosisPrimary>(entity =>
        {
            entity.HasKey(e => e.Dg1id);

            entity.ToTable("DG1_DiagnosisPrimary", "HL7");

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_HL7UniqueIdentifier").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLog").HasFillFactor(80);

            entity.Property(e => e.Dg1id).HasColumnName("DG1ID");
            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dg11SetIddg1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DG1_1_SetIDDG1");
            entity.Property(e => e.Dg12DiagnosisCodingMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DG1_2_DiagnosisCodingMethod");
            entity.Property(e => e.Dg130DiagnosisCodeDg1identifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DG1_3_0_DiagnosisCodeDG1Identifier");
            entity.Property(e => e.Dg131DiagnosisCodeDg1text)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DG1_3_1_DiagnosisCodeDG1Text");
            entity.Property(e => e.Dg132DiagnosisCodeDg1nameofCodingSystem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DG1_3_2_DiagnosisCodeDG1NameofCodingSystem");
            entity.Property(e => e.Dg14DiagnosisDescription)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DG1_4_DiagnosisDescription");
            entity.Property(e => e.Dg15DiagnosisDateTime)
                .HasColumnType("datetime")
                .HasColumnName("DG1_5_DiagnosisDateTime");
            entity.Property(e => e.Dg16DiagnosisType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DG1_6_DiagnosisType");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
        });

        modelBuilder.Entity<Dg1DiagnosisPrimaryImportHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DG1_DiagnosisPrimary_ImportHistory", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dg11SetIddg1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DG1_1_SetIDDG1");
            entity.Property(e => e.Dg12DiagnosisCodingMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DG1_2_DiagnosisCodingMethod");
            entity.Property(e => e.Dg130DiagnosisCodeDg1identifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DG1_3_0_DiagnosisCodeDG1Identifier");
            entity.Property(e => e.Dg131DiagnosisCodeDg1text)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DG1_3_1_DiagnosisCodeDG1Text");
            entity.Property(e => e.Dg132DiagnosisCodeDg1nameofCodingSystem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DG1_3_2_DiagnosisCodeDG1NameofCodingSystem");
            entity.Property(e => e.Dg14DiagnosisDescription)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DG1_4_DiagnosisDescription");
            entity.Property(e => e.Dg15DiagnosisDateTime)
                .HasColumnType("datetime")
                .HasColumnName("DG1_5_DiagnosisDateTime");
            entity.Property(e => e.Dg16DiagnosisType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DG1_6_DiagnosisType");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
        });

        modelBuilder.Entity<Diagnosis>(entity =>
        {
            entity.ToTable("Diagnosis", "IMT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CategoryName).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DiagnosisSub>(entity =>
        {
            entity.ToTable("DiagnosisSub", "IMT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SubCategoryName).HasMaxLength(255);

            entity.HasOne(d => d.Category).WithMany(p => p.DiagnosisSubs)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiagnosisSub_Diagnosis");
        });

        modelBuilder.Entity<DohnotifiableCondition>(entity =>
        {
            entity.HasKey(e => e.DohnotifiableConditionId).HasName("PK__DOHNotif__9DE0C59A154927CE");

            entity.ToTable("DOHNotifiableCondition", "IMT");

            entity.Property(e => e.DohnotifiableConditionId).HasColumnName("DOHNotifiableConditionID");
            entity.Property(e => e.DohnotifiableCondition1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DOHNotifiableCondition");
        });

        modelBuilder.Entity<DrugClassAmpath>(entity =>
        {
            entity.HasKey(e => e.DrugId).HasName("PK__DrugClas__908D661679899E84");

            entity.ToTable("DrugClassAmpath", "IMT");

            entity.Property(e => e.AtcCode)
                .HasMaxLength(255)
                .HasColumnName("ATC Code");
            entity.Property(e => e.Drug).HasMaxLength(255);
            entity.Property(e => e.DrugClassesForDrugBug)
                .HasMaxLength(255)
                .HasColumnName("Drug classes for drug-bug");
            entity.Property(e => e.LabDrugCode).HasMaxLength(255);
            entity.Property(e => e.NumberDrugBugClass).HasColumnName("Number drug bug class");
        });

        modelBuilder.Entity<DrugClassLancet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DrugClassLancet", "IMT");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(255)
                .HasColumnName("ABBREVIATION");
            entity.Property(e => e.AtcCode)
                .HasMaxLength(255)
                .HasColumnName("ATC Code");
            entity.Property(e => e.DrugBugClassesForAnitbiograms)
                .HasMaxLength(255)
                .HasColumnName("Drug bug classes for anitbiograms");
            entity.Property(e => e.Group)
                .HasMaxLength(255)
                .HasColumnName("GROUP");
            entity.Property(e => e.Mnemonic)
                .HasMaxLength(255)
                .HasColumnName("MNEMONIC");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.NumberDrugBugClass).HasColumnName("Number drug bug class");
            entity.Property(e => e.Subgroup)
                .HasMaxLength(255)
                .HasColumnName("SUBGROUP");
        });

        modelBuilder.Entity<DrugClassPathcare>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DrugClassPathcare", "IMT");

            entity.Property(e => e.AntibioticCd)
                .HasMaxLength(255)
                .HasColumnName("AntibioticCD");
            entity.Property(e => e.AtcCode)
                .HasMaxLength(255)
                .HasColumnName("ATC code");
            entity.Property(e => e.ClassesForDrugBug)
                .HasMaxLength(255)
                .HasColumnName("Classes for drug bug");
            entity.Property(e => e.GroupCd)
                .HasMaxLength(255)
                .HasColumnName("GroupCD");
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.Loinc)
                .HasMaxLength(255)
                .HasColumnName("LOINC");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NumberDrugBugClass).HasColumnName("Number drug bug class");
            entity.Property(e => e.SubGroupCd)
                .HasMaxLength(255)
                .HasColumnName("SubGroupCD");
            entity.Property(e => e.SubGroupName).HasMaxLength(255);
        });

        modelBuilder.Entity<DrugClassVermaak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DrugClassVermaak", "IMT");

            entity.Property(e => e.AntimicrobialAgent)
                .HasMaxLength(255)
                .HasColumnName("Antimicrobial agent");
            entity.Property(e => e.AtcCode)
                .HasMaxLength(255)
                .HasColumnName("ATC code");
            entity.Property(e => e.ClassesForDrugBug)
                .HasMaxLength(255)
                .HasColumnName("Classes for drug bug");
            entity.Property(e => e.NumberDrugBugClass).HasColumnName("Number drug bug class");
            entity.Property(e => e.TestId).HasColumnName("Test ID");
            entity.Property(e => e.TestMnemonic)
                .HasMaxLength(255)
                .HasColumnName("Test Mnemonic");
        });

        modelBuilder.Entity<EvnEventType>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("EVN_EventType", "HL7");

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLog").HasFillFactor(80);

            entity.HasIndex(e => new { e.Hl7uniqueIdentifier, e.Evn1EventTypeCode, e.Evn2RecordedDateTime }, "NCI_test")
                .IsDescending(false, false, true)
                .HasFillFactor(80);

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NonClusteredIndex-20220217-170156")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "ind_HL7UniqueIdentifier").HasFillFactor(80);

            entity.Property(e => e.DateTimeInserted).HasColumnType("datetime");
            entity.Property(e => e.Evn15161NameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EVN_15_16_1_NameContextIdentifier");
            entity.Property(e => e.Evn15162NameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EVN_15_16_2_NameContextText");
            entity.Property(e => e.Evn15163NameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EVN_15_16_3_NameContextNameOfCodingSystem");
            entity.Property(e => e.Evn15164NameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EVN_15_16_4_NameContextAlternateIdentifier");
            entity.Property(e => e.Evn15165NameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EVN_15_16_5_NameContextAlternateText");
            entity.Property(e => e.Evn15166NameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EVN_15_16_6_NameContextNameOfAlternateCodingSystem");
            entity.Property(e => e.Evn1EventTypeCode)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_1_EventTypeCode");
            entity.Property(e => e.Evn2RecordedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("EVN_2_RecordedDateTime");
            entity.Property(e => e.Evn3DateTimePlannedEvent)
                .HasColumnType("datetime")
                .HasColumnName("EVN_3_DateTimePlannedEvent");
            entity.Property(e => e.Evn4EventReasonCode)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_4_EventReasonCode");
            entity.Property(e => e.Evn510NameTypeCode)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_10_NameTypeCode");
            entity.Property(e => e.Evn511IdentifierCheckDigit)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_11_IdentifierCheckDigit");
            entity.Property(e => e.Evn512CodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_12_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Evn513IdentifierTypeCode)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_13_IdentifierTypeCode");
            entity.Property(e => e.Evn5141AssigningFacilityNamespaceId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_14_1_AssigningFacilityNamespaceID");
            entity.Property(e => e.Evn5142AssigningFacilityUniversalId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_14_2_AssigningFacilityUniversalID");
            entity.Property(e => e.Evn5143AssigningFacilityUniversalIdtype)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_14_3_AssigningFacilityUniversalIDType");
            entity.Property(e => e.Evn515NameRepresentationCode)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_15_NameRepresentationCode");
            entity.Property(e => e.Evn5171RangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("EVN_5_17_1_RangeStartDateTime");
            entity.Property(e => e.Evn5172RangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("EVN_5_17_2_RangeEndDateTime");
            entity.Property(e => e.Evn518NameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EVN_5_18_NameAssemblyOrder");
            entity.Property(e => e.Evn51OperatorIdnumber)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_1_OperatorIDNumber");
            entity.Property(e => e.Evn521FamilyNameSurname)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_2_1_FamilyNameSurname");
            entity.Property(e => e.Evn522FamilyNameOwnSurnamePrefix)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_2_2_FamilyNameOwnSurnamePrefix");
            entity.Property(e => e.Evn523FamilyNameOwnSurname)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_2_3_FamilyNameOwnSurname");
            entity.Property(e => e.Evn524FamilyNamePrefixFromPartnerSpouse)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_2_4_FamilyNamePrefixFromPartnerSpouse");
            entity.Property(e => e.Evn525FamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_2_5_FamilyNameSurnameFromPartnerSpouse");
            entity.Property(e => e.Evn53GivenName)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_3_GivenName");
            entity.Property(e => e.Evn54SecondAndFurtherGivenNamesOrInitialsThereOf)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_4_SecondAndFurtherGivenNamesOrInitialsThereOf");
            entity.Property(e => e.Evn55Suffix)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_5_Suffix");
            entity.Property(e => e.Evn56Prefix)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_6_Prefix");
            entity.Property(e => e.Evn57Degree)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_7_Degree");
            entity.Property(e => e.Evn58SourceTable)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_8_SourceTable");
            entity.Property(e => e.Evn591AssigningAuthorityNamespaceId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_9_1_AssigningAuthorityNamespaceID");
            entity.Property(e => e.Evn592AssigningAuthorityUniversalId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_9_2_AssigningAuthorityUniversalID");
            entity.Property(e => e.Evn593AssigningAuthorityUniversalIdtype)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_5_9_3_AssigningAuthorityUniversalIDType");
            entity.Property(e => e.Evn6EventOccurred)
                .HasColumnType("datetime")
                .HasColumnName("EVN_6_EventOccurred");
            entity.Property(e => e.Evn71EventFacilityNamespaceId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_7_1_EventFacilityNamespaceID");
            entity.Property(e => e.Evn72EventFacilityUniversalId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_7_2_EventFacilityUniversalID");
            entity.Property(e => e.Evn73EventFacilityUniversalIdtype)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_7_3_EventFacilityUniversalIDType");
            entity.Property(e => e.Evn7EventFacility)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("EVN_7_EventFacility");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
        });

        modelBuilder.Entity<Fix>(entity =>
        {
            entity.HasKey(e => e.Hl7uniqueIdentifier);

            entity.ToTable("FIX", "HL7");

            entity.Property(e => e.Hl7uniqueIdentifier)
                .ValueGeneratedNever()
                .HasColumnName("HL7UniqueIdentifier");
        });

        modelBuilder.Entity<FlagsInOrganism>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FlagsInOrganism", "IMT");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Flag).HasMaxLength(50);
            entity.Property(e => e.UniversalOrganism).HasMaxLength(500);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Hl7importlog>(entity =>
        {
            entity.HasKey(e => e.ImportlogId).HasName("PK__ImportlogID__3F2CADC840EE3083");

            entity.ToTable("HL7Importlog", "HL7");

            entity.Property(e => e.ImportlogId).HasColumnName("ImportlogID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Saphl7msgId).HasColumnName("SAPHL7MsgID");
        });

        modelBuilder.Entity<Hl7messageSplitLog>(entity =>
        {
            entity.HasKey(e => e.SplitLogId).HasName("PK__SplitLogID__3F2CADC840EE3083");

            entity.ToTable("HL7MessageSplitLog", "HL7");

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "SAPHL7MsgID").HasFillFactor(80);

            entity.Property(e => e.SplitLogId).HasColumnName("SplitLogID");
            entity.Property(e => e.Abxcreated).HasColumnName("ABXCreated");
            entity.Property(e => e.AbxdrugCorrection).HasColumnName("ABXDrugCorrection");
            entity.Property(e => e.CaseNo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Hl7msgTypeId).HasColumnName("HL7MsgTypeID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.InstitutionId).HasColumnName("institutionID");
            entity.Property(e => e.InstitutionName).HasMaxLength(255);
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.ProcessedAbs).HasColumnName("ProcessedABS");
            entity.Property(e => e.ProcessedDate)
                .HasColumnType("datetime")
                .HasColumnName("Processed_Date");
            entity.Property(e => e.ProcessedIpp).HasColumnName("ProcessedIPP");
            entity.Property(e => e.Saphl7msgId).HasColumnName("SAPHL7MsgID");
            entity.Property(e => e.Unreconciled).HasDefaultValueSql("((0))");
            entity.Property(e => e.UnreconciledCase)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hl7messageSplitLogProcess>(entity =>
        {
            entity.HasKey(e => e.SplitLogProcessId).HasName("PK__SplitLogProcessID");

            entity.ToTable("HL7MessageSplitLogProcess", "HL7");

            entity.Property(e => e.SplitLogProcessId).HasColumnName("SplitLogProcessID");
            entity.Property(e => e.SplitLogId).HasColumnName("SplitLogID");
        });

        modelBuilder.Entity<Hl7messageSplitLogProcessError>(entity =>
        {
            entity.HasKey(e => e.SplitLogProcessErrorId).HasName("PK__SplitLogProcessErrorID");

            entity.ToTable("HL7MessageSplitLogProcessErrors", "HL7");

            entity.Property(e => e.SplitLogProcessErrorId).HasColumnName("SplitLogProcessErrorID");
            entity.Property(e => e.SplitLogId).HasColumnName("SplitLogID");
        });

        modelBuilder.Entity<Hl7sqlquery>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__RKA_Syst__LogID");

            entity.ToTable("HL7SQLQueries", "HL7");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Sqlname)
                .HasMaxLength(255)
                .HasColumnName("SQLName");
            entity.Property(e => e.Sqlquery).HasColumnName("SQLQuery");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<Hl7sqlqueryParameter>(entity =>
        {
            entity.HasKey(e => e.ParameterId).HasName("PK__HL7SQLQu__F80C6297B3C621BE");

            entity.ToTable("HL7SQLQueryParameters", "HL7");

            entity.Property(e => e.ParameterId).HasColumnName("ParameterID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Hl7sqlqueryId).HasColumnName("HL7SQLQueryID");
            entity.Property(e => e.ParameterName).HasMaxLength(255);
            entity.Property(e => e.ParameterValue).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(1)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<Htmltemplate>(entity =>
        {
            entity.HasKey(e => e.Htmlid).HasName("PK__HTMLTemp__034216C0FED021B2");

            entity.ToTable("HTMLTemplates", "HL7");

            entity.Property(e => e.Htmlid).HasColumnName("HTMLID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Htmlbody).HasColumnName("HTMLBody");
            entity.Property(e => e.Htmldescription)
                .HasMaxLength(255)
                .HasColumnName("HTMLDescription");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ImtIsolateCdcClassification>(entity =>
        {
            entity.HasKey(e => e.IsolateSymptomClassificationId).HasName("PK_ImtIsolateSymptomClassification");

            entity.ToTable("ImtIsolateCdcClassification", "IMT");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Classification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Criteria).IsUnicode(false);
            entity.Property(e => e.FkSpecimenGroupId)
                .HasDefaultValueSql("((3))")
                .HasColumnName("fkSpecimenGroupId");

            entity.HasOne(d => d.FkSpecimenGroup).WithMany(p => p.ImtIsolateCdcClassifications)
                .HasForeignKey(d => d.FkSpecimenGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImtIsolateCdcClassification_IMTSpecimenGroups");
        });

        modelBuilder.Entity<ImtIsolateUrineInfectionCriterion>(entity =>
        {
            entity.HasKey(e => e.UrineInfectionId);

            entity.ToTable("ImtIsolateUrineInfectionCriteria", "IMT");

            entity.Property(e => e.UrineInfectionCriteria)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Imtabsmonitoring>(entity =>
        {
            entity.HasKey(e => e.MonitorRuleId).HasName("PK__IMTABSMo__B8C0D0754BC0EA72");

            entity.ToTable("IMTABSMonitoring", "IMT");

            entity.Property(e => e.MonitorRuleId).HasColumnName("MonitorRuleID");
            entity.Property(e => e.AtcdrugId).HasColumnName("ATCDrugID");
            entity.Property(e => e.AtcobservationDrugStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("ATCObservationDrugStartDateTime");
            entity.Property(e => e.CaseNo).HasMaxLength(100);
            entity.Property(e => e.DayCountSinceAtcobservationDrugStartDateTime).HasColumnName("DayCountSinceATCObservationDrugStartDateTime");
            entity.Property(e => e.ExtentionDayCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.LabObservationIdentifier).HasMaxLength(255);
            entity.Property(e => e.LabObservationIdentifierText).HasMaxLength(255);
            entity.Property(e => e.LabObservationValue).HasMaxLength(255);
            entity.Property(e => e.LabObservationValueUnits).HasMaxLength(255);
            entity.Property(e => e.LabReferenceRange).HasMaxLength(255);
            entity.Property(e => e.PatientIdnumber)
                .HasMaxLength(100)
                .HasColumnName("PatientIDNumber");
            entity.Property(e => e.Pminumber)
                .HasMaxLength(100)
                .HasColumnName("PMINumber");
            entity.Property(e => e.Rxeatcdrug)
                .HasMaxLength(255)
                .HasColumnName("RXEATCDrug");
            entity.Property(e => e.RxeatcobservationDrugStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXEATCObservationDrugStartDateTime");
            entity.Property(e => e.RxeatcobservationDrugValue)
                .HasMaxLength(255)
                .HasColumnName("RXEATCObservationDrugValue");
            entity.Property(e => e.RxeatcobservationDrugValueUnits)
                .HasMaxLength(255)
                .HasColumnName("RXEATCObservationDrugValueUnits");
        });

        modelBuilder.Entity<ImtabxauditDetail>(entity =>
        {
            entity.HasKey(e => e.AbxauditDetailId).HasName("PK__ABXAuditDetailID__D1FDCF6A7905A60E");

            entity.ToTable("IMTABXAuditDetails", "IMT");

            entity.HasIndex(e => e.AbxauditId, "NCI_AbxAuditId_GivenCodeAdministrationUnits")
                .IsUnique()
                .IsDescending();

            entity.HasIndex(e => e.AbxauditId, "NCI_AbxAuditId_Rxe24GivenCodeAlternateIdentifier").IsDescending();

            entity.HasIndex(e => e.Rxe22GivenCodeText, "NCI_RXE_2_2_GivenCode_Text");

            entity.Property(e => e.AbxauditDetailId).HasColumnName("ABXAuditDetailID");
            entity.Property(e => e.AbxauditId).HasColumnName("ABXAuditID");
            entity.Property(e => e.AtcproductDescription)
                .HasMaxLength(500)
                .HasColumnName("ATCProductDescription");
            entity.Property(e => e.Rxe12NumberOfRefills)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_12_Number_Of_Refills");
            entity.Property(e => e.Rxe131OrderingProvidersDeaNumberIdNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_13_1_Ordering_Providers_DEA_Number_IdNumber");
            entity.Property(e => e.Rxe141PharmacistTreatmentSuppliersVerifierIdIdNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_14_1_PharmacistTreatmentSuppliersVerifierID_IdNumber");
            entity.Property(e => e.Rxe141QuantityTimingStartDateTimeTimeOfAnEvent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_4_1_QuantityTiming_StartDateTime_TimeOfAnEvent");
            entity.Property(e => e.Rxe1421PharmacistTreatmentSuppliersVerifierIdFamilyNameSurname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_14_2_1_PharmacistTreatmentSuppliersVerifierID_FamilyName_Surname");
            entity.Property(e => e.Rxe143PharmacistTreatmentSuppliersVerifierIdGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_14_3_PharmacistTreatmentSuppliersVerifierID_GivenName");
            entity.Property(e => e.Rxe151QuantityTimingEndDateTimeTimeOfAnEvent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_5_1_QuantityTiming_EndDateTime_TimeOfAnEvent");
            entity.Property(e => e.Rxe15PrescriptionNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_15_PrescriptionNumber");
            entity.Property(e => e.Rxe21GivenCodeIdentifier)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RXE_2_1_GivenCode_Identifier");
            entity.Property(e => e.Rxe22GivenCodeText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_2_2_GivenCode_Text");
            entity.Property(e => e.Rxe24GivenCodeAlternateIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_2_4_GivenCode_AlternateIdentifier");
            entity.Property(e => e.Rxe3GivenAmountMinimum)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_3_GivenAmountMinimum");
            entity.Property(e => e.Rxe4GiveAmountMaximum)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_4_GiveAmountMaximum");
            entity.Property(e => e.Rxe51GiveUnitsIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_5_1_Give_Units_Identifier");
            entity.Property(e => e.Rxe61GiveDosageFormIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_6_1_Give_Dosage_Form_Identifier");
            entity.Property(e => e.Rxe71ProvidersAdministrationInstructionsIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_7_1_Providers_Administration_Instructions_Identifier");
            entity.Property(e => e.Rxe81DeliverToLocationPointOfCare)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_1_Deliver_To_Location_PointOfCare");

            entity.HasOne(d => d.Abxaudit).WithOne(p => p.ImtabxauditDetail)
                .HasForeignKey<ImtabxauditDetail>(d => d.AbxauditId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTABXAuditDetails_IMTABXAuditHeader");
        });

        modelBuilder.Entity<ImtabxauditHeader>(entity =>
        {
            entity.HasKey(e => e.AbxauditId).HasName("PK__ABXAuditID__EBB16AEDC0186963");

            entity.ToTable("IMTABXAuditHeader", "IMT");

            entity.HasIndex(e => e.CaseNo, "NCI_CaseIncludeAuditId");

            entity.HasIndex(e => new { e.InstitutionId, e.Active, e.IsTargetedDrug, e.IsinTracking }, "NCI_TimeLineAudit");

            entity.HasIndex(e => e.InstitutionId, "NCI_institutionID");

            entity.HasIndex(e => new { e.InstitutionId, e.IsTargetedDrug, e.CreatedDate }, "NCI_institutionID_IsTargetedDrug_CreatedDate");

            entity.Property(e => e.AbxauditId).HasColumnName("ABXAuditID");
            entity.Property(e => e.CaseNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Hl7AssociatedPersonLogId).HasColumnName("Hl7AssociatedPersonLogID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.InstitutionId).HasColumnName("institutionID");
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsinTracking).HasDefaultValueSql("((0))");
            entity.Property(e => e.OriginalAbxauditId).HasColumnName("OriginalABXAuditID");
            entity.Property(e => e.PatientFullName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientIdnumber)
                .HasMaxLength(100)
                .HasColumnName("PatientIDNumber");
            entity.Property(e => e.Pminumber)
                .HasMaxLength(100)
                .HasColumnName("PMINumber");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedByBeforeDischarge).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDateBeforeDischarge).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtabxtargetedDrug>(entity =>
        {
            entity.HasKey(e => e.TargetedDrugId).HasName("PK__IMTABXTa__825F0645F1DF8292");

            entity.ToTable("IMTABXTargetedDrugs", "IMT");

            entity.Property(e => e.TargetedDrugId).HasColumnName("TargetedDrugID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.TargetedDrugAtc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TargetedDrugATC");
            entity.Property(e => e.TargetedDrugDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Imtadmission>(entity =>
        {
            entity.ToTable("IMTAdmission", "IMT");

            entity.Property(e => e.AdmissionNumber)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasComputedColumnSql("('A'+right('0000000000'+CONVERT([varchar](10),[Id]),(10)))", true);
            entity.Property(e => e.AdmittedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DischargedDate).HasColumnType("datetime");
            entity.Property(e => e.PatientDeathDateTime).HasColumnType("datetime");
            entity.Property(e => e.PatientDob)
                .HasColumnType("date")
                .HasColumnName("PatientDOB");
            entity.Property(e => e.PatientIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PatientIDNumber");
            entity.Property(e => e.PatientPminumber).HasColumnName("PatientPMINumber");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtalertCategory>(entity =>
        {
            entity.HasKey(e => e.AlertCategoryId).HasName("PK__IMTAlert__838051DF071C85C4");

            entity.ToTable("IMTAlertCategories", "IMT");

            entity.Property(e => e.AlertCategoryId).HasColumnName("AlertCategoryID");
            entity.Property(e => e.AlertCategory)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtalertDetail>(entity =>
        {
            entity.HasKey(e => e.ArlertDetailStatusId).HasName("PK__IMTAlert__D1FDCF6A7905A60E");

            entity.ToTable("IMTAlertDetails", "IMT");

            entity.Property(e => e.ArlertDetailStatusId).HasColumnName("ArlertDetailStatusID");
            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.AssociatedObrdrugSensitivityId).HasColumnName("AssociatedOBRDrugSensitivityID");
            entity.Property(e => e.AtcdrugId).HasColumnName("ATCDrugID");
            entity.Property(e => e.AtcobservationDrugStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("ATCObservationDrugStartDateTime");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DayCountSinceAtcobservationDrugStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("DayCountSinceATCObservationDrugStartDateTime");
            entity.Property(e => e.LabAbnormalFlags).HasMaxLength(100);
            entity.Property(e => e.LabObservationDate).HasColumnType("datetime");
            entity.Property(e => e.LabObservationIdentifier).HasMaxLength(250);
            entity.Property(e => e.LabObservationIdentifierText).HasMaxLength(250);
            entity.Property(e => e.LabObservationValue).HasMaxLength(100);
            entity.Property(e => e.LabObservationValueUnits).HasMaxLength(100);
            entity.Property(e => e.LabReferenceRange).HasMaxLength(250);
            entity.Property(e => e.LabSpecimen).HasMaxLength(250);
            entity.Property(e => e.LabUniversalServiceDentifierIdentifier)
                .HasMaxLength(250)
                .HasColumnName("LabUniversalService_dentifier_Identifier");
            entity.Property(e => e.LabUniversalServiceIdentifierText)
                .HasMaxLength(250)
                .HasColumnName("LabUniversalServiceIdentifier_Text");
            entity.Property(e => e.Rxeatcdrug)
                .HasMaxLength(100)
                .HasColumnName("RXEATCDrug");
            entity.Property(e => e.RxeatcobservationDrugStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXEATCObservationDrugStartDateTime");
            entity.Property(e => e.RxeatcobservationDrugValue)
                .HasMaxLength(100)
                .HasColumnName("RXEATCObservationDrugValue");
            entity.Property(e => e.RxeatcobservationDrugValueUnits)
                .HasMaxLength(100)
                .HasColumnName("RXEATCObservationDrugValueUnits");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Alert).WithMany(p => p.ImtalertDetails)
                .HasForeignKey(d => d.AlertId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTAlertDetails_IMTAlertHeader");
        });

        modelBuilder.Entity<ImtalertHeader>(entity =>
        {
            entity.HasKey(e => e.AlertId).HasName("PK__IMTAlert__EBB16AEDC0186963");

            entity.ToTable("IMTAlertHeader", "IMT");

            entity.HasIndex(e => e.FlagId, "NCI_AlertHeader_DurationNotification");

            entity.HasIndex(e => e.FlagId, "NCI_AlertHeader_DurationNotification2");

            entity.HasIndex(e => e.FlagId, "NCI_AlertHeader_DurationNotification3");

            entity.HasIndex(e => e.CaseNo, "NCI_CaseNumberIncludeAlertAppType");

            entity.HasIndex(e => new { e.InstitutionId, e.Hl7AssociatedPersonLogId }, "NCI_InitialAlertCall");

            entity.HasIndex(e => new { e.OrganismIdentified, e.Hl7uniqueIdentifier, e.CaseNo }, "NCI_OrganismNameHl7");

            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.AlertStatusId).HasColumnName("AlertStatusID");
            entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");
            entity.Property(e => e.CaseNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EscalationId).HasColumnName("EscalationID");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.Hl7AssociatedPersonLogId).HasColumnName("Hl7AssociatedPersonLogID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.InstitutionId).HasColumnName("institutionID");
            entity.Property(e => e.InstitutionName).HasMaxLength(255);
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.OrganismIdentified)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PatientFullName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientIdnumber)
                .HasMaxLength(100)
                .HasColumnName("PatientIDNumber");
            entity.Property(e => e.Pminumber)
                .HasMaxLength(100)
                .HasColumnName("PMINumber");
            entity.Property(e => e.ReconciledDate).HasColumnType("datetime");
            entity.Property(e => e.ReconciledStatusId).HasColumnName("ReconciledStatusID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtalertHeaderExcludeFlagsOnUi>(entity =>
        {
            entity.HasKey(e => e.ExcludeFlagId);

            entity.ToTable("IMTAlertHeaderExcludeFlagsOnUI", "IMT");
        });

        modelBuilder.Entity<ImtalertResolveOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMTAlertResolveOptions", "IMT");

            entity.Property(e => e.AlertStatusId).HasColumnName("AlertStatusID");
            entity.Property(e => e.CaseNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.OrganismId).HasColumnName("OrganismID");
            entity.Property(e => e.ResultStatusId).HasColumnName("ResultStatusID");
            entity.Property(e => e.SpecimenId).HasColumnName("SpecimenID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtalertStatus>(entity =>
        {
            entity.HasKey(e => e.AlertStatusId).HasName("PK__IMTAlert__E411CE6379349595");

            entity.ToTable("IMTAlertStatus", "IMT");

            entity.Property(e => e.AlertStatusId).HasColumnName("AlertStatusID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StatusDescription).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Imtapirole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__IMTAPIRo__8AFACE3A21B89968");

            entity.ToTable("IMTAPIRoles", "HL7");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Imtapiuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IMTAPIUs__3214EC27CD0C2685");

            entity.ToTable("IMTAPIUsers", "HL7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpireyDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtapplicationType>(entity =>
        {
            entity.HasKey(e => e.ApplicationTypeId).HasName("PK__IMTAppli__2821511AE6D116CB");

            entity.ToTable("IMTApplicationTypes", "IMT");

            entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");
            entity.Property(e => e.ApplicationType).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtatccodesInLabDrug>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTATCCodesInLabDrugs__5E548648C59A1434");

            entity.ToTable("IMTATCCodesInLabDrugs", "IMT");

            entity.Property(e => e.Atccode)
                .HasMaxLength(255)
                .HasColumnName("ATCCode");
            entity.Property(e => e.LabDrugId).HasColumnName("LabDrugID");
        });

        modelBuilder.Entity<Imtcmlgroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("IMTCMLGroups", "IMT");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'Rules Engine')");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'Rules Engine')");
        });

        modelBuilder.Entity<Imtcmlresult>(entity =>
        {
            entity.HasKey(e => e.ResultId);

            entity.ToTable("IMTCMLResults", "IMT");

            entity.Property(e => e.ResultId).HasColumnName("ResultID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'Rules Engine')");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.Mnemonic)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PrintCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'Rules Engine')");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Group).WithMany(p => p.Imtcmlresults)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTCMLResults_IMTCMLGroups");

            entity.HasOne(d => d.Lab).WithMany(p => p.Imtcmlresults)
                .HasForeignKey(d => d.LabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTCMLResults_IMTLabs");
        });

        modelBuilder.Entity<Imtcmlresultstemp>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PK_IMTCMLResultsTemp");

            entity.ToTable("IMTCMLResultstemp", "IMT");

            entity.Property(e => e.ResultId).HasColumnName("ResultID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'Rules Engine')");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.Labcode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'Rules Engine')");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Imtcomment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__IMTComme__C3B4DFAAA9F71ABC");

            entity.ToTable("IMTComments", "IMT");

            entity.HasIndex(e => new { e.ContentId, e.ContentType }, "NCI_ContentIdContentType_All").IsDescending(true, false);

            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.CaseNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comment).HasMaxLength(2048);
            entity.Property(e => e.CommentTypeId).HasColumnName("CommentTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PmiNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtcommentType>(entity =>
        {
            entity.HasKey(e => e.CommentTypeId).HasName("PK__IMTComme__D7118B0A9D5BDFD3");

            entity.ToTable("IMTCommentTypes", "IMT");

            entity.Property(e => e.CommentTypeId).HasColumnName("CommentTypeID");
            entity.Property(e => e.CommentType).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtcontentType>(entity =>
        {
            entity.HasKey(e => e.ContentTypeId).HasName("PK_ContentType");

            entity.ToTable("IMTContentType", "IMT");

            entity.Property(e => e.ContentTypeId).ValueGeneratedNever();
            entity.Property(e => e.ContentTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtcriteriaOpporator>(entity =>
        {
            entity.HasKey(e => e.CriteriaOpporatorId).HasName("PK__CriteriaOpporators__908D66166B45C8FB");

            entity.ToTable("IMTCriteriaOpporators", "IMT");

            entity.Property(e => e.CriteriaOpporatorId).HasColumnName("CriteriaOpporatorID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CriteriaOpporator).HasMaxLength(150);
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtdeviceAuditing>(entity =>
        {
            entity.HasKey(e => e.DeviceAuditingId).HasName("PK_IMTDeviceAuditing_2");

            entity.ToTable("IMTDeviceAuditing", "IMT");

            entity.Property(e => e.AuditDescription).HasMaxLength(50);
            entity.Property(e => e.CaseNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Device).WithMany(p => p.ImtdeviceAuditings)
                .HasForeignKey(d => d.DeviceId)
                .HasConstraintName("FK_IMTDeviceAuditing_Device");
        });

        modelBuilder.Entity<ImtdohNotifcation>(entity =>
        {
            entity.HasKey(e => e.Dohid).HasName("PK__DohID__8A4848302E1CC450");

            entity.ToTable("IMTDohNotifcations", "IMT");

            entity.Property(e => e.Dohid).HasColumnName("DOHId");
            entity.Property(e => e.Comment).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtdohNotifcationsTemp>(entity =>
        {
            entity.HasKey(e => e.Dohid).HasName("PK__DohID__8A4848302E1CC4501");

            entity.ToTable("IMTDohNotifcationsTemp", "IMT");

            entity.Property(e => e.Dohid).HasColumnName("DOHId");
            entity.Property(e => e.Comment).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Imtdrug>(entity =>
        {
            entity.HasKey(e => e.DrugId).HasName("PK__IMTDrugs__908D66166B45C8FB");

            entity.ToTable("IMTDrugs", "IMT");

            entity.HasIndex(e => e.DrugCode, "DrugCode");

            entity.HasIndex(e => e.NappiCode, "NappiCode");

            entity.Property(e => e.ActiveIngredientText).HasMaxLength(255);
            entity.Property(e => e.Activeingredient2)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT2");
            entity.Property(e => e.Activeingredient3)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT3");
            entity.Property(e => e.Activeingredient4)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT4");
            entity.Property(e => e.Activeingredient5)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT5");
            entity.Property(e => e.Activeingredient6)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT6");
            entity.Property(e => e.Activeingredient7)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT7");
            entity.Property(e => e.Activeingredient8)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT8");
            entity.Property(e => e.Drug).HasMaxLength(150);
            entity.Property(e => e.DrugCode).HasMaxLength(100);
            entity.Property(e => e.MaterialText).HasMaxLength(255);
            entity.Property(e => e.NappiCode).HasMaxLength(255);
        });

        modelBuilder.Entity<ImtdrugGroup>(entity =>
        {
            entity.HasKey(e => e.DrugGroupId).HasName("PK__IMTDrugG__CECA1DF5C24DD2F5");

            entity.ToTable("IMTDrugGroups", "IMT");

            entity.Property(e => e.DrugGroupId).HasColumnName("DrugGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DrugGroupName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtdrugStatus>(entity =>
        {
            entity.HasKey(e => e.DrugStatusId).HasName("PK__IMTDrugS__48AE6764C70A5622");

            entity.ToTable("IMTDrugStatus", "IMT");

            entity.HasIndex(e => e.Atccode, "ind_ATCCode");

            entity.HasIndex(e => e.CaseNo, "ind_CaseNo").HasFillFactor(90);

            entity.Property(e => e.DrugStatusId).HasColumnName("DrugStatusID");
            entity.Property(e => e.Atccode)
                .HasMaxLength(100)
                .HasColumnName("ATCCode");
            entity.Property(e => e.CaseNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DispensedDate).HasColumnType("datetime");
            entity.Property(e => e.DrugCancelledDate).HasColumnType("datetime");
            entity.Property(e => e.DrugId).HasColumnName("DrugID");
            entity.Property(e => e.DrugIsCancelled).HasDefaultValueSql("((0))");
            entity.Property(e => e.DrugLastRestartedDate).HasColumnType("datetime");
            entity.Property(e => e.DrugStartDate).HasColumnType("datetime");
            entity.Property(e => e.DrugStoppedDate).HasColumnType("datetime");
            entity.Property(e => e.LastDispensedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtdrugsInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTDrugs__5E548648C59A1434");

            entity.ToTable("IMTDrugsInGroups", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DrugGroupId).HasColumnName("DrugGroupID");
            entity.Property(e => e.DrugId).HasColumnName("DrugID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtdurationNotificationTracking>(entity =>
        {
            entity.HasKey(e => e.DurationTrackingId).HasName("PK__IMTDurat__2E61D2438D6AB886");

            entity.ToTable("IMTDurationNotificationTracking", "IMT");

            entity.Property(e => e.DurationTrackingId).HasColumnName("DurationTrackingID");
            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.CaseNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExtendedDate).HasColumnType("datetime");
            entity.Property(e => e.Lrt).HasColumnName("LRT");
            entity.Property(e => e.NotificationDurationTrackingActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ReActivatedDate).HasColumnType("datetime");
            entity.Property(e => e.Rxe21GivenCodeIdentifier)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RXE_2_1_GivenCode_Identifier");
            entity.Property(e => e.StoppedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Alert).WithMany(p => p.ImtdurationNotificationTrackings)
                .HasForeignKey(d => d.AlertId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertID");
        });

        modelBuilder.Entity<ImtdynamicFormBuilder>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__IMT__0DC06F8CF3D9AFFB");

            entity.ToTable("IMTDynamicFormBuilder", "IMT");

            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.ControlIcon).HasMaxLength(255);
            entity.Property(e => e.ControlId)
                .HasMaxLength(255)
                .HasColumnName("ControlID");
            entity.Property(e => e.ControlSpecialContainer).HasMaxLength(255);
            entity.Property(e => e.ControlType).HasMaxLength(255);
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.GroupNotSelectedlookupQueryId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GroupNotSelectedlookupQueryID");
            entity.Property(e => e.GrouplookQueryId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GrouplookQueryID");
            entity.Property(e => e.ImtlookUpField)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IMTLookUpField");
            entity.Property(e => e.LookupDefaultValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LookupId).HasColumnName("LookupID");
            entity.Property(e => e.ParentQuestionContainer).HasMaxLength(255);
            entity.Property(e => e.ParentQuestionId).HasColumnName("ParentQuestionID");
            entity.Property(e => e.ParentQuestionSelection).HasMaxLength(255);
            entity.Property(e => e.QueryId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("QueryID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.StyleId).HasColumnName("StyleID");
            entity.Property(e => e.ValidationId).HasColumnName("ValidationID");
            entity.Property(e => e.WorkFlowContainer).HasMaxLength(255);
        });

        modelBuilder.Entity<ImtdynamicFormBuilderLookup>(entity =>
        {
            entity.HasKey(e => e.LookupId).HasName("PK__IMT_Look__6D8B9C6B22C9A32E");

            entity.ToTable("IMTDynamicFormBuilderLookups", "IMT");

            entity.Property(e => e.LookupId).HasColumnName("LookupID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.LookupQuery).HasColumnName("lookupQuery");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ImtdynamicFormBuilderLookupValue>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMT_Look__7839F62D096D4166");

            entity.ToTable("IMTDynamicFormBuilderLookupValues", "IMT");

            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.LookupId).HasColumnName("LookupID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ImtdynamicFormBuilderLookupsParameter>(entity =>
        {
            entity.HasKey(e => e.ParameterId).HasName("PK__ParamSQLQu__F80C6297B3C621BE");

            entity.ToTable("IMTDynamicFormBuilderLookupsParameters", "IMT");

            entity.Property(e => e.ParameterId).HasColumnName("ParameterID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.LookupId).HasColumnName("LookupID");
            entity.Property(e => e.ParameterName).HasMaxLength(255);
            entity.Property(e => e.ParameterValue).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(1)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<Imtescalation>(entity =>
        {
            entity.HasKey(e => e.EscalationId).HasName("PK__IMTEscal__6C7956F0DD56EC3E");

            entity.ToTable("IMTEscalations", "IMT");

            entity.Property(e => e.EscalationId).HasColumnName("EscalationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EscalationDescription).HasMaxLength(255);
            entity.Property(e => e.EscalationDurationUnitOfMeasurement).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtexceptionScript>(entity =>
        {
            entity.HasKey(e => e.ExceptionScriptId).HasName("PK__IMTExcep__DC0B228F69DA59BB");

            entity.ToTable("IMTExceptionScripts", "IMT");

            entity.Property(e => e.ExceptionScriptId).HasColumnName("ExceptionScriptID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DristribustionGroupId).HasColumnName("DristribustionGroupID");
            entity.Property(e => e.ExceptionScriptName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExceptionScriptSubject)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HasHtmlbody).HasColumnName("HasHTMLBody");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtexceptionScriptDristribustionGroup>(entity =>
        {
            entity.HasKey(e => e.DristribustionGroupId).HasName("PK__IMTExcep__04EF92DBAEA3AC1E");

            entity.ToTable("IMTExceptionScriptDristribustionGroups", "IMT");

            entity.Property(e => e.DristribustionGroupId).HasColumnName("DristribustionGroupID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DristribustionGroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtexceptionScriptDristribustionList>(entity =>
        {
            entity.HasKey(e => e.ListId).HasName("PK__IMTExcep__E38328654F2F7578");

            entity.ToTable("IMTExceptionScriptDristribustionList", "IMT");

            entity.Property(e => e.ListId).HasColumnName("ListID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DristribustionGroupId).HasColumnName("DristribustionGroupID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.DristribustionGroup).WithMany(p => p.ImtexceptionScriptDristribustionLists)
                .HasForeignKey(d => d.DristribustionGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DristribustionGroupID");
        });

        modelBuilder.Entity<ImtexcludedDrugsInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTExcludedDrugsInGroups__5E548648C59A1434");

            entity.ToTable("IMTExcludedDrugsInGroups", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DrugGroupId).HasColumnName("DrugGroupID");
            entity.Property(e => e.DrugId).HasColumnName("DrugID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Imtflag>(entity =>
        {
            entity.HasKey(e => e.FlagId).HasName("PK__IMTFlags__780D45B34DACAC46");

            entity.ToTable("IMTFlags", "IMT");

            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FlagDesc).HasMaxLength(100);
            entity.Property(e => e.FlagDetails).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtflagAlertType>(entity =>
        {
            entity.HasKey(e => e.AlertTypeId).HasName("PK__IMTFlagA__016D419D87399321");

            entity.ToTable("IMTFlagAlertTypes", "IMT");

            entity.Property(e => e.AlertTypeId).HasColumnName("AlertTypeID");
            entity.Property(e => e.AlertTypeDescription).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtglobalFlag>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTGloba__5E5499A88A6012BB");

            entity.ToTable("IMTGlobalFlags", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.IsolateFlagId).HasColumnName("IsolateFlagID");
            entity.Property(e => e.IsolateId).HasColumnName("IsolateID");

            entity.HasOne(d => d.IsolateFlag).WithMany(p => p.ImtglobalFlags)
                .HasForeignKey(d => d.IsolateFlagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTGlobalFlags_IMTIsolateInflags");
        });

        modelBuilder.Entity<Imthl7table>(entity =>
        {
            entity.HasKey(e => e.Hl7tableId).HasName("PK__IMTHL7Tables__908D66166B45C8FB");

            entity.ToTable("IMTHL7Tables", "IMT");

            entity.Property(e => e.Hl7tableId).HasColumnName("HL7TableID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Hl7TableName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Imthl7tableColumn>(entity =>
        {
            entity.HasKey(e => e.Hl7tableColumnId).HasName("PK__IMTHL7TableColumns__908D66166B45C8FB");

            entity.ToTable("IMTHL7TableColumns", "IMT");

            entity.Property(e => e.Hl7tableColumnId).HasColumnName("HL7TableColumnID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Hl7ColumnName).HasMaxLength(255);
            entity.Property(e => e.Hl7tableId).HasColumnName("HL7TableID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtinstitutionMetadatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IMTInsti__3214EC07F524544B");

            entity.ToTable("IMTInstitutionMetadata", "IMT");

            entity.Property(e => e.AbbreviatedInstitutionDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SapIshCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SAP_ISH_CODE");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateAdhoc>(entity =>
        {
            entity.ToTable("IMTIsolateAdhoc", "IMT");

            entity.Property(e => e.AbsAlertId).HasDefaultValueSql("((0))");
            entity.Property(e => e.AlertId).HasDefaultValueSql("((0))");
            entity.Property(e => e.Base64PdfReport).IsUnicode(false);
            entity.Property(e => e.CaseNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FlagDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IppAlertId).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsolateId).HasDefaultValueSql("((0))");
            entity.Property(e => e.OrganismName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OtherLabDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PanelDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Site)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateAlternativeSpecimenGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTIsola__7839F62D7F8A3A95");

            entity.ToTable("IMTIsolateAlternativeSpecimenGroups", "IMT");

            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.Obr42UniversalServiceIdentifierText)
                .HasMaxLength(255)
                .HasColumnName("OBR_4_2_UniversalServiceIdentifier_Text");
            entity.Property(e => e.SpecimenGroupId).HasColumnName("SpecimenGroupID");
        });

        modelBuilder.Entity<ImtisolateDetail>(entity =>
        {
            entity.HasKey(e => e.IsolateDetailId).HasName("PK__IMTIsolateDetails__D1FDCF6A7905A60E");

            entity.ToTable("IMTIsolateDetails", "IMT");

            entity.HasIndex(e => e.IsolateDetailHeaderId, "IDX_IsolateDetailHeaderID");

            entity.HasIndex(e => new { e.IsolateDetailId, e.IsolateDetailHeaderId, e.Obx32ObservationIdentifierText }, "NCI_Obr3_2_All");

            entity.Property(e => e.IsolateDetailId).HasColumnName("IsolateDetailID");
            entity.Property(e => e.IsolateDetailHeaderId).HasColumnName("IsolateDetailHeaderID");
            entity.Property(e => e.Obx141DateTimeOfObservationTimeOfEvent)
                .HasColumnType("datetime")
                .HasColumnName("OBX_14_1_DateTimeOfObservation_TimeOfEvent");
            entity.Property(e => e.Obx31ObservationIdentifier)
                .HasMaxLength(250)
                .HasColumnName("OBX_3_1_ObservationIdentifier");
            entity.Property(e => e.Obx32ObservationIdentifierText)
                .HasMaxLength(250)
                .HasColumnName("OBX_3_2_ObservationIdentifierText");
            entity.Property(e => e.Obx33ObservationIdentifierNameOfCodingSystem)
                .HasMaxLength(250)
                .HasColumnName("OBX_3_3_ObservationIdentifierNameOfCodingSystem");
            entity.Property(e => e.Obx5ObservationValue)
                .HasMaxLength(250)
                .HasColumnName("OBX_5_ObservationValue");
            entity.Property(e => e.Obx61UnitsIdentifier)
                .HasMaxLength(250)
                .HasColumnName("OBX_6_1_Units_Identifier");
            entity.Property(e => e.Obx7ReferenceRange)
                .HasMaxLength(250)
                .HasColumnName("OBX_7_ReferenceRange");
            entity.Property(e => e.Obx8AbnormalFlags)
                .HasMaxLength(250)
                .HasColumnName("OBX_8_AbnormalFlags");

            entity.HasOne(d => d.IsolateDetailHeader).WithMany(p => p.ImtisolateDetails)
                .HasForeignKey(d => d.IsolateDetailHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTIsolateDetails_IMTIsolateDetailHeader");
        });

        modelBuilder.Entity<ImtisolateDetailHeader>(entity =>
        {
            entity.HasKey(e => e.IsolateDetailHeaderId).HasName("PK__IMTIsolateDetailHeader__D1FDCF6A7905A60E");

            entity.ToTable("IMTIsolateDetailHeader", "IMT");

            entity.HasIndex(e => e.IsolateId, "NCI_IsolateID_All");

            entity.Property(e => e.IsolateDetailHeaderId).HasColumnName("IsolateDetailHeaderID");
            entity.Property(e => e.IsolateId).HasColumnName("IsolateID");
            entity.Property(e => e.Obr1511SpecimenSourceSpecimenSourceNameOrCodeIdentifier)
                .HasMaxLength(255)
                .HasColumnName("OBR_15_1_1_SpecimenSource_SpecimenSourceNameOrCode_Identifier");
            entity.Property(e => e.Obr41UniversalServiceDentifierIdentifier)
                .HasMaxLength(250)
                .HasColumnName("OBR_4_1_UniversalService_dentifier_Identifier");
            entity.Property(e => e.Obr42UniversalServiceIdentifierText)
                .HasMaxLength(250)
                .HasColumnName("OBR_4_2_UniversalServiceIdentifier_Text");
            entity.Property(e => e.Obr71ObservationDateTimeTimeOfEvent)
                .HasColumnType("datetime")
                .HasColumnName("OBR_7_1_Observation_DateTime_TimeOfEvent");
            entity.Property(e => e.PkObrId).HasColumnName("pk_OBR_ID");

            entity.HasOne(d => d.Isolate).WithMany(p => p.ImtisolateDetailHeaders)
                .HasForeignKey(d => d.IsolateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTIsolateDetailHeader_IMTIsolateHeader");
        });

        modelBuilder.Entity<ImtisolateDohMarker>(entity =>
        {
            entity.HasKey(e => e.IsolateDohMarkerId);

            entity.ToTable("IMTIsolateDohMarker", "IMT");

            entity.Property(e => e.DohnotifiableConditionId).HasColumnName("DOHNotifiableConditionID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LabOrganism).HasDefaultValueSql("('')");
            entity.Property(e => e.ResponsibleOrganism)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TestCode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateDohMarkerTemp>(entity =>
        {
            entity.HasKey(e => e.IsolateDohMarkerId);

            entity.ToTable("IMTIsolateDohMarkerTemp", "IMT");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.TestCode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateDohMarkerTemp2>(entity =>
        {
            entity.HasKey(e => e.IsolateDohMarkerId);

            entity.ToTable("IMTIsolateDohMarkerTemp2", "IMT");

            entity.Property(e => e.DohnotifiableConditionId).HasColumnName("DOHNotifiableConditionID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LabOrganism).HasDefaultValueSql("('')");
            entity.Property(e => e.ResponsibleOrganism)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TestCode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateEventTypeSpecimenCheck>(entity =>
        {
            entity.HasKey(e => e.EventTypeSpecimenId);

            entity.ToTable("IMTIsolateEventTypeSpecimenCheck", "IMT");

            entity.Property(e => e.Criteria).IsUnicode(false);
            entity.Property(e => e.FieldCheck)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FieldValue)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateFlagGroup>(entity =>
        {
            entity.HasKey(e => e.IsolateFlagGroupId).HasName("PK__IsolateFlagGroupID__CECA1DF5C24DD2F5");

            entity.ToTable("IMTIsolateFlagGroups", "IMT");

            entity.Property(e => e.IsolateFlagGroupId).HasColumnName("IsolateFlagGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.RuleFlagId).HasColumnName("RuleFlagID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateFlagsInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__LogID__95B71CAD7DD9DD06");

            entity.ToTable("IMTIsolateFlagsInGroups", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.IsolateFlagGroupId).HasColumnName("IsolateFlagGroupID");
            entity.Property(e => e.IsolateFlagId).HasColumnName("IsolateFlagID");
            entity.Property(e => e.Priority).HasColumnName("priority");
        });

        modelBuilder.Entity<ImtisolateGroup>(entity =>
        {
            entity.HasKey(e => e.IsolateGroupId).HasName("PK__IMTIsola__6D588865955720C0");

            entity.ToTable("IMTIsolateGroups", "IMT");

            entity.Property(e => e.IsolateGroupId).HasColumnName("IsolateGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsolateGroupName).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateGroupClassification>(entity =>
        {
            entity.HasKey(e => e.IsolateClassificationId).HasName("PK__IsolateClassificationID__3C72E9ECE10BC4F1");

            entity.ToTable("IMTIsolateGroupClassification", "IMT");

            entity.Property(e => e.IsolateClassificationId).HasColumnName("IsolateClassificationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.FullDescription).HasMaxLength(150);
            entity.Property(e => e.TypeDesciption)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateGroupItem>(entity =>
        {
            entity.HasKey(e => e.IsolateGroupListId).HasName("PK__IMTIsola__CFC330005F4AC1F7");

            entity.ToTable("IMTIsolateGroupItems", "IMT");

            entity.Property(e => e.IsolateGroupListId).HasColumnName("IsolateGroupListID");
            entity.Property(e => e.IsolateGroupItemDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsolateGroupTypeId).HasColumnName("IsolateGroupTypeID");
            entity.Property(e => e.IsolategroupItem)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.UniversalOrganismName).HasMaxLength(255);
        });

        modelBuilder.Entity<ImtisolateGroupItemSplit>(entity =>
        {
            entity.HasKey(e => e.ImtisolateGroupItemSplitId).HasName("PK__IMTIsola__11E9A4ACCB42A62D");

            entity.ToTable("IMTIsolateGroupItemSplit", "IMT");

            entity.Property(e => e.ImtisolateGroupItemSplitId).HasColumnName("IMTIsolateGroupItemSplitID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.LabId).HasColumnName("labID");
            entity.Property(e => e.Obx31ObservationIdentifier)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OBX_3_1_ObservationIdentifier");
            entity.Property(e => e.Obx32ObservationIdentifierText)
                .HasMaxLength(255)
                .HasColumnName("OBX_3_2_ObservationIdentifierText");
        });

        modelBuilder.Entity<ImtisolateGroupItemSplitDetail>(entity =>
        {
            entity.HasKey(e => e.ImtisolateGroupItemSplitDetailId).HasName("PK__IMTIsola__E5FB98884E91C368");

            entity.ToTable("IMTIsolateGroupItemSplitDetails", "IMT");

            entity.Property(e => e.ImtisolateGroupItemSplitDetailId).HasColumnName("IMTIsolateGroupItemSplitDetailID");
            entity.Property(e => e.ImtisolateGroupItemSplitId).HasColumnName("IMTIsolateGroupItemSplitID");
            entity.Property(e => e.Obx31ObservationIdentifier)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OBX_3_1_ObservationIdentifier");
            entity.Property(e => e.Obx32ObservationIdentifierText)
                .HasMaxLength(255)
                .HasColumnName("OBX_3_2_ObservationIdentifierText");
            entity.Property(e => e.UniversalOrganismName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateGroupItemsinGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTIsola__5E5499A81D026F82");

            entity.ToTable("IMTIsolateGroupItemsinGroups", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.IsolateGroupId).HasColumnName("IsolateGroupID");
            entity.Property(e => e.IsolateGroupListId).HasColumnName("IsolateGroupListID");
        });

        modelBuilder.Entity<ImtisolateGroupItemstoExclude>(entity =>
        {
            entity.HasKey(e => e.IsolateGroupListExcludeId).HasName("PK__IsolateGroupListExcludeID__CFC330005F4AC1F7");

            entity.ToTable("IMTIsolateGroupItemstoExclude", "IMT");

            entity.Property(e => e.IsolateGroupListExcludeId).HasColumnName("IsolateGroupListExcludeID");
            entity.Property(e => e.IsolateExcludeGroupItemDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsolateExcludegroupItem)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsolateGroupTypeId).HasColumnName("IsolateGroupTypeID");
            entity.Property(e => e.LabId).HasColumnName("LabID");
        });

        modelBuilder.Entity<ImtisolateGroupWorkflow>(entity =>
        {
            entity.HasKey(e => e.IsolateGroupWorkflowId).HasName("PK__IsolateGroupWorkflow__5E5499A84D5CBE88");

            entity.ToTable("IMTIsolateGroupWorkflows", "IMT");

            entity.Property(e => e.IsolateGroupWorkflowId).HasColumnName("IsolateGroupWorkflowID");
            entity.Property(e => e.GroupDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsolateGroupId).HasColumnName("IsolateGroupID");
            entity.Property(e => e.IsolateResultType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.QueryId).HasColumnName("QueryID");
        });

        modelBuilder.Entity<ImtisolateHeader>(entity =>
        {
            entity.HasKey(e => e.IsolateId).HasName("PK__IMTIsolateHeader__EBB16AEDC0186963");

            entity.ToTable("IMTIsolateHeader", "IMT");

            entity.HasIndex(e => e.CaseNo, "NCI_CaseNumberIncludeIsolateId");

            entity.HasIndex(e => new { e.InstitutionId, e.Active, e.IsFinal }, "NCI_InstitutionActiveIsFinalIncludeMultiple").HasFillFactor(80);

            entity.HasIndex(e => e.InstitutionId, "NCI_InstitutionID_IsolateID");

            entity.Property(e => e.IsolateId).HasColumnName("IsolateID");
            entity.Property(e => e.CaseNo).HasMaxLength(100);
            entity.Property(e => e.CollectionDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Hl7AssociatedPersonLogId).HasColumnName("Hl7AssociatedPersonLogID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.InstitutionId).HasColumnName("institutionID");
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsolateGroupId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsolateGroupID");
            entity.Property(e => e.LabId).HasColumnName("labID");
            entity.Property(e => e.LabSpecimenSite).HasMaxLength(255);
            entity.Property(e => e.LabSpecimenSource).HasMaxLength(255);
            entity.Property(e => e.NoLink).HasDefaultValueSql("((0))");
            entity.Property(e => e.Obrid).HasColumnName("OBRID");
            entity.Property(e => e.OrganismIdentified)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PatientFullName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientIdnumber)
                .HasMaxLength(100)
                .HasColumnName("PatientIDNumber");
            entity.Property(e => e.PatientLocationBed)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PatientLocationRoom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PatientLocationWard)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pminumber)
                .HasMaxLength(100)
                .HasColumnName("PMINumber");
            entity.Property(e => e.ReconciledDate).HasColumnType("datetime");
            entity.Property(e => e.ReconciledStatusId).HasColumnName("ReconciledStatusID");
            entity.Property(e => e.ResultTypeGroupId).HasColumnName("ResultTypeGroupID");
            entity.Property(e => e.SpecimenGroupId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SpecimenGroupID");
            entity.Property(e => e.SpecimenReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.SpecimenSite).HasMaxLength(255);
            entity.Property(e => e.SpecimenSource).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateInfectionType>(entity =>
        {
            entity.HasKey(e => e.IsolateInfectionTypeId).HasName("PK__IsolateInfectionTypeID__8A4848302E1CC450");

            entity.ToTable("IMTIsolateInfectionType", "IMT");

            entity.Property(e => e.IsolateInfectionTypeId).HasColumnName("IsolateInfectionTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsolateInfectionType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateInflag>(entity =>
        {
            entity.HasKey(e => e.IsolateFlagId).HasName("PK__IMTIsola__3F5B1BF88215CA5B");

            entity.ToTable("IMTIsolateInflags", "IMT");

            entity.HasIndex(e => e.FlagDescription, "ind_FlagDescription");

            entity.Property(e => e.IsolateFlagId).HasColumnName("IsolateFlagID");
            entity.Property(e => e.FlagDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsVisible).HasDefaultValueSql("((0))");
            entity.Property(e => e.LabDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.RuleFlagId).HasColumnName("RuleFlagID");
        });

        modelBuilder.Entity<ImtisolateLrtPnuDiagnosis>(entity =>
        {
            entity.HasKey(e => e.PnuId);

            entity.ToTable("IMTIsolateLrtPnuDiagnosis", "IMT");

            entity.Property(e => e.PnuId).ValueGeneratedNever();
            entity.Property(e => e.ImagingTestCriteria).IsUnicode(false);
            entity.Property(e => e.LaboratoryCriteria).IsUnicode(false);
            entity.Property(e => e.PnuDescription)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SignSymptomsCriteria).IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateOrigin>(entity =>
        {
            entity.HasKey(e => e.IsolateOriginId).HasName("PK__IsolateOriginID__3C72E9ECE10BC4F1");

            entity.ToTable("IMTIsolateOrigins", "IMT");

            entity.Property(e => e.IsolateOriginId).HasColumnName("IsolateOriginID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateQuestion>(entity =>
        {
            entity.HasKey(e => e.IsolateQuestionId);

            entity.ToTable("IMTIsolateQuestion", "IMT");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.IsolateQuestionAnswerId).HasName("PK__IMTIsola__3AADBF088F25B164");

            entity.ToTable("IMTIsolateQuestionAnswer", "IMT");

            entity.HasIndex(e => new { e.IsolateId, e.IsolateQuestionId }, "NCI_IsolateIDQuestionID_Answer");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Answer)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Note)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.SubAnwer)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateSerologyMapping>(entity =>
        {
            entity.HasKey(e => e.SerologyMappingId);

            entity.ToTable("IMTIsolateSerologyMapping", "IMT");

            entity.Property(e => e.ImtIsolateName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.OrderCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SerologyLabName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateSpecificDetail>(entity =>
        {
            entity.HasKey(e => e.IsolateSpecificDetailId).HasName("PK__IsolateSpecificDetailID__8A4848302E1CC450");

            entity.ToTable("IMTIsolateSpecificDetails", "IMT");

            entity.Property(e => e.IsolateSpecificDetailId).HasColumnName("IsolateSpecificDetailID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DiagnosedDescription).HasMaxLength(255);
            entity.Property(e => e.IsolateId).HasColumnName("IsolateID");
            entity.Property(e => e.Surgery).HasMaxLength(255);
            entity.Property(e => e.TbClassifcation).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtisolateSpecimenEventType>(entity =>
        {
            entity.ToTable("IMTIsolateSpecimenEventType", "IMT");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FkIsolateEventId).HasColumnName("fkIsolateEventId");
            entity.Property(e => e.FkSpecimenGroupId).HasColumnName("fkSpecimenGroupId");

            entity.HasOne(d => d.FkIsolateEvent).WithMany(p => p.ImtisolateSpecimenEventTypes)
                .HasForeignKey(d => d.FkIsolateEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTIsolateSpecimenEventType_IMTIsolateSpecimenEventType");

            entity.HasOne(d => d.FkSpecimenGroup).WithMany(p => p.ImtisolateSpecimenEventTypes)
                .HasForeignKey(d => d.FkSpecimenGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTIsolateSpecimenEventType_IMTSpecimenGroups");
        });

        modelBuilder.Entity<ImtisolateSpecimenQuestion>(entity =>
        {
            entity.HasKey(e => e.SpecimenQuestionId);

            entity.ToTable("IMTIsolateSpecimenQuestion", "IMT");
        });

        modelBuilder.Entity<ImtisolateSubQuestion>(entity =>
        {
            entity.HasKey(e => e.IsolateQuestionSubId);

            entity.ToTable("IMTIsolateSubQuestion", "IMT");

            entity.Property(e => e.IsolateQuestionSubId).ValueGeneratedOnAdd();
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IsolateQuestionSub).WithOne(p => p.ImtisolateSubQuestion)
                .HasForeignKey<ImtisolateSubQuestion>(d => d.IsolateQuestionSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTIsolateSubQuestion_IMTIsolateQuestion");
        });

        modelBuilder.Entity<ImtisolateSurgerySelection>(entity =>
        {
            entity.HasKey(e => e.SurgerySelectionId);

            entity.ToTable("IMTIsolateSurgerySelection", "IMT");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SurgerySelectionCriteria)
                .HasMaxLength(850)
                .IsUnicode(false);
            entity.Property(e => e.SurgerySelectionDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtisolateSymptom>(entity =>
        {
            entity.HasKey(e => e.IsolateSymptomId);

            entity.ToTable("IMTIsolateSymptom", "IMT");
        });

        modelBuilder.Entity<Imtlab>(entity =>
        {
            entity.HasKey(e => e.LabId).HasName("PK__IMTLabs__EDBD773A2FFB0B62");

            entity.ToTable("IMTLabs", "IMT");

            entity.HasIndex(e => e.LabName, "NCI_LabName_Id")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LabName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtlabCatalogue>(entity =>
        {
            entity.HasKey(e => e.CatalogueId).HasName("PK__CatalogueID");

            entity.ToTable("IMTLabCatalogues", "IMT");

            entity.Property(e => e.CatalogueId)
                .ValueGeneratedNever()
                .HasColumnName("CatalogueID");
            entity.Property(e => e.CatalogueTypeId).HasColumnName("CatalogueTypeID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabId).HasColumnName("labID");
        });

        modelBuilder.Entity<ImtlabDrug>(entity =>
        {
            entity.HasKey(e => e.DrugId).HasName("PK__IMTLabDrugs__908D66166B45C8FB");

            entity.ToTable("IMTLabDrugs", "IMT");

            entity.Property(e => e.Atccode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ATCCode");
            entity.Property(e => e.Drug).HasMaxLength(150);
            entity.Property(e => e.DrugGroupId).HasColumnName("DrugGroupID");
            entity.Property(e => e.LabDrugCode).HasMaxLength(100);
        });

        modelBuilder.Entity<ImtlabDrugGroup>(entity =>
        {
            entity.HasKey(e => e.LabDrugGroupId).HasName("PK__LabDrugGroupID__CECA1DF5C24DD2F5");

            entity.ToTable("IMTLabDrugGroups", "IMT");

            entity.Property(e => e.LabDrugGroupId).HasColumnName("LabDrugGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LabDrugGroupName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtlabDrugsInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__LabDrugsInGroups__5E548648C59A1434");

            entity.ToTable("IMTLabDrugsInGroups", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LabDrugGroupId).HasColumnName("LabDrugGroupID");
            entity.Property(e => e.LabDrugId).HasColumnName("LabDrugID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtlabWardMapping>(entity =>
        {
            entity.ToTable("IMTLabWardMapping", "IMT");

            entity.HasIndex(e => new { e.LabHospital, e.LabId }, "NCI_LabWardName_SapCode");

            entity.Property(e => e.LabHospital)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LabWardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LabWardName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SapHospital)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SapWardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SapWardName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtlatestCaseState>(entity =>
        {
            entity.HasKey(e => e.LatestCaseStatesId);

            entity.ToTable("IMTLatestCaseStates", "IMT");

            entity.HasIndex(e => e.CaseNumber, "NCI_CaseNumber").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogIdcurrentLocation, "NCI_HL7PersonLogIDCurrentLocation").HasFillFactor(80);

            entity.HasIndex(e => e.CaseNumber, "UC_CaseNumber").IsUnique();

            entity.Property(e => e.AdmissionType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.AdmittedDate).HasColumnType("datetime");
            entity.Property(e => e.AdmittingDoctor)
                .HasMaxLength(405)
                .IsUnicode(false);
            entity.Property(e => e.CaseNumber).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DischargedDate).HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogIdcurrentLocation).HasColumnName("HL7PersonLogIDCurrentLocation");
            entity.Property(e => e.Hl7uniqueIdentifierCurrentLocation).HasColumnName("HL7UniqueIdentifierCurrentLocation");
            entity.Property(e => e.InstitutionMasterId).HasColumnName("InstitutionMasterID");
            entity.Property(e => e.InstitutionSapIshCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientClass)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PatientCurrentlyDeceased).HasDefaultValueSql("((0))");
            entity.Property(e => e.PatientDeathDateTime).HasColumnType("datetime");
            entity.Property(e => e.PatientDob)
                .HasColumnType("date")
                .HasColumnName("PatientDOB");
            entity.Property(e => e.PatientFirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientFullName)
                .HasMaxLength(401)
                .IsUnicode(false);
            entity.Property(e => e.PatientIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PatientIDNumber");
            entity.Property(e => e.PatientLocationBed)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientLocationPointOfCare)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientMedicalAid)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientMedicalAidPolicyNumber)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientPminumber).HasColumnName("PatientPMINumber");
            entity.Property(e => e.PatientSex)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatientStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientSurname)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Admission).WithMany(p => p.ImtlatestCaseStates)
                .HasForeignKey(d => d.AdmissionId)
                .HasConstraintName("FK_IMTLatestCaseStates_IMTAdmission");
        });

        modelBuilder.Entity<ImtmicroTest>(entity =>
        {
            entity.HasKey(e => e.MicroTestId).HasName("PK__IMTMicro__7CE1783A97A14DED");

            entity.ToTable("IMTMicroTests", "IMT");

            entity.Property(e => e.MicroTestId).HasColumnName("MicroTestID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.Mnemonic).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtmicroTestGroup>(entity =>
        {
            entity.HasKey(e => e.MicroTestGroupId).HasName("PK__IMTMicro__8DEE4C086D54AE51");

            entity.ToTable("IMTMicroTestGroups", "IMT");

            entity.Property(e => e.MicroTestGroupId).HasColumnName("MicroTestGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MicroTestGroupName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtmicroTestInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTMicro__5E5499A85D932E6C");

            entity.ToTable("IMTMicroTestInGroups", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MicroTestGroupId).HasColumnName("MicroTestGroupID");
            entity.Property(e => e.MicroTestId).HasColumnName("MicroTestID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtnotifiableDisease>(entity =>
        {
            entity.HasKey(e => e.NotifiableDiseaseId).HasName("NotifiableDiseaseID");

            entity.ToTable("IMTNotifiableDisease", "IMT");

            entity.Property(e => e.NotifiableDiseaseId).HasColumnName("NotifiableDiseaseID");
            entity.Property(e => e.IsolategroupItem)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NotifiableDisease)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtnotificationFlag>(entity =>
        {
            entity.HasKey(e => e.NotificationFlagId).HasName("PK__IMTNotif__508AF6B4A9091DD0");

            entity.ToTable("IMTNotificationFlags", "IMT");

            entity.Property(e => e.NotificationFlagId).HasColumnName("NotificationFlagID");
            entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.FlagName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.PermutationFlagId).HasColumnName("PermutationFlagID");
            entity.Property(e => e.PermutationFlagName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtnotificationFlagGroup>(entity =>
        {
            entity.HasKey(e => e.NotificationFlagGroupId).HasName("PK_NotificationFlagGroupID");

            entity.ToTable("IMTNotificationFlagGroups", "IMT");

            entity.Property(e => e.NotificationFlagGroupId).HasColumnName("NotificationFlagGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Imtorganism>(entity =>
        {
            entity.HasKey(e => e.OrganismId).HasName("PK__IMTOrgan__3C72E9ECE10BC4F1");

            entity.ToTable("IMTOrganisms", "IMT");

            entity.HasIndex(e => e.Organism, "ind_OrganismLookup");

            entity.Property(e => e.OrganismId).HasColumnName("OrganismID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LabCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.Mnemonic)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Organism).HasMaxLength(150);
            entity.Property(e => e.UniversalOrganismName).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtorganismGroup>(entity =>
        {
            entity.HasKey(e => e.OrganismGroupId).HasName("PK__IMTOrgan__EF59F516AD6354F2");

            entity.ToTable("IMTOrganismGroups", "IMT");

            entity.Property(e => e.OrganismGroupId).HasColumnName("OrganismGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrganismGroupName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtorganismsInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTOrgan__5E5499A84D5CBE88");

            entity.ToTable("IMTOrganismsInGroups", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrganismGroupId).HasColumnName("OrganismGroupID");
            entity.Property(e => e.OrganismId).HasColumnName("OrganismID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtpatientEventSummary>(entity =>
        {
            entity.HasKey(e => e.EventSummaryId).HasName("PK__IMTPatie__45D15D2E82934EB7");

            entity.ToTable("IMTPatientEventSummary", "IMT");

            entity.HasIndex(e => e.CaseNumber, "ind_CaseNumber");

            entity.Property(e => e.EventSummaryId).HasColumnName("EventSummaryID");
            entity.Property(e => e.CaseNumber).HasMaxLength(255);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventRecordedDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventTypeCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EventTypeDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtpatientSummary>(entity =>
        {
            entity.HasKey(e => e.PatientSummaryId).HasName("PK__IMTPatie__3B37C33307697E2D");

            entity.ToTable("IMTPatientSummary", "IMT");

            entity.HasIndex(e => e.Pmi, "UC_PMI").IsUnique();

            entity.Property(e => e.PatientSummaryId).HasColumnName("PatientSummaryID ");
            entity.Property(e => e.AddressLine1).HasMaxLength(150);
            entity.Property(e => e.AddressLine2).HasMaxLength(150);
            entity.Property(e => e.AddressLine3).HasMaxLength(150);
            entity.Property(e => e.AddressLine4).HasMaxLength(150);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.ContactNumber2).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeceasedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Firstname).HasMaxLength(100);
            entity.Property(e => e.Gender)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(50)
                .HasColumnName("IDNumber");
            entity.Property(e => e.MedicalAidGroupName).HasMaxLength(150);
            entity.Property(e => e.MedicalAidName).HasMaxLength(150);
            entity.Property(e => e.MedicalAidPlan).HasMaxLength(150);
            entity.Property(e => e.Pmi).HasColumnName("PMI");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.Surname).HasMaxLength(100);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtpatientVisitSummary>(entity =>
        {
            entity.HasKey(e => e.VisitSummaryId).HasName("PK__IMTPatie__5A5A583FFA638A15");

            entity.ToTable("IMTPatientVisitSummary", "IMT");

            entity.HasIndex(e => e.CaseNumber, "NCI_CaseNumber").HasFillFactor(90);

            entity.Property(e => e.VisitSummaryId).HasColumnName("VisitSummaryID");
            entity.Property(e => e.CaseNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Pv1170AdmittingDoctorIdnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_17_0_AdmittingDoctorIDNumber");
            entity.Property(e => e.Pv1171AdmittingDoctorFamilyName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_17_1_AdmittingDoctorFamilyName");
            entity.Property(e => e.Pv1172AdmittingDoctorGivenName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_17_2_AdmittingDoctorGivenName");
            entity.Property(e => e.Pv12PatientClass)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_2_PatientClass");
            entity.Property(e => e.Pv130AssignedPatientLocationPointOfCare)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_3_0_AssignedPatientLocationPointOfCare");
            entity.Property(e => e.Pv131AssignedPatientLocationRoom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_3_1_AssignedPatientLocationRoom");
            entity.Property(e => e.Pv132AssignedPatientLocationBed)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_3_2_AssignedPatientLocationBed");
            entity.Property(e => e.Pv14AdmissionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_4_AdmissionType");
            entity.Property(e => e.Pv170AttendingDoctorIdnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_7_0_AttendingDoctorIDNumber");
            entity.Property(e => e.Pv171AttendingDoctorFamilyName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_7_1_AttendingDoctorFamilyName");
            entity.Property(e => e.Pv172AttendingDoctorGivenName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_7_2_AttendingDoctorGivenName");
            entity.Property(e => e.Pv180ReferringDoctorIdnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_8_0_ReferringDoctorIDNumber");
            entity.Property(e => e.Pv181ReferringDoctorFamilyName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_8_1_ReferringDoctorFamilyName");
            entity.Property(e => e.Pv182ReferringDoctorGivenName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_8_2_ReferringDoctorGivenName");
            entity.Property(e => e.Pv190ConsultingDoctorIdnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_9_0_ConsultingDoctorIDNumber");
            entity.Property(e => e.Pv191ConsultingDoctorFamilyName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_9_1_ConsultingDoctorFamilyName");
            entity.Property(e => e.Pv192ConsultingDoctorGivenName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PV1_9_2_ConsultingDoctorGivenName");
        });

        modelBuilder.Entity<ImtreconciledStatus>(entity =>
        {
            entity.HasKey(e => e.ReconciledStatusId).HasName("PK__IMTRecon__949161958FDEB328");

            entity.ToTable("IMTReconciledStatus", "IMT");

            entity.Property(e => e.ReconciledStatusId).HasColumnName("ReconciledStatusID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ReconciledStatusDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtresultTypeGroup>(entity =>
        {
            entity.HasKey(e => e.ResultTypeGroupId).HasName("PK__IMTResul__6E514DF0B39BA2D1");

            entity.ToTable("IMTResultTypeGroups", "IMT");

            entity.Property(e => e.ResultTypeGroupId).HasColumnName("ResultTypeGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.ResultTypeGroupCode).HasMaxLength(100);
            entity.Property(e => e.ResultTypeName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtresultTypeInGroup>(entity =>
        {
            entity.HasKey(e => e.ResultTypeId).HasName("PK__IMTResul__95B71CAD7DD9DD06");

            entity.ToTable("IMTResultTypeInGroups", "IMT");

            entity.Property(e => e.ResultTypeId).HasColumnName("ResultTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.ResultTypeGroupId).HasColumnName("ResultTypeGroupID");
            entity.Property(e => e.ResultTypeName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtruleCriteriaValueGroup>(entity =>
        {
            entity.HasKey(e => e.RuleCriteriaValueGroupId).HasName("PK__IMTRuleC__56AA44C610FD9004");

            entity.ToTable("IMTRuleCriteriaValueGroups", "IMT");

            entity.Property(e => e.RuleCriteriaValueGroupId).HasColumnName("RuleCriteriaValueGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.RuleCriteriaValueGroupName).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtruleCriteriaValuesInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTRuleC__5E5499A8859A2AD7");

            entity.ToTable("IMTRuleCriteriaValuesInGroups", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RuleCriteriaValue).HasMaxLength(255);
            entity.Property(e => e.RuleCriteriaValueGroupId).HasColumnName("RuleCriteriaValueGroupID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtruleDetail>(entity =>
        {
            entity.HasKey(e => e.RuleDetailId).HasName("PK__IMTRuleD__AE79658ADA5A4078");

            entity.ToTable("IMTRuleDetails", "IMT");

            entity.Property(e => e.RuleDetailId).HasColumnName("RuleDetailID");
            entity.Property(e => e.AtccustomDrugFilterId).HasColumnName("ATCCustomDrugFilterID");
            entity.Property(e => e.AtcdrugGroupId).HasColumnName("ATCDrugGroupID");
            entity.Property(e => e.AtcdrugId).HasColumnName("ATCDrugID");
            entity.Property(e => e.CheckForDuplicate).HasDefaultValueSql("((0))");
            entity.Property(e => e.CriteriaOpporatorId).HasColumnName("CriteriaOpporatorID");
            entity.Property(e => e.EnzymeGroupId).HasColumnName("EnzymeGroupID");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.Hl7tableColumnId).HasColumnName("HL7TableColumnID");
            entity.Property(e => e.Hl7tableId).HasColumnName("HL7TableID");
            entity.Property(e => e.IdentifiesOrganism).HasDefaultValueSql("((0))");
            entity.Property(e => e.LabDrugGroupId).HasColumnName("LabDrugGroupID");
            entity.Property(e => e.LabDrugId).HasColumnName("LabDrugID");
            entity.Property(e => e.MicroTestGroupId).HasColumnName("MicroTestGroupID");
            entity.Property(e => e.MicroTestId).HasColumnName("MicroTestID");
            entity.Property(e => e.OrganismGroupId).HasColumnName("OrganismGroupID");
            entity.Property(e => e.OrganismId).HasColumnName("OrganismID");
            entity.Property(e => e.QueryId).HasColumnName("QueryID");
            entity.Property(e => e.ResultTypeGroupId).HasColumnName("ResultTypeGroupID");
            entity.Property(e => e.ResultTypeGroupNameId).HasColumnName("ResultTypeGroupNameID");
            entity.Property(e => e.RuleCriteriaValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RuleCriteriaValueGroupId).HasColumnName("RuleCriteriaValueGroupID");
            entity.Property(e => e.SpecimenGroupId).HasColumnName("SpecimenGroupID");
            entity.Property(e => e.SpecimenId).HasColumnName("SpecimenID");
            entity.Property(e => e.UnitOfMeasurementId).HasColumnName("UnitOfMeasurementID");
            entity.Property(e => e.UsesBaseQuery).HasDefaultValueSql("((0))");
            entity.Property(e => e.ValidationWorkFlowId).HasColumnName("ValidationWorkFlowID");
            entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");
        });

        modelBuilder.Entity<ImtruleEngineService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__IMTRuleE__C51BB0EA4745CBF9");

            entity.ToTable("IMTRuleEngineServices", "IMT");

            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceDescription).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtruleExecutionLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTRuleE__5E5499A8EB9BB966");

            entity.ToTable("IMTRuleExecutionLog", "IMT");

            entity.HasIndex(e => e.CaseNo, "ind_CaseNo");

            entity.HasIndex(e => e.ConditionId, "ind_ConditionID");

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "ind_HL7UniqueIdentifier").HasFillFactor(90);

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.CaseNo).HasMaxLength(250);
            entity.Property(e => e.ConditionId).HasColumnName("ConditionID");
            entity.Property(e => e.ConditionRunDate).HasColumnType("datetime");
            entity.Property(e => e.ExecutionPlanId).HasColumnName("ExecutionPlanID");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
        });

        modelBuilder.Entity<ImtrulesInFlag>(entity =>
        {
            entity.HasKey(e => e.FlagId).HasName("PK__FlagID__110458C2FCB14996");

            entity.ToTable("IMTRulesInFlags", "IMT");

            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.AlertCategoryId).HasColumnName("AlertCategoryID");
            entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExecutionPlanId).HasColumnName("ExecutionPlanID");
            entity.Property(e => e.FlagDescription).HasMaxLength(50);
            entity.Property(e => e.IsMonitoringRule).HasDefaultValueSql("((0))");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.RequiredOrganismName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RunForRuleId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("RunForRuleID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Flaggroup).WithMany(p => p.ImtrulesInFlags)
                .HasForeignKey(d => d.FlaggroupId)
                .HasConstraintName("FK__IMTRulesI__Flagg__5E6AD939");
        });

        modelBuilder.Entity<ImtrulesInFlagsGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMTRulesInFlagsGroups", "IMT");

            entity.Property(e => e.GroupName).IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Imtscheduler>(entity =>
        {
            entity.HasKey(e => e.SchedulerId).HasName("PK__SchedulerID");

            entity.ToTable("IMTScheduler", "IMT");

            entity.Property(e => e.SchedulerId).HasColumnName("SchedulerID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.RunEveryDay).HasDefaultValueSql("((0))");
            entity.Property(e => e.SchedulerTypeId).HasColumnName("SchedulerTypeID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ImtschedulerExecutionLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__SchedulerExecutionLogID");

            entity.ToTable("IMTSchedulerExecutionLog", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SchedulerAction)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.SchedulerId).HasColumnName("SchedulerID");
            entity.Property(e => e.SchedulerMessage).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtschedulerSetting>(entity =>
        {
            entity.HasKey(e => e.SchedulerSettingId).HasName("PK__SchedulerSettingID");

            entity.ToTable("IMTSchedulerSettings", "IMT");

            entity.Property(e => e.SchedulerSettingId).HasColumnName("SchedulerSettingID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.SettingName).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ImtschedulerSettingDetail>(entity =>
        {
            entity.HasKey(e => e.SchedulerSettingDetailId).HasName("PK__SchedulerSettingDetailID");

            entity.ToTable("IMTSchedulerSettingDetails", "IMT");

            entity.Property(e => e.SchedulerSettingDetailId).HasColumnName("SchedulerSettingDetailID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.SchedulerSettingId).HasColumnName("SchedulerSettingID");
            entity.Property(e => e.SettingName).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ImtschedulerType>(entity =>
        {
            entity.HasKey(e => e.SchedulerTypeId).HasName("PK__SchedulerTypeID");

            entity.ToTable("IMTSchedulerTypes", "IMT");

            entity.Property(e => e.SchedulerTypeId).HasColumnName("SchedulerTypeID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<ImtscriptsInException>(entity =>
        {
            entity.HasKey(e => e.ScriptId).HasName("PK__IMTScrip__206EDD7A57C2518F");

            entity.ToTable("IMTScriptsInExceptions", "IMT");

            entity.Property(e => e.ScriptId).HasColumnName("ScriptID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExceptionScriptId).HasColumnName("ExceptionScriptID");
            entity.Property(e => e.QueryId).HasColumnName("QueryID");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TabName)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.ExceptionScript).WithMany(p => p.ImtscriptsInExceptions)
                .HasForeignKey(d => d.ExceptionScriptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExceptionScriptID");
        });

        modelBuilder.Entity<Imtspeciman>(entity =>
        {
            entity.HasKey(e => e.SpecimenId).HasName("PK__IMTSpeci__719B2251AB78973F");

            entity.ToTable("IMTSpecimen", "IMT");

            entity.Property(e => e.SpecimenId).HasColumnName("SpecimenID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Specimen).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.UniversalDetail).WithMany(p => p.Imtspecimen)
                .HasForeignKey(d => d.UniversalDetailId)
                .HasConstraintName("FK_UniversalDetailId");
        });

        modelBuilder.Entity<ImtspecimenAndGroupFromTestName>(entity =>
        {
            entity.ToTable("IMTSpecimenAndGroupFromTestName", "IMT");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Obr42UniversalServiceIdentifierText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_4_2_UniversalServiceIdentifier_Text");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Lab).WithMany(p => p.ImtspecimenAndGroupFromTestNames)
                .HasForeignKey(d => d.LabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTSpecimenAndGroupFromTestName_IMTLabs");

            entity.HasOne(d => d.SpecimenGroup).WithMany(p => p.ImtspecimenAndGroupFromTestNames)
                .HasForeignKey(d => d.SpecimenGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTSpecimenAndGroupFromTestName_IMTSpecimenGroups");

            entity.HasOne(d => d.SpecimenSitesFriendly).WithMany(p => p.ImtspecimenAndGroupFromTestNames)
                .HasForeignKey(d => d.SpecimenSitesFriendlyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTSpecimenAndGroupFromTestName_IMTSpecimenSitesFriendly");
        });

        modelBuilder.Entity<ImtspecimenGroup>(entity =>
        {
            entity.HasKey(e => e.SpecimenGroupId).HasName("PK__SpecimenGroupID__EF59F516AD6354F2");

            entity.ToTable("IMTSpecimenGroups", "IMT");

            entity.Property(e => e.SpecimenGroupId).HasColumnName("SpecimenGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SpecimenGroupName).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtspecimenGroupMarker>(entity =>
        {
            entity.ToTable("IMTSpecimenGroupMarker", "IMT");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.TestCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtspecimenInGroup>(entity =>
        {
            entity.HasKey(e => e.SpecimenInGroupsId).HasName("PK__SpecimenInGroupsID__EF59F516AD6354F2");

            entity.ToTable("IMTSpecimenInGroups", "IMT");

            entity.Property(e => e.SpecimenInGroupsId).HasColumnName("SpecimenInGroupsID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SpecimenGroupId).HasColumnName("SpecimenGroupID");
            entity.Property(e => e.SpecimenId).HasColumnName("SpecimenID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.SpecimenGroup).WithMany(p => p.ImtspecimenInGroups)
                .HasForeignKey(d => d.SpecimenGroupId)
                .HasConstraintName("FK_IMTSpecimenInGroups_IMTSpecimenGroups");

            entity.HasOne(d => d.Specimen).WithMany(p => p.ImtspecimenInGroups)
                .HasForeignKey(d => d.SpecimenId)
                .HasConstraintName("FK_IMTSpecimenInGroups_IMTSpecimen");
        });

        modelBuilder.Entity<ImtspecimenSiteSourceMapping>(entity =>
        {
            entity.ToTable("IMTSpecimenSiteSourceMapping", "IMT");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.SpecimenSiteFriendly).WithMany(p => p.ImtspecimenSiteSourceMappings)
                .HasForeignKey(d => d.SpecimenSiteFriendlyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTSpecimenSiteSourceMapping_IMTSpecimenSitesFriendly");

            entity.HasOne(d => d.SpecimenSite).WithMany(p => p.ImtspecimenSiteSourceMappings)
                .HasForeignKey(d => d.SpecimenSiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTSpecimenSiteSourceMapping_IMTSpecimen");

            entity.HasOne(d => d.SpecimenSourceFriendly).WithMany(p => p.ImtspecimenSiteSourceMappings)
                .HasForeignKey(d => d.SpecimenSourceFriendlyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTSpecimenSiteSourceMapping_IMTSpecimenSourcesFriendly");

            entity.HasOne(d => d.SpecimenSource).WithMany(p => p.ImtspecimenSiteSourceMappings)
                .HasForeignKey(d => d.SpecimenSourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMTSpecimenSiteSourceMapping_IMTSpecimenSources");
        });

        modelBuilder.Entity<ImtspecimenSitesFriendly>(entity =>
        {
            entity.ToTable("IMTSpecimenSitesFriendly", "IMT");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtspecimenSource>(entity =>
        {
            entity.ToTable("IMTSpecimenSources", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtspecimenSourcesFriendly>(entity =>
        {
            entity.ToTable("IMTSpecimenSourcesFriendly", "IMT");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtspecimenUniversalDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IMTSpeci__719B2251AB78973G");

            entity.ToTable("IMTSpecimenUniversalDetail", "IMT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImttempDrug>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IMTTempD__3214EC27B319EEB7");

            entity.ToTable("IMTTempDrug", "IMT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActiveIngredientText).HasMaxLength(255);
            entity.Property(e => e.Activeingredient2)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT2");
            entity.Property(e => e.Activeingredient3)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT3");
            entity.Property(e => e.Activeingredient4)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT4");
            entity.Property(e => e.Activeingredient5)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT5");
            entity.Property(e => e.Activeingredient6)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT6");
            entity.Property(e => e.Activeingredient7)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT7");
            entity.Property(e => e.Activeingredient8)
                .HasMaxLength(255)
                .HasColumnName("ACTIVEINGREDIENT8");
            entity.Property(e => e.Drug).HasMaxLength(255);
            entity.Property(e => e.DrugCode).HasMaxLength(255);
            entity.Property(e => e.MaterialText).HasMaxLength(255);
            entity.Property(e => e.NappiCode).HasMaxLength(255);
        });

        modelBuilder.Entity<Imttrace>(entity =>
        {
            entity.HasKey(e => e.TraceId).HasName("PK__IMTTrace__E411CE6379349595");

            entity.ToTable("IMTTrace", "IMT");

            entity.HasIndex(e => new { e.ContentId, e.ContentType }, "NCI_ContentIDContentType");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtunitOfMeasurement>(entity =>
        {
            entity.HasKey(e => e.UnitOfMeasurementId).HasName("PK__UnitOfMeasurements__908D66166B45C8FB");

            entity.ToTable("IMTUnitOfMeasurements", "IMT");

            entity.Property(e => e.UnitOfMeasurementId).HasColumnName("UnitOfMeasurementID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.UnitOfMeasurement).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImtuniversalMapping>(entity =>
        {
            entity.HasKey(e => e.UniversalMappingIdentifierId).HasName("PK__IMTUnive__51A10C39F682353A");

            entity.ToTable("IMTUniversalMapping", "IMT");

            entity.Property(e => e.UniversalMappingIdentifierId).HasColumnName("UniversalMappingIdentifierID");
            entity.Property(e => e.DohnotifiableConditionId).HasColumnName("DOHNotifiableConditionID");
            entity.Property(e => e.IsDohnotifiableCondition).HasColumnName("IsDOHNotifiableCondition");
            entity.Property(e => e.IsolateGroupTypeId).HasColumnName("IsolateGroupTypeID");
            entity.Property(e => e.LabCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.UniversalOrganismName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtuniversalMappingItemsToExclude>(entity =>
        {
            entity.HasKey(e => e.ExcludedUniversalMappingIdentifierId).HasName("PK__ExcludedUniversalMappingIdentifierID__51A10C39F682353A");

            entity.ToTable("IMTUniversalMappingItemsToExclude", "IMT");

            entity.Property(e => e.ExcludedUniversalMappingIdentifierId).HasColumnName("ExcludedUniversalMappingIdentifierID");
            entity.Property(e => e.IsolateGroupTypeId).HasColumnName("IsolateGroupTypeID");
            entity.Property(e => e.LabCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LabId).HasColumnName("LabID");
        });

        modelBuilder.Entity<ImtvalidationFlagsInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTValid__5E5499A8AEBDCE0B");

            entity.ToTable("IMTValidationFlagsInGroups", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.ValidationGroupId).HasColumnName("ValidationGroupID");
        });

        modelBuilder.Entity<ImtvalidationGroup>(entity =>
        {
            entity.HasKey(e => e.ValidationGroupId).HasName("PK__IMTValid__0A6400EAF98AB2DB");

            entity.ToTable("IMTValidationGroups", "IMT");

            entity.Property(e => e.ValidationGroupId).HasColumnName("ValidationGroupID");
            entity.Property(e => e.ValidationGroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtworkFlow>(entity =>
        {
            entity.HasKey(e => e.WorkFlowId).HasName("PK__WorkFlowID__EF59F516AD6354F2");

            entity.ToTable("IMTWorkFlows", "IMT");

            entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WorkFlowName).HasMaxLength(150);
        });

        modelBuilder.Entity<ImtworkFlowQueriesInGroup>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__IMTWFLogID__5E5499A84D5CBE88");

            entity.ToTable("IMTWorkFlowQueriesInGroups", "IMT");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.ConditionColumn)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsMainQuery).HasDefaultValueSql("((0))");
            entity.Property(e => e.QuerId).HasColumnName("QuerID");
            entity.Property(e => e.ReturnLookupValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReturnType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");
            entity.Property(e => e.WorkFlowRuleDetailId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("WorkFlowRuleDetailID");
        });

        modelBuilder.Entity<ImtworkFlowReturnField>(entity =>
        {
            entity.HasKey(e => e.WorkFlowReturnFieldId).HasName("PK__IMTWorkF__85D3DF195ABE9D1C");

            entity.ToTable("IMTWorkFlowReturnFields", "IMT");

            entity.Property(e => e.WorkFlowReturnFieldId).HasColumnName("WorkFlowReturnFieldID");
            entity.Property(e => e.ReturnQueryId).HasColumnName("ReturnQueryID");
            entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");
            entity.Property(e => e.WorkFlowQueryLookupValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WorkFlowReturnField)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WorkFlowReturnFieldDataType)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImtworkFlowRuleDetail>(entity =>
        {
            entity.HasKey(e => e.WorkFlowRuleDetailId).HasName("PK__WorkFlowRuleDetailID__AE79658ADA5A4078");

            entity.ToTable("IMTWorkFlowRuleDetails", "IMT");

            entity.Property(e => e.WorkFlowRuleDetailId).HasColumnName("WorkFlowRuleDetailID");
            entity.Property(e => e.ConditionColumn)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExternalLookupValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExternalLookupValueDataType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HasExternalReturnFields).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdentifiesOrganism).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsMainQuery).HasDefaultValueSql("((0))");
            entity.Property(e => e.MainQueryReturnLookupValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RequiredRecords).HasDefaultValueSql("((0))");
            entity.Property(e => e.ReturnLookupValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReturnType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WorkFlowAtccustomDrugFilterId).HasColumnName("WorkFlowATCCustomDrugFilterID");
            entity.Property(e => e.WorkFlowAtcdrugGroupId).HasColumnName("WorkFlowATCDrugGroupID");
            entity.Property(e => e.WorkFlowAtcdrugId).HasColumnName("WorkFlowATCDrugID");
            entity.Property(e => e.WorkFlowCriteriaOpp)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WorkFlowCriteriaOpporatorId).HasColumnName("WorkFlowCriteriaOpporatorID");
            entity.Property(e => e.WorkFlowEnzymeGroupId).HasColumnName("WorkFlowEnzymeGroupID");
            entity.Property(e => e.WorkFlowHl7tableColumnId).HasColumnName("WorkFlowHL7TableColumnID");
            entity.Property(e => e.WorkFlowHl7tableId).HasColumnName("WorkFlowHL7TableID");
            entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");
            entity.Property(e => e.WorkFlowLabDrugGroupId).HasColumnName("WorkFlowLabDrugGroupID");
            entity.Property(e => e.WorkFlowLabDrugId).HasColumnName("WorkFlowLabDrugID");
            entity.Property(e => e.WorkFlowMicroTestGroupId).HasColumnName("WorkFlowMicroTestGroupID");
            entity.Property(e => e.WorkFlowMicroTestId).HasColumnName("WorkFlowMicroTestID");
            entity.Property(e => e.WorkFlowOrganismGroupId).HasColumnName("WorkFlowOrganismGroupID");
            entity.Property(e => e.WorkFlowOrganismId).HasColumnName("WorkFlowOrganismID");
            entity.Property(e => e.WorkFlowQueryId).HasColumnName("WorkFlowQueryID");
            entity.Property(e => e.WorkFlowResultTypeGroupId).HasColumnName("WorkFlowResultTypeGroupID");
            entity.Property(e => e.WorkFlowResultTypeGroupNameId).HasColumnName("WorkFlowResultTypeGroupNameID");
            entity.Property(e => e.WorkFlowRuleCriteriaValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WorkFlowRuleCriteriaValueGroupId).HasColumnName("WorkFlowRuleCriteriaValueGroupID");
            entity.Property(e => e.WorkFlowSpecimenGroupId).HasColumnName("WorkFlowSpecimenGroupID");
            entity.Property(e => e.WorkFlowSpecimenId).HasColumnName("WorkFlowSpecimenID");
            entity.Property(e => e.WorkFlowUnitOfMeasurementId).HasColumnName("WorkFlowUnitOfMeasurementID");
            entity.Property(e => e.WorkFlowValidationWorkFlowId).HasColumnName("WorkFlowValidationWorkFlowID");
            entity.Property(e => e.WorkFlowWorkFlowId).HasColumnName("WorkFlowWorkFlowID");
        });

        modelBuilder.Entity<In1Insurance>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("IN1_Insurance", "HL7");

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_HL7UniqueIdentifier").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLog_In140").HasFillFactor(80);

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.In1100InsuredsGroupEmpIdidnumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_10_0_InsuredsGroupEmpIDIDNumber");
            entity.Property(e => e.In1110InsuredsGroupEmpNameOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_11_0_InsuredsGroupEmpNameOrganizationName");
            entity.Property(e => e.In112PlanEffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("IN1_12_PlanEffectiveDate");
            entity.Property(e => e.In113PlanExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("IN1_13_PlanExpirationDate");
            entity.Property(e => e.In1140AuthorizationInformationAuthorizationNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IN1_14_0_AuthorizationInformationAuthorizationNumber");
            entity.Property(e => e.In115PlanType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IN1_15_PlanType");
            entity.Property(e => e.In1160NameOfInsuredFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_16_0_NameOfInsuredFamilyName");
            entity.Property(e => e.In1161NameOfInsuredGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_16_1_NameOfInsuredGivenName");
            entity.Property(e => e.In1162NameOfInsuredSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_16_2_NameOfInsuredSecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.In1163NameOfInsuredSuffix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_16_3_NameOfInsuredSuffix");
            entity.Property(e => e.In1164NameOfInsuredPrefix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_16_4_NameOfInsuredPrefix");
            entity.Property(e => e.In117InsuredsRelationshipToPatient)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_17_InsuredsRelationshipToPatient");
            entity.Property(e => e.In118InsuredsDateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("IN1_18_InsuredsDateOfBirth");
            entity.Property(e => e.In1190InsuredsAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_0_InsuredsAddressStreetAddress");
            entity.Property(e => e.In1191InsuredsAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_1_InsuredsAddressOtherDesignation");
            entity.Property(e => e.In1192InsuredsAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_2_InsuredsAddressCity");
            entity.Property(e => e.In1193InsuredsAddressStateOrProvince)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_3_InsuredsAddressStateOrProvince");
            entity.Property(e => e.In1194InsuredsAddressZipOrPostalCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_4_InsuredsAddressZipOrPostalCode");
            entity.Property(e => e.In1195InsuredsAddressCountry)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_5_InsuredsAddressCountry");
            entity.Property(e => e.In11SetIdin1).HasColumnName("IN1_1_SetIDIN1");
            entity.Property(e => e.In120AssignmentOfBenefits)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_20_AssignmentOfBenefits");
            entity.Property(e => e.In120InsurancePlanIdidentifier)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("IN1_2_0_InsurancePlanIDIdentifier");
            entity.Property(e => e.In121CoordinationOfBenefits)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_21_CoordinationOfBenefits");
            entity.Property(e => e.In122CoordOfBenPriority)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_22_CoordOfBenPriority");
            entity.Property(e => e.In123NoticeOfAdmissionFlag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_23_NoticeOfAdmissionFlag");
            entity.Property(e => e.In124NoticeOfAdmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("IN1_24_NoticeOfAdmissionDate");
            entity.Property(e => e.In125ReportOfEligibilityFlag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_25_ReportOfEligibilityFlag");
            entity.Property(e => e.In126ReportOfEligibilityDate)
                .HasColumnType("datetime")
                .HasColumnName("IN1_26_ReportOfEligibilityDate");
            entity.Property(e => e.In127ReleaseInformationCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_27_ReleaseInformationCode");
            entity.Property(e => e.In128PreAdmitCertPac)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_28_PreAdmitCertPAC");
            entity.Property(e => e.In129VerificationDateTime)
                .HasColumnType("datetime")
                .HasColumnName("IN1_29_VerificationDateTime");
            entity.Property(e => e.In1300VerificationByIdnumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_30_0_VerificationByIDNumber");
            entity.Property(e => e.In1301VerificationByFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_30_1_VerificationByFamilyName");
            entity.Property(e => e.In1302VerificationByGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_30_2_VerificationByGivenName");
            entity.Property(e => e.In130InsuranceCompanyIdidnumber)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("IN1_3_0_InsuranceCompanyIDIDNumber");
            entity.Property(e => e.In131TypeOfAgreementCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_31_TypeOfAgreementCode");
            entity.Property(e => e.In132BillingStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_32_BillingStatus");
            entity.Property(e => e.In133LifetimeReserveDays)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN1_33_LifetimeReserveDays");
            entity.Property(e => e.In134DelayBeforeLrday)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN1_34_DelayBeforeLRDay");
            entity.Property(e => e.In135CompanyPlanCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_35_CompanyPlanCode");
            entity.Property(e => e.In136PolicyNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_36_PolicyNumber");
            entity.Property(e => e.In13700PolicyDeductiblePriceQuantity)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN1_37_0_0_PolicyDeductiblePriceQuantity");
            entity.Property(e => e.In138PolicyLimitAmount)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_38_PolicyLimitAmount");
            entity.Property(e => e.In139PolicyLimitDays)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN1_39_PolicyLimitDays");
            entity.Property(e => e.In140InsuranceCompanyNameOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_4_0_InsuranceCompanyNameOrganizationName");
            entity.Property(e => e.In140RoomRateSemiPrivate)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_40_RoomRateSemiPrivate");
            entity.Property(e => e.In141RoomRatePrivate)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_41_RoomRatePrivate");
            entity.Property(e => e.In1420InsuredsEmploymentStatusIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_42_0_InsuredsEmploymentStatusIdentifier");
            entity.Property(e => e.In143InsuredsAdministrativeSex)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_43_InsuredsAdministrativeSex");
            entity.Property(e => e.In1440InsuredsEmployersAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_0_InsuredsEmployersAddressStreetAddress");
            entity.Property(e => e.In1441InsuredsEmployersAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_1_InsuredsEmployersAddressOtherDesignation");
            entity.Property(e => e.In1442InsuredsEmployersAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_2_InsuredsEmployersAddressCity");
            entity.Property(e => e.In1443InsuredsEmployersAddressStateOrProvince)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_3_InsuredsEmployersAddressStateOrProvince");
            entity.Property(e => e.In1444InsuredsEmployersAddressZipOrPostalCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_4_InsuredsEmployersAddressZipOrPostalCode");
            entity.Property(e => e.In1445InsuredsEmployersAddressCountry)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_5_InsuredsEmployersAddressCountry");
            entity.Property(e => e.In145VerificationStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_45_VerificationStatus");
            entity.Property(e => e.In146PriorInsurancePlanId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_46_PriorInsurancePlanID");
            entity.Property(e => e.In147CoverageType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_47_CoverageType");
            entity.Property(e => e.In148Handicap)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_48_Handicap");
            entity.Property(e => e.In1490InsuredsIdnumberIdnumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_49_0_InsuredsIDNumberIDNumber");
            entity.Property(e => e.In150InsuranceCompanyAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_0_InsuranceCompanyAddressStreetAddress");
            entity.Property(e => e.In151InsuranceCompanyAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_1_InsuranceCompanyAddressOtherDesignation");
            entity.Property(e => e.In152InsuranceCompanyAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_2_InsuranceCompanyAddressCity");
            entity.Property(e => e.In153InsuranceCompanyAddressState)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_3_InsuranceCompanyAddressState");
            entity.Property(e => e.In154InsuranceCompanyAddressZipOrPostalCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_4_InsuranceCompanyAddressZipOrPostalCode");
            entity.Property(e => e.In155InsuranceCompanyAddressCountry)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_5_InsuranceCompanyAddressCountry");
            entity.Property(e => e.In161InsuranceCoContactPersonGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_6_1_InsuranceCoContactPersonGivenName");
            entity.Property(e => e.In170InsuranceCoPhoneNumberTelephoneNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_7_0_InsuranceCoPhoneNumberTelephoneNumber");
            entity.Property(e => e.In18GroupNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_8_GroupNumber");
            entity.Property(e => e.In190GroupNameOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_9_0_GroupNameOrganizationName");
        });

        modelBuilder.Entity<In1InsuranceImportHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN1_Insurance_ImportHistory", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.In1100InsuredsGroupEmpIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_10_0_InsuredsGroupEmpIDIDNumber");
            entity.Property(e => e.In1110InsuredsGroupEmpNameOrganizationName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_11_0_InsuredsGroupEmpNameOrganizationName");
            entity.Property(e => e.In112PlanEffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("IN1_12_PlanEffectiveDate");
            entity.Property(e => e.In113PlanExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("IN1_13_PlanExpirationDate");
            entity.Property(e => e.In1140AuthorizationInformationAuthorizationNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IN1_14_0_AuthorizationInformationAuthorizationNumber");
            entity.Property(e => e.In115PlanType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IN1_15_PlanType");
            entity.Property(e => e.In1160NameOfInsuredFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_16_0_NameOfInsuredFamilyName");
            entity.Property(e => e.In1161NameOfInsuredGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_16_1_NameOfInsuredGivenName");
            entity.Property(e => e.In1162NameOfInsuredSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_16_2_NameOfInsuredSecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.In1163NameOfInsuredSuffix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_16_3_NameOfInsuredSuffix");
            entity.Property(e => e.In1164NameOfInsuredPrefix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_16_4_NameOfInsuredPrefix");
            entity.Property(e => e.In117InsuredsRelationshipToPatient)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_17_InsuredsRelationshipToPatient");
            entity.Property(e => e.In118InsuredsDateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("IN1_18_InsuredsDateOfBirth");
            entity.Property(e => e.In1190InsuredsAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_0_InsuredsAddressStreetAddress");
            entity.Property(e => e.In1191InsuredsAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_1_InsuredsAddressOtherDesignation");
            entity.Property(e => e.In1192InsuredsAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_19_2_InsuredsAddressCity");
            entity.Property(e => e.In1193InsuredsAddressStateOrProvince)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_19_3_InsuredsAddressStateOrProvince");
            entity.Property(e => e.In1194InsuredsAddressZipOrPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN1_19_4_InsuredsAddressZipOrPostalCode");
            entity.Property(e => e.In1195InsuredsAddressCountry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_19_5_InsuredsAddressCountry");
            entity.Property(e => e.In11SetIdin1).HasColumnName("IN1_1_SetIDIN1");
            entity.Property(e => e.In120AssignmentOfBenefits)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_20_AssignmentOfBenefits");
            entity.Property(e => e.In120InsurancePlanIdidentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN1_2_0_InsurancePlanIDIdentifier");
            entity.Property(e => e.In121CoordinationOfBenefits)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_21_CoordinationOfBenefits");
            entity.Property(e => e.In122CoordOfBenPriority)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_22_CoordOfBenPriority");
            entity.Property(e => e.In123NoticeOfAdmissionFlag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_23_NoticeOfAdmissionFlag");
            entity.Property(e => e.In124NoticeOfAdmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("IN1_24_NoticeOfAdmissionDate");
            entity.Property(e => e.In125ReportOfEligibilityFlag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_25_ReportOfEligibilityFlag");
            entity.Property(e => e.In126ReportOfEligibilityDate)
                .HasColumnType("datetime")
                .HasColumnName("IN1_26_ReportOfEligibilityDate");
            entity.Property(e => e.In127ReleaseInformationCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_27_ReleaseInformationCode");
            entity.Property(e => e.In128PreAdmitCertPac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_28_PreAdmitCertPAC");
            entity.Property(e => e.In129VerificationDateTime)
                .HasColumnType("datetime")
                .HasColumnName("IN1_29_VerificationDateTime");
            entity.Property(e => e.In1300VerificationByIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_30_0_VerificationByIDNumber");
            entity.Property(e => e.In1301VerificationByFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_30_1_VerificationByFamilyName");
            entity.Property(e => e.In1302VerificationByGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_30_2_VerificationByGivenName");
            entity.Property(e => e.In130InsuranceCompanyIdidnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN1_3_0_InsuranceCompanyIDIDNumber");
            entity.Property(e => e.In131TypeOfAgreementCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_31_TypeOfAgreementCode");
            entity.Property(e => e.In132BillingStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_32_BillingStatus");
            entity.Property(e => e.In133LifetimeReserveDays)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN1_33_LifetimeReserveDays");
            entity.Property(e => e.In134DelayBeforeLrday)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN1_34_DelayBeforeLRDay");
            entity.Property(e => e.In135CompanyPlanCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_35_CompanyPlanCode");
            entity.Property(e => e.In136PolicyNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_36_PolicyNumber");
            entity.Property(e => e.In13700PolicyDeductiblePriceQuantity)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN1_37_0_0_PolicyDeductiblePriceQuantity");
            entity.Property(e => e.In138PolicyLimitAmount)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IN1_38_PolicyLimitAmount");
            entity.Property(e => e.In139PolicyLimitDays)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN1_39_PolicyLimitDays");
            entity.Property(e => e.In140InsuranceCompanyNameOrganizationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_4_0_InsuranceCompanyNameOrganizationName");
            entity.Property(e => e.In140RoomRateSemiPrivate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IN1_40_RoomRateSemiPrivate");
            entity.Property(e => e.In141RoomRatePrivate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IN1_41_RoomRatePrivate");
            entity.Property(e => e.In1420InsuredsEmploymentStatusIdentifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_42_0_InsuredsEmploymentStatusIdentifier");
            entity.Property(e => e.In143InsuredsAdministrativeSex)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_43_InsuredsAdministrativeSex");
            entity.Property(e => e.In1440InsuredsEmployersAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_0_InsuredsEmployersAddressStreetAddress");
            entity.Property(e => e.In1441InsuredsEmployersAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_1_InsuredsEmployersAddressOtherDesignation");
            entity.Property(e => e.In1442InsuredsEmployersAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_44_2_InsuredsEmployersAddressCity");
            entity.Property(e => e.In1443InsuredsEmployersAddressStateOrProvince)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_44_3_InsuredsEmployersAddressStateOrProvince");
            entity.Property(e => e.In1444InsuredsEmployersAddressZipOrPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN1_44_4_InsuredsEmployersAddressZipOrPostalCode");
            entity.Property(e => e.In1445InsuredsEmployersAddressCountry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_44_5_InsuredsEmployersAddressCountry");
            entity.Property(e => e.In145VerificationStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_45_VerificationStatus");
            entity.Property(e => e.In146PriorInsurancePlanId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_46_PriorInsurancePlanID");
            entity.Property(e => e.In147CoverageType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_47_CoverageType");
            entity.Property(e => e.In148Handicap)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_48_Handicap");
            entity.Property(e => e.In1490InsuredsIdnumberIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_49_0_InsuredsIDNumberIDNumber");
            entity.Property(e => e.In150InsuranceCompanyAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_0_InsuranceCompanyAddressStreetAddress");
            entity.Property(e => e.In151InsuranceCompanyAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_1_InsuranceCompanyAddressOtherDesignation");
            entity.Property(e => e.In152InsuranceCompanyAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_5_2_InsuranceCompanyAddressCity");
            entity.Property(e => e.In153InsuranceCompanyAddressState)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_5_3_InsuranceCompanyAddressState");
            entity.Property(e => e.In154InsuranceCompanyAddressZipOrPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN1_5_4_InsuranceCompanyAddressZipOrPostalCode");
            entity.Property(e => e.In155InsuranceCompanyAddressCountry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_5_5_InsuranceCompanyAddressCountry");
            entity.Property(e => e.In161InsuranceCoContactPersonGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN1_6_1_InsuranceCoContactPersonGivenName");
            entity.Property(e => e.In170InsuranceCoPhoneNumberTelephoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_7_0_InsuranceCoPhoneNumberTelephoneNumber");
            entity.Property(e => e.In18GroupNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_8_GroupNumber");
            entity.Property(e => e.In190GroupNameOrganizationName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN1_9_0_GroupNameOrganizationName");
        });

        modelBuilder.Entity<In2InsuranceAdditionalInformation>(entity =>
        {
            entity.HasKey(e => e.Hl7uniqueIdentifier);

            entity.ToTable("IN2_InsuranceAdditionalInformation", "HL7");

            entity.HasIndex(e => e.In230InsuredsEmployersNameandIdidnumber, "idx_IN2_InsuranceAdditionalInformation_IN2_3_0_InsuredsEmployersNameandIDIDNumber").HasFillFactor(80);

            entity.Property(e => e.Hl7uniqueIdentifier)
                .ValueGeneratedNever()
                .HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.In210InsuredsEmployeeIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_1_0_InsuredsEmployeeIDIDNumber");
            entity.Property(e => e.In210MilitaryIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_10_MilitaryIDNumber");
            entity.Property(e => e.In2110DependentOfMilitaryRecipientIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_11_0_DependentOfMilitaryRecipientIdentifier");
            entity.Property(e => e.In212MilitaryOrganization)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_12_MilitaryOrganization");
            entity.Property(e => e.In213MilitaryStation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_13_MilitaryStation");
            entity.Property(e => e.In214MilitaryService)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_14_MilitaryService");
            entity.Property(e => e.In215MilitaryRankGrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_15_MilitaryRankGrade");
            entity.Property(e => e.In216MilitaryStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_16_MilitaryStatus");
            entity.Property(e => e.In217MilitaryRetireDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_17_MilitaryRetireDate");
            entity.Property(e => e.In218MilitaryNonAvailCertOnFile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_18_MilitaryNonAvailCertOnFile");
            entity.Property(e => e.In219BabyCoverage)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_19_BabyCoverage");
            entity.Property(e => e.In220CombineBabyBill)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_20_CombineBabyBill");
            entity.Property(e => e.In221BloodDeductible)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_21_BloodDeductible");
            entity.Property(e => e.In2220SpecialCoverageApprovalNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_22_0_SpecialCoverageApprovalNameFamilyName");
            entity.Property(e => e.In2221SpecialCoverageApprovalNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_22_1_SpecialCoverageApprovalNameGivenName");
            entity.Property(e => e.In223SpecialCoverageApprovalTitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_23_SpecialCoverageApprovalTitle");
            entity.Property(e => e.In224NonCoveredInsuranceCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_24_NonCoveredInsuranceCode");
            entity.Property(e => e.In2250PayorIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_25_0_PayorIDIDNumber");
            entity.Property(e => e.In2260PayorSubscriberIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_26_0_PayorSubscriberIDIDNumber");
            entity.Property(e => e.In227EligibilitySource)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_27_EligibilitySource");
            entity.Property(e => e.In2280RoomCoverageTypeAmountRoomType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_28_0_RoomCoverageTypeAmountRoomType");
            entity.Property(e => e.In2281RoomCoverageTypeAmountAmountType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_28_1_RoomCoverageTypeAmountAmountType");
            entity.Property(e => e.In2282RoomCoverageTypeAmountCoverageAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN2_28_2_RoomCoverageTypeAmountCoverageAmount");
            entity.Property(e => e.In229PolicyTypeAmount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_29_PolicyTypeAmount");
            entity.Property(e => e.In22InsuredsSocialSecurityNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_2_InsuredsSocialSecurityNumber");
            entity.Property(e => e.In2300DailyDeductibleDelayDays)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN2_30_0_DailyDeductibleDelayDays");
            entity.Property(e => e.In2301DailyDeductibleMonetaryAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN2_30_1_DailyDeductibleMonetaryAmount");
            entity.Property(e => e.In230InsuredsEmployersNameandIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_3_0_InsuredsEmployersNameandIDIDNumber");
            entity.Property(e => e.In231LivingDependency)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_31_LivingDependency");
            entity.Property(e => e.In232AmbulatoryStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_32_AmbulatoryStatus");
            entity.Property(e => e.In233Citizenship)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_33_Citizenship");
            entity.Property(e => e.In2340PrimaryLanguageIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_34_0_PrimaryLanguageIdentifier");
            entity.Property(e => e.In235LivingArrangement)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_35_LivingArrangement");
            entity.Property(e => e.In2360PublicityCodeIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_36_0_PublicityCodeIdentifier");
            entity.Property(e => e.In237ProtectionIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_37_ProtectionIndicator");
            entity.Property(e => e.In238StudentIndicator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_38_StudentIndicator");
            entity.Property(e => e.In239Religion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_39_Religion");
            entity.Property(e => e.In2400MothersMaidenNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_40_0_MothersMaidenNameFamilyName");
            entity.Property(e => e.In2410NationalityIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_41_0_NationalityIdentifier");
            entity.Property(e => e.In242EthnicGroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_42_EthnicGroup");
            entity.Property(e => e.In243MaritalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_43_MaritalStatus");
            entity.Property(e => e.In244InsuredsEmploymentStartDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_44_InsuredsEmploymentStartDate");
            entity.Property(e => e.In245EmploymentStopDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_45_EmploymentStopDate");
            entity.Property(e => e.In246JobTitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_46_JobTitle");
            entity.Property(e => e.In2470JobCodeClassJobCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_47_0_JobCodeClassJobCode");
            entity.Property(e => e.In2471JobCodeClassJobClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_47_1_JobCodeClassJobClass");
            entity.Property(e => e.In248JobStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_48_JobStatus");
            entity.Property(e => e.In2490EmployerContactPersonNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_49_0_EmployerContactPersonNameFamilyName");
            entity.Property(e => e.In2491EmployerContactPersonNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_49_1_EmployerContactPersonNameGivenName");
            entity.Property(e => e.In24EmployerInformationData)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_4_EmployerInformationData");
            entity.Property(e => e.In250EmployerContactPersonPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_50_EmployerContactPersonPhoneNumber");
            entity.Property(e => e.In251EmployerContactReason)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_51_EmployerContactReason");
            entity.Property(e => e.In2520InsuredsContactPersonsNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_52_0_InsuredsContactPersonsNameFamilyName");
            entity.Property(e => e.In2521InsuredsContactPersonsNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_52_1_InsuredsContactPersonsNameGivenName");
            entity.Property(e => e.In253InsuredsContactPersonPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_53_InsuredsContactPersonPhoneNumber");
            entity.Property(e => e.In254InsuredsContactPersonReason)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_54_InsuredsContactPersonReason");
            entity.Property(e => e.In255RelationshiptothePatientStartDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_55_RelationshiptothePatientStartDate");
            entity.Property(e => e.In256RelationshiptothePatientStopDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_56_RelationshiptothePatientStopDate");
            entity.Property(e => e.In257InsuranceCoContactReason)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_57_InsuranceCoContactReason");
            entity.Property(e => e.In258InsuranceCoContactPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_58_InsuranceCoContactPhoneNumber");
            entity.Property(e => e.In259PolicyScope)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_59_PolicyScope");
            entity.Property(e => e.In25MailClaimParty)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_5_MailClaimParty");
            entity.Property(e => e.In260PolicySource)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_60_PolicySource");
            entity.Property(e => e.In2610PatientMemberNumberIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_61_0_PatientMemberNumberIDNumber");
            entity.Property(e => e.In262GuarantorsRelationshiptoInsured)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_62_GuarantorsRelationshiptoInsured");
            entity.Property(e => e.In263InsuredsPhoneNumberHome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_63_InsuredsPhoneNumberHome");
            entity.Property(e => e.In264InsuredsEmployerPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_64_InsuredsEmployerPhoneNumber");
            entity.Property(e => e.In2650MilitaryHandicappedProgramIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_65_0_MilitaryHandicappedProgramIdentifier");
            entity.Property(e => e.In266SuspendFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_66_SuspendFlag");
            entity.Property(e => e.In267CopayLimitFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_67_CopayLimitFlag");
            entity.Property(e => e.In268StoplossLimitFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_68_StoplossLimitFlag");
            entity.Property(e => e.In2690InsuredOrganizationNameandIdorganizationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_69_0_InsuredOrganizationNameandIDOrganizationName");
            entity.Property(e => e.In2691InsuredOrganizationNameandIdorganizationNameTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_69_1_InsuredOrganizationNameandIDOrganizationNameTypeCode");
            entity.Property(e => e.In2692InsuredOrganizationNameandIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_69_2_InsuredOrganizationNameandIDIDNumber");
            entity.Property(e => e.In26MedicareHealthInsCardNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_6_MedicareHealthInsCardNumber");
            entity.Property(e => e.In2700InsuredEmployerOrganizationNameandIdorganizationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_70_0_InsuredEmployerOrganizationNameandIDOrganizationName");
            entity.Property(e => e.In2701InsuredEmployerOrganizationNameandIdorganizationNameTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_70_1_InsuredEmployerOrganizationNameandIDOrganizationNameTypeCode");
            entity.Property(e => e.In2702InsuredEmployerOrganizationNameandIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_70_2_InsuredEmployerOrganizationNameandIDIDNumber");
            entity.Property(e => e.In270MedicaidCaseNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_7_0_MedicaidCaseNameFamilyName");
            entity.Property(e => e.In271MedicaidCaseNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_7_1_MedicaidCaseNameGivenName");
            entity.Property(e => e.In271Race)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_71_Race");
            entity.Property(e => e.In272PatientsRelationshipToInsured)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_72_PatientsRelationshipToInsured");
            entity.Property(e => e.In28MedicaidCaseNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_8_MedicaidCaseNumber");
            entity.Property(e => e.In290MilitarySponsorNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_9_0_MilitarySponsorNameFamilyName");
            entity.Property(e => e.In291MilitarySponsorNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_9_1_MilitarySponsorNameGivenName");
        });

        modelBuilder.Entity<In2InsuranceAdditionalInformationImportHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN2_InsuranceAdditionalInformation_ImportHistory", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.In210InsuredsEmployeeIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_1_0_InsuredsEmployeeIDIDNumber");
            entity.Property(e => e.In210MilitaryIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_10_MilitaryIDNumber");
            entity.Property(e => e.In2110DependentOfMilitaryRecipientIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_11_0_DependentOfMilitaryRecipientIdentifier");
            entity.Property(e => e.In212MilitaryOrganization)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_12_MilitaryOrganization");
            entity.Property(e => e.In213MilitaryStation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_13_MilitaryStation");
            entity.Property(e => e.In214MilitaryService)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_14_MilitaryService");
            entity.Property(e => e.In215MilitaryRankGrade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_15_MilitaryRankGrade");
            entity.Property(e => e.In216MilitaryStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_16_MilitaryStatus");
            entity.Property(e => e.In217MilitaryRetireDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_17_MilitaryRetireDate");
            entity.Property(e => e.In218MilitaryNonAvailCertOnFile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_18_MilitaryNonAvailCertOnFile");
            entity.Property(e => e.In219BabyCoverage)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_19_BabyCoverage");
            entity.Property(e => e.In220CombineBabyBill)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_20_CombineBabyBill");
            entity.Property(e => e.In221BloodDeductible)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_21_BloodDeductible");
            entity.Property(e => e.In2220SpecialCoverageApprovalNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_22_0_SpecialCoverageApprovalNameFamilyName");
            entity.Property(e => e.In2221SpecialCoverageApprovalNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_22_1_SpecialCoverageApprovalNameGivenName");
            entity.Property(e => e.In223SpecialCoverageApprovalTitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_23_SpecialCoverageApprovalTitle");
            entity.Property(e => e.In224NonCoveredInsuranceCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_24_NonCoveredInsuranceCode");
            entity.Property(e => e.In2250PayorIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_25_0_PayorIDIDNumber");
            entity.Property(e => e.In2260PayorSubscriberIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_26_0_PayorSubscriberIDIDNumber");
            entity.Property(e => e.In227EligibilitySource)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_27_EligibilitySource");
            entity.Property(e => e.In2280RoomCoverageTypeAmountRoomType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_28_0_RoomCoverageTypeAmountRoomType");
            entity.Property(e => e.In2281RoomCoverageTypeAmountAmountType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_28_1_RoomCoverageTypeAmountAmountType");
            entity.Property(e => e.In2282RoomCoverageTypeAmountCoverageAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN2_28_2_RoomCoverageTypeAmountCoverageAmount");
            entity.Property(e => e.In229PolicyTypeAmount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_29_PolicyTypeAmount");
            entity.Property(e => e.In22InsuredsSocialSecurityNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_2_InsuredsSocialSecurityNumber");
            entity.Property(e => e.In2300DailyDeductibleDelayDays)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN2_30_0_DailyDeductibleDelayDays");
            entity.Property(e => e.In2301DailyDeductibleMonetaryAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("IN2_30_1_DailyDeductibleMonetaryAmount");
            entity.Property(e => e.In230InsuredsEmployersNameandIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_3_0_InsuredsEmployersNameandIDIDNumber");
            entity.Property(e => e.In231LivingDependency)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_31_LivingDependency");
            entity.Property(e => e.In232AmbulatoryStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_32_AmbulatoryStatus");
            entity.Property(e => e.In233Citizenship)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_33_Citizenship");
            entity.Property(e => e.In2340PrimaryLanguageIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_34_0_PrimaryLanguageIdentifier");
            entity.Property(e => e.In235LivingArrangement)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_35_LivingArrangement");
            entity.Property(e => e.In2360PublicityCodeIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_36_0_PublicityCodeIdentifier");
            entity.Property(e => e.In237ProtectionIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_37_ProtectionIndicator");
            entity.Property(e => e.In238StudentIndicator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_38_StudentIndicator");
            entity.Property(e => e.In239Religion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_39_Religion");
            entity.Property(e => e.In2400MothersMaidenNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_40_0_MothersMaidenNameFamilyName");
            entity.Property(e => e.In2410NationalityIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_41_0_NationalityIdentifier");
            entity.Property(e => e.In242EthnicGroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_42_EthnicGroup");
            entity.Property(e => e.In243MaritalStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_43_MaritalStatus");
            entity.Property(e => e.In244InsuredsEmploymentStartDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_44_InsuredsEmploymentStartDate");
            entity.Property(e => e.In245EmploymentStopDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_45_EmploymentStopDate");
            entity.Property(e => e.In246JobTitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_46_JobTitle");
            entity.Property(e => e.In2470JobCodeClassJobCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_47_0_JobCodeClassJobCode");
            entity.Property(e => e.In2471JobCodeClassJobClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_47_1_JobCodeClassJobClass");
            entity.Property(e => e.In248JobStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_48_JobStatus");
            entity.Property(e => e.In2490EmployerContactPersonNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_49_0_EmployerContactPersonNameFamilyName");
            entity.Property(e => e.In2491EmployerContactPersonNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_49_1_EmployerContactPersonNameGivenName");
            entity.Property(e => e.In24EmployerInformationData)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_4_EmployerInformationData");
            entity.Property(e => e.In250EmployerContactPersonPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_50_EmployerContactPersonPhoneNumber");
            entity.Property(e => e.In251EmployerContactReason)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_51_EmployerContactReason");
            entity.Property(e => e.In2520InsuredsContactPersonsNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_52_0_InsuredsContactPersonsNameFamilyName");
            entity.Property(e => e.In2521InsuredsContactPersonsNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_52_1_InsuredsContactPersonsNameGivenName");
            entity.Property(e => e.In253InsuredsContactPersonPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_53_InsuredsContactPersonPhoneNumber");
            entity.Property(e => e.In254InsuredsContactPersonReason)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_54_InsuredsContactPersonReason");
            entity.Property(e => e.In255RelationshiptothePatientStartDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_55_RelationshiptothePatientStartDate");
            entity.Property(e => e.In256RelationshiptothePatientStopDate)
                .HasColumnType("datetime")
                .HasColumnName("IN2_56_RelationshiptothePatientStopDate");
            entity.Property(e => e.In257InsuranceCoContactReason)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_57_InsuranceCoContactReason");
            entity.Property(e => e.In258InsuranceCoContactPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_58_InsuranceCoContactPhoneNumber");
            entity.Property(e => e.In259PolicyScope)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_59_PolicyScope");
            entity.Property(e => e.In25MailClaimParty)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_5_MailClaimParty");
            entity.Property(e => e.In260PolicySource)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_60_PolicySource");
            entity.Property(e => e.In2610PatientMemberNumberIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_61_0_PatientMemberNumberIDNumber");
            entity.Property(e => e.In262GuarantorsRelationshiptoInsured)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_62_GuarantorsRelationshiptoInsured");
            entity.Property(e => e.In263InsuredsPhoneNumberHome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_63_InsuredsPhoneNumberHome");
            entity.Property(e => e.In264InsuredsEmployerPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_64_InsuredsEmployerPhoneNumber");
            entity.Property(e => e.In2650MilitaryHandicappedProgramIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_65_0_MilitaryHandicappedProgramIdentifier");
            entity.Property(e => e.In266SuspendFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_66_SuspendFlag");
            entity.Property(e => e.In267CopayLimitFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_67_CopayLimitFlag");
            entity.Property(e => e.In268StoplossLimitFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN2_68_StoplossLimitFlag");
            entity.Property(e => e.In2690InsuredOrganizationNameandIdorganizationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_69_0_InsuredOrganizationNameandIDOrganizationName");
            entity.Property(e => e.In2691InsuredOrganizationNameandIdorganizationNameTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_69_1_InsuredOrganizationNameandIDOrganizationNameTypeCode");
            entity.Property(e => e.In2692InsuredOrganizationNameandIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_69_2_InsuredOrganizationNameandIDIDNumber");
            entity.Property(e => e.In26MedicareHealthInsCardNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_6_MedicareHealthInsCardNumber");
            entity.Property(e => e.In2700InsuredEmployerOrganizationNameandIdorganizationName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_70_0_InsuredEmployerOrganizationNameandIDOrganizationName");
            entity.Property(e => e.In2701InsuredEmployerOrganizationNameandIdorganizationNameTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_70_1_InsuredEmployerOrganizationNameandIDOrganizationNameTypeCode");
            entity.Property(e => e.In2702InsuredEmployerOrganizationNameandIdidnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_70_2_InsuredEmployerOrganizationNameandIDIDNumber");
            entity.Property(e => e.In270MedicaidCaseNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_7_0_MedicaidCaseNameFamilyName");
            entity.Property(e => e.In271MedicaidCaseNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_7_1_MedicaidCaseNameGivenName");
            entity.Property(e => e.In271Race)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_71_Race");
            entity.Property(e => e.In272PatientsRelationshipToInsured)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_72_PatientsRelationshipToInsured");
            entity.Property(e => e.In28MedicaidCaseNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN2_8_MedicaidCaseNumber");
            entity.Property(e => e.In290MilitarySponsorNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_9_0_MilitarySponsorNameFamilyName");
            entity.Property(e => e.In291MilitarySponsorNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IN2_9_1_MilitarySponsorNameGivenName");
        });

        modelBuilder.Entity<Intervention>(entity =>
        {
            entity.HasKey(e => e.InterventionId).HasName("PK_InterventionId");

            entity.ToTable("Intervention", "IMT");

            entity.HasIndex(e => new { e.ContentId, e.ContentType }, "NCI_ContentIDContentType_All").IsDescending(true, false);

            entity.HasIndex(e => new { e.InstitutionMasterId, e.ContentId, e.ContentType }, "NCI_ContentIdNumberInstitution_ALL").IsDescending(false, true, false);

            entity.Property(e => e.Abx).HasMaxLength(100);
            entity.Property(e => e.CaseNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DoctorName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Indication).HasMaxLength(100);
            entity.Property(e => e.InterventionTypeNoneOther).HasMaxLength(100);
            entity.Property(e => e.Pminumber)
                .HasMaxLength(100)
                .HasColumnName("PMINumber");
            entity.Property(e => e.Prescriber).HasMaxLength(100);
            entity.Property(e => e.Reason).HasMaxLength(300);
            entity.Property(e => e.Recommendation).HasMaxLength(300);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Ward).HasMaxLength(100);

            entity.HasOne(d => d.CommunicationType).WithMany(p => p.Interventions)
                .HasForeignKey(d => d.CommunicationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("IMT_FK_Intervention_CommunicationType");
        });

        modelBuilder.Entity<InterventionAdditionalType>(entity =>
        {
            entity.HasKey(e => e.InterventionAdditionalTypeId).HasName("PK_AMSInterventionAdditionalType");

            entity.ToTable("InterventionAdditionalType", "IMT");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InterventionAdditionalTypeGroup>(entity =>
        {
            entity.HasKey(e => e.InterventionAdditionalTypeGroupId).HasName("PK_AMSInterventionAdditionalTypeGroup");

            entity.ToTable("InterventionAdditionalTypeGroup", "IMT");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.InterventionAdditionalType).WithMany(p => p.InterventionAdditionalTypeGroups)
                .HasForeignKey(d => d.InterventionAdditionalTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("IMT_FK_AMSInterventionAdditionalTypeGroup_AMSInterventionAdditionalType");

            entity.HasOne(d => d.InterventionType).WithMany(p => p.InterventionAdditionalTypeGroups)
                .HasForeignKey(d => d.InterventionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AMSInterventionAdditionalTypeGroup_AMSInterventionType");
        });

        modelBuilder.Entity<InterventionGroup>(entity =>
        {
            entity.HasKey(e => e.InterventionGroupId).HasName("PK_InterventionType");

            entity.ToTable("InterventionGroup", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InterventionType>(entity =>
        {
            entity.HasKey(e => e.InterventionTypeId).HasName("PK_AMSInterventionType");

            entity.ToTable("InterventionType", "IMT");

            entity.HasIndex(e => e.InterventionTypeId, "NCI_InterventionTypeId_Description");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InterventionTypeContentTypeLink>(entity =>
        {
            entity.ToTable("InterventionTypeContentTypeLink", "IMT");

            entity.HasOne(d => d.InterventionType).WithMany(p => p.InterventionTypeContentTypeLinks)
                .HasForeignKey(d => d.InterventionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InterventionTypeContentTypeLink_InterventionType");
        });

        modelBuilder.Entity<IsolateEventType>(entity =>
        {
            entity.HasKey(e => e.IsolateEventId);

            entity.ToTable("IsolateEventType", "IMT");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<IsolateSwab>(entity =>
        {
            entity.ToTable("IsolateSwab", "IMT");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SwabCriteria)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SwabDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MessageError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MessageErrors", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ErrorMessage).HasColumnType("text");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.OriginalMessage).HasColumnType("text");
        });

        modelBuilder.Entity<MshMessageHeaderEvnEventType>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_MSH_MessageHeader_EVN_EventType_1");

            entity.ToTable("MSH_MessageHeader_EVN_EventType", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Evn1EventTypeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVN_1_EventTypeCode");
            entity.Property(e => e.Evn2RecordedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("EVN_2_RecordedDateTime");
            entity.Property(e => e.Evn3DateTimePlannedEvent)
                .HasColumnType("datetime")
                .HasColumnName("EVN_3_DateTimePlannedEvent");
            entity.Property(e => e.Evn4EventReasonCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVN_4_EventReasonCode");
            entity.Property(e => e.Evn5OperatorId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVN_5_OperatorID");
            entity.Property(e => e.Evn6EventOccurred)
                .HasColumnType("datetime")
                .HasColumnName("EVN_6_EventOccurred");
            entity.Property(e => e.Evn7EventFacility)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVN_7_EventFacility");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Msh10MessageControlId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_10_MessageControlID");
            entity.Property(e => e.Msh11ProcessingId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_11_ProcessingID");
            entity.Property(e => e.Msh12VersionId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_12_VersionID");
            entity.Property(e => e.Msh13SequenceNumber)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_13_SequenceNumber");
            entity.Property(e => e.Msh14ContinuationPointer)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_14_ContinuationPointer");
            entity.Property(e => e.Msh15AcceptAcknowledgmentType)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_15_AcceptAcknowledgmentType");
            entity.Property(e => e.Msh16ApplicationAcknowledgmentType)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_16_ApplicationAcknowledgmentType");
            entity.Property(e => e.Msh17CountryCode)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_17_CountryCode");
            entity.Property(e => e.Msh190PrincipalLanguageOfMessageIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MSH_19_0_PrincipalLanguageOfMessageIdentifier");
            entity.Property(e => e.Msh191PrincipalLanguageOfMessageText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MSH_19_1_PrincipalLanguageOfMessageText");
            entity.Property(e => e.Msh192PrincipalLanguageOfMessageNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MSH_19_2_PrincipalLanguageOfMessageNameOfCodingSystem");
            entity.Property(e => e.Msh193PrincipalLanguageOfMessageAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MSH_19_3_PrincipalLanguageOfMessageAlternateIdentifier");
            entity.Property(e => e.Msh194PrincipalLanguageOfMessageAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MSH_19_4_PrincipalLanguageOfMessageAlternateText");
            entity.Property(e => e.Msh195PrincipalLanguageOfMessageNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MSH_19_5_PrincipalLanguageOfMessageNameOfAlternateCodingSystem");
            entity.Property(e => e.Msh1FieldSeparator)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_1_FieldSeparator");
            entity.Property(e => e.Msh20AlternateCharacterSetHandlingScheme)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_20_AlternateCharacterSetHandlingScheme");
            entity.Property(e => e.Msh2EncodingCharacters)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_2_EncodingCharacters");
            entity.Property(e => e.Msh31SendingApplicationNamespaceId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_3_1_SendingApplication_NamespaceID");
            entity.Property(e => e.Msh32SendingApplicationUniversalId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_3_2_SendingApplication_UniversalId");
            entity.Property(e => e.Msh33SendingApplicationUniversalIdType)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_3_3_SendingApplication_Universal_Id_Type");
            entity.Property(e => e.Msh3SendingApplication)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_3_SendingApplication");
            entity.Property(e => e.Msh40SendingFacilityNameSpace)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_4_0_SendingFacilityNameSpace");
            entity.Property(e => e.Msh41SendingFacilityUniversalId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_4_1_SendingFacilityUniversalID");
            entity.Property(e => e.Msh42SendingFacilityUniversalIdtype)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_4_2_SendingFacilityUniversalIDType");
            entity.Property(e => e.Msh50ReceivingApplicationNamespaceId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_5_0_ReceivingApplicationNamespaceId");
            entity.Property(e => e.Msh51ReceivingApplicationUniversalId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_5_1_ReceivingApplicationUniversalId");
            entity.Property(e => e.Msh52ReceivingApplicationUniversalIdType)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_5_2_ReceivingApplicationUniversalIdType");
            entity.Property(e => e.Msh5ReceivingApplication)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_5_ReceivingApplication");
            entity.Property(e => e.Msh60ReceivingFacilityNamespaceId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_6_0_ReceivingFacilityNamespaceId");
            entity.Property(e => e.Msh61ReceivingFacilityUniversalId)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_6_1_ReceivingFacilityUniversalId");
            entity.Property(e => e.Msh62ReceivingFacilityUniversalIdType)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_6_2_ReceivingFacilityUniversalIdType");
            entity.Property(e => e.Msh6ReceivingFacility)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_6_ReceivingFacility");
            entity.Property(e => e.Msh7DateTimeofMessage)
                .HasColumnType("datetime")
                .HasColumnName("MSH_7_DateTimeofMessage");
            entity.Property(e => e.Msh8Security)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_8_Security");
            entity.Property(e => e.Msh90MessageTypeMessageCode)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_9_0_MessageTypeMessageCode");
            entity.Property(e => e.Msh91MessageTypeTriggerEvent)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_9_1_MessageTypeTriggerEvent");
            entity.Property(e => e.Msh92MessageTypeMessageStructure)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("MSH_9_2_MessageTypeMessageStructure");
            entity.Property(e => e.OriginalMessage).HasColumnType("text");
        });

        modelBuilder.Entity<MshMessageHeaderEvnEventTypeImportHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MSH_MessageHeader_EVN_EventType_ImportHistory", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Evn1EventTypeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVN_1_EventTypeCode");
            entity.Property(e => e.Evn2RecordedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("EVN_2_RecordedDateTime");
            entity.Property(e => e.Evn3DateTimePlannedEvent)
                .HasColumnType("datetime")
                .HasColumnName("EVN_3_DateTimePlannedEvent");
            entity.Property(e => e.Evn4EventReasonCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVN_4_EventReasonCode");
            entity.Property(e => e.Evn5OperatorId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVN_5_OperatorID");
            entity.Property(e => e.Evn6EventOccurred)
                .HasColumnType("datetime")
                .HasColumnName("EVN_6_EventOccurred");
            entity.Property(e => e.Evn7EventFacility)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EVN_7_EventFacility");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Msh10MessageControlId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_10_MessageControlID");
            entity.Property(e => e.Msh11ProcessingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_11_ProcessingID");
            entity.Property(e => e.Msh12VersionId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_12_VersionID");
            entity.Property(e => e.Msh1FieldSeparator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_1_FieldSeparator");
            entity.Property(e => e.Msh2EncodingCharacters)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_2_EncodingCharacters");
            entity.Property(e => e.Msh3SendingApplication)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_3_SendingApplication");
            entity.Property(e => e.Msh40SendingFacilityNameSpace)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_4_0_SendingFacilityNameSpace");
            entity.Property(e => e.Msh41SendingFacilityUniversalId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_4_1_SendingFacilityUniversalID");
            entity.Property(e => e.Msh5ReceivingApplication)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_5_ReceivingApplication");
            entity.Property(e => e.Msh6ReceivingFacility)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_6_ReceivingFacility");
            entity.Property(e => e.Msh7DateTimeofMessage)
                .HasColumnType("datetime")
                .HasColumnName("MSH_7_DateTimeofMessage");
            entity.Property(e => e.Msh8Security)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_8_Security");
            entity.Property(e => e.Msh90MessageTypeMessageCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_9_0_MessageTypeMessageCode");
            entity.Property(e => e.Msh91MessageTypeTriggerEvent)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MSH_9_1_MessageTypeTriggerEvent");
            entity.Property(e => e.OriginalMessage).HasColumnType("text");
        });

        modelBuilder.Entity<NotificationDetailDuplicateWorkFlow>(entity =>
        {
            entity.HasKey(e => e.DetailDuplicateWorkFlowId).HasName("PK__Notifica__1E51C9FB93AB901E");

            entity.ToTable("NotificationDetailDuplicateWorkFlow", "IMT");

            entity.Property(e => e.DetailDuplicateWorkFlowId).HasColumnName("DetailDuplicateWorkFlowID");
            entity.Property(e => e.ConditionId).HasColumnName("ConditionID");
            entity.Property(e => e.ExecutionPlanId).HasColumnName("ExecutionPlanID");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.LookupColumnName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LookupTableName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lookupTableName");
            entity.Property(e => e.LookupType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultColumnName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NteNotesAndComment>(entity =>
        {
            entity.HasKey(e => e.PkNteId).HasName("PK_HL7_NTE_NotesAndComments");

            entity.ToTable("NTE_NotesAndComments", "HL7");

            entity.Property(e => e.PkNteId).HasColumnName("pk_NTE_ID");
            entity.Property(e => e.FkObrId).HasColumnName("fk_OBR_ID");
            entity.Property(e => e.FkObxId).HasColumnName("fk_OBX_ID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Nte1Setidnte).HasColumnName("NTE_1_SETIDNTE");
            entity.Property(e => e.Nte2SourceofComment)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTE_2_SourceofComment");
            entity.Property(e => e.Nte3Comment)
                .IsUnicode(false)
                .HasColumnName("NTE_3_Comment");
            entity.Property(e => e.Nte41CommentTypeIdentifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTE_4_1_CommentTypeIdentifier");
            entity.Property(e => e.Nte42CommentTypeText)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTE_4_2_CommentTypeText");
            entity.Property(e => e.Nte43CommentTypeNameOfCodingSystem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTE_4_3_CommentTypeNameOfCodingSystem");
            entity.Property(e => e.Nte44CommentTypeAlternateIdentifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTE_4_4_CommentTypeAlternateIdentifier");
            entity.Property(e => e.Nte45NameOfAlternateCodingSystem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTE_4_5_NameOfAlternateCodingSystem");
            entity.Property(e => e.Nte4CommentType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NTE_4_CommentType");

            entity.HasOne(d => d.FkObr).WithMany(p => p.NteNotesAndComments)
                .HasForeignKey(d => d.FkObrId)
                .HasConstraintName("FK_NTE_NotesAndComments_OBR_ObservationRequest");

            entity.HasOne(d => d.FkObx).WithMany(p => p.NteNotesAndComments)
                .HasForeignKey(d => d.FkObxId)
                .HasConstraintName("FK_NTE_NotesAndComments_OBX_ObservationResult");
        });

        modelBuilder.Entity<ObrObservationRequest>(entity =>
        {
            entity.HasKey(e => e.PkObrId).HasName("PK_OBR_Observation_Request_1");

            entity.ToTable("OBR_Observation_Request", "HL7");

            entity.HasIndex(e => new { e.Hl7uniqueIdentifier, e.Hl7personLogId }, "NCI_Hl7PersonLog").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_Hl7_Obr15").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_InterimFinalCheck").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLog_ObservationTime").HasFillFactor(80);

            entity.Property(e => e.PkObrId).HasColumnName("pk_OBR_ID");
            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FkOrcId).HasColumnName("fk_ORC_ID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.InsertOrder).HasColumnName("insertOrder");
            entity.Property(e => e.Obr1010CollectorIdentifierNameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_10_CollectorIdentifier_NameTypeCode");
            entity.Property(e => e.Obr1011CollectorIdentifierIdentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_11_CollectorIdentifier_IdentifierCheckDigit");
            entity.Property(e => e.Obr1012CollectorIdentifierCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_12_CollectorIdentifier_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Obr1013CollectorIdentifierIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_13_CollectorIdentifier_IdentifierTypeCode");
            entity.Property(e => e.Obr10141CollectorIdentifierAssigningFacilityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_14_1_CollectorIdentifier_AssigningFacility_NamespaceId");
            entity.Property(e => e.Obr10142CollectorIdentifierAssigningFacilityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_14_2_CollectorIdentifier_AssigningFacility_UniversalId");
            entity.Property(e => e.Obr10143CollectorIdentifierAssigningFacilityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_14_3_CollectorIdentifier_AssigningFacility_UniversalIdType");
            entity.Property(e => e.Obr1015CollectorIdentifierNameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_15_CollectorIdentifier_NameRepresentationCode");
            entity.Property(e => e.Obr10161CollectorIdentifierNameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_16_1_CollectorIdentifier_NameContext_Identifier");
            entity.Property(e => e.Obr10162CollectorIdentifierNameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_16_2_CollectorIdentifier_NameContext_Text");
            entity.Property(e => e.Obr10163CollectorIdentifierNameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_16_3_CollectorIdentifier_NameContext_NameOfCodingSystem");
            entity.Property(e => e.Obr10164CollectorIdentifierNameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_16_4_CollectorIdentifier_NameContext_AlternateIdentifier");
            entity.Property(e => e.Obr10165CollectorIdentifierNameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_16_5_CollectorIdentifier_NameContext_AlternateText");
            entity.Property(e => e.Obr10166CollectorIdentifierNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_16_6_CollectorIdentifier_NameContext_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr10171CollectorIdentifierNameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_10_17_1_CollectorIdentifier_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Obr10172CollectorIdentifierNameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_10_17_2_CollectorIdentifier_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Obr1018CollectorIdentifierNameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_18_CollectorIdentifierNameAssemblyOrder");
            entity.Property(e => e.Obr101CollectorIdentifierIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_1_CollectorIdentifier_IdNumber");
            entity.Property(e => e.Obr1021CollectorIdentifierFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_2_1_CollectorIdentifier_FamilyName_Surname");
            entity.Property(e => e.Obr1022CollectorIdentifierFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_2_2_CollectorIdentifier_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Obr1023CollectorIdentifierFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_2_3_CollectorIdentifier_FamilyName_OwnSurname");
            entity.Property(e => e.Obr1024CollectorIdentifierFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_2_4_CollectorIdentifier_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Obr1025CollectorIdentifierFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_2_5_CollectorIdentifier_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Obr103CollectorIdentifierGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_3_CollectorIdentifier_GivenName");
            entity.Property(e => e.Obr104CollectorIdentifierSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_4_CollectorIdentifier_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Obr105CollectorIdentifierSuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_5_CollectorIdentifier_Suffix");
            entity.Property(e => e.Obr106CollectorIdentifierPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_6_CollectorIdentifier_Prefix");
            entity.Property(e => e.Obr107CollectorIdentifierDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_7_CollectorIdentifier_Degree");
            entity.Property(e => e.Obr108CollectorIdentifierSourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_8_CollectorIdentifier_SourceTable");
            entity.Property(e => e.Obr1091CollectorIdentifierAssigningAuthorityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_9_1_CollectorIdentifier_AssigningAuthority_NamespaceId");
            entity.Property(e => e.Obr1092CollectorIdentifierAssigningAuthorityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_9_2_CollectorIdentifier_AssigningAuthority_UniversalId");
            entity.Property(e => e.Obr1093CollectorIdentifierAssigningAuthorityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_10_9_3_CollectorIdentifier_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Obr11SpecimenActionCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OBR_11_Specimen_Action_Code");
            entity.Property(e => e.Obr121DangerCodeIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_12_1_DangerCode_Identifier");
            entity.Property(e => e.Obr122DangerCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_12_2_DangerCode_Text");
            entity.Property(e => e.Obr123DangerCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_12_3_DangerCode_NameOfCodingSystem");
            entity.Property(e => e.Obr124DangerCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_12_4_DangerCode_AlternateIdentifier");
            entity.Property(e => e.Obr125DangerCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_12_5_DangerCode_AlternateText");
            entity.Property(e => e.Obr126DangerCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_12_6_DangerCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr13RelevantClinicalInfo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_13_RelevantClinicalInfo");
            entity.Property(e => e.Obr141SpecimenReceivedDateTimeTimeOfEvent)
                .HasColumnType("datetime")
                .HasColumnName("OBR_14_1_SpecimenReceivedDateTime_TimeOfEvent");
            entity.Property(e => e.Obr142SpecimenReceivedDateTimeDegreeOfPrecision)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_14_2_Specimen_Received_Date_Time_DegreeOfPrecision");
            entity.Property(e => e.Obr1511SpecimenSourceSpecimenSourceNameOrCodeIdentifier)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_1_1_SpecimenSource_SpecimenSourceNameOrCode_Identifier");
            entity.Property(e => e.Obr1512SpecimenSourceSpecimenSourceNameOrCodeText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_1_2_SpecimenSource_SpecimenSourceNameOrCode_Text");
            entity.Property(e => e.Obr1513SpecimenSourceSpecimenSourceNameOrCodeNameOfCodingSystem)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_1_3_SpecimenSource_SpecimenSourceNameOrCode_NameOfCodingSystem");
            entity.Property(e => e.Obr1514SpecimenSourceSpecimenSourceNameOrCodeAlternateIdentifier)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_1_4_SpecimenSource_SpecimenSourceNameOrCode_AlternateIdentifier");
            entity.Property(e => e.Obr1515SpecimenSourceSpecimenSourceNameOrCodeAlternateText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_1_5_SpecimenSource_SpecimenSourceNameOrCode_AlternateText");
            entity.Property(e => e.Obr1516SpecimenSourceSpecimenSourceNameOrCodeNameOfAlternateCodingSystem)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_1_6_SpecimenSource_SpecimenSourceNameOrCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr152SpecimenSourceAdditives)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_2_SpecimenSource_Additives");
            entity.Property(e => e.Obr153SpecimenSourceFreetext)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_3_SpecimenSource_Freetext");
            entity.Property(e => e.Obr1541SpecimenSourceBodySiteIdentifier)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_4_1_SpecimenSource_BodySite_Identifier");
            entity.Property(e => e.Obr1542SpecimenSourceBodySiteText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_4_2_SpecimenSource_BodySite_Text");
            entity.Property(e => e.Obr1543SpecimenSourceBodySiteNameOfCodingSystem)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_4_3_SpecimenSource_BodySite_NameOfCodingSystem");
            entity.Property(e => e.Obr1544SpecimenSourceBodySiteAlternateIdentifier)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_4_4_SpecimenSource_BodySite_AlternateIdentifier");
            entity.Property(e => e.Obr1545SpecimenSourceBodySiteAlternateText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_4_5_SpecimenSource_BodySite_AlternateText");
            entity.Property(e => e.Obr1546SpecimenSourceBodySiteNameOfAlternateCodingSystem)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_4_6_SpecimenSource_BodySite_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr1551SpecimenSourceSiteModifierIdentifier)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_5_1_SpecimenSource_SiteModifier_Identifier");
            entity.Property(e => e.Obr1552SpecimenSourceSiteModifierText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_5_2_SpecimenSource_SiteModifier_Text");
            entity.Property(e => e.Obr1553SpecimenSourceSiteModifierNameOfCodingSystem)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_5_3_SpecimenSource_SiteModifier_NameOfCodingSystem");
            entity.Property(e => e.Obr1554SpecimenSourceSiteModifierAlternateIdentifier)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_5_4_SpecimenSource_SiteModifier_AlternateIdentifier");
            entity.Property(e => e.Obr1555SpecimenSourceSiteModifierAlternateText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_5_5_SpecimenSource_SiteModifier_AlternateText");
            entity.Property(e => e.Obr1556SpecimenSourceSiteModifierNameOfAlternateCodingSystem)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_5_6_SpecimenSource_SiteModifier_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr156SpecimenSourceCollectionModifierMethodCode)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_6_SpecimenSource_CollectionModifierMethodCode");
            entity.Property(e => e.Obr1571SpecimenSourceSpecimenRoleIdentifier)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_7_1_SpecimenSource_SpecimenRole_Identifier");
            entity.Property(e => e.Obr1572SpecimenSourceSpecimenRoleText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_7_2_SpecimenSource_SpecimenRole_Text");
            entity.Property(e => e.Obr1573SpecimenSourceSpecimenRoleNameOfCodingSystem)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_7_3_SpecimenSource_SpecimenRole_NameOfCodingSystem");
            entity.Property(e => e.Obr1574SpecimenSourceSpecimenRoleAlternateIdentifier)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_7_4_SpecimenSource_SpecimenRole_AlternateIdentifier");
            entity.Property(e => e.Obr1575SpecimenSourceSpecimenRoleAlternateText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_7_5_SpecimenSource_SpecimenRole_AlternateText");
            entity.Property(e => e.Obr1576SpecimenSourceSpecimenRoleNameOfAlternateCodingSystem)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBR_15_7_6_SpecimenSource_SpecimenRole_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr1610OrderingProviderNameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_10_OrderingProvider_NameTypeCode");
            entity.Property(e => e.Obr1611OrderingProviderIdentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_11_OrderingProvider_IdentifierCheckDigit");
            entity.Property(e => e.Obr1612OrderingProviderCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_12_Ordering_Provider_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Obr1613OrderingProviderIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_13_OrderingProvider_IdentifierTypeCode");
            entity.Property(e => e.Obr16141OrderingProviderAssigningFacilityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_14_1_OrderingProvider_AssigningFacility_NamespaceId");
            entity.Property(e => e.Obr16142OrderingProviderAssigningFacilityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_14_2_OrderingProvider_AssigningFacility_UniversalId");
            entity.Property(e => e.Obr16143OrderingProviderAssigningFacilityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_14_3_OrderingProvider_AssigningFacility_UniversalIdType");
            entity.Property(e => e.Obr1615OrderingProviderNameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_15_OrderingProvider_NameRepresentationCode");
            entity.Property(e => e.Obr16161OrderingProviderNameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_16_1_OrderingProvider_NameContext_Identifier");
            entity.Property(e => e.Obr16162OrderingProviderNameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_16_2_OrderingProvider_NameContext_Text");
            entity.Property(e => e.Obr16163OrderingProviderNameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_16_3_OrderingProvider_NameContext_NameOfCodingSystem");
            entity.Property(e => e.Obr16164OrderingProviderNameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_16_4_OrderingProvider_NameContext_AlternateIdentifier");
            entity.Property(e => e.Obr16165OrderingProviderNameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_16_5_OrderingProvider_NameContext_AlternateText");
            entity.Property(e => e.Obr16166OrderingProviderNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_16_6_OrderingProvider_NameContext_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr16171OrderingProviderNameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_16_17_1_OrderingProvider_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Obr16172OrderingProviderNameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_16_17_2_OrderingProvider_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Obr1618OrderingProviderNameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_18_OrderingProvider_NameAssemblyOrder");
            entity.Property(e => e.Obr161OrderingProviderIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_1_OrderingProvider_IdNumber");
            entity.Property(e => e.Obr1621OrderingProviderFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_2_1_OrderingProvider_FamilyName_Surname");
            entity.Property(e => e.Obr1622OrderingProviderFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_2_2_OrderingProvider_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Obr1623OrderingProviderFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_2_3_OrderingProvider_FamilyName_OwnSurname");
            entity.Property(e => e.Obr1624OrderingProviderFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_2_4_OrderingProvider_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Obr1625OrderingProviderFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_2_5_OrderingProvider_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Obr163OrderingProviderGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_3_OrderingProvider_GivenName");
            entity.Property(e => e.Obr164OrderingProviderSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_4_OrderingProvider_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Obr165OrderingProviderSuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_5_OrderingProvider_Suffix");
            entity.Property(e => e.Obr166OrderingProviderPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_6_OrderingProvider_Prefix");
            entity.Property(e => e.Obr167OrderingProviderDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_7_OrderingProvider_Degree");
            entity.Property(e => e.Obr168OrderingProviderSourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_16_8_OrderingProvider_SourceTable");
            entity.Property(e => e.Obr1691OrderingProviderAssigningAuthorityNamespaceId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OBR_16_9_1_OrderingProvider_AssigningAuthority_NamespaceId");
            entity.Property(e => e.Obr1692OrderingProviderAssigningAuthorityUniversalId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OBR_16_9_2_OrderingProvider_AssigningAuthority_UniversalId");
            entity.Property(e => e.Obr1693OrderingProviderAssigningAuthorityUniversalIdType)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OBR_16_9_3_OrderingProvider_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Obr171OrderCallbackPhoneNumberTelephoneNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_1_OrderCallbackPhoneNumber_TelephoneNumber");
            entity.Property(e => e.Obr172OrderCallbackPhoneNumberTelecommunicationUseCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_2_OrderCallbackPhoneNumber_TelecommunicationUseCode");
            entity.Property(e => e.Obr173OrderCallbackPhoneNumberTelecommunicationEquipmentType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_3_OrderCallbackPhoneNumber_TelecommunicationEquipmentType");
            entity.Property(e => e.Obr174OrderCallbackPhoneNumberEmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_4_OrderCallbackPhoneNumber_EmailAddress");
            entity.Property(e => e.Obr175OrderCallbackPhoneNumberCountryCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_5_OrderCallbackPhoneNumber_CountryCode");
            entity.Property(e => e.Obr176OrderCallbackPhoneNumberAreaCityCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_6_OrderCallbackPhoneNumber_AreaCityCode");
            entity.Property(e => e.Obr177OrderCallbackPhoneNumberPhoneNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_7_OrderCallbackPhoneNumber_PhoneNumber");
            entity.Property(e => e.Obr178OrderCallbackPhoneNumberExtension)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_8_OrderCallbackPhoneNumber_Extension");
            entity.Property(e => e.Obr179OrderCallbackPhoneNumberAnyText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_17_9_OrderCallbackPhoneNumber_AnyText");
            entity.Property(e => e.Obr18PlacerField1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OBR_18_PlacerField1");
            entity.Property(e => e.Obr19PlacerField2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OBR_19_PlacerField2");
            entity.Property(e => e.Obr1SetIdObr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OBR_1_Set_ID_OBR");
            entity.Property(e => e.Obr20FillerField1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OBR_20_FillerField1");
            entity.Property(e => e.Obr21FillerField2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OBR_21_FillerField2");
            entity.Property(e => e.Obr21PlacerOrderNumberEntityIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_2_1_Placer_Order_Number_EntityIdentifier");
            entity.Property(e => e.Obr221ResultsRptStatusChngDateTimeOfAnEvent)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBR_22_1_ResultsRptStatusChngDate_TimeOfAnEvent");
            entity.Property(e => e.Obr222ResultsRptStatusChngDateTimeDegreeOfPrecision)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBR_22_2_ResultsRptStatusChngDateTime_DegreeOfPrecision");
            entity.Property(e => e.Obr22PlacerOrderNumberNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_2_2_Placer_Order_Number_NamespaceId");
            entity.Property(e => e.Obr2311ChargetoPracticeMocDollarAmountQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OBR_23_1_1_ChargetoPracticeMOC_DollarAmount_Quantity");
            entity.Property(e => e.Obr2312ChargetoPracticeMocDollarAmountDenomination)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OBR_23_1_2_ChargetoPracticeMOC_DollarAmount_Denomination");
            entity.Property(e => e.Obr2321ChargetoPracticeMocChargeCodeIdentifier)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OBR_23_2_1_ChargetoPracticeMOC_ChargeCode_Identifier");
            entity.Property(e => e.Obr2322ChargetoPracticeMocChargeCodeText)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OBR_23_2_2_ChargetoPracticeMOC_ChargeCode_Text");
            entity.Property(e => e.Obr2323ChargetoPracticeMocChargeCodeNameOfCodingSystem)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OBR_23_2_3_ChargetoPracticeMOC_ChargeCode_NameOfCodingSystem");
            entity.Property(e => e.Obr2324ChargetoPracticeMocChargeCodeAlternateIdentifier)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OBR_23_2_4_ChargetoPracticeMOC_ChargeCode_AlternateIdentifier");
            entity.Property(e => e.Obr2325ChargetoPracticeMocChargeCodeAlternateText)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OBR_23_2_5_ChargetoPracticeMOC_ChargeCode_AlternateText");
            entity.Property(e => e.Obr2326ChargetoPracticeMocChargeCodeNameOfAlternateCodingSystem)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OBR_23_2_6_ChargetoPracticeMOC_ChargeCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr23PlacerOrderNumberUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_2_3_Placer_Order_Number_UniversalId");
            entity.Property(e => e.Obr24DiagnosticServSectId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OBR_24_DiagnosticServSectID");
            entity.Property(e => e.Obr24PlacerOrderNumberUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_2_4_Placer_Order_Number_UniversalIdType");
            entity.Property(e => e.Obr25ResultStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OBR_25_Result_Status");
            entity.Property(e => e.Obr2611ParentResultObx3observationIdentifierOfParentResultIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_26_1_1_ParentResult_OBX3ObservationIdentifierOfParentResult_Identifier");
            entity.Property(e => e.Obr2612ParentResultObx3observationIdentifierOfParentResultText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_26_1_2_ParentResult_OBX3ObservationIdentifierOfParentResult_Text");
            entity.Property(e => e.Obr2613ParentResultObx3observationIdentifierOfParentResultNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_26_1_3_ParentResult_OBX3ObservationIdentifierOfParentResult_NameOfCodingSystem");
            entity.Property(e => e.Obr2614ParentResultObx3observationIdentifierOfParentResultAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_26_1_4_ParentResult_OBX3ObservationIdentifierOfParentResult_AlternateIdentifier");
            entity.Property(e => e.Obr2615ParentResultObx3observationIdentifierOfParentResultAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_26_1_5_ParentResult_OBX3ObservationIdentifierOfParentResult_AlternateText");
            entity.Property(e => e.Obr2616ParentResultObx3observationIdentifierOfParentResultNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_26_1_6_ParentResult_OBX3ObservationIdentifierOfParentResult_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr262ParentResultObx4subIdofParentResult)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("OBR_26_2_ParentResult_OBX4SubIDOfParentResult");
            entity.Property(e => e.Obr263ParentResultPartOfObx5observationResultFromParent)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("OBR_26_3_ParentResult_PartOfOBX_5ObservationResultFromParent");
            entity.Property(e => e.Obr271010QuantityTimingOrderSequencingFillerOrderNumberUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_10_QuantityTiming_OrderSequencing_FillerOrderNumberUniversalId");
            entity.Property(e => e.Obr271011QuantityTimingOrderSequencingFillerOrderNumberUniversaldType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_11_QuantityTiming_OrderSequencing_FillerOrderNumberUniversaldType");
            entity.Property(e => e.Obr27101QuantityTimingOrderSequencingSequenceResultsFlag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_1_QuantityTiming_OrderSequencing_SequenceResultsFlag");
            entity.Property(e => e.Obr27102QuantityTimingOrderSequencingPlaceOrderNumberEntityIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_2_QuantityTiming_OrderSequencing_PlaceOrderNumberEntityIdentifier");
            entity.Property(e => e.Obr27103QuantityTimingOrderSequencingPlaceOrderNumberNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_3_QuantityTiming_OrderSequencing_PlaceOrderNumberNamespaceId");
            entity.Property(e => e.Obr27104QuantityTimingOrderSequencingFillerOrderNumberEntityIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_4_QuantityTiming_OrderSequencing__FillerOrderNumberEntityIdentifier");
            entity.Property(e => e.Obr27105QuantityTimingOrderSequencingFillerOrderNumberNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_5_QuantityTiming_OrderSequencing_FillerOrderNumberNamespaceId");
            entity.Property(e => e.Obr27106QuantityTimingOrderSequencingSequenceConditionValue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_6_QuantityTiming_OrderSequencing_SequenceConditionValue");
            entity.Property(e => e.Obr27107QuantityTimingOrderSequencingMaximumNumberOfRepeats)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_7_QuantityTiming_OrderSequencing_MaximumNumberOfRepeats");
            entity.Property(e => e.Obr27108QuantityTimingOrderSequencingPlaceOrderNumberUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_8_QuantityTiming_OrderSequencing__PlaceOrderNumberUniversalId");
            entity.Property(e => e.Obr27109QuantityTimingOrderSequencingPlaceOrderNumberUniversalIdType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_10_9_QuantityTiming_OrderSequencing__PlaceOrderNumberUniversalIdType");
            entity.Property(e => e.Obr27111QuantityTimingOccurrenceDurationIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_11_1_QuantityTiming_OccurrenceDuration_Identifier");
            entity.Property(e => e.Obr27112QuantityTimingOccurrenceDurationText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_11_2_QuantityTiming_OccurrenceDuration_Text");
            entity.Property(e => e.Obr27113QuantityTimingOccurrenceDurationNameOfCodingSystem)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_11_3_QuantityTiming_OccurrenceDuration_NameOfCodingSystem");
            entity.Property(e => e.Obr27114QuantityTimingOccurrenceDurationIdentifierAlternateIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_11_4_QuantityTiming_OccurrenceDuration_Identifier_AlternateIdentifier");
            entity.Property(e => e.Obr27115QuantityTimingOccurrenceDurationIdentifierAlternateText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_11_5_QuantityTiming_OccurrenceDuration_Identifier_AlternateText");
            entity.Property(e => e.Obr27116QuantityTimingOccurrenceDurationIdentifierNameOfAlternateCodingSystem)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_11_6_QuantityTiming_OccurrenceDuration_Identifier_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr2711QuantityTimingQuantityQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OBR_27_1_1_QuantityTiming_Quantity_Quantity");
            entity.Property(e => e.Obr2712QuantityTimingQuantityUnits)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_1_2_QuantityTiming_Quantity_Units");
            entity.Property(e => e.Obr2712QuantityTimingTotalOccurences)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OBR_27_12_QuantityTiming_TotalOccurences");
            entity.Property(e => e.Obr2721QuantityTimingIntervalRepeatPattern)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_2_1_QuantityTiming_Interval_RepeatPattern");
            entity.Property(e => e.Obr2722QuantityTimingIntervalExplicitTimeInterval)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_2_2_QuantityTiming_Interval_ExplicitTimeInterval");
            entity.Property(e => e.Obr273QuantityTimingDuration)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_3_QuantityTiming_Duration");
            entity.Property(e => e.Obr274QuantityTimingStartDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_27_4_QuantityTiming_StartDatetime");
            entity.Property(e => e.Obr275QuantityTimingEndDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_27_5_QuantityTiming_EndDatetime");
            entity.Property(e => e.Obr276QuantityTimingPriority)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_6_QuantityTiming_Priority");
            entity.Property(e => e.Obr277QuantityTimingCondition)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_7_QuantityTiming_Condition");
            entity.Property(e => e.Obr278QuantityTimingText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_8_QuantityTiming_Text");
            entity.Property(e => e.Obr279QuantityTimingConjunctionComponent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_27_9_QuantityTiming_Conjunction_Component");
            entity.Property(e => e.Obr2810ResultCopiesToNameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_10_ResultCopiesTo_NameTypeCode");
            entity.Property(e => e.Obr2811ResultCopiesToIdentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_11_ResultCopiesTo_IdentifierCheckDigit");
            entity.Property(e => e.Obr2812ResultCopiesToCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_12_ResultCopiesTo_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Obr2813ResultCopiesToIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_13_ResultCopiesTo_Identifier_Type_Code");
            entity.Property(e => e.Obr28141ResultCopiesToAssigningFacilityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_14_1_ResultCopiesTo_AssigningFacility_NamespaceId");
            entity.Property(e => e.Obr28142ResultCopiesToAssigningFacilityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_14_2_ResultCopiesTo_AssigningFacility_UniversalId");
            entity.Property(e => e.Obr28143ResultCopiesToAssigningFacilityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_14_3_ResultCopiesTo_AssigningFacility_UniversalIdType");
            entity.Property(e => e.Obr2815ResultCopiesToNameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_15_ResultCopiesTo_Name_Representation_Code");
            entity.Property(e => e.Obr28161ResultCopiesToNameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_16_1_ResultCopiesTo_NameContext_Identifier");
            entity.Property(e => e.Obr28162ResultCopiesToNameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_16_2_ResultCopiesTo_NameContext_Text");
            entity.Property(e => e.Obr28163ResultCopiesToNameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_16_3_ResultCopiesTo_NameContext_NameOfCodingSystem");
            entity.Property(e => e.Obr28164ResultCopiesToNameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_16_4_ResultCopiesTo_NameContext_AlternateIdentifier");
            entity.Property(e => e.Obr28165ResultCopiesToNameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_16_5_ResultCopiesTo_NameContext_AlternateText");
            entity.Property(e => e.Obr28166ResultCopiesToNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_16_6_ResultCopiesTo_NameContext_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr28171ResultCopiesToNameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_28_17_1_ResultCopiesTo_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Obr28172ResultCopiesToNameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_28_17_2_ResultCopiesTo_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Obr2818ResultCopiesToNameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_18_ResultCopiesTo_NameAssemblyOrder");
            entity.Property(e => e.Obr281ResultCopiesToIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_1_ResultCopiesTo_IdNumber");
            entity.Property(e => e.Obr2821ResultCopiesToFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_2_1_ResultCopiesTo_FamilyName_Surname");
            entity.Property(e => e.Obr2822ResultCopiesToFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_2_2_ResultCopiesTo_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Obr2823ResultCopiesToFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_2_3_ResultCopiesTo_FamilyName_OwnSurname");
            entity.Property(e => e.Obr2824ResultCopiesToFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_2_4_ResultCopiesTo_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Obr2825ResultCopiesToFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_2_5_ResultCopiesTo_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Obr283ResultCopiesToGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_3_ResultCopiesTo_GivenName");
            entity.Property(e => e.Obr284ResultCopiesToSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_4_ResultCopiesTo_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Obr285ResultCopiesToSuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_5_ResultCopiesTo_Suffix");
            entity.Property(e => e.Obr286ResultCopiesToPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_6_ResultCopiesTo_Prefix");
            entity.Property(e => e.Obr287ResultCopiesToDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_7_ResultCopiesTo_Degree");
            entity.Property(e => e.Obr288ResultCopiesToSourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_8_ResultCopiesTo_SourceTable");
            entity.Property(e => e.Obr2891ResultCopiesToAssigningAuthorityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_9_1_ResultCopiesTo_AssigningAuthority_NamespaceId");
            entity.Property(e => e.Obr2892ResultCopiesToAssigningAuthorityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_9_2_ResultCopiesTo_AssigningAuthority_UniversalId");
            entity.Property(e => e.Obr2893ResultCopiesToAssigningAuthorityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_28_9_3_ResultCopiesTo_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Obr291ParentNumberParentsPlacerOrderNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_29_1_ParentNumber_ParentsPlacerOrderNumber");
            entity.Property(e => e.Obr292ParentNumberParentsFillerOrderNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_29_2_ParentNumber_ParentsFillerOrderNumber");
            entity.Property(e => e.Obr30TransportationMode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBR_30_Transportation_Mode");
            entity.Property(e => e.Obr311ReasonforStudyIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_31_1_ReasonforStudy_Identifier");
            entity.Property(e => e.Obr312ReasonForStudyText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_31_2_Reason_for_Study_Text");
            entity.Property(e => e.Obr313ReasonforStudyNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_31_3_ReasonforStudy_NameOfCodingSystem");
            entity.Property(e => e.Obr314ReasonforStudyAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_31_4_ReasonforStudy_AlternateIdentifier");
            entity.Property(e => e.Obr315ReasonforStudyAlternateExt)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_31_5_ReasonforStudy_Alternate_ext");
            entity.Property(e => e.Obr316ReasonforStudyNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_31_6_ReasonforStudy_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr31FillerOrderNumberEntityIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_3_1_Filler_Order_Number_EntityIdentifier");
            entity.Property(e => e.Obr3210PrincipalResultInterpreterBuilding)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_10_PrincipalResultInterpreter_Building");
            entity.Property(e => e.Obr32110PrincipalResultInterpreterOpnameAssigningAuthorityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_10_PrincipalResultInterpreter_OPName_AssigningAuthorityUniversalID");
            entity.Property(e => e.Obr32111PrincipalResultInterpreterOpnameAssigningAuthorityUniversalIdtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_11_PrincipalResultInterpreter_OPName_AssigningAuthorityUniversalIDType");
            entity.Property(e => e.Obr3211PrincipalResultInterpreterFloor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_11_PrincipalResultInterpreter_Floor");
            entity.Property(e => e.Obr3211PrincipalResultInterpreterOpnameIdnumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_1_PrincipalResultInterpreter_OPName_IDNumber");
            entity.Property(e => e.Obr3212PrincipalResultInterpreterOpnameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_2_PrincipalResultInterpreter_OPName_FamilyName");
            entity.Property(e => e.Obr3213PrincipalResultInterpreterOpnameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_3_PrincipalResultInterpreter_OPName_GivenName");
            entity.Property(e => e.Obr3214PrincipalResultInterpreterOpnameSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_4_PrincipalResultInterpreter_OPName_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Obr3215PrincipalResultInterpreterOpnameSuffix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_5_PrincipalResultInterpreter_OPName_Suffix");
            entity.Property(e => e.Obr3216PrincipalResultInterpreterOpnamePrefix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_6_PrincipalResultInterpreter_OPName_Prefix");
            entity.Property(e => e.Obr3217PrincipalResultInterpreterOpnameDegree)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_7_PrincipalResultInterpreter_OPName_Degree");
            entity.Property(e => e.Obr3218PrincipalResultInterpreterOpnameSourceTable)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_8_PrincipalResultInterpreter_OPName_SourceTable");
            entity.Property(e => e.Obr3219PrincipalResultInterpreterOpnameAssigningAuthorityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_1_9_PrincipalResultInterpreter_OPName_AssigningAuthorityNamespaceID");
            entity.Property(e => e.Obr322PrincipalResultInterpreterStartDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_32_2_PrincipalResultInterpreter_StartDatetime");
            entity.Property(e => e.Obr323PrincipalResultInterpreterEndDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_32_3_PrincipalResultInterpreter_EndDatetime");
            entity.Property(e => e.Obr324PrincipalResultInterpreterPointOfCare)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_4_PrincipalResultInterpreter_PointOfCare");
            entity.Property(e => e.Obr325PrincipalResultInterpreterRoom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_5_PrincipalResultInterpreter_Room");
            entity.Property(e => e.Obr326PrincipalResultInterpreterBed)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_6_PrincipalResultInterpreter_Bed");
            entity.Property(e => e.Obr3271PrincipalResultInterpreterFacilityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_7_1_PrincipalResultInterpreter_Facility_NamespaceId");
            entity.Property(e => e.Obr3272PrincipalResultInterpreterFacilityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_7_2_PrincipalResultInterpreter_Facility_UniversalId");
            entity.Property(e => e.Obr3273PrincipalResultInterpreterFacilityUniversalIdType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_7_3_PrincipalResultInterpreter_Facility_UniversalIdType");
            entity.Property(e => e.Obr328PrincipalResultInterpreterLocationStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_8_PrincipalResultInterpreter_Location_Status");
            entity.Property(e => e.Obr329PrincipalResultInterpreterPersonLocationType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_32_9_PrincipalResultInterpreter_PersonLocationType");
            entity.Property(e => e.Obr32FillerOrderNumberNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_3_2_Filler_Order_Number_NamespaceId");
            entity.Property(e => e.Obr3310AssistantResultInterpreterBuilding)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_10_AssistantResultInterpreter_Building");
            entity.Property(e => e.Obr33110AssistantResultInterpreterOpnameAssigningAuthorityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_10_AssistantResultInterpreter_OPName_AssigningAuthorityUniversalID");
            entity.Property(e => e.Obr33111AssistantResultInterpreterOpnameAssigningAuthorityUniversalIdtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_11_AssistantResultInterpreter_OPName_AssigningAuthorityUniversalIDType");
            entity.Property(e => e.Obr3311AssistantResultInterpreterFloor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_11_AssistantResultInterpreter_Floor");
            entity.Property(e => e.Obr3311AssistantResultInterpreterOpnameIdnumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_1_AssistantResultInterpreter_OPName_IDNumber");
            entity.Property(e => e.Obr3312AssistantResultInterpreterOpnameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_2_AssistantResultInterpreter_OPName_FamilyName");
            entity.Property(e => e.Obr3313AssistantResultInterpreterOpnameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_3_AssistantResultInterpreter_OPName_GivenName");
            entity.Property(e => e.Obr3314AssistantResultInterpreterOpnameSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_4_AssistantResultInterpreter_OPName_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Obr3315AssistantResultInterpreterOpnameSuffix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_5_AssistantResultInterpreter_OPName_Suffix");
            entity.Property(e => e.Obr3316AssistantResultInterpreterOpnamePrefix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_6_AssistantResultInterpreter_OPName_Prefix");
            entity.Property(e => e.Obr3317AssistantResultInterpreterOpnameDegree)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_7_AssistantResultInterpreter_OPName_Degree");
            entity.Property(e => e.Obr3318AssistantResultInterpreterOpnameSourceTable)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_8_AssistantResultInterpreter_OPName_SourceTable");
            entity.Property(e => e.Obr3319AssistantResultInterpreterOpnameAssigningAuthorityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_1_9_AssistantResultInterpreter_OPName_AssigningAuthorityNamespaceID");
            entity.Property(e => e.Obr332AssistantResultInterpreterStartDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_33_2_AssistantResultInterpreter_StartDatetime");
            entity.Property(e => e.Obr333AssistantResultInterpreterEndDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_33_3_AssistantResultInterpreter_EndDatetime");
            entity.Property(e => e.Obr334AssistantResultInterpreterPointOfCare)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_4_AssistantResultInterpreter_PointOfCare");
            entity.Property(e => e.Obr335AssistantResultInterpreterRoom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_5_AssistantResultInterpreter_Room");
            entity.Property(e => e.Obr336AssistantResultInterpreterBed)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_6_AssistantResultInterpreter_Bed");
            entity.Property(e => e.Obr3371AssistantResultInterpreterFacilityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_7_1_AssistantResultInterpreter_Facility_NamespaceID");
            entity.Property(e => e.Obr3372AssistantResultInterpreterFacilityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_7_2_AssistantResultInterpreter_Facility_UniversalID");
            entity.Property(e => e.Obr3373AssistantResultInterpreterFacilityUniversalIdtype)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OBR_33_7_3_AssistantResultInterpreter_Facility_UniversalIDType");
            entity.Property(e => e.Obr338AssistantResultInterpreterLocationStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_8_AssistantResultInterpreter_LocationStatus");
            entity.Property(e => e.Obr339AssistantResultInterpreterPersonLocationType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_33_9_AssistantResultInterpreter_PersonLocationType");
            entity.Property(e => e.Obr33FillerOrderNumberUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_3_3_Filler_Order_Number_UniversalId");
            entity.Property(e => e.Obr3410TechnicianBuilding)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_10_Technician_Building");
            entity.Property(e => e.Obr34110TechnicianOpnameAssigningAuthorityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_10_Technician_OPName_AssigningAuthorityUniversalID");
            entity.Property(e => e.Obr34111TechnicianOpnameAssigningAuthorityUniversalIdtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_11_Technician_OPName_AssigningAuthorityUniversalIDType");
            entity.Property(e => e.Obr3411TechnicianFloor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_11_Technician_Floor");
            entity.Property(e => e.Obr3411TechnicianOpnameIdnumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_1_Technician_OPName_IDNumber");
            entity.Property(e => e.Obr3412TechnicianOpnameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_2_Technician_OPName_FamilyName");
            entity.Property(e => e.Obr3413TechnicianOpnameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_3_Technician_OPName_GivenName");
            entity.Property(e => e.Obr3414TechnicianOpnameSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_4_Technician_OPName_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Obr3415TechnicianOpnameSuffix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_5_Technician_OPName_Suffix");
            entity.Property(e => e.Obr3416TechnicianOpnamePrefix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_6_Technician_OPName_Prefix");
            entity.Property(e => e.Obr3417TechnicianOpnameDegree)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_7_Technician_OPName_Degree");
            entity.Property(e => e.Obr3418TechnicianOpnameSourceTable)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_8_Technician_OPName_SourceTable");
            entity.Property(e => e.Obr3419TechnicianOpnameAssigningAuthorityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_1_9_Technician_OPName_AssigningAuthorityNamespaceID");
            entity.Property(e => e.Obr342TechnicianStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_34_2_Technician_Start_Date_time");
            entity.Property(e => e.Obr343TechnicianEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_34_3_Technician_End_Date_time");
            entity.Property(e => e.Obr344TechnicianPointOfCare)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_4_Technician_PointOfCare");
            entity.Property(e => e.Obr345TechnicianRoom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_5_Technician_Room");
            entity.Property(e => e.Obr346TechnicianBed)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_6_Technician_Bed");
            entity.Property(e => e.Obr3471TechnicianFacilityNamespaceId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OBR_34_7_1_Technician_Facility_NamespaceID");
            entity.Property(e => e.Obr3472TechnicianFacilityUniversalId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OBR_34_7_2_Technician_Facility_UniversalID");
            entity.Property(e => e.Obr3473TechnicianFacilityUniversalIdtype)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OBR_34_7_3_Technician_Facility_UniversalIDType");
            entity.Property(e => e.Obr348TechnicianLocationStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_8_Technician_LocationStatus");
            entity.Property(e => e.Obr349TechnicianPersonLocationType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_34_9_Technician_PersonLocationType");
            entity.Property(e => e.Obr34FillerOrderNumberUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_3_4_Filler_Order_Number_UniversalIdType");
            entity.Property(e => e.Obr3510TranscriptionistBuilding)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_10_Transcriptionist_Building");
            entity.Property(e => e.Obr35110TranscriptionistOpnameAssigningAuthorityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_10_Transcriptionist_OPName_AssigningAuthorityUniversalID");
            entity.Property(e => e.Obr3511TranscriptionistFloor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_11_Transcriptionist_Floor");
            entity.Property(e => e.Obr3511TranscriptionistOpnameIdnumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_1_Transcriptionist_OPName_IDNumber");
            entity.Property(e => e.Obr3512TranscriptionistOpnameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_2_Transcriptionist_OPName_FamilyName");
            entity.Property(e => e.Obr3513TranscriptionistOpnameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_3_Transcriptionist_OPName_GivenName");
            entity.Property(e => e.Obr3514TranscriptionistOpnameSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_4_Transcriptionist_OPName_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Obr3515TranscriptionistOpnameSuffix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_5_Transcriptionist_OPName_Suffix");
            entity.Property(e => e.Obr3516TranscriptionistOpnamePrefix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_6_Transcriptionist_OPName_Prefix");
            entity.Property(e => e.Obr3517TranscriptionistOpnameDegree)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_7_Transcriptionist_OPName_Degree");
            entity.Property(e => e.Obr3518TranscriptionistOpnameSourceTable)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_8_Transcriptionist_OPName_SourceTable");
            entity.Property(e => e.Obr3519TranscriptionistOpnameAssigningAuthorityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_1_9_Transcriptionist_OPName_AssigningAuthorityNamespaceID");
            entity.Property(e => e.Obr352TranscriptionistStartDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_35_2_Transcriptionist_StartDatetime");
            entity.Property(e => e.Obr353TranscriptionistEndDatetime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_35_3_Transcriptionist_EndDatetime");
            entity.Property(e => e.Obr354TranscriptionistPointOfCare)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_4_Transcriptionist_PointOfCare");
            entity.Property(e => e.Obr355TranscriptionistRoom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_5_Transcriptionist_Room");
            entity.Property(e => e.Obr356TranscriptionistBed)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_6_Transcriptionist_Bed");
            entity.Property(e => e.Obr3571TranscriptionistFacilityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_7_1_Transcriptionist_Facility_NamespaceID");
            entity.Property(e => e.Obr3572TranscriptionistFacilityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_7_2_Transcriptionist_Facility_UniversalID");
            entity.Property(e => e.Obr3573TranscriptionistFacilityUniversalIdtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_7_3_Transcriptionist_Facility_UniversalIDType");
            entity.Property(e => e.Obr358TranscriptionistLocationStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_8_Transcriptionist_LocationStatus");
            entity.Property(e => e.Obr359TranscriptionistPersonLocationType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBR_35_9_Transcriptionist__PersonLocationType");
            entity.Property(e => e.Obr36ScheduledDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBR_36_Scheduled_Date_Time");
            entity.Property(e => e.Obr37NumberOfSampleContainers)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OBR_37_Number_of_Sample_Containers");
            entity.Property(e => e.Obr381TransportLogisticsofCollectedSampleIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_38_1_TransportLogisticsofCollectedSample_Identifier");
            entity.Property(e => e.Obr382TransportLogisticsofCollectedSampleText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_38_2_TransportLogisticsofCollectedSample_Text");
            entity.Property(e => e.Obr383TransportLogisticsofCollectedSampleNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_38_3_TransportLogisticsofCollectedSample_NameOfCodingSystem");
            entity.Property(e => e.Obr384TransportLogisticsofCollectedSampleAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_38_4_TransportLogisticsofCollectedSample_AlternateIdentifier");
            entity.Property(e => e.Obr385TransportLogisticsofCollectedSampleAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_38_5_TransportLogisticsofCollectedSample_AlternateText");
            entity.Property(e => e.Obr386TransportLogisticsofCollectedSampleNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_38_6_TransportLogisticsofCollectedSample_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr391CollectorsCommentIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_39_1_CollectorsComment_Identifier");
            entity.Property(e => e.Obr392CollectorsCommentText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_39_2_CollectorsComment_Text");
            entity.Property(e => e.Obr393CollectorsCommentNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_39_3_CollectorsComment_NameOfCodingSystem");
            entity.Property(e => e.Obr394CollectorsCommentAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_39_4_CollectorsComment_AlternateIdentifier");
            entity.Property(e => e.Obr395CollectorsCommentAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_39_5_CollectorsComment_AlternateText");
            entity.Property(e => e.Obr396CollectorsCommentNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_39_6_CollectorsComment_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr401TransportArrangementResponsibilityIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_40_1_TransportArrangementResponsibility_Identifier");
            entity.Property(e => e.Obr402TransportArrangementResponsibilityText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_40_2_TransportArrangementResponsibility_Text");
            entity.Property(e => e.Obr403TransportArrangementResponsibilityNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_40_3_TransportArrangementResponsibility_NameOfCodingSystem");
            entity.Property(e => e.Obr404TransportArrangementResponsibilityAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_40_4_TransportArrangementResponsibility_AlternateIdentifier");
            entity.Property(e => e.Obr405TransportArrangementResponsibilityAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_40_5_TransportArrangementResponsibility_AlternateText");
            entity.Property(e => e.Obr406TransportArrangementResponsibilityNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_40_6_TransportArrangementResponsibility_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr41TransportArranged)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OBR_41_Transport_Arranged");
            entity.Property(e => e.Obr41UniversalServiceDentifierIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_4_1_UniversalService_dentifier_Identifier");
            entity.Property(e => e.Obr42EscortRequired)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OBR_42_Escort_Required");
            entity.Property(e => e.Obr42UniversalServiceIdentifierText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_4_2_UniversalServiceIdentifier_Text");
            entity.Property(e => e.Obr431PlannedPatientTransportCommentIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_43_1_PlannedPatientTransportComment_Identifier");
            entity.Property(e => e.Obr432PlannedPatientTransportCommentText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_43_2_PlannedPatientTransportComment_Text");
            entity.Property(e => e.Obr433PlannedPatientTransportCommentNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_43_3_PlannedPatientTransportComment_NameOfCodingSystem");
            entity.Property(e => e.Obr434PlannedPatientTransportCommentAlternateIdentifierr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_43_4_PlannedPatientTransportComment_AlternateIdentifierr");
            entity.Property(e => e.Obr435PlannedPatientTransportCommentAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_43_5_PlannedPatientTransportComment_AlternateText");
            entity.Property(e => e.Obr436PlannedPatientTransportCommentNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_43_6_PlannedPatientTransportComment_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr43UniversalServiceIdentifierNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_4_3_UniversalServiceIdentifier_NameOfCodingSystem");
            entity.Property(e => e.Obr441ProcedureCodeIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_44_1_ProcedureCode_Identifier");
            entity.Property(e => e.Obr442ProcedureCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_44_2_ProcedureCode_Text");
            entity.Property(e => e.Obr443ProcedureCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_44_3_ProcedureCode_NameOfCodingSystem");
            entity.Property(e => e.Obr444ProcedureCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_44_4_ProcedureCode_Alternate_Identifier");
            entity.Property(e => e.Obr445ProcedureCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_44_5_ProcedureCode_AlternateText");
            entity.Property(e => e.Obr446ProcedureCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_44_6_ProcedureCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr44UniversalServiceIdentifierAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_4_4_UniversalServiceIdentifier_AlternateIdentifier");
            entity.Property(e => e.Obr451ProcedureCodeModifierIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_45_1_ProcedureCodeModifier_Identifier");
            entity.Property(e => e.Obr452ProcedureCodeModifierText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_45_2_ProcedureCodeModifier_Text");
            entity.Property(e => e.Obr453ProcedureCodeModifierNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_45_3_ProcedureCodeModifier_NameOfCodingSystem");
            entity.Property(e => e.Obr454ProcedureCodeModifierAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_45_4_ProcedureCodeModifier_AlternateIdentifier");
            entity.Property(e => e.Obr455ProcedureCodeModifierAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_45_5_ProcedureCodeModifier_AlternateText");
            entity.Property(e => e.Obr456ProcedureCodeModifierNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_45_6_ProcedureCodeModifier_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr45UniversalServiceIdentifierAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_4_5_UniversalServiceIdentifier_AlternateText");
            entity.Property(e => e.Obr461PlacerSupplementalServiceInformationIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_46_1_PlacerSupplementalServiceInformation_Identifier");
            entity.Property(e => e.Obr462PlacerSupplementalServiceInformationText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_46_2_PlacerSupplementalServiceInformation_Text");
            entity.Property(e => e.Obr463PlacerSupplementalServiceInformationNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_46_3_PlacerSupplementalServiceInformation_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr464PlacerSupplementalServiceInformationAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_46_4_PlacerSupplementalServiceInformation_AlternateIdentifier");
            entity.Property(e => e.Obr465PlacerSupplementalServiceInformationAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_46_5_PlacerSupplementalServiceInformation_Alternate_Text");
            entity.Property(e => e.Obr466PlacerSupplementalServiceInformationNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_46_6_PlacerSupplementalServiceInformation_NameOfCodingSystem");
            entity.Property(e => e.Obr46UniversalServiceIdentifierNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_4_6_UniversalServiceIdentifier_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr471FillerSupplementalServiceInformationIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_47_1_FillerSupplementalServiceInformation_Identifier");
            entity.Property(e => e.Obr472FillerSupplementalServiceInformationText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_47_2_FillerSupplementalServiceInformation_Text");
            entity.Property(e => e.Obr473FillerSupplementalServiceInformationNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_47_3_FillerSupplementalServiceInformation_Name_Of_Coding_System");
            entity.Property(e => e.Obr474FillerSupplementalServiceInformationAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_47_4_FillerSupplementalServiceInformation_AlternateIdentifier");
            entity.Property(e => e.Obr475FillerSupplementalServiceInformationAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_47_5_FillerSupplementalServiceInformation_AlternateText");
            entity.Property(e => e.Obr476FillerSupplementalServiceInformationNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBR_47_6_FillerSupplementalServiceInformation_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obr5Priority)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OBR_5_Priority");
            entity.Property(e => e.Obr61RequestedDateTimeTimeOfEvent)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBR_6_1_Requested_DateTime_TimeOfEvent");
            entity.Property(e => e.Obr62RequestedDateTimeDegreeOfPrecision)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBR_6_2_Requested_DateTime_DegreeOfPrecision");
            entity.Property(e => e.Obr71ObservationDateTimeTimeOfEvent)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBR_7_1_Observation_DateTime_TimeOfEvent");
            entity.Property(e => e.Obr72ObservationDateTimeDegreeOfPrecision)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBR_7_2_Observation_DateTime_DegreeOfPrecision");
            entity.Property(e => e.Obr81ObservationEndDateTimeTimeOfEvent)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBR_8_1_Observation_End_DateTime_TimeOfEvent");
            entity.Property(e => e.Obr82ObservationEndDateTimeDegreeOfPrecision)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBR_8_2_Observation_End_DateTime_DegreeOfPrecision");
            entity.Property(e => e.Obr91CollectionVolumeQuantity)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBR_9_1_CollectionVolume_Quantity");
            entity.Property(e => e.Obr92CollectionVolumeUnits)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBR_9_2_CollectionVolume_Units");

            entity.HasOne(d => d.FkOrc).WithMany(p => p.ObrObservationRequests)
                .HasForeignKey(d => d.FkOrcId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ORC_ID");
        });

        modelBuilder.Entity<ObxObservationOriginalLabMessage>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__OBX_Obse__7839F62D4B852870");

            entity.ToTable("OBX_Observation_Original_Lab_Messages", "HL7");

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_HL7UniqueIdentifier").HasFillFactor(80);

            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.CaseNo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeInserted).HasColumnType("datetime");
            entity.Property(e => e.FkObrId).HasColumnName("fk_OBR_ID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.LabOriginalMessage).IsUnicode(false);
            entity.Property(e => e.StorageApiArchiveFailed)
                .HasDefaultValueSql("((0))")
                .HasColumnName("StorageApi_ArchiveFailed");
            entity.Property(e => e.StorageApiFileId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("StorageApi_FileId");

            entity.HasOne(d => d.FkObr).WithMany(p => p.ObxObservationOriginalLabMessages)
                .HasForeignKey(d => d.FkObrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_OBR_ID_OLM");
        });

        modelBuilder.Entity<ObxObservationResult>(entity =>
        {
            entity.HasKey(e => e.PkObxId);

            entity.ToTable("OBX_ObservationResult", "HL7");

            entity.HasIndex(e => e.FkObrId, "NCI_FKOBRID_ALL").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_HL7UniqueIdentifier");

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_Hl7_OBX14").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLog").HasFillFactor(80);

            entity.Property(e => e.PkObxId).HasColumnName("pk_OBX_ID");
            entity.Property(e => e.FkObrId).HasColumnName("fk_OBR_ID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Obx10NatureOfAbnormalText)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_10_NatureOfAbnormalText");
            entity.Property(e => e.Obx11ObservationResultStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_11_ObservationResultStatus");
            entity.Property(e => e.Obx121DateLastObservationNormalValueTimeOfEvent)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBX_12_1_DateLastObservationNormalValue_TimeOfEvent");
            entity.Property(e => e.Obx122DateLastObservationNormalValueDegreeOfPrecision)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBX_12_2_DateLastObservationNormalValue_DegreeOfPrecision");
            entity.Property(e => e.Obx13UserDefindedAccessChecks)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBX_13_UserDefindedAccessChecks");
            entity.Property(e => e.Obx141DateTimeOfObservationTimeOfEvent)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBX_14_1_DateTimeOfObservation_TimeOfEvent");
            entity.Property(e => e.Obx142DateTimeOfObservationDegreeOfPrecision)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBX_14_2_DateTimeOfObservation_DegreeOfPrecision");
            entity.Property(e => e.Obx151ProducersIdIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_15_1_ProducersID_Identifier");
            entity.Property(e => e.Obx152ProducersIdText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_15_2_ProducersID_Text");
            entity.Property(e => e.Obx153ProducersIdNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_15_3_ProducersID_NameOfCodingSystem");
            entity.Property(e => e.Obx154ProducersIdAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_15_4_ProducersID_AlternateIdentifier");
            entity.Property(e => e.Obx155ProducersIdAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_15_5_ProducersID_AlternateText");
            entity.Property(e => e.Obx156ProducersIdNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_15_6_ProducersID_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obx1610ResponsibleObserverNameTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_10_ResponsibleObserver_NameTypeCode");
            entity.Property(e => e.Obx1611ResponsibleObserverIdentifierCheckDigit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_11_ResponsibleObserver_IdentifierCheckDigit");
            entity.Property(e => e.Obx1612ResponsibleObserverCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_12_ResponsibleObserver_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Obx1613ResponsibleObserverIdentifierTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_13_ResponsibleObserver_IdentifierTypeCode");
            entity.Property(e => e.Obx16141ResponsibleObserverAssigningFacilityNamespaceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_14_1_ResponsibleObserver_AssigningFacility_NamespaceId");
            entity.Property(e => e.Obx16142ResponsibleObserverAssigningFacilityUniversalId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_14_2_ResponsibleObserver_AssigningFacility_UniversalId");
            entity.Property(e => e.Obx16143ResponsibleObserverAssigningFacilityUniversalIdType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_14_3_ResponsibleObserver_AssigningFacility_UniversalIdType");
            entity.Property(e => e.Obx1615ResponsibleObserverNameRepresentationCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_15_ResponsibleObserver_NameRepresentationCode");
            entity.Property(e => e.Obx16161ResponsibleObserverNameContextIdentifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_16_1_ResponsibleObserver_NameContext_Identifier");
            entity.Property(e => e.Obx16162ResponsibleObserverNameContextText)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_16_2_ResponsibleObserver_NameContext_Text");
            entity.Property(e => e.Obx16163ResponsibleObserverNameContextNameOfCodingSystem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_16_3_ResponsibleObserver_NameContext_NameOfCodingSystem");
            entity.Property(e => e.Obx16164ResponsibleObserverNameContextAlternateIdentifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_16_4_ResponsibleObserver_NameContext_AlternateIdentifier");
            entity.Property(e => e.Obx16165ResponsibleObserverNameContextAlternateText)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_16_5_ResponsibleObserver_NameContext_AlternateText");
            entity.Property(e => e.Obx16166ResponsibleObserverNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_16_6_ResponsibleObserver_NameContext_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obx16171NameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBX_16_17_1_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Obx16172NameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("OBX_16_17_2_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Obx1618NameAssemblyOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_18_NameAssemblyOrder");
            entity.Property(e => e.Obx161ResponsibleObserverIdnumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_16_1_ResponsibleObserver_IDNumber");
            entity.Property(e => e.Obx1621ResponsibleObserverFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_16_2_1_ResponsibleObserver_FamilyName_Surname");
            entity.Property(e => e.Obx1622ResponsibleObserverFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_16_2_2_ResponsibleObserver_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Obx1623ResponsibleObserverFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_16_2_3_ResponsibleObserver_FamilyName_OwnSurname");
            entity.Property(e => e.Obx1624ResponsibleObserverFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_16_2_4_ResponsibleObserver_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Obx1625ResponsibleObserverFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_16_2_5_ResponsibleObserver_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Obx163ResponsibleObserverGivenName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_3_ResponsibleObserverGiven_Name");
            entity.Property(e => e.Obx164ResponsibleObserverSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_4_ResponsibleObserver_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Obx165ResponsibleObserverSuffix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_5_ResponsibleObserver_Suffix");
            entity.Property(e => e.Obx166ResponsibleObserverPrefix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_6_ResponsibleObserver_Prefix");
            entity.Property(e => e.Obx167ResponsibleObserverDegree)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_7_ResponsibleObserver_Degree");
            entity.Property(e => e.Obx168ResponsibleObserverSourceTable)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_8_ResponsibleObserver_SourceTable");
            entity.Property(e => e.Obx1691ResponsibleObserverAssigningAuthorityNamespaceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_9_1_ResponsibleObserver_AssigningAuthority_NamespaceId");
            entity.Property(e => e.Obx1692ResponsibleObserverAssigningAuthorityUniversalId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_9_2_ResponsibleObserver_AssigningAuthority_UniversalId");
            entity.Property(e => e.Obx1693ResponsibleObserverAssigningAuthorityUniversalIdType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_16_9_3_ResponsibleObserver_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Obx171ObservationMethodIdentifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_17_1_ObservationMethod_Identifier");
            entity.Property(e => e.Obx172ObservationMethodText)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_17_2_ObservationMethod_Text");
            entity.Property(e => e.Obx173ObservationMethodNameOfCodingSystem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_17_3_ObservationMethod_NameOfCodingSystem");
            entity.Property(e => e.Obx174ObservationMethodAlternateIdentifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_17_4_ObservationMethod_AlternateIdentifier");
            entity.Property(e => e.Obx175ObservationMethodAlternateText)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_17_5_ObservationMethod_AlternateText");
            entity.Property(e => e.Obx176ObservationMethodNameOfAlternateCodingSystem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_17_6_ObservationMethod_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obx181EquipmentInstanceIdentifierEntityIdentifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_18_1_EquipmentInstanceIdentifier_EntityIdentifier");
            entity.Property(e => e.Obx182EquipmentInstanceIdentifierNamespaceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_18_2_EquipmentInstanceIdentifier_NamespaceId");
            entity.Property(e => e.Obx183EquipmentInstanceIdentifierUniversalId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_18_3_EquipmentInstanceIdentifier_UniversalId");
            entity.Property(e => e.Obx184EquipmentInstanceIdentifierUniversalIdType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_18_4_EquipmentInstanceIdentifier_UniversalIdType");
            entity.Property(e => e.Obx191DateTimeOfAnalysisTimeOfEvent)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBX_19_1_DateTimeOfAnalysis_TimeOfEvent");
            entity.Property(e => e.Obx192DateTimeOfAnalysis2DegreeOfPrecision)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("OBX_19_2_DateTimeOfAnalysis_2_DegreeOfPrecision");
            entity.Property(e => e.Obx1SetIdobx).HasColumnName("OBX_1_SetIDOBX");
            entity.Property(e => e.Obx2ValueType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_2_ValueType");
            entity.Property(e => e.Obx31ObservationIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_3_1_ObservationIdentifier");
            entity.Property(e => e.Obx32ObservationIdentifierText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_3_2_ObservationIdentifierText");
            entity.Property(e => e.Obx33ObservationIdentifierNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_3_3_ObservationIdentifierNameOfCodingSystem");
            entity.Property(e => e.Obx34ObservationIdentifierAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_3_4_ObservationIdentifierAlternateIdentifier");
            entity.Property(e => e.Obx35ObservationIdentifierAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_3_5_ObservationIdentifierAlternateText");
            entity.Property(e => e.Obx36ObservationIdentifierNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_3_6_ObservationIdentifierNameOfAlternateCodingSystem");
            entity.Property(e => e.Obx4ObservationSubId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_4_ObservationSubID");
            entity.Property(e => e.Obx5ObservationValue)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("OBX_5_ObservationValue");
            entity.Property(e => e.Obx61UnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_6_1_Units_Identifier");
            entity.Property(e => e.Obx62UnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_6_2_Units_Text");
            entity.Property(e => e.Obx63UnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_6_3_Units_NameOfCodingSystem");
            entity.Property(e => e.Obx64UnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_6_4_Units_AlternateIdentifier");
            entity.Property(e => e.Obx65UnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_6_5_Units_AlternateText");
            entity.Property(e => e.Obx66UnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBX_6_6_Units_NameOfAlternateCodingSystem");
            entity.Property(e => e.Obx7ReferenceRange)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OBX_7_ReferenceRange");
            entity.Property(e => e.Obx8AbnormalFlags)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBX_8_AbnormalFlags");
            entity.Property(e => e.Obx9Probability)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OBX_9_Probability");

            entity.HasOne(d => d.FkObr).WithMany(p => p.ObxObservationResults)
                .HasForeignKey(d => d.FkObrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_OBR_ID");
        });

        modelBuilder.Entity<OrcCommonOrder>(entity =>
        {
            entity.HasKey(e => e.PkOrcId).HasName("PK_ORC_CommonOrder_1");

            entity.ToTable("ORC_CommonOrder", "HL7");

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_Hl7_Orc4Placer").HasFillFactor(90);

            entity.HasIndex(e => e.Orc4PlacerGroupNumber1EntityIdentifier, "NCI_Orc4_Hl7");

            entity.Property(e => e.PkOrcId).HasColumnName("pk_ORC_ID");
            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Orc1010EnteredByNameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_10_EnteredBy_NameTypeCode");
            entity.Property(e => e.Orc1011EnteredByIdentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_11_EnteredBy_IdentifierCheckDigit");
            entity.Property(e => e.Orc1012EnteredByCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_12_EnteredBy_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Orc1013EnteredByIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_13_EnteredBy_IdentifierTypeCode");
            entity.Property(e => e.Orc10141EnteredByNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_14_1_EnteredBy_NamespaceId");
            entity.Property(e => e.Orc10142EnteredByUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_14_2_EnteredBy_UniversalId");
            entity.Property(e => e.Orc10143EnteredByUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_14_3_EnteredBy_UniversalIdType");
            entity.Property(e => e.Orc1015EnteredByNameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_15_EnteredBy_NameRepresentationCode");
            entity.Property(e => e.Orc10161EnteredByIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_16_1_EnteredBy_Identifier");
            entity.Property(e => e.Orc10162EnteredByText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_16_2_EnteredBy_Text");
            entity.Property(e => e.Orc10163EnteredByNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_16_3_EnteredBy_NameOfCodingSystem");
            entity.Property(e => e.Orc10164EnteredByIdentifierAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_16_4_EnteredBy_Identifier_AlternateIdentifier");
            entity.Property(e => e.Orc10165EnteredByIdentifierAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_16_5_EnteredBy_Identifier_AlternateText");
            entity.Property(e => e.Orc10166EnteredByIdentifierNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_16_6_EnteredBy_Identifier_NameOfAlternateCodingSystem");
            entity.Property(e => e.Orc10171EnteredByRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("ORC_10_17_1_EnteredBy_RangeStartDateTime");
            entity.Property(e => e.Orc10172EnteredByRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("ORC_10_17_2_EnteredBy_RangeEndDateTime");
            entity.Property(e => e.Orc1018EnteredByNameAssemblyorder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_18_EnteredBy_NameAssemblyorder");
            entity.Property(e => e.Orc101EnteredByIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_1_EnteredBy_IdNumber");
            entity.Property(e => e.Orc1021EnteredByFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_2_1_EnteredBy_FamilyName_Surname");
            entity.Property(e => e.Orc1022EnteredByFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_2_2_EnteredBy_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Orc1023EnteredByFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_2_3_EnteredBy_FamilyName_OwnSurname");
            entity.Property(e => e.Orc1024EnteredByFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_2_4_EnteredBy_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Orc1025EnteredByFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_2_5_EnteredBy_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Orc103EnteredByGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_3_EnteredBy_GivenName");
            entity.Property(e => e.Orc104EnteredBySecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_4_EnteredBy_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Orc105EnteredBySuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_5_EnteredBy_Suffix");
            entity.Property(e => e.Orc106EnteredByPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_6_EnteredBy_Prefix");
            entity.Property(e => e.Orc107EnteredByDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_7_EnteredBy_Degree");
            entity.Property(e => e.Orc108EnteredBySourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_8_EnteredBy_SourceTable");
            entity.Property(e => e.Orc1091EnteredByNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_9_1_EnteredBy_NamespaceId");
            entity.Property(e => e.Orc1092EnteredByUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_9_2_EnteredBy_UniversalId");
            entity.Property(e => e.Orc1093EnteredByUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_10_9_3_EnteredBy_UniversalIdType");
            entity.Property(e => e.Orc11VerifiedBy)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_11_VerifiedBy");
            entity.Property(e => e.Orc1210OrderingProviderNameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_10_OrderingProvider_NameTypeCode");
            entity.Property(e => e.Orc1211OrderingProviderIdentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_11_OrderingProvider_IdentifierCheckDigit");
            entity.Property(e => e.Orc1212OrderingProviderCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_12_OrderingProvider_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Orc1213OrderingProviderIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_13_OrderingProvider_IdentifierTypeCode");
            entity.Property(e => e.Orc12141OrderingProviderAssigningFacilityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_14_1__OrderingProvider_AssigningFacility_NamespaceId");
            entity.Property(e => e.Orc12142OrderingProviderAssigningFacilityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_14_2_OrderingProvider_AssigningFacility_UniversalId");
            entity.Property(e => e.Orc12143OrderingProviderAssigningFacilityUniverslIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_14_3_OrderingProvider_AssigningFacility_UniverslIdType");
            entity.Property(e => e.Orc1215NameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_15_NameRepresentationCode");
            entity.Property(e => e.Orc12161OrderingProviderNameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_16_1_OrderingProvider_NameContext_Identifier");
            entity.Property(e => e.Orc12162OrderingProviderNameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_16_2_OrderingProvider_NameContext_Text");
            entity.Property(e => e.Orc12163OrderingProviderNameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_16_3_OrderingProvider_NameContext_NameOfCodingSystem");
            entity.Property(e => e.Orc12164OrderingProviderNameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_16_4_OrderingProvider_NameContext_AlternateIdentifier");
            entity.Property(e => e.Orc12165OrderingProviderNameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_16_5_OrderingProvider_NameContext_AlternateText");
            entity.Property(e => e.Orc12166OrderingProviderNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_16_6_OrderingProvider_NameContext_NameOfAlternateCodingSystem");
            entity.Property(e => e.Orc12171OrderingProviderNameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("ORC_12_17_1_OrderingProvider_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Orc12172OrderingProviderNameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("ORC_12_17_2_OrderingProvider_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Orc1218OrderingProviderNameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_18_OrderingProvider_NameAssemblyOrder");
            entity.Property(e => e.Orc121OrderingProviderIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_1_OrderingProvider_IdNumber");
            entity.Property(e => e.Orc1221OrderingProviderFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_2_1_OrderingProvider_FamilyName_Surname");
            entity.Property(e => e.Orc1222OrderingProviderFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_2_2_OrderingProvider_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Orc1223OrderingProviderFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_2_3_OrderingProvider_FamilyName_OwnSurname");
            entity.Property(e => e.Orc1224OrderingProviderFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_2_4_OrderingProvider_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Orc1225OrderingProviderFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_2_5_OrderingProvider_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Orc123OrderingProviderGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_3_OrderingProvider_GivenName");
            entity.Property(e => e.Orc124OrderingProviderSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_4_OrderingProvider_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Orc125OrderingProviderSuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_5_OrderingProvider_Suffix");
            entity.Property(e => e.Orc126OrderingProviderPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_6_OrderingProvider_Prefix");
            entity.Property(e => e.Orc127OrderingProviderDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_7_OrderingProvider_Degree");
            entity.Property(e => e.Orc128OrderingProviderSourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_8_OrderingProvider_SourceTable");
            entity.Property(e => e.Orc1291OrderingProviderAssigningAuthorityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_9_1_OrderingProvider_AssigningAuthority_NamespaceId");
            entity.Property(e => e.Orc1292OrderingProviderAssigningAuthorityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_9_2_OrderingProvider_AssigningAuthority_UniversalId");
            entity.Property(e => e.Orc1293OrderingProviderAssigningAuthorityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_12_9_3_OrderingProvider_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Orc131EnterersLocationPointOfCare)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_1_EnterersLocation_PointOfCare");
            entity.Property(e => e.Orc132EnterersLocationRoom)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_2_EnterersLocation_Room");
            entity.Property(e => e.Orc133EnterersLocationBed)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_3_EnterersLocation_Bed");
            entity.Property(e => e.Orc1341EnterersLocationFacilityNamespaceId)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_4_1_EnterersLocation_Facility_NamespaceId");
            entity.Property(e => e.Orc1342EnterersLocationFacilityUniversalId)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_4_2_EnterersLocation_Facility_UniversalId");
            entity.Property(e => e.Orc1343EnterersLocationFacilityUniversalIdType)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_4_3_EnterersLocation_Facility_UniversalIdType");
            entity.Property(e => e.Orc135EnterersLocationLocationStatus)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_5_EnterersLocation_LocationStatus");
            entity.Property(e => e.Orc136EnterersLocationPersonLocationType)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_6_EnterersLocation_PersonLocationType");
            entity.Property(e => e.Orc137EnterersLocationBuilding)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_7_EnterersLocation_Building");
            entity.Property(e => e.Orc138EnterersLocationFloor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_8_EnterersLocation_Floor");
            entity.Property(e => e.Orc139EnterersLocationLocationDescription)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ORC_13_9_EnterersLocation_LocationDescription");
            entity.Property(e => e.Orc141CallBackPhoneNumberTelephoneNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_1_CallBackPhoneNumber_TelephoneNumber");
            entity.Property(e => e.Orc142CallBackPhoneNumberTelecommunicationUseCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_2_CallBackPhoneNumber_TelecommunicationUseCode");
            entity.Property(e => e.Orc143CallBackPhoneNumberTelecommunicationEquipmentType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_3_CallBackPhoneNumber_TelecommunicationEquipmentType");
            entity.Property(e => e.Orc144CallBackPhoneNumberEmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_4_CallBackPhoneNumber_EmailAddress");
            entity.Property(e => e.Orc145CallBackPhoneNumberCountryCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_5_CallBackPhoneNumber_CountryCode");
            entity.Property(e => e.Orc146CallBackPhoneNumberAreaCityCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_6_CallBackPhoneNumber_AreaCityCode");
            entity.Property(e => e.Orc147CallBackPhoneNumberPhoneNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_7_CallBackPhoneNumber_PhoneNumber");
            entity.Property(e => e.Orc148CallBackPhoneNumberExtension)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_8_CallBackPhoneNumber_Extension");
            entity.Property(e => e.Orc149CallBackPhoneNumberAnyText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_14_9_CallBackPhoneNumber_AnyText");
            entity.Property(e => e.Orc151OrderEffectiveDateTimeTimeOfAnEvent)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_15_1_OrderEffectiveDateTime_TimeOfAnEvent");
            entity.Property(e => e.Orc152OrderEffectiveDateTimeDegreeOfPrecision)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ORC_15_2_OrderEffectiveDateTime_DegreeOfPrecision");
            entity.Property(e => e.Orc16OrderControlCodeReason)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_16_OrderControlCodeReason");
            entity.Property(e => e.Orc17EnteringOrganization)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_17_EnteringOrganization");
            entity.Property(e => e.Orc18EnteringDevice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_18_EnteringDevice");
            entity.Property(e => e.Orc19ActionBy)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_19_ActionBy");
            entity.Property(e => e.Orc1OrderControl)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ORC_1_OrderControl");
            entity.Property(e => e.Orc20AdvancedBeneficiaryNoticeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_20_AdvancedBeneficiaryNoticeCode");
            entity.Property(e => e.Orc21OrderingFacilityName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_21_OrderingFacilityName");
            entity.Property(e => e.Orc22OrderingFacilityAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_22_OrderingFacilityAddress");
            entity.Property(e => e.Orc23OrderingFacilityPhoneNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_23_OrderingFacilityPhoneNumber");
            entity.Property(e => e.Orc2410OrderingProviderAddressCensusTract)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_10_OrderingProviderAddress_CensusTract");
            entity.Property(e => e.Orc2411OrderingProviderAddressAddressRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_11_OrderingProviderAddress_AddressRepresentationCode");
            entity.Property(e => e.Orc2411OrderingProviderAddressAddressValidityRange)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_11_OrderingProviderAddress_AddressValidityRange");
            entity.Property(e => e.Orc241OrderingProviderAddressStreetAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_1_OrderingProviderAddress_StreetAddress");
            entity.Property(e => e.Orc242OrderingProviderAddressOtherDesignation)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_2_OrderingProviderAddress_OtherDesignation");
            entity.Property(e => e.Orc243OrderingProviderAddressCity)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_3_OrderingProviderAddress_City");
            entity.Property(e => e.Orc244OrderingProviderAddressStateOrProvince)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_4_OrderingProviderAddress_StateOrProvince");
            entity.Property(e => e.Orc245OrderingProviderAddressZipOrPostalCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_5_OrderingProviderAddress_ZipOrPostalCode");
            entity.Property(e => e.Orc246OrderingProviderAddressCountry)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_6_OrderingProviderAddress_Country");
            entity.Property(e => e.Orc247OrderingProviderAddressAddressType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_7_OrderingProviderAddress_AddressType");
            entity.Property(e => e.Orc248OrderingProviderAddressOtherGeographicDesignation)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_8_OrderingProviderAddress_OtherGeographicDesignation");
            entity.Property(e => e.Orc249OrderingProviderAddressCountyParishCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_24_9_OrderingProviderAddress_CountyParishCode");
            entity.Property(e => e.Orc25OrderStatusModifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORC_25_OrderStatusModifier");
            entity.Property(e => e.Orc2PlacerOrderNumber1EntityIdentifier)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_2_PlacerOrderNumber_1_EntityIdentifier");
            entity.Property(e => e.Orc2PlacerOrderNumber2NamespaceId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_2_PlacerOrderNumber_2_NamespaceId");
            entity.Property(e => e.Orc2PlacerOrderNumber3UniversalId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_2_PlacerOrderNumber_3_UniversalId");
            entity.Property(e => e.Orc2PlacerOrderNumber4UniversalIdType)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_2_PlacerOrderNumber_4_UniversalIdType");
            entity.Property(e => e.Orc3FillerOrderNumber1EntityIdentifier)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_3_FillerOrderNumber_1_EntityIdentifier");
            entity.Property(e => e.Orc3FillerOrderNumber2NamespaceId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_3_FillerOrderNumber_2_NamespaceId");
            entity.Property(e => e.Orc3FillerOrderNumber3UniversalId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_3_FillerOrderNumber_3_UniversalId");
            entity.Property(e => e.Orc3FillerOrderNumber4UniversalIdType)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_3_FillerOrderNumber_4_UniversalIdType");
            entity.Property(e => e.Orc4PlacerGroupNumber1EntityIdentifier)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_4_PlacerGroupNumber_1_EntityIdentifier");
            entity.Property(e => e.Orc4PlacerGroupNumber2NamespaceId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_4_PlacerGroupNumber_2_NamespaceId");
            entity.Property(e => e.Orc4PlacerGroupNumber3UniversalId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_4_PlacerGroupNumber_3_UniversalId");
            entity.Property(e => e.Orc4PlacerGroupNumber4UniversalIdType)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ORC_4_PlacerGroupNumber_4_UniversalIdType");
            entity.Property(e => e.Orc5OrderStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ORC_5_OrderStatus");
            entity.Property(e => e.Orc6ResponseFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ORC_6_ResponseFlag");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing10FillerOrderNumberUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_10_FillerOrderNumberUniversalID");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing11FillerOrderNumberUniversalIdtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_11_FillerOrderNumberUniversalIDType");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing1SequenceResultsFlag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_1_SequenceResultsFlag");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing2PlacerOrderNumberEntityIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_2_PlacerOrderNumberEntityIdentifier");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing3PlacerOrderNumberNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_3_PlacerOrderNumberNamespaceID");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing4FillerOrderNumberEntityIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_4_FillerOrderNumberEntityIdentifier");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing5FillerOrderNumberNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_5_FillerOrderNumberNamespaceID");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing6SequenceConditionValue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_6_SequenceConditionValue");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing7MaximumNumberOfRepeats)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_7_MaximumNumberOfRepeats");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing8PlacerOrderNumberUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_8_PlacerOrderNumberUniversalID");
            entity.Property(e => e.Orc7QuantityTiming10OrderSequencing9PlacerOrderNumberUniversalIdtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_10_OrderSequencing_9_PlacerOrderNumberUniversalIDType");
            entity.Property(e => e.Orc7QuantityTiming11OccurenceDuration1Identifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_11_OccurenceDuration_1_Identifier");
            entity.Property(e => e.Orc7QuantityTiming11OccurenceDuration2Text)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_11_OccurenceDuration_2_Text");
            entity.Property(e => e.Orc7QuantityTiming11OccurenceDuration3NameOfCodingSystem)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_11_OccurenceDuration_3_NameOfCodingSystem");
            entity.Property(e => e.Orc7QuantityTiming11OccurenceDuration4AlternateIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_11_OccurenceDuration_4_AlternateIdentifier");
            entity.Property(e => e.Orc7QuantityTiming11OccurenceDuration5AlternateText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_11_OccurenceDuration_5_AlternateText");
            entity.Property(e => e.Orc7QuantityTiming11OccurenceDuration6NameOfAlternateCodingSystem)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_11_OccurenceDuration_6_NameOfAlternateCodingSystem");
            entity.Property(e => e.Orc7QuantityTiming12TotalOccurences)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ORC_7_QuantityTiming_12_TotalOccurences");
            entity.Property(e => e.Orc7QuantityTiming1Quantity1Quantity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_1_Quantity_1_Quantity");
            entity.Property(e => e.Orc7QuantityTiming1Quantity2Units)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_1_Quantity_2_Units");
            entity.Property(e => e.Orc7QuantityTiming2Interval1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ORC_7_QuantityTiming_2_Interval_1");
            entity.Property(e => e.Orc7QuantityTiming2Interval2)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ORC_7_QuantityTiming_2_Interval_2");
            entity.Property(e => e.Orc7QuantityTiming3Duration)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_3_Duration");
            entity.Property(e => e.Orc7QuantityTiming4StartDateTime1TimeOfEvent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_4_StartDateTime_1_TimeOfEvent");
            entity.Property(e => e.Orc7QuantityTiming4StartDateTime2DegreeOfPrecision)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_4_StartDateTime_2_DegreeOfPrecision");
            entity.Property(e => e.Orc7QuantityTiming5EndDateTime1TimeOfEvent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_5_EndDateTime_1_TimeOfEvent");
            entity.Property(e => e.Orc7QuantityTiming5EndDateTime2DegreeOfPrecision)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_5_EndDateTime_2_DegreeOfPrecision");
            entity.Property(e => e.Orc7QuantityTiming6Priority)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_6_Priority");
            entity.Property(e => e.Orc7QuantityTiming7Condition)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_7_Condition");
            entity.Property(e => e.Orc7QuantityTiming8Text)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_8_Text");
            entity.Property(e => e.Orc7QuantityTiming9ConjuctionComponent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_7_QuantityTiming_9_ConjuctionComponent");
            entity.Property(e => e.Orc811ParentOrderPlacerOrderNumberEntityIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_8_1_1_ParentOrder_PlacerOrderNumber_EntityIdentifier");
            entity.Property(e => e.Orc812ParentOrderPlacerOrderNumberNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_8_1_2_ParentOrder_PlacerOrderNumber_NamespaceId");
            entity.Property(e => e.Orc813ParentOrderPlacerOrderNumberUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_8_1_3_ParentOrder_PlacerOrderNumber_UniversalId");
            entity.Property(e => e.Orc814ParentOrderPlacerOrderNumberUniversalIdType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_8_1_4_ParentOrder_PlacerOrderNumber_UniversalIdType");
            entity.Property(e => e.Orc821ParentOrderFillerOrderNumberEntityIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_8_2_1_ParentOrder_FillerOrderNumber_EntityIdentifier");
            entity.Property(e => e.Orc822ParentOrderFillerOrderNumberNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_8_2_2_ParentOrder_FillerOrderNumber_NamespaceId");
            entity.Property(e => e.Orc823ParentOrderFillerOrderNumberUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_8_2_3_ParentOrder_FillerOrderNumber_UniversalId");
            entity.Property(e => e.Orc824ParentOrderFillerOrderNumberUniversalIdType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_8_2_4_ParentOrder_FillerOrderNumber_UniversalIdType");
            entity.Property(e => e.Orc9DateTimeTransaction1TimeOfAnEvent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_9_DateTimeTransaction_1_TimeOfAnEvent");
            entity.Property(e => e.Orc9DateTimeTransaction2DegreeOfPrecision)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORC_9_DateTimeTransaction_2_DegreeOfPrecision");
        });

        modelBuilder.Entity<OrderDrugClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrderDrugClass", "IMT");

            entity.Property(e => e.Abbr).HasMaxLength(255);
            entity.Property(e => e.DrugClassesForDrugBug)
                .HasMaxLength(255)
                .HasColumnName("Drug classes for drug-bug");
        });

        modelBuilder.Entity<OrganismDrug>(entity =>
        {
            entity.ToTable("OrganismDrug", "IMT");

            entity.HasIndex(e => e.AlertId, "IDX_AlertId");

            entity.Property(e => e.CaseNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ObservationDate).HasColumnType("datetime");
            entity.Property(e => e.ObservationIdentifier31)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ObservationText32)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganismName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PatientIdNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sensitivity)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SpecimenSite)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniversalServiceIdentifier42)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PatientActivityLog>(entity =>
        {
            entity.ToTable("PatientActivityLog", "IMT");

            entity.Property(e => e.CaseNumber).HasMaxLength(100);
            entity.Property(e => e.ColumnName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.NewValue).HasMaxLength(500);
            entity.Property(e => e.OldValue).HasMaxLength(500);
            entity.Property(e => e.PmiNumber).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PatientActivityLogType>(entity =>
        {
            entity.ToTable("PatientActivityLogTypes", "IMT");

            entity.Property(e => e.PatientActivityLogTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<PatientAllergiesAndComorbidity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PatientA__3214EC0702AFAF29");

            entity.ToTable("PatientAllergiesAndComorbidities", "IMT");

            entity.HasIndex(e => e.PmiNumber, "NCI_PMI_all").HasFillFactor(90);

            entity.Property(e => e.OtherAllergy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OtherComobidity)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PmiNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<PatientAllergy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PatientA__3214EC0767FD1B99");

            entity.ToTable("PatientAllergies", "IMT");

            entity.HasIndex(e => e.PatientAllergiesAndComorbiditiesId, "NCI_Id_All").HasFillFactor(90);

            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            entity.Property(e => e.Pmi).HasMaxLength(100);

            entity.HasOne(d => d.Allergies).WithMany(p => p.PatientAllergies)
                .HasForeignKey(d => d.AllergiesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PatientAl__Aller__79DDE984");

            entity.HasOne(d => d.PatientAllergiesAndComorbidities).WithMany(p => p.PatientAllergies)
                .HasForeignKey(d => d.PatientAllergiesAndComorbiditiesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PatientAl__Patie__0737E4A2");
        });

        modelBuilder.Entity<PatientComorbidity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PatientC__3214EC0723F2720A");

            entity.ToTable("PatientComorbidities", "IMT");

            entity.HasIndex(e => e.PatientAllergiesAndComorbiditiesId, "NCI_Id_All");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            entity.Property(e => e.Pmi).HasMaxLength(100);

            entity.HasOne(d => d.Comorbidities).WithMany(p => p.PatientComorbidities)
                .HasForeignKey(d => d.ComorbiditiesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PatientCo__Comor__7DAE7A68");

            entity.HasOne(d => d.PatientAllergiesAndComorbidities).WithMany(p => p.PatientComorbidities)
                .HasForeignKey(d => d.PatientAllergiesAndComorbiditiesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PatientCo__Patie__0643C069");
        });

        modelBuilder.Entity<PatientWardDevice>(entity =>
        {
            entity.HasKey(e => e.PatientWardDeviceId).HasName("PK_PatientWardDevice_2");

            entity.ToTable("PatientWardDevice", "IMT");

            entity.Property(e => e.Bed).HasMaxLength(50);
            entity.Property(e => e.CaseNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateBeforeDischarge).HasColumnType("datetime");
            entity.Property(e => e.EndDateUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.EndDateUserInput).HasColumnType("datetime");
            entity.Property(e => e.PmiNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Room).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StopReason).HasMaxLength(225);
            entity.Property(e => e.StopReasonBeforeDischarge).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedByBeforeDischarge).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDateBeforeDischarge).HasColumnType("datetime");
            entity.Property(e => e.WardNumber).HasMaxLength(50);

            entity.HasOne(d => d.Audit).WithMany(p => p.PatientWardDevices)
                .HasForeignKey(d => d.AuditId)
                .HasConstraintName("FK_PatientWardDevice_IMTDeviceAuditing");

            entity.HasOne(d => d.Device).WithMany(p => p.PatientWardDevices)
                .HasForeignKey(d => d.DeviceId)
                .HasConstraintName("FK_PatientWardDevice_Device");
        });

        modelBuilder.Entity<PersonLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PersonLog2");

            entity.ToTable("PersonLog", "HL7");

            entity.HasIndex(e => e.CaseNo, "CaseNo");

            entity.Property(e => e.ActiveSmssent).HasColumnName("ActiveSMSSent");
            entity.Property(e => e.AdmittingDoctorFirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AdmittingDoctorHpcsa)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("AdmittingDoctorHPCSA");
            entity.Property(e => e.AdmittingDoctorLastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BedStatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CaseNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CellNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ConsultingDoctorFirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ConsultingDoctorHpcsa)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ConsultingDoctorHPCSA");
            entity.Property(e => e.ConsultingDoctorLastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.DeadPatient)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Emergency)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Gpconsent)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GPConsent");
            entity.Property(e => e.HospitalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ImportDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InfectionControl)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.MiddleInitial)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PlannedDate).HasColumnType("datetime");
            entity.Property(e => e.PmiNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Suffix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Transplant)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TriggerEvent)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Vip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VIP");
            entity.Property(e => e.WardDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WardNo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PharmacyAtcCode>(entity =>
        {
            entity.HasKey(e => e.Pharmacycodeid);

            entity.ToTable("PharmacyAtcCodes", "IMT");

            entity.Property(e => e.Pharmacycodeid).HasColumnName("PHARMACYCODEID");
            entity.Property(e => e.L1Code)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("L1_CODE");
            entity.Property(e => e.L1Description)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("L1_DESCRIPTION");
            entity.Property(e => e.L2Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("L2_CODE");
            entity.Property(e => e.L2Description)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("L2_DESCRIPTION");
            entity.Property(e => e.L3Code)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("L3_CODE");
            entity.Property(e => e.L3Description)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("L3_DESCRIPTION");
            entity.Property(e => e.L4Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("L4_CODE");
            entity.Property(e => e.L4Description)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("L4_DESCRIPTION");
            entity.Property(e => e.L5Code)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("L5_CODE");
            entity.Property(e => e.L5Description)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("L5_DESCRIPTION");
        });

        modelBuilder.Entity<PharmacyStockMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PharmacyStockMaster", "IMT");

            entity.Property(e => e.AtcCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ATC_CODE");
            entity.Property(e => e.ChronicInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CHRONIC_IND");
            entity.Property(e => e.CostHist1Date)
                .HasColumnType("datetime")
                .HasColumnName("COST_HIST1_DATE");
            entity.Property(e => e.CostHist2Date)
                .HasColumnType("datetime")
                .HasColumnName("COST_HIST2_DATE");
            entity.Property(e => e.CostPrice)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("COST_PRICE");
            entity.Property(e => e.CostPriceDate)
                .HasColumnType("datetime")
                .HasColumnName("COST_PRICE_DATE");
            entity.Property(e => e.CostPriceHist1)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("COST_PRICE_HIST1");
            entity.Property(e => e.CostPriceHist2)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("COST_PRICE_HIST2");
            entity.Property(e => e.DosageForm)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DOSAGE_FORM");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("EFFECTIVE_DATE");
            entity.Property(e => e.GenericInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GENERIC_IND");
            entity.Property(e => e.GenericProductDescription)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("GENERIC_PRODUCT_DESCRIPTION");
            entity.Property(e => e.GenericProductNumber)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("GENERIC_PRODUCT_NUMBER");
            entity.Property(e => e.ImportTrackingId).HasColumnName("ImportTrackingID");
            entity.Property(e => e.ManufacturerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURER_NAME");
            entity.Property(e => e.MetricStrength)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("METRIC_STRENGTH");
            entity.Property(e => e.MmapInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MMAP_IND");
            entity.Property(e => e.NappiCode)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NAPPI_CODE");
            entity.Property(e => e.NappiNine)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NAPPI_NINE");
            entity.Property(e => e.NappiSix)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NAPPI_SIX");
            entity.Property(e => e.NewNappi)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NEW_NAPPI");
            entity.Property(e => e.PackSize)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("PACK_SIZE");
            entity.Property(e => e.PharmacyStockMasterId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PharmacyStockMasterID");
            entity.Property(e => e.ProductDescript)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_DESCRIPT");
            entity.Property(e => e.ProductStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PRODUCT_STATUS");
            entity.Property(e => e.RouteOfAdmin)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ROUTE_OF_ADMIN");
            entity.Property(e => e.Schedule)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SCHEDULE");
            entity.Property(e => e.SellHist1Date)
                .HasColumnType("datetime")
                .HasColumnName("SELL_HIST1_DATE");
            entity.Property(e => e.SellHist2Date)
                .HasColumnType("datetime")
                .HasColumnName("SELL_HIST2_DATE");
            entity.Property(e => e.SellPrice)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("SELL_PRICE");
            entity.Property(e => e.SellPriceDate)
                .HasColumnType("datetime")
                .HasColumnName("SELL_PRICE_DATE");
            entity.Property(e => e.SellPriceHist1)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("SELL_PRICE_HIST1");
            entity.Property(e => e.SellPriceHist2)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("SELL_PRICE_HIST2");
            entity.Property(e => e.StrengthUnitMeasure)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("STRENGTH_UNIT_MEASURE");
            entity.Property(e => e.TempCosthist1Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEMP_COSTHIST1_DATE");
            entity.Property(e => e.TempCosthist2Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEMP_COSTHIST2_DATE");
            entity.Property(e => e.TempCostpriceDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEMP_COSTPRICE_DATE");
            entity.Property(e => e.TempEffectiveDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TEMP_EFFECTIVE_DATE");
            entity.Property(e => e.TempSellhist1Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEMP_SELLHIST1_DATE");
            entity.Property(e => e.TempSellhist2Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEMP_SELLHIST2_DATE");
            entity.Property(e => e.TempSellpriceDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEMP_SELLPRICE_DATE");
            entity.Property(e => e.TempTClass)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TEMP_T_CLASS");
            entity.Property(e => e.TherapeuticClass)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("THERAPEUTIC_CLASS");
            entity.Property(e => e.TherapeuticClassDescr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("THERAPEUTIC_CLASS_DESCR");
        });

        modelBuilder.Entity<PidPatientIdentification>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_PID_PatientIdentification1");

            entity.ToTable("PID_PatientIdentification", "HL7");

            entity.HasIndex(e => new { e.Hl7personLogId, e.Pid30PatientDeathIndicator }, "NCI_DeathIndicator").HasFillFactor(80);

            entity.HasIndex(e => e.Pid19SsnnumberPatient, "NCI_PIDSSN_MANY").HasFillFactor(80);

            entity.HasIndex(e => e.Pid29PatientDeathDateTime, "NCI_PID_29_PatientDeathDateTime").HasFillFactor(80);

            entity.HasIndex(e => e.Pid3PatientIdentifierList, "NCI_PID_3").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLogID").HasFillFactor(80);

            entity.HasIndex(e => new { e.Hl7uniqueIdentifier, e.Pid4AlternatePatientId }, "NonClusteredIndex-20220217-180039").HasFillFactor(80);

            entity.HasIndex(e => e.Pid4AlternatePatientId, "ind_PID_4_AlternatePatientID").HasFillFactor(80);

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Pid10Race)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_10_Race");
            entity.Property(e => e.Pid110PatientAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_11_0_PatientAddressStreetAddress");
            entity.Property(e => e.Pid111PatientAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_11_1_PatientAddressOtherDesignation");
            entity.Property(e => e.Pid112PatientAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_11_2_PatientAddressCity");
            entity.Property(e => e.Pid113PatientAddressProvince)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_11_3_PatientAddressProvince");
            entity.Property(e => e.Pid114PatientAddressPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_11_4_PatientAddressPostalCode");
            entity.Property(e => e.Pid115PatientAddressCountry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_11_5_PatientAddressCountry");
            entity.Property(e => e.Pid12CountyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_12_CountyCode");
            entity.Property(e => e.Pid130PhoneNumberHome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_13_0_PhoneNumberHome");
            entity.Property(e => e.Pid131PhoneNumberHome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_13_1_PhoneNumberHome");
            entity.Property(e => e.Pid132PhoneNumberHome)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_13_2_PhoneNumberHome");
            entity.Property(e => e.Pid14PhoneNumberBusiness)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_14_PhoneNumberBusiness");
            entity.Property(e => e.Pid15PrimaryLanguage)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_15_PrimaryLanguage");
            entity.Property(e => e.Pid16MaritalStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_16_MaritalStatus");
            entity.Property(e => e.Pid17Religion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_17_Religion");
            entity.Property(e => e.Pid18PatientAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_18_PatientAccountNumber");
            entity.Property(e => e.Pid19PSsnnumberPatientPatch)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_19_P_SSNNumberPatientPatch");
            entity.Property(e => e.Pid19SsnnumberPatient)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_19_SSNNumberPatient");
            entity.Property(e => e.Pid1SetIdpid).HasColumnName("PID_1_SetIDPID");
            entity.Property(e => e.Pid20DriversLicenseNumberPatient)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_20_DriversLicenseNumberPatient");
            entity.Property(e => e.Pid21MothersIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_21_MothersIdentifier");
            entity.Property(e => e.Pid22EthnicGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_22_EthnicGroup");
            entity.Property(e => e.Pid23BirthPlace)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_23_BirthPlace");
            entity.Property(e => e.Pid24MultipleBirthIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_24_MultipleBirthIndicator");
            entity.Property(e => e.Pid25BirthOrder)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_25_BirthOrder");
            entity.Property(e => e.Pid26Citizenship)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_26_Citizenship");
            entity.Property(e => e.Pid27VeteransMilitaryStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_27_VeteransMilitaryStatus");
            entity.Property(e => e.Pid28Nationality)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_28_Nationality");
            entity.Property(e => e.Pid29PatientDeathDateTime)
                .HasColumnType("datetime")
                .HasColumnName("PID_29_PatientDeathDateTime");
            entity.Property(e => e.Pid2PatientId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_2_PatientID");
            entity.Property(e => e.Pid30PatientDeathIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_30_PatientDeathIndicator");
            entity.Property(e => e.Pid31IdentityUnknownIndicator)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PID_31_IdentityUnknownIndicator");
            entity.Property(e => e.Pid32IdentityReliabilityCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PID_32_IdentityReliabilityCode");
            entity.Property(e => e.Pid33LastUpdateDateTime)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_33_LastUpdateDateTime");
            entity.Property(e => e.Pid34LastUpdateFacility)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("PID_34_LastUpdateFacility");
            entity.Property(e => e.Pid35SpeciesCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PID_35_SpeciesCode");
            entity.Property(e => e.Pid36BreedCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PID_36_BreedCode");
            entity.Property(e => e.Pid37Strain)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PID_37_Strain");
            entity.Property(e => e.Pid38ProductionClassCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PID_38_ProductionClassCode");
            entity.Property(e => e.Pid3PatientIdentifierList)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PID_3_PatientIdentifierList");
            entity.Property(e => e.Pid3PatientIdentifierList1Id)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PID_3_PatientIdentifierList_1_ID");
            entity.Property(e => e.Pid3PatientIdentifierList2CheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PID_3_PatientIdentifierList_2_CheckDigit");
            entity.Property(e => e.Pid3PatientIdentifierList3CodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PID_3_PatientIdentifierList_3_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Pid3PatientIdentifierList4AssigningAuthority)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PID_3_PatientIdentifierList_4_AssigningAuthority");
            entity.Property(e => e.Pid3PatientIdentifierList5IdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PID_3_PatientIdentifierList_5_IdentifierTypeCode");
            entity.Property(e => e.Pid3PatientIdentifierList6AssigningFacility)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PID_3_PatientIdentifierList_6_AssigningFacility");
            entity.Property(e => e.Pid3PatientIdentifierList7EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("PID_3_PatientIdentifierList_7_EffectiveDate");
            entity.Property(e => e.Pid3PatientIdentifierList7ExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("PID_3_PatientIdentifierList_7_ExpirationDate");
            entity.Property(e => e.Pid4AlternatePatientId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PID_4_AlternatePatientID");
            entity.Property(e => e.Pid50PatientNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_5_0_PatientNameFamilyName");
            entity.Property(e => e.Pid51PatientNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_5_1_PatientNameGivenName");
            entity.Property(e => e.Pid52PatientNameSecondNamesOrInitials)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_5_2_PatientNameSecondNamesOrInitials");
            entity.Property(e => e.Pid53PatientNameSuffix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_5_3_PatientNameSuffix");
            entity.Property(e => e.Pid54PatientNamePrefix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_5_4_PatientNamePrefix");
            entity.Property(e => e.Pid6MothersMaidenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_6_MothersMaidenName");
            entity.Property(e => e.Pid7DateTimeOfBirth)
                .HasColumnType("date")
                .HasColumnName("PID_7_DateTimeOfBirth");
            entity.Property(e => e.Pid8AdministrativeSex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_8_AdministrativeSex");
            entity.Property(e => e.Pid9PatientAlias)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_9_PatientAlias");
        });

        modelBuilder.Entity<PidPatientIdentificationImportHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PID_PatientIdentification_ImportHistory", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Pid10Race)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_10_Race");
            entity.Property(e => e.Pid110PatientAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_11_0_PatientAddressStreetAddress");
            entity.Property(e => e.Pid111PatientAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_11_1_PatientAddressOtherDesignation");
            entity.Property(e => e.Pid112PatientAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_11_2_PatientAddressCity");
            entity.Property(e => e.Pid113PatientAddressProvince)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_11_3_PatientAddressProvince");
            entity.Property(e => e.Pid114PatientAddressPostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_11_4_PatientAddressPostalCode");
            entity.Property(e => e.Pid115PatientAddressCountry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_11_5_PatientAddressCountry");
            entity.Property(e => e.Pid12CountyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_12_CountyCode");
            entity.Property(e => e.Pid130PhoneNumberHome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_13_0_PhoneNumberHome");
            entity.Property(e => e.Pid131PhoneNumberHome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_13_1_PhoneNumberHome");
            entity.Property(e => e.Pid132PhoneNumberHome)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_13_2_PhoneNumberHome");
            entity.Property(e => e.Pid14PhoneNumberBusiness)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_14_PhoneNumberBusiness");
            entity.Property(e => e.Pid15PrimaryLanguage)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_15_PrimaryLanguage");
            entity.Property(e => e.Pid16MaritalStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_16_MaritalStatus");
            entity.Property(e => e.Pid17Religion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_17_Religion");
            entity.Property(e => e.Pid18PatientAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_18_PatientAccountNumber");
            entity.Property(e => e.Pid19PSsnnumberPatientPatch)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_19_P_SSNNumberPatientPatch");
            entity.Property(e => e.Pid19SsnnumberPatient)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_19_SSNNumberPatient");
            entity.Property(e => e.Pid1SetIdpid).HasColumnName("PID_1_SetIDPID");
            entity.Property(e => e.Pid20DriversLicenseNumberPatient)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_20_DriversLicenseNumberPatient");
            entity.Property(e => e.Pid21MothersIdentifier)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_21_MothersIdentifier");
            entity.Property(e => e.Pid22EthnicGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_22_EthnicGroup");
            entity.Property(e => e.Pid23BirthPlace)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_23_BirthPlace");
            entity.Property(e => e.Pid24MultipleBirthIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_24_MultipleBirthIndicator");
            entity.Property(e => e.Pid25BirthOrder)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_25_BirthOrder");
            entity.Property(e => e.Pid26Citizenship)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_26_Citizenship");
            entity.Property(e => e.Pid27VeteransMilitaryStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_27_VeteransMilitaryStatus");
            entity.Property(e => e.Pid28Nationality)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_28_Nationality");
            entity.Property(e => e.Pid29PatientDeathDateTime)
                .HasColumnType("datetime")
                .HasColumnName("PID_29_PatientDeathDateTime");
            entity.Property(e => e.Pid2PatientId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_2_PatientID");
            entity.Property(e => e.Pid30PatientDeathIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_30_PatientDeathIndicator");
            entity.Property(e => e.Pid3PatientIdentifierList)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_3_PatientIdentifierList");
            entity.Property(e => e.Pid4AlternatePatientId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_4_AlternatePatientID");
            entity.Property(e => e.Pid50PatientNameFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_5_0_PatientNameFamilyName");
            entity.Property(e => e.Pid51PatientNameGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_5_1_PatientNameGivenName");
            entity.Property(e => e.Pid52PatientNameSecondNamesOrInitials)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_5_2_PatientNameSecondNamesOrInitials");
            entity.Property(e => e.Pid53PatientNameSuffix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_5_3_PatientNameSuffix");
            entity.Property(e => e.Pid54PatientNamePrefix)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PID_5_4_PatientNamePrefix");
            entity.Property(e => e.Pid6MothersMaidenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_6_MothersMaidenName");
            entity.Property(e => e.Pid7DateTimeOfBirth)
                .HasColumnType("date")
                .HasColumnName("PID_7_DateTimeOfBirth");
            entity.Property(e => e.Pid8AdministrativeSex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PID_8_AdministrativeSex");
            entity.Property(e => e.Pid9PatientAlias)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PID_9_PatientAlias");
        });

        modelBuilder.Entity<Pr1Procedure>(entity =>
        {
            entity.HasKey(e => e.Pr1Id).HasName("PK_PR1_Procedures_1");

            entity.ToTable("PR1_Procedures", "HL7");

            entity.HasIndex(e => e.Hl7personLogIdcurrentLocation, "NCI_HL7PersonLogIDCurrentLocation").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLogId").HasFillFactor(80);

            entity.Property(e => e.Pr1Id).HasColumnName("Pr1ID");
            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7personLogIdcurrentLocation).HasColumnName("HL7PersonLogIDCurrentLocation");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Pr110AnesthesiaMinutes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_10_Anesthesia_Minutes");
            entity.Property(e => e.Pr11110SurgeonNameTypeCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_10_Surgeon_Name_Type_Code");
            entity.Property(e => e.Pr11111SurgeonIdentifierCheckDigit)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_11_Surgeon_Identifier_Check_Digit");
            entity.Property(e => e.Pr11112SurgeonDigitSchemeEmployed)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_12_Surgeon_Digit_Scheme_Employed");
            entity.Property(e => e.Pr11113SurgeonIdentifierTypeCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_13_Surgeon_Identifier_Type_Code");
            entity.Property(e => e.Pr1111SurgeonIdNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_1_Surgeon_Id_Number");
            entity.Property(e => e.Pr1112SurgeonFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_2_Surgeon_Family_Name");
            entity.Property(e => e.Pr1113SurgeonGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_3_Surgeon_Given_Name");
            entity.Property(e => e.Pr1114SurgeonSecondAndFurtherGivenNames)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_4_Surgeon_Second_And_Further_Given_Names");
            entity.Property(e => e.Pr1115SurgeonSuffix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_5_Surgeon_Suffix");
            entity.Property(e => e.Pr1116SurgeonPrefix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_6_Surgeon_Prefix");
            entity.Property(e => e.Pr1117SurgeonDegree)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_7_Surgeon_Degree");
            entity.Property(e => e.Pr1118SurgeonSourceTable)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_8_Surgeon_Source_Table");
            entity.Property(e => e.Pr1119SurgeonAssigningAuthority)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_11_9_Surgeon_Assigning_Authority");
            entity.Property(e => e.Pr112ProcedurePractitioner)
                .IsUnicode(false)
                .HasColumnName("PR1_12_Procedure_Practitioner");
            entity.Property(e => e.Pr113ConsentCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_13_Consent_Code");
            entity.Property(e => e.Pr114ProcedurePriority)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_14_Procedure_Priority");
            entity.Property(e => e.Pr115AssociatedDiagnosisCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_15_Associated_Diagnosis_Code");
            entity.Property(e => e.Pr116ProcedureCodeModifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_16_Procedure_Code_Modifier");
            entity.Property(e => e.Pr117ProcedureDrgType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_17_Procedure_DRG_Type");
            entity.Property(e => e.Pr118TissueTypeCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_18_Tissue_Type_Code");
            entity.Property(e => e.Pr11SetIdPr1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_1_Set_ID_PR1");
            entity.Property(e => e.Pr12ProcedureCodingMethod)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_2_Procedure_Coding_Method");
            entity.Property(e => e.Pr131ProcedureCodeIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_3_1_Procedure_Code_Identifier");
            entity.Property(e => e.Pr132ProcedureCodeNameOfCodingSystem)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_3_2_Procedure_Code_Name_Of_Coding_System");
            entity.Property(e => e.Pr132ProcedureCodeText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_3_2_Procedure_Code_Text");
            entity.Property(e => e.Pr14ProcedureDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_4_Procedure_Description");
            entity.Property(e => e.Pr15ProcedureDateTime)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_5_Procedure_Date_Time");
            entity.Property(e => e.Pr16ProcedureFunctionalType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_6_Procedure_Functional_Type");
            entity.Property(e => e.Pr17ProcedureMinutes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_7_Procedure_Minutes");
            entity.Property(e => e.Pr1810AnesthesiologistNameTypeCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_10_Anesthesiologist_Name_Type_Code");
            entity.Property(e => e.Pr1811AnesthesiologistIdentifierCheckDigit)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_11_Anesthesiologist_Identifier_Check_Digit");
            entity.Property(e => e.Pr1812AnesthesiologistDigitSchemeEmployed)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_12_Anesthesiologist_Digit_Scheme_Employed");
            entity.Property(e => e.Pr1813AnesthesiologistIdentifierTypeCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_13_Anesthesiologist_Identifier_Type_Code");
            entity.Property(e => e.Pr181AnesthesiologistIdNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_1_Anesthesiologist_Id_Number");
            entity.Property(e => e.Pr182AnesthesiologistFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_2_Anesthesiologist_Family_Name");
            entity.Property(e => e.Pr183AnesthesiologistGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_3_Anesthesiologist_Given_Name");
            entity.Property(e => e.Pr184AnesthesiologistSecondAndGivenNames)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_4_Anesthesiologist_Second_And_Given_Names");
            entity.Property(e => e.Pr185AnesthesiologistSuffix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_5_Anesthesiologist_Suffix");
            entity.Property(e => e.Pr186AnesthesiologistPrefix)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_6_Anesthesiologist_Prefix");
            entity.Property(e => e.Pr187AnesthesiologistDegree)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_7_Anesthesiologist_Degree");
            entity.Property(e => e.Pr188AnesthesiologistSourceTable)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_8_Anesthesiologist_Source_Table");
            entity.Property(e => e.Pr189AnesthesiologistAssigningAuthority)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_8_9_Anesthesiologist_Assigning_Authority");
            entity.Property(e => e.Pr19AnesthesiaCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR1_9_Anesthesia_Code");
        });

        modelBuilder.Entity<Pv1PatientVisit>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_PV1_PatientVisit1");

            entity.ToTable("PV1_PatientVisit", "HL7");

            entity.HasIndex(e => new { e.Pv145DischargeDateTime, e.Pv130AssignedPatientLocationPointOfCare, e.Pv131AssignedPatientLocationRoom, e.Pv132AssignedPatientLocationBed, e.Pv144AdmitDateTime }, "NCI_DischargePointOfCareLocationAssign").HasFillFactor(80);

            entity.HasIndex(e => new { e.Hl7personLogId, e.Pv130AssignedPatientLocationPointOfCare, e.Pv145DischargeDateTime }, "NCI_HL7PersonLogID_POC_DischargeDateTime").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogId, "NCI_Hl7PersonLog")
                .IsDescending()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_Hl7_ConsultingDoctor")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Hl7personLogId, "NCI_HlPersonLogId_Isolate").HasFillFactor(80);

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_PV1VisitHL7_POCAPLB_PPLB").HasFillFactor(80);

            entity.HasIndex(e => e.Pv12PatientClass, "NCI_PV1_2_PatientClass").HasFillFactor(80);

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Pv110HospitalService)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_10_HospitalService");
            entity.Property(e => e.Pv1110TemporaryLocationPointOfCare)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_11_0_TemporaryLocationPointOfCare");
            entity.Property(e => e.Pv1111TemporaryLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_11_1_TemporaryLocationRoom");
            entity.Property(e => e.Pv1112TemporaryLocationBed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_11_2_TemporaryLocationBed");
            entity.Property(e => e.Pv112PreadmitTestIndicator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_12_PreadmitTestIndicator");
            entity.Property(e => e.Pv113ReadmissionIndicator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_13_ReadmissionIndicator");
            entity.Property(e => e.Pv114AdmitSource)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_14_AdmitSource");
            entity.Property(e => e.Pv115AmbulatoryStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_15_AmbulatoryStatus");
            entity.Property(e => e.Pv116Vipindicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_16_VIPIndicator");
            entity.Property(e => e.Pv1170AdmittingDoctorIdnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PV1_17_0_AdmittingDoctorIDNumber");
            entity.Property(e => e.Pv1171AdmittingDoctorFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_17_1_AdmittingDoctorFamilyName");
            entity.Property(e => e.Pv1172AdmittingDoctorGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_17_2_AdmittingDoctorGivenName");
            entity.Property(e => e.Pv118PatientType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_18_PatientType");
            entity.Property(e => e.Pv1190VisitNumberIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_19_0_VisitNumberIDNumber");
            entity.Property(e => e.Pv11SetIdpv1).HasColumnName("PV1_1_SetIDPV1");
            entity.Property(e => e.Pv1200FinancialClassFinancialClassCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_20_0_FinancialClassFinancialClassCode");
            entity.Property(e => e.Pv121ChargePriceIndicator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_21_ChargePriceIndicator");
            entity.Property(e => e.Pv122CourtesyCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_22_CourtesyCode");
            entity.Property(e => e.Pv123CreditRating)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_23_CreditRating");
            entity.Property(e => e.Pv124ContractCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_24_ContractCode");
            entity.Property(e => e.Pv125ContractEffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("PV1_25_ContractEffectiveDate");
            entity.Property(e => e.Pv126ContractAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("PV1_26_ContractAmount");
            entity.Property(e => e.Pv127ContractPeriod)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("PV1_27_ContractPeriod");
            entity.Property(e => e.Pv128InterestCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_28_InterestCode");
            entity.Property(e => e.Pv129TransfertoBadDebtCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_29_TransfertoBadDebtCode");
            entity.Property(e => e.Pv12PatientClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_2_PatientClass");
            entity.Property(e => e.Pv130AssignedPatientLocationPointOfCare)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_0_AssignedPatientLocationPointOfCare");
            entity.Property(e => e.Pv130TransfertoBadDebtDate)
                .HasColumnType("datetime")
                .HasColumnName("PV1_30_TransfertoBadDebtDate");
            entity.Property(e => e.Pv131AssignedPatientLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_1_AssignedPatientLocationRoom");
            entity.Property(e => e.Pv131BadDebtAgencyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_31_BadDebtAgencyCode");
            entity.Property(e => e.Pv132AssignedPatientLocationBed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_2_AssignedPatientLocationBed");
            entity.Property(e => e.Pv132BadDebtTransferAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("PV1_32_BadDebtTransferAmount");
            entity.Property(e => e.Pv133AssignedPatientLocationFacility)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_3_AssignedPatientLocationFacility");
            entity.Property(e => e.Pv133BadDebtRecoveryAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("PV1_33_BadDebtRecoveryAmount");
            entity.Property(e => e.Pv134AssignedPatientLocationLocationStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_4_AssignedPatientLocationLocationStatus");
            entity.Property(e => e.Pv134DeleteAccountIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_34_DeleteAccountIndicator");
            entity.Property(e => e.Pv135AssignedPatientLocationPersonLocationType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_5_AssignedPatientLocationPersonLocationType");
            entity.Property(e => e.Pv135DeleteAccountDate)
                .HasColumnType("datetime")
                .HasColumnName("PV1_35_DeleteAccountDate");
            entity.Property(e => e.Pv136AssignedPatientLocationBuilding)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PV1_3_6_AssignedPatientLocationBuilding");
            entity.Property(e => e.Pv136DischargeDisposition)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_36_DischargeDisposition");
            entity.Property(e => e.Pv137AssignedPatientLocationFloor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_3_7_AssignedPatientLocationFloor");
            entity.Property(e => e.Pv137DischargedToLocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_37_DischargedToLocation");
            entity.Property(e => e.Pv138AssignedPatientLocationLocationDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PV1_3_8_AssignedPatientLocationLocationDescription");
            entity.Property(e => e.Pv138DietType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_38_DietType");
            entity.Property(e => e.Pv139ServicingFacility)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_39_ServicingFacility");
            entity.Property(e => e.Pv140BedStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_40_BedStatus");
            entity.Property(e => e.Pv141AccountStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_41_AccountStatus");
            entity.Property(e => e.Pv142PendingLocation)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PV1_42_PendingLocation");
            entity.Property(e => e.Pv143PriorTemporaryLocation)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PV1_43_PriorTemporaryLocation");
            entity.Property(e => e.Pv1441AdmitDateTimeDegreeOfPrecision)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("PV1_44_1_AdmitDateTime_DegreeOfPrecision");
            entity.Property(e => e.Pv144AdmitDateTime)
                .HasColumnType("datetime")
                .HasColumnName("PV1_44_AdmitDateTime");
            entity.Property(e => e.Pv145DischargeDateTime)
                .HasColumnType("datetime")
                .HasColumnName("PV1_45_DischargeDateTime");
            entity.Property(e => e.Pv14AdmissionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_4_AdmissionType");
            entity.Property(e => e.Pv150PreadmitNumberIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_5_0_PreadmitNumberIDNumber");
            entity.Property(e => e.Pv160PriorPatientLocationPointOfCare)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_0_PriorPatientLocationPointOfCare");
            entity.Property(e => e.Pv161PriorPatientLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_1_PriorPatientLocationRoom");
            entity.Property(e => e.Pv162PriorPatientLocationBed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_2_PriorPatientLocationBed");
            entity.Property(e => e.Pv163PriorPatientLocationFacility)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_3_PriorPatientLocationFacility");
            entity.Property(e => e.Pv164PriorPatientLocationLocationStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_4_PriorPatientLocationLocationStatus");
            entity.Property(e => e.Pv165PriorPatientLocationPersonLocationType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_5_PriorPatientLocationPersonLocationType");
            entity.Property(e => e.Pv166PriorPatientLocationBuilding)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PV1_6_6_PriorPatientLocationBuilding");
            entity.Property(e => e.Pv167PriorPatientLocationFloor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_7_PriorPatientLocationFloor");
            entity.Property(e => e.Pv168PriorPatientLocationLocationDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PV1_6_8_PriorPatientLocationLocationDescription");
            entity.Property(e => e.Pv170AttendingDoctorIdnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PV1_7_0_AttendingDoctorIDNumber");
            entity.Property(e => e.Pv171AttendingDoctorFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_7_1_AttendingDoctorFamilyName");
            entity.Property(e => e.Pv172AttendingDoctorGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_7_2_AttendingDoctorGivenName");
            entity.Property(e => e.Pv180ReferringDoctorIdnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PV1_8_0_ReferringDoctorIDNumber");
            entity.Property(e => e.Pv181ReferringDoctorFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_8_1_ReferringDoctorFamilyName");
            entity.Property(e => e.Pv182ReferringDoctorGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_8_2_ReferringDoctorGivenName");
            entity.Property(e => e.Pv190ConsultingDoctorIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_9_0_ConsultingDoctorIDNumber");
            entity.Property(e => e.Pv191ConsultingDoctorFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_9_1_ConsultingDoctorFamilyName");
            entity.Property(e => e.Pv192ConsultingDoctorGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_9_2_ConsultingDoctorGivenName");
        });

        modelBuilder.Entity<Pv1PatientVisitImportHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PV1_PatientVisit_ImportHistory", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Pv110HospitalService)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_10_HospitalService");
            entity.Property(e => e.Pv1110TemporaryLocationPointOfCare)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_11_0_TemporaryLocationPointOfCare");
            entity.Property(e => e.Pv1111TemporaryLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_11_1_TemporaryLocationRoom");
            entity.Property(e => e.Pv1112TemporaryLocationBed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_11_2_TemporaryLocationBed");
            entity.Property(e => e.Pv112PreadmitTestIndicator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_12_PreadmitTestIndicator");
            entity.Property(e => e.Pv113ReadmissionIndicator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_13_ReadmissionIndicator");
            entity.Property(e => e.Pv114AdmitSource)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_14_AdmitSource");
            entity.Property(e => e.Pv115AmbulatoryStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_15_AmbulatoryStatus");
            entity.Property(e => e.Pv116Vipindicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_16_VIPIndicator");
            entity.Property(e => e.Pv1170AdmittingDoctorIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_17_0_AdmittingDoctorIDNumber");
            entity.Property(e => e.Pv1171AdmittingDoctorFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_17_1_AdmittingDoctorFamilyName");
            entity.Property(e => e.Pv1172AdmittingDoctorGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_17_2_AdmittingDoctorGivenName");
            entity.Property(e => e.Pv118PatientType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_18_PatientType");
            entity.Property(e => e.Pv1190VisitNumberIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_19_0_VisitNumberIDNumber");
            entity.Property(e => e.Pv11SetIdpv1).HasColumnName("PV1_1_SetIDPV1");
            entity.Property(e => e.Pv1200FinancialClassFinancialClassCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_20_0_FinancialClassFinancialClassCode");
            entity.Property(e => e.Pv121ChargePriceIndicator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_21_ChargePriceIndicator");
            entity.Property(e => e.Pv122CourtesyCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_22_CourtesyCode");
            entity.Property(e => e.Pv123CreditRating)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_23_CreditRating");
            entity.Property(e => e.Pv124ContractCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_24_ContractCode");
            entity.Property(e => e.Pv125ContractEffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("PV1_25_ContractEffectiveDate");
            entity.Property(e => e.Pv126ContractAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("PV1_26_ContractAmount");
            entity.Property(e => e.Pv127ContractPeriod)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("PV1_27_ContractPeriod");
            entity.Property(e => e.Pv128InterestCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_28_InterestCode");
            entity.Property(e => e.Pv129TransfertoBadDebtCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_29_TransfertoBadDebtCode");
            entity.Property(e => e.Pv12PatientClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_2_PatientClass");
            entity.Property(e => e.Pv130AssignedPatientLocationPointOfCare)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_0_AssignedPatientLocationPointOfCare");
            entity.Property(e => e.Pv130TransfertoBadDebtDate)
                .HasColumnType("datetime")
                .HasColumnName("PV1_30_TransfertoBadDebtDate");
            entity.Property(e => e.Pv131AssignedPatientLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_1_AssignedPatientLocationRoom");
            entity.Property(e => e.Pv131BadDebtAgencyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_31_BadDebtAgencyCode");
            entity.Property(e => e.Pv132AssignedPatientLocationBed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_2_AssignedPatientLocationBed");
            entity.Property(e => e.Pv132BadDebtTransferAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("PV1_32_BadDebtTransferAmount");
            entity.Property(e => e.Pv133AssignedPatientLocationFacility)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_3_AssignedPatientLocationFacility");
            entity.Property(e => e.Pv133BadDebtRecoveryAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("PV1_33_BadDebtRecoveryAmount");
            entity.Property(e => e.Pv134AssignedPatientLocationLocationStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_4_AssignedPatientLocationLocationStatus");
            entity.Property(e => e.Pv134DeleteAccountIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_34_DeleteAccountIndicator");
            entity.Property(e => e.Pv135AssignedPatientLocationPersonLocationType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_5_AssignedPatientLocationPersonLocationType");
            entity.Property(e => e.Pv135DeleteAccountDate)
                .HasColumnType("datetime")
                .HasColumnName("PV1_35_DeleteAccountDate");
            entity.Property(e => e.Pv136AssignedPatientLocationBuilding)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_6_AssignedPatientLocationBuilding");
            entity.Property(e => e.Pv136DischargeDisposition)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_36_DischargeDisposition");
            entity.Property(e => e.Pv137AssignedPatientLocationFloor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_3_7_AssignedPatientLocationFloor");
            entity.Property(e => e.Pv137DischargedToLocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_37_DischargedToLocation");
            entity.Property(e => e.Pv138AssignedPatientLocationLocationDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PV1_3_8_AssignedPatientLocationLocationDescription");
            entity.Property(e => e.Pv138DietType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_38_DietType");
            entity.Property(e => e.Pv139ServicingFacility)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_39_ServicingFacility");
            entity.Property(e => e.Pv140BedStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_40_BedStatus");
            entity.Property(e => e.Pv141AccountStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PV1_41_AccountStatus");
            entity.Property(e => e.Pv142PendingLocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_42_PendingLocation");
            entity.Property(e => e.Pv143PriorTemporaryLocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_43_PriorTemporaryLocation");
            entity.Property(e => e.Pv144AdmitDateTime)
                .HasColumnType("datetime")
                .HasColumnName("PV1_44_AdmitDateTime");
            entity.Property(e => e.Pv145DischargeDateTime)
                .HasColumnType("datetime")
                .HasColumnName("PV1_45_DischargeDateTime");
            entity.Property(e => e.Pv14AdmissionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_4_AdmissionType");
            entity.Property(e => e.Pv150PreadmitNumberIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_5_0_PreadmitNumberIDNumber");
            entity.Property(e => e.Pv160PriorPatientLocationPointOfCare)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_0_PriorPatientLocationPointOfCare");
            entity.Property(e => e.Pv161PriorPatientLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_1_PriorPatientLocationRoom");
            entity.Property(e => e.Pv162PriorPatientLocationBed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_6_2_PriorPatientLocationBed");
            entity.Property(e => e.Pv170AttendingDoctorIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_7_0_AttendingDoctorIDNumber");
            entity.Property(e => e.Pv171AttendingDoctorFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_7_1_AttendingDoctorFamilyName");
            entity.Property(e => e.Pv172AttendingDoctorGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_7_2_AttendingDoctorGivenName");
            entity.Property(e => e.Pv180ReferringDoctorIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_8_0_ReferringDoctorIDNumber");
            entity.Property(e => e.Pv181ReferringDoctorFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_8_1_ReferringDoctorFamilyName");
            entity.Property(e => e.Pv182ReferringDoctorGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_8_2_ReferringDoctorGivenName");
            entity.Property(e => e.Pv190ConsultingDoctorIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PV1_9_0_ConsultingDoctorIDNumber");
            entity.Property(e => e.Pv191ConsultingDoctorFamilyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_9_1_ConsultingDoctorFamilyName");
            entity.Property(e => e.Pv192ConsultingDoctorGivenName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PV1_9_2_ConsultingDoctorGivenName");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__Reports__D5BD4805099AF6F6");

            entity.ToTable("Reports", "IMT");

            entity.Property(e => e.ReportId).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ReportLink).IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PK_RouteId");

            entity.ToTable("Route", "IMT");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RouteDescription).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RxcPharmacyTreatmentComponentOrder>(entity =>
        {
            entity.HasKey(e => e.PkRxcId).HasName("PK_RXC");

            entity.ToTable("RXC_Pharmacy_Treatment_Component_Order", "HL7");

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLog_ALL");

            entity.Property(e => e.PkRxcId).HasColumnName("pk_RXC_ID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Rxc1RxcomponentType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RXC_1_RXComponentType");
            entity.Property(e => e.Rxc21ComponentCodeIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_2_1_ComponentCode_Identifier");
            entity.Property(e => e.Rxc22ComponentCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_2_2_ComponentCode_Text");
            entity.Property(e => e.Rxc23ComponentCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_2_3_ComponentCode_NameOfCodingSystem");
            entity.Property(e => e.Rxc24ComponentCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_2_4_ComponentCode_AlternateIdentifier");
            entity.Property(e => e.Rxc25ComponentCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_2_5_ComponentCode_AlternateText");
            entity.Property(e => e.Rxc26ComponentCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_2_6_ComponentCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxc2ComponentCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_2_ComponentCode");
            entity.Property(e => e.Rxc3ComponentAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("RXC_3_ComponentAmount");
            entity.Property(e => e.Rxc41ComponentUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_4_1_ComponentUnits_Identifier");
            entity.Property(e => e.Rxc42ComponentUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_4_2_ComponentUnits_Text");
            entity.Property(e => e.Rxc43ComponentUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_4_3_ComponentUnits_NameOfCodingSystem");
            entity.Property(e => e.Rxc44ComponentUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_4_4_ComponentUnits_AlternateIdentifier");
            entity.Property(e => e.Rxc45ComponentUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_4_5_ComponentUnits_AlternateText");
            entity.Property(e => e.Rxc46ComponentUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_4_6_ComponentUnits_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxc4ComponentUnits)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_4_ComponentUnits");
            entity.Property(e => e.Rxc5ComponentStrength)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("RXC_5_ComponentStrength");
            entity.Property(e => e.Rxc61ComponentStrengthUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_6_1_ComponentStrengthUnits_Identifier");
            entity.Property(e => e.Rxc62ComponentStrengthUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_6_2_ComponentStrengthUnits_Text");
            entity.Property(e => e.Rxc63ComponentStrengthUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_6_3_ComponentStrengthUnits_NameOfCodingSystem");
            entity.Property(e => e.Rxc64ComponentStrengthUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_6_4_ComponentStrengthUnits_AlternateIdentifier");
            entity.Property(e => e.Rxc65ComponentStrengthUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_6_5_ComponentStrengthUnits_AlternateText");
            entity.Property(e => e.Rxc66ComponentStrengthUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_6_6_ComponentStrengthUnits_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxc6ComponentStrengthUnits)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_6_ComponentStrengthUnits");
            entity.Property(e => e.Rxc71SupplementaryCodeIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_7_1_Supplementary_Code_Identifier");
            entity.Property(e => e.Rxc72SupplementaryCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_7_2_Supplementary_Code_Text");
            entity.Property(e => e.Rxc73SupplementaryCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_7_3_Supplementary_Code_NameOfCodingSystem");
            entity.Property(e => e.Rxc74SupplementaryCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_7_4_Supplementary_Code_AlternateIdentifier");
            entity.Property(e => e.Rxc75SupplementaryCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_7_5_Supplementary_Code_AlternateText");
            entity.Property(e => e.Rxc76SupplementaryCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_7_6_Supplementary_Code_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxc7SupplementaryCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXC_7_Supplementary_Code");
        });

        modelBuilder.Entity<RxePharmacyTreatmentEncodedOrder>(entity =>
        {
            entity.HasKey(e => e.PkRxeId).HasName("PK_RXE_ID");

            entity.ToTable("RXE_Pharmacy_Treatment_Encoded_Order", "HL7");

            entity.HasIndex(e => e.Hl7uniqueIdentifier, "NCI_Hl7Guid_All").HasFillFactor(80);

            entity.Property(e => e.PkRxeId).HasColumnName("pk_RXE_ID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Rxe10DispenseAmount)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_10_Dispense_Amount");
            entity.Property(e => e.Rxe11010QuantityTimingOrderSequencingFillerOrderNumberUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_10_QuantityTiming_OrderSequencing_FillerOrderNumberUniversalID");
            entity.Property(e => e.Rxe11011QuantityTimingOrderSequencingFillerOrderNumberUniversalIdtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_11_QuantityTiming_OrderSequencing_FillerOrderNumberUniversalIDType");
            entity.Property(e => e.Rxe1101QuantityTimingOrderSequencingSequenceResultsFlag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_1_QuantityTiming_OrderSequencing_SequenceResultsFlag");
            entity.Property(e => e.Rxe1102QuantityTimingOrderSequencingPlacerOrderNumberEntityIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_2_QuantityTiming_OrderSequencing_PlacerOrderNumberEntityIdentifier");
            entity.Property(e => e.Rxe1103QuantityTimingOrderSequencingPlacerOrderNumberNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_3_QuantityTiming_OrderSequencing_PlacerOrderNumberNamespaceID");
            entity.Property(e => e.Rxe1104QuantityTimingOrderSequencingFillerOrderNumberEntityIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_4_QuantityTiming_OrderSequencing_FillerOrderNumberEntityIdentifier");
            entity.Property(e => e.Rxe1105QuantityTimingOrderSequencingFillerOrderNumberNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_5_QuantityTiming_OrderSequencing_FillerOrderNumberNamespaceID");
            entity.Property(e => e.Rxe1106QuantityTimingOrderSequencingSequenceConditionValue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_6_QuantityTiming_OrderSequencing_SequenceConditionValue");
            entity.Property(e => e.Rxe1107QuantityTimingOrderSequencingMaximumNumberOfRepeats)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RXE_1_10_7_QuantityTiming_OrderSequencing_MaximumNumberOfRepeats");
            entity.Property(e => e.Rxe1108QuantityTimingOrderSequencingPlacerOrderNumberUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_8_QuantityTiming_OrderSequencing_PlacerOrderNumberUniversalID");
            entity.Property(e => e.Rxe1109QuantityTimingOrderSequencingPlacerOrderNumberUniversalIdtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_10_9_QuantityTiming_OrderSequencing_PlacerOrderNumberUniversalIDType");
            entity.Property(e => e.Rxe1111QuantityTimingOccurrenceDurationIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_11_1_QuantityTiming_OccurrenceDuration_Identifier");
            entity.Property(e => e.Rxe1112QuantityTimingOccurrenceDurationText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_11_2_QuantityTiming_OccurrenceDuration_Text");
            entity.Property(e => e.Rxe1113QuantityTimingOccurrenceDurationNameOfCodingSystem)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_11_3_QuantityTiming_OccurrenceDuration_NameOfCodingSystem");
            entity.Property(e => e.Rxe1114QuantityTimingOccurrenceDurationAlternateIdentifier)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_11_4_QuantityTiming_OccurrenceDuration_AlternateIdentifier");
            entity.Property(e => e.Rxe1115QuantityTimingOccurrenceDurationAlternateText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_11_5_QuantityTiming_OccurrenceDuration_AlternateText");
            entity.Property(e => e.Rxe1116QuantityTimingOccurrenceDurationNameOfAlternateCodingSystem)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_11_6_QuantityTiming_OccurrenceDuration_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe111DispenseUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_11_1_Dispense_Units_Identifier");
            entity.Property(e => e.Rxe111QuantityTimingQuantityQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RXE_1_1_1_QuantityTiming_Quantity_Quantity");
            entity.Property(e => e.Rxe112DispenseUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_11_2_Dispense_Units_Text");
            entity.Property(e => e.Rxe112QuantityTimingTotalOccurences)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RXE_1_12_QuantityTiming_TotalOccurences");
            entity.Property(e => e.Rxe112QuantityTimingUnits)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_1_2_QuantityTiming_Units");
            entity.Property(e => e.Rxe113DispenseUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_11_3_Dispense_Units_NameOfCodingSystem");
            entity.Property(e => e.Rxe114DispenseUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_11_4_Dispense_Units_AlternateIdentifier");
            entity.Property(e => e.Rxe115DispenseUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_11_5_Dispense_Units_AlternateText");
            entity.Property(e => e.Rxe116DispenseUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_11_6_Dispense_Units_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe11QuantityTimingQuantity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_1_QuantityTiming_Quantity");
            entity.Property(e => e.Rxe121QuantityTimingIntervalRepeatPattern)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_2_1_QuantityTiming_Interval_RepeatPattern");
            entity.Property(e => e.Rxe122QuantityTimingIntervalExplicitTimeInterval)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_2_2_QuantityTiming_Interval_ExplicitTimeInterval");
            entity.Property(e => e.Rxe12NumberOfRefills)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_12_Number_Of_Refills");
            entity.Property(e => e.Rxe1310OrderingProvidersDeaNumberNameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_10_Ordering_Providers_DEA_Number_NameTypeCode");
            entity.Property(e => e.Rxe1311OrderingProvidersDeaNumberIdentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_11_Ordering_Providers_DEA_Number_IdentifierCheckDigit");
            entity.Property(e => e.Rxe1312OrderingProvidersDeaNumberCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_12_Ordering_Providers_DEA_Number_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Rxe1313OrderingProvidersDeaNumberIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_13_Ordering_Providers_DEA_Number_IdentifierTypeCode");
            entity.Property(e => e.Rxe13141OrderingProvidersDeaNumberAssigningFacilityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_14_1_Ordering_Providers_DEA_Number_AssigningFacility_NamespaceId");
            entity.Property(e => e.Rxe13142OrderingProvidersDeaNumberAssigningFacilityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_14_2_Ordering_Providers_DEA_Number_AssigningFacility_UniversalId");
            entity.Property(e => e.Rxe13143OrderingProvidersDeaNumberAssigningFacilityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_14_3_Ordering_Providers_DEA_Number_AssigningFacility_UniversalIdType");
            entity.Property(e => e.Rxe1315OrderingProvidersDeaNumberNameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_15_Ordering_Providers_DEA_Number_NameRepresentationCode");
            entity.Property(e => e.Rxe13161OrderingProvidersDeaNumberNameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_16_1_Ordering_Providers_DEA_Number_Name_Context_Identifier");
            entity.Property(e => e.Rxe13162OrderingProvidersDeaNumberNameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_16_2_Ordering_Providers_DEA_Number_Name_Context_Text");
            entity.Property(e => e.Rxe13163OrderingProvidersDeaNumberNameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_16_3_Ordering_Providers_DEA_Number_Name_Context_NameOfCodingSystem");
            entity.Property(e => e.Rxe13164OrderingProvidersDeaNumberNameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_16_4_Ordering_Providers_DEA_Number_Name_Context_AlternateIdentifier");
            entity.Property(e => e.Rxe13165OrderingProvidersDeaNumberNameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_16_5_Ordering_Providers_DEA_Number_Name_Context_AlternateText");
            entity.Property(e => e.Rxe13166OrderingProvidersDeaNumberNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_16_6_Ordering_Providers_DEA_Number_Name_Context_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe13171OrderingProvidersDeaNumberNameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXE_13_17_1_Ordering_Providers_DEA_Number_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Rxe13172OrderingProvidersDeaNumberNameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXE_13_17_2_Ordering_Providers_DEA_Number_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Rxe1318OrderingProvidersDeaNumberNameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_18_Ordering_Providers_DEA_Number_NameAssemblyOrder");
            entity.Property(e => e.Rxe131OrderingProvidersDeaNumberIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_1_Ordering_Providers_DEA_Number_IdNumber");
            entity.Property(e => e.Rxe1321OrderingProvidersDeaNumberFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_2_1_Ordering_Providers_DEA_Number_FamilyName_Surname");
            entity.Property(e => e.Rxe1322OrderingProvidersDeaNumberFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_2_2_Ordering_Providers_DEA_Number_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Rxe1323OrderingProvidersDeaNumberFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_2_3_Ordering_Providers_DEA_Number_FamilyName_OwnSurname");
            entity.Property(e => e.Rxe1324OrderingProvidersDeaNumberFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_2_4_Ordering_Providers_DEA_Number_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Rxe1325OrderingProvidersDeaNumberFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_2_5_Ordering_Providers_DEA_Number_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Rxe133OrderingProvidersDeaNumberGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_3_Ordering_Providers_DEA_Number_GivenName");
            entity.Property(e => e.Rxe134OrderingProvidersDeaNumberSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_4_Ordering_Providers_DEA_Number_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Rxe135OrderingProvidersDeaNumberSuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_5_Ordering_Providers_DEA_Number_Suffix");
            entity.Property(e => e.Rxe136OrderingProvidersDeaNumberPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_6_Ordering_Providers_DEA_Number_Prefix");
            entity.Property(e => e.Rxe137OrderingProvidersDeaNumberDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_7_Ordering_Providers_DEA_Number_Degree");
            entity.Property(e => e.Rxe138OrderingProvidersDeaNumberSourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_8_Ordering_Providers_DEA_Number_SourceTable");
            entity.Property(e => e.Rxe1391OrderingProvidersDeaNumberAssigningAuthorityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_9_1_Ordering_Providers_DEA_Number_AssigningAuthority_NamespaceID");
            entity.Property(e => e.Rxe1392OrderingProvidersDeaNumberAssigningAuthorityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_9_2_Ordering_Providers_DEA_Number_AssigningAuthority_UniversalId");
            entity.Property(e => e.Rxe1393OrderingProvidersDeaNumberAssigningAuthorityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_13_9_3_Ordering_Providers_DEA_Number_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Rxe13QuantityTimingDuration)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_3_QuantityTiming_Duration");
            entity.Property(e => e.Rxe1410PharmacistTreatmentSuppliersVerifierIdnameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_10_PharmacistTreatmentSuppliersVerifierIDNameTypeCode");
            entity.Property(e => e.Rxe1411PharmacistTreatmentSuppliersVerifierIdidentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_11_PharmacistTreatmentSuppliersVerifierIDIdentifierCheckDigit");
            entity.Property(e => e.Rxe1412PharmacistTreatmentSuppliersVerifierIdCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_12_PharmacistTreatmentSuppliersVerifierID_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Rxe1413PharmacistTreatmentSuppliersVerifierIdIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_13_PharmacistTreatmentSuppliersVerifierID_IdentifierTypeCode");
            entity.Property(e => e.Rxe14141PharmacistTreatmentSuppliersVerifierIdAssigningFacilityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_14_1_PharmacistTreatmentSuppliersVerifierID_AssigningFacility_NamespaceId");
            entity.Property(e => e.Rxe14142PharmacistTreatmentSuppliersVerifierIdAssigningFacilityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_14_2_PharmacistTreatmentSuppliersVerifierID_AssigningFacility_UniversalId");
            entity.Property(e => e.Rxe14143PharmacistTreatmentSuppliersVerifierIdAssigningFacilityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_14_3_PharmacistTreatmentSuppliersVerifierID_AssigningFacility_UniversalIdType");
            entity.Property(e => e.Rxe1415PharmacistTreatmentSuppliersVerifierIdNameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_15_PharmacistTreatmentSuppliersVerifierID_NameRepresentationCode");
            entity.Property(e => e.Rxe14161PharmacistTreatmentSuppliersVerifierIdNameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_16_1_PharmacistTreatmentSuppliersVerifierID_NameContext_Identifier");
            entity.Property(e => e.Rxe14162PharmacistTreatmentSuppliersVerifierIdNameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_16_2_PharmacistTreatmentSuppliersVerifierID_NameContext_Text");
            entity.Property(e => e.Rxe14163PharmacistTreatmentSuppliersVerifierIdNameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_16_3_PharmacistTreatmentSuppliersVerifierID_NameContext_NameOfCodingSystem");
            entity.Property(e => e.Rxe14164PharmacistTreatmentSuppliersVerifierIdNameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_16_4_PharmacistTreatmentSuppliersVerifierID_NameContext_AlternateIdentifier");
            entity.Property(e => e.Rxe14165PharmacistTreatmentSuppliersVerifierIdNameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_16_5_PharmacistTreatmentSuppliersVerifierID_NameContext_AlternateText");
            entity.Property(e => e.Rxe14166PharmacistTreatmentSuppliersVerifierIdNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_16_6_PharmacistTreatmentSuppliersVerifierID_NameContext_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe14171PharmacistTreatmentSuppliersVerifierIdNameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXE_14_17_1_PharmacistTreatmentSuppliersVerifierID_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Rxe14172PharmacistTreatmentSuppliersVerifierIdNameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXE_14_17_2_PharmacistTreatmentSuppliersVerifierID_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Rxe1418PharmacistTreatmentSuppliersVerifierIdNameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_18_PharmacistTreatmentSuppliersVerifierID_NameAssemblyOrder");
            entity.Property(e => e.Rxe141PharmacistTreatmentSuppliersVerifierIdIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_1_PharmacistTreatmentSuppliersVerifierID_IdNumber");
            entity.Property(e => e.Rxe141QuantityTimingStartDateTimeTimeOfAnEvent)
                .HasColumnType("datetime")
                .HasColumnName("RXE_1_4_1_QuantityTiming_StartDateTime_TimeOfAnEvent");
            entity.Property(e => e.Rxe1421PharmacistTreatmentSuppliersVerifierIdFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_2_1_PharmacistTreatmentSuppliersVerifierID_FamilyName_Surname");
            entity.Property(e => e.Rxe1422PharmacistTreatmentSuppliersVerifierIdFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_2_2_PharmacistTreatmentSuppliersVerifierID_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Rxe1423PharmacistTreatmentSuppliersVerifierIdFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_2_3_PharmacistTreatmentSuppliersVerifierID_FamilyName_OwnSurname");
            entity.Property(e => e.Rxe1424PharmacistTreatmentSuppliersVerifierIdFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_2_4_PharmacistTreatmentSuppliersVerifierID_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Rxe1425PharmacistTreatmentSuppliersVerifierIdFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_2_5_PharmacistTreatmentSuppliersVerifierID_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Rxe142QuantityTimingStartDateTimeDegreeOfPrecision)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_4_2_QuantityTiming_StartDateTime_DegreeOfPrecision");
            entity.Property(e => e.Rxe143PharmacistTreatmentSuppliersVerifierIdGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_3_PharmacistTreatmentSuppliersVerifierID_GivenName");
            entity.Property(e => e.Rxe144PharmacistTreatmentSuppliersVerifierIdSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_4_PharmacistTreatmentSuppliersVerifierID_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Rxe145PharmacistTreatmentSuppliersVerifierIdSuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_5_PharmacistTreatmentSuppliersVerifierID_Suffix");
            entity.Property(e => e.Rxe146PharmacistTreatmentSuppliersVerifierIdPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_6_PharmacistTreatmentSuppliersVerifierID_Prefix");
            entity.Property(e => e.Rxe147PharmacistTreatmentSuppliersVerifierIdDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_7_PharmacistTreatmentSuppliersVerifierID_Degree");
            entity.Property(e => e.Rxe148PharmacistTreatmentSuppliersVerifierIdSourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_8_PharmacistTreatmentSuppliersVerifierID_SourceTable");
            entity.Property(e => e.Rxe1491PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_9_1_PharmacistTreatmentSuppliersVerifierID_AssigningAuthority_NamespaceId");
            entity.Property(e => e.Rxe1492PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_9_2_PharmacistTreatmentSuppliersVerifierID_AssigningAuthority_UniversalId");
            entity.Property(e => e.Rxe1493PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_14_9_3_PharmacistTreatmentSuppliersVerifierID_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Rxe151QuantityTimingEndDateTimeTimeOfAnEvent)
                .HasColumnType("datetime")
                .HasColumnName("RXE_1_5_1_QuantityTiming_EndDateTime_TimeOfAnEvent");
            entity.Property(e => e.Rxe152QuantityTimingEndDateTimeDegreeOfPrecision)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_5_2_QuantityTiming_EndDateTime_DegreeOfPrecision");
            entity.Property(e => e.Rxe15PrescriptionNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_15_PrescriptionNumber");
            entity.Property(e => e.Rxe16NumberofRefillsRemaining)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_16_NumberofRefillsRemaining");
            entity.Property(e => e.Rxe16QuantityTimingPriority)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_6_QuantityTiming_Priority");
            entity.Property(e => e.Rxe17NumberOfRefillsDosesDispensed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_17_NumberOfRefillsDosesDispensed");
            entity.Property(e => e.Rxe17QuantityTimingCondition)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_7_QuantityTiming_Condition");
            entity.Property(e => e.Rxe181DtofMostRecentRefillOrDoseDispensedTimeOfAnEvent)
                .HasColumnType("datetime")
                .HasColumnName("RXE_18_1_DTOfMostRecentRefillOrDoseDispensed_TimeOfAnEvent");
            entity.Property(e => e.Rxe182DtofMostRecentRefillOrDoseDispensedDegreeOfPrecision)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_18_2_DTOfMostRecentRefillOrDoseDispensed_DegreeOfPrecision");
            entity.Property(e => e.Rxe18QuantityTimingText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_8_QuantityTiming_Text");
            entity.Property(e => e.Rxe191TotalDailyDoseQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RXE_19_1_TotalDailyDose_Quantity");
            entity.Property(e => e.Rxe192TotalDailyDoseUnits)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_19_2_TotalDailyDose_Units");
            entity.Property(e => e.Rxe19QuantityTimingConjunctionComponent)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_1_9_QuantityTiming_ConjunctionComponent");
            entity.Property(e => e.Rxe20NeedsHumanReview)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_20_NeedsHumanReview");
            entity.Property(e => e.Rxe211PharmacyTreatmentSuppliersSpecialDispensingInstructionsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_21_1_PharmacyTreatmentSuppliersSpecialDispensingInstructions_Identifier");
            entity.Property(e => e.Rxe212PharmacyTreatmentSuppliersSpecialDispensingInstructionsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_21_2_PharmacyTreatmentSuppliersSpecialDispensingInstructions_Text");
            entity.Property(e => e.Rxe213PharmacyTreatmentSuppliersSpecialDispensingInstructionsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_21_3_PharmacyTreatmentSuppliersSpecialDispensingInstructions_NameOfCodingSystem");
            entity.Property(e => e.Rxe214PharmacyTreatmentSuppliersSpecialDispensingInstructionsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_21_4_PharmacyTreatmentSuppliersSpecialDispensingInstructions_AlternateIdentifier");
            entity.Property(e => e.Rxe215PharmacyTreatmentSuppliersSpecialDispensingInstructionsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_21_5_PharmacyTreatmentSuppliersSpecialDispensingInstructions_AlternateText");
            entity.Property(e => e.Rxe216PharmacyTreatmentSuppliersSpecialDispensingInstructionsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_21_6_PharmacyTreatmentSuppliersSpecialDispensingInstructions_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe21GivenCodeIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_2_1_GivenCode_Identifier");
            entity.Property(e => e.Rxe22GivePerTimeUnits)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_22_GivePerTimeUnits");
            entity.Property(e => e.Rxe22GivenCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_2_2_GivenCode_Text");
            entity.Property(e => e.Rxe23GiveRateAmount)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_23_GiveRateAmount");
            entity.Property(e => e.Rxe23GivenCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_2_3_GivenCode_NameOfCodingSystem");
            entity.Property(e => e.Rxe241GiveRateUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_24_1_GiveRateUnits_Identifier");
            entity.Property(e => e.Rxe242GiveRateUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_24_2_GiveRateUnits_Text");
            entity.Property(e => e.Rxe243GiveRateUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_24_3_GiveRateUnits_NameOfCodingSystem");
            entity.Property(e => e.Rxe244GiveRateUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_24_4_GiveRateUnits_AlternateIdentifier");
            entity.Property(e => e.Rxe245GiveRateUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_24_5_GiveRateUnits_AlternateText");
            entity.Property(e => e.Rxe246GiveRateUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_24_6_GiveRateUnits_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe24GivenCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_2_4_GivenCode_AlternateIdentifier");
            entity.Property(e => e.Rxe25GiveStrength)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_25_GiveStrength");
            entity.Property(e => e.Rxe25GivenCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_2_5_GivenCode_AlternateText");
            entity.Property(e => e.Rxe261GiveStrengthUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_26_1_GiveStrengthUnits_Identifier");
            entity.Property(e => e.Rxe262GiveStrengthUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_26_2_GiveStrengthUnits_Text");
            entity.Property(e => e.Rxe263GiveStrengthUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_26_3_GiveStrengthUnits_NameOfCodingSystem");
            entity.Property(e => e.Rxe264GiveStrengthUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_26_4_GiveStrengthUnits_AlternateIdentifier");
            entity.Property(e => e.Rxe265GiveStrengthUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_26_5_GiveStrengthUnits_AlternateText");
            entity.Property(e => e.Rxe266GiveStrengthUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_26_6_GiveStrengthUnits_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe26GivenCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_2_6_GivenCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe271GiveIndicationIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_27_1_GiveIndication_Identifier");
            entity.Property(e => e.Rxe272GiveIndicationText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_27_2_GiveIndication_Text");
            entity.Property(e => e.Rxe273GiveIndicationNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_27_3_GiveIndication_NameOfCodingSystem");
            entity.Property(e => e.Rxe274GiveIndicationAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_27_4_GiveIndication_AlternateIdentifier");
            entity.Property(e => e.Rxe275GiveIndicationAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_27_5_GiveIndication_AlternateText");
            entity.Property(e => e.Rxe276GiveIndicationNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_27_6_GiveIndication_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe28DispensePackageSize)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_28_DispensePackageSize");
            entity.Property(e => e.Rxe291DispensePackageSizeUnitIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_29_1_Dispense_Package_Size_Unit_Identifier");
            entity.Property(e => e.Rxe292DispensePackageSizeUnitText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_29_2_Dispense_Package_Size_Unit_Text");
            entity.Property(e => e.Rxe293DispensePackageSizeUnitNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_29_3_Dispense_Package_Size_Unit_NameOfCodingSystem");
            entity.Property(e => e.Rxe294DispensePackageSizeUnitAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_29_4_Dispense_Package_Size_Unit_AlternateIdentifier");
            entity.Property(e => e.Rxe295DispensePackageSizeUnitAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_29_5_Dispense_Package_Size_Unit_AlternateText");
            entity.Property(e => e.Rxe296DispensePackageSizeUnitNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_29_6_Dispense_Package_Size_Unit_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe30DispensePackageMethod)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_30_Dispense_Package_Method");
            entity.Property(e => e.Rxe311SupplementaryCodeIdenntifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_31_1_Supplementary_Code_Idenntifier");
            entity.Property(e => e.Rxe312SupplementaryCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_31_2_Supplementary_Code_Text");
            entity.Property(e => e.Rxe313SupplementaryCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_31_3_Supplementary_Code_NameOfCodingSystem");
            entity.Property(e => e.Rxe314SupplementaryCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_31_4_Supplementary_Code_AlternateIdentifier");
            entity.Property(e => e.Rxe315SupplementaryCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_31_5_Supplementary_Code_AlternateText");
            entity.Property(e => e.Rxe316SupplementaryCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_31_6_Supplementary_Code_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe3GivenAmountMinimum)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RXE_3_GivenAmountMinimum");
            entity.Property(e => e.Rxe4GiveAmountMaximum)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RXE_4_GiveAmountMaximum");
            entity.Property(e => e.Rxe51GiveUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_5_1_Give_Units_Identifier");
            entity.Property(e => e.Rxe52GiveUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_5_2_Give_Units_Text");
            entity.Property(e => e.Rxe53GiveUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_5_3_Give_Units_NameOfCodingSystem");
            entity.Property(e => e.Rxe54GiveUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_5_4_Give_Units_AlternateIdentifier");
            entity.Property(e => e.Rxe55GiveUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_5_5_Give_Units_AlternateText");
            entity.Property(e => e.Rxe56GiveUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_5_6_Give_Units_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe61GiveDosageFormIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_6_1_Give_Dosage_Form_Identifier");
            entity.Property(e => e.Rxe62GiveDosageFormText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_6_2_Give_Dosage_Form_Text");
            entity.Property(e => e.Rxe63GiveDosageFormNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_6_3_Give_Dosage_Form_NameOfCodingSystem");
            entity.Property(e => e.Rxe64GiveDosageFormAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_6_4_Give_Dosage_Form_AlternateIdentifier");
            entity.Property(e => e.Rxe65GiveDosageFormAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_6_5_Give_Dosage_Form_AlternateText");
            entity.Property(e => e.Rxe66GiveDosageFormNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_6_6_Give_Dosage_Form_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe71ProvidersAdministrationInstructionsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_7_1_Providers_Administration_Instructions_Identifier");
            entity.Property(e => e.Rxe72ProvidersAdministrationInstructionsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_7_2_Providers_Administration_Instructions_Text");
            entity.Property(e => e.Rxe73ProvidersAdministrationInstructionsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_7_3_Providers_Administration_Instructions_NameOfCodingSystem");
            entity.Property(e => e.Rxe74ProvidersAdministrationInstructionsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_7_4_Providers_Administration_Instructions_AlternateIdentifier");
            entity.Property(e => e.Rxe75ProvidersAdministrationInstructionsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_7_5_Providers_Administration_Instructions_AlternateText");
            entity.Property(e => e.Rxe76ProvidersAdministrationInstructionsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_7_6_Providers_Administration_Instructions_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxe81DeliverToLocationPointOfCare)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_1_Deliver_To_Location_PointOfCare");
            entity.Property(e => e.Rxe82DeliverToLocationRoom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_2_Deliver_To_Location_Room");
            entity.Property(e => e.Rxe83DeliverToLocationBed)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_3_Deliver_To_Location_Bed");
            entity.Property(e => e.Rxe841DeliverToLocationFacilityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_4_1_Deliver_To_Location_Facility_NamespaceId");
            entity.Property(e => e.Rxe842DeliverToLocationFacilityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_4_2_Deliver_To_Location_Facility_UniversalId");
            entity.Property(e => e.Rxe843DeliverToLocationFacilityUniversalIdType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_4_3_Deliver_To_Location_Facility_UniversalIdType");
            entity.Property(e => e.Rxe85DeliverToLocationLocationStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_5_Deliver_To_Location_LocationStatus");
            entity.Property(e => e.Rxe86DeliverToLocationPersonLocationType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_6_Deliver_To_Location_PersonLocationType");
            entity.Property(e => e.Rxe87DeliverToLocationBuilding)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_7_Deliver_To_Location_Building");
            entity.Property(e => e.Rxe88DeliverToLocationFloor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_8_Deliver_To_Location_Floor");
            entity.Property(e => e.Rxe891DeliverToLocationAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_9_1_Deliver_To_Location_Address_StreetAddress");
            entity.Property(e => e.Rxe892DeliverToLocationAddressOtherDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_9_2_Deliver_To_Location_Address_OtherDesignation");
            entity.Property(e => e.Rxe893DeliverToLocationAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_9_3_Deliver_To_Location_Address_City");
            entity.Property(e => e.Rxe894DeliverToLocationAddressStateOrProcince)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_9_4_Deliver_To_Location_Address_StateOrProcince");
            entity.Property(e => e.Rxe895DeliverToLocationAddressZipOrPostalCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_9_5_Deliver_To_Location_Address_ZipOrPostalCode");
            entity.Property(e => e.Rxe896DeliverToLocationAddressCountry)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_9_6_Deliver_To_Location_Address_Country");
            entity.Property(e => e.Rxe897DeliverToLocationAddressAddressType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_9_7_Deliver_To_Location_Address_AddressType");
            entity.Property(e => e.Rxe898DeliverToLocationAddressOtherGeographicDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXE_8_9_8_Deliver_To_Location_Address_OtherGeographicDesignation");
            entity.Property(e => e.Rxe9SubstitutionStatus)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXE_9_Substitution_Status");
        });

        modelBuilder.Entity<RxoPharmacyTreatmentOrder>(entity =>
        {
            entity.HasKey(e => e.PkRxoId).HasName("PK_RXO");

            entity.ToTable("RXO_Pharmacy_Treatment_Order", "HL7");

            entity.Property(e => e.PkRxoId).HasColumnName("pk_RXO_ID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Rxo101RequestedDispenseCodeIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_10_1_RequestedDispenseCode_Identifier");
            entity.Property(e => e.Rxo102RequestedDispenseCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_10_2_RequestedDispenseCode_Text");
            entity.Property(e => e.Rxo103RequestedDispenseCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_10_3_RequestedDispenseCode_NameOfCodingSystem");
            entity.Property(e => e.Rxo104RequestedDispenseCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_10_4_RequestedDispenseCode_AlternateIdentifier");
            entity.Property(e => e.Rxo105RequestedDispenseCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_10_5_RequestedDispenseCode_AlternateText");
            entity.Property(e => e.Rxo106RequestedDispenseCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_10_6_RequestedDispenseCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo11RequestedDispenseAmount)
                .HasColumnType("numeric(20, 2)")
                .HasColumnName("RXO_11_RequestedDispenseAmount");
            entity.Property(e => e.Rxo11RequestedGivenCodeIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_1_1_RequestedGivenCode_Identifier");
            entity.Property(e => e.Rxo121RequestedDispenseUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_12_1_RequestedDispenseUnits_Identifier");
            entity.Property(e => e.Rxo122RequestedDispenseUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_12_2_RequestedDispenseUnits_Text");
            entity.Property(e => e.Rxo123RequestedDispenseUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_12_3_RequestedDispenseUnits_NameOfCodingSystem");
            entity.Property(e => e.Rxo124RequestedDispenseUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_12_4_RequestedDispenseUnits_AlternateIdentifier");
            entity.Property(e => e.Rxo125RequestedDispenseUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_12_5_RequestedDispenseUnits_AlternateText");
            entity.Property(e => e.Rxo126RequestedDispenseUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_12_6_RequestedDispenseUnits_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo12RequestedGivenCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_1_2_RequestedGivenCode_Text");
            entity.Property(e => e.Rxo13NumberOfRefills)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("RXO_13_NumberOfRefills");
            entity.Property(e => e.Rxo13RequestedGivenCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_1_3_RequestedGivenCode_NameOfCodingSystem");
            entity.Property(e => e.Rxo1410OrderingProvidersDeanumberNameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_10_OrderingProvidersDEANumber_NameTypeCode");
            entity.Property(e => e.Rxo1411OrderingProvidersDeanumberIdentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_11_OrderingProvidersDEANumber_IdentifierCheckDigit");
            entity.Property(e => e.Rxo1412OrderingProvidersDeanumberCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_12_OrderingProvidersDEANumber_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Rxo1413OrderingProvidersDeanumberIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_13_OrderingProvidersDEANumber_IdentifierTypeCode");
            entity.Property(e => e.Rxo14141OrderingProvidersDeanumberAssigningFacilityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_14_1_OrderingProvidersDEANumber_AssigningFacility_NamespaceId");
            entity.Property(e => e.Rxo14142OrderingProvidersDeanumberAssigningFacilityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_14_2_OrderingProvidersDEANumber_AssigningFacility_UniversalId");
            entity.Property(e => e.Rxo14143OrderingProvidersDeanumberAssigningFacilityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_14_3_OrderingProvidersDEANumber_AssigningFacility_UniversalIdType");
            entity.Property(e => e.Rxo1415OrderingProvidersDeanumberNameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_15_OrderingProvidersDEANumber_NameRepresentationCode");
            entity.Property(e => e.Rxo14161OrderingProvidersDeanumberNameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_16_1_OrderingProvidersDEANumber_NameContext_Identifier");
            entity.Property(e => e.Rxo14162OrderingProvidersDeanumberNameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_16_2_OrderingProvidersDEANumber_NameContext_Text");
            entity.Property(e => e.Rxo14163OrderingProvidersDeanumberNameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_16_3_OrderingProvidersDEANumber_NameContext_NameOfCodingSystem");
            entity.Property(e => e.Rxo14164OrderingProvidersDeanumberNameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_16_4_OrderingProvidersDEANumber_NameContext_AlternateIdentifier");
            entity.Property(e => e.Rxo14165OrderingProvidersDeanumberNameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_16_5_OrderingProvidersDEANumber_NameContext_AlternateText");
            entity.Property(e => e.Rxo14166OrderingProvidersDeanumberNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_16_6_OrderingProvidersDEANumber_NameContext_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo14171OrderingProvidersDeanumberNameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXO_14_17_1_OrderingProvidersDEANumber_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Rxo14172OrderingProvidersDeanumberNameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXO_14_17_2_OrderingProvidersDEANumber_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Rxo1418OrderingProvidersDeanumberNameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_18_OrderingProvidersDEANumber_NameAssemblyOrder");
            entity.Property(e => e.Rxo141OrderingProvidersDeanumberIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_1_OrderingProvidersDEANumber_IdNumber");
            entity.Property(e => e.Rxo1421OrderingProvidersDeanumberFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_2_1_OrderingProvidersDEANumber_FamilyName_Surname");
            entity.Property(e => e.Rxo1422OrderingProvidersDeanumberFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_2_2_OrderingProvidersDEANumber_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Rxo1423OrderingProvidersDeanumberFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_2_3_OrderingProvidersDEANumber_FamilyName_OwnSurname");
            entity.Property(e => e.Rxo1424OrderingProvidersDeanumberFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_2_4_OrderingProvidersDEANumber_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Rxo1425OrderingProvidersDeanumberFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_2_5_OrderingProvidersDEANumber_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Rxo143OrderingProvidersDeanumberGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_3_OrderingProvidersDEANumber_GivenName");
            entity.Property(e => e.Rxo144OrderingProvidersDeanumberSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_4_OrderingProvidersDEANumber_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Rxo145OrderingProvidersDeanumberSuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_5_OrderingProvidersDEANumber_Suffix");
            entity.Property(e => e.Rxo146OrderingProvidersDeanumberPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_6_OrderingProvidersDEANumber_Prefix");
            entity.Property(e => e.Rxo147OrderingProvidersDeanumberDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_7_OrderingProvidersDEANumber_Degree");
            entity.Property(e => e.Rxo148OrderingProvidersDeanumberSourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_8_OrderingProvidersDEANumber_SourceTable");
            entity.Property(e => e.Rxo1491OrderingProvidersDeanumberAssigningAuthorityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_9_1_OrderingProvidersDEANumber_AssigningAuthority_NamespaceId");
            entity.Property(e => e.Rxo1492OrderingProvidersDeanumberAssigningAuthorityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_9_2_OrderingProvidersDEANumber_AssigningAuthority_UniversalId");
            entity.Property(e => e.Rxo1493OrderingProvidersDeanumberAssigningAuthorityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_14_9_3_OrderingProvidersDEANumber_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Rxo14RequestedGivenCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_1_4_RequestedGivenCode_AlternateIdentifier");
            entity.Property(e => e.Rxo1510PharmacistTreatmentSuppliersVerifierIdNameTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_10_PharmacistTreatmentSuppliersVerifierID_NameTypeCode");
            entity.Property(e => e.Rxo1511PharmacistTreatmentSuppliersVerifierIdIdentifierCheckDigit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_11_PharmacistTreatmentSuppliersVerifierID_IdentifierCheckDigit");
            entity.Property(e => e.Rxo1512PharmacistTreatmentSuppliersVerifierIdCodeIdentifyingTheCheckDigitSchemeEmployed)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_12_PharmacistTreatmentSuppliersVerifierID_CodeIdentifyingTheCheckDigitSchemeEmployed");
            entity.Property(e => e.Rxo1513PharmacistTreatmentSuppliersVerifierIdIdentifierTypeCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_13_PharmacistTreatmentSuppliersVerifierID_IdentifierTypeCode");
            entity.Property(e => e.Rxo15141PharmacistTreatmentSuppliersVerifierIdAssigningFacilityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_14_1_PharmacistTreatmentSuppliersVerifierID_AssigningFacility_NamespaceId");
            entity.Property(e => e.Rxo15142PharmacistTreatmentSuppliersVerifierIdAssigningFacilityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_14_2_PharmacistTreatmentSuppliersVerifierID_AssigningFacility_UniversalId");
            entity.Property(e => e.Rxo15143PharmacistTreatmentSuppliersVerifierIdAssigningFacilityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_14_3_PharmacistTreatmentSuppliersVerifierID_AssigningFacility_UniversalIdType");
            entity.Property(e => e.Rxo1515PharmacistTreatmentSuppliersVerifierIdNameRepresentationCode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_15_PharmacistTreatmentSuppliersVerifierID_NameRepresentationCode");
            entity.Property(e => e.Rxo15161PharmacistTreatmentSuppliersVerifierIdNameContextIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_16_1_PharmacistTreatmentSuppliersVerifierID_NameContext_Identifier");
            entity.Property(e => e.Rxo15162PharmacistTreatmentSuppliersVerifierIdNameContextText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_16_2_PharmacistTreatmentSuppliersVerifierID_NameContext_Text");
            entity.Property(e => e.Rxo15163PharmacistTreatmentSuppliersVerifierIdNameContextNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_16_3_PharmacistTreatmentSuppliersVerifierID_NameContext_NameOfCodingSystem");
            entity.Property(e => e.Rxo15164PharmacistTreatmentSuppliersVerifierIdNameContextAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_16_4_PharmacistTreatmentSuppliersVerifierID_NameContext_AlternateIdentifier");
            entity.Property(e => e.Rxo15165PharmacistTreatmentSuppliersVerifierIdNameContextAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_16_5_PharmacistTreatmentSuppliersVerifierID_NameContext_AlternateText");
            entity.Property(e => e.Rxo15166PharmacistTreatmentSuppliersVerifierIdNameContextNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_16_6_PharmacistTreatmentSuppliersVerifierID_NameContext_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo15171PharmacistTreatmentSuppliersVerifierIdNameValidityRangeRangeStartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXO_15_17_1_PharmacistTreatmentSuppliersVerifierID_NameValidityRange_RangeStartDateTime");
            entity.Property(e => e.Rxo15172PharmacistTreatmentSuppliersVerifierIdNameValidityRangeRangeEndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("RXO_15_17_2_PharmacistTreatmentSuppliersVerifierID_NameValidityRange_RangeEndDateTime");
            entity.Property(e => e.Rxo1518PharmacistTreatmentSuppliersVerifierIdNameAssemblyOrder)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_18_PharmacistTreatmentSuppliersVerifierID_NameAssemblyOrder");
            entity.Property(e => e.Rxo151PharmacistTreatmentSuppliersVerifierIdIdNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_1_PharmacistTreatmentSuppliersVerifierID_IdNumber");
            entity.Property(e => e.Rxo1521PharmacistTreatmentSuppliersVerifierIdFamilyNameSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_2_1_PharmacistTreatmentSuppliersVerifierID_FamilyName_Surname");
            entity.Property(e => e.Rxo1522PharmacistTreatmentSuppliersVerifierIdFamilyNameOwnSurnamePrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_2_2_PharmacistTreatmentSuppliersVerifierID_FamilyName_OwnSurnamePrefix");
            entity.Property(e => e.Rxo1523PharmacistTreatmentSuppliersVerifierIdFamilyNameOwnSurname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_2_3_PharmacistTreatmentSuppliersVerifierID_FamilyName_OwnSurname");
            entity.Property(e => e.Rxo1524PharmacistTreatmentSuppliersVerifierIdFamilyNameSurnamePrefixFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_2_4_PharmacistTreatmentSuppliersVerifierID_FamilyName_SurnamePrefixFromPartnerSpouse");
            entity.Property(e => e.Rxo1525PharmacistTreatmentSuppliersVerifierIdFamilyNameSurnameFromPartnerSpouse)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_2_5_PharmacistTreatmentSuppliersVerifierID_FamilyName_SurnameFromPartnerSpouse");
            entity.Property(e => e.Rxo153PharmacistTreatmentSuppliersVerifierIdGivenName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_3_PharmacistTreatmentSuppliersVerifierID_GivenName");
            entity.Property(e => e.Rxo154PharmacistTreatmentSuppliersVerifierIdSecondAndFurtherGivenNamesOrInitialsThereof)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_4_PharmacistTreatmentSuppliersVerifierID_SecondAndFurtherGivenNamesOrInitialsThereof");
            entity.Property(e => e.Rxo155PharmacistTreatmentSuppliersVerifierIdSuffix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_5_PharmacistTreatmentSuppliersVerifierID_Suffix");
            entity.Property(e => e.Rxo156PharmacistTreatmentSuppliersVerifierIdPrefix)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_6_PharmacistTreatmentSuppliersVerifierID_Prefix");
            entity.Property(e => e.Rxo157PharmacistTreatmentSuppliersVerifierIdDegree)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_7_PharmacistTreatmentSuppliersVerifierID_Degree");
            entity.Property(e => e.Rxo158PharmacistTreatmentSuppliersVerifierIdSourceTable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_8_PharmacistTreatmentSuppliersVerifierID_SourceTable");
            entity.Property(e => e.Rxo1591PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityNamespaceId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_9_1_PharmacistTreatmentSuppliersVerifierID_AssigningAuthority_NamespaceId");
            entity.Property(e => e.Rxo1592PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityUniversalId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_9_2_PharmacistTreatmentSuppliersVerifierID_AssigningAuthority_UniversalId");
            entity.Property(e => e.Rxo1593PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityUniversalIdType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_15_9_3_PharmacistTreatmentSuppliersVerifierID_AssigningAuthority_UniversalIdType");
            entity.Property(e => e.Rxo15RequestedGivenCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_1_5_RequestedGivenCode_AlternateText");
            entity.Property(e => e.Rxo16NeedsHumanReview)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RXO_16_NeedsHumanReview");
            entity.Property(e => e.Rxo16RequestedGivenCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_1_6_RequestedGivenCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo17RequestedGivePerTimeUnit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RXO_17_RequestedGivePerTimeUnit");
            entity.Property(e => e.Rxo18RequestedGiveStrength)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RXO_18_RequestedGiveStrength");
            entity.Property(e => e.Rxo191RequestedGiveStrengthUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_19_1_RequestedGiveStrengthUnits_Identifier");
            entity.Property(e => e.Rxo192RequestedGiveStrengthUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_19_2_RequestedGiveStrengthUnits_Text");
            entity.Property(e => e.Rxo193RequestedGiveStrengthUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_19_3_RequestedGiveStrengthUnits_NameOfCodingSystem");
            entity.Property(e => e.Rxo194RequestedGiveStrengthUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_19_4_RequestedGiveStrengthUnits_AlternateIdentifier");
            entity.Property(e => e.Rxo195RequestedGiveStrengthUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_19_5_RequestedGiveStrengthUnits_AlternateText");
            entity.Property(e => e.Rxo196RequestedGiveStrengthUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_19_6_RequestedGiveStrengthUnits_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo201IndicationIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_20_1_Indication_Identifier");
            entity.Property(e => e.Rxo202IndicationText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_20_2_Indication_Text");
            entity.Property(e => e.Rxo203IndicationNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_20_3_Indication_NameOfCodingSystem");
            entity.Property(e => e.Rxo204IndicationAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_20_4_Indication_AlternateIdentifier");
            entity.Property(e => e.Rxo205IndicationAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_20_5_Indication_AlternateText");
            entity.Property(e => e.Rxo206Indication)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_20_6_Indication");
            entity.Property(e => e.Rxo206IndicationNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_20_6_Indication_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo21RequestedGiveStrengthUnits)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_21_RequestedGiveStrengthUnits");
            entity.Property(e => e.Rxo221RequestedGiveRateUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_22_1_RequestedGiveRateUnits_Identifier");
            entity.Property(e => e.Rxo222RequestedGiveRateUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_22_2_RequestedGiveRateUnits_Text");
            entity.Property(e => e.Rxo223RequestedGiveRateUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_22_3_RequestedGiveRateUnits_NameOfCodingSystem");
            entity.Property(e => e.Rxo224RequestedGiveRateUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_22_4_RequestedGiveRateUnits_AlternateIdentifier");
            entity.Property(e => e.Rxo225RequestedGiveRateUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_22_5_RequestedGiveRateUnits_AlternateText");
            entity.Property(e => e.Rxo226RequestedGiveRateUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_22_6_RequestedGiveRateUnits_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo231TotalDailyDoseQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RXO_23_1_TotalDailyDose_Quantity");
            entity.Property(e => e.Rxo232TotalDailyDoseUnits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RXO_23_2_TotalDailyDose_Units");
            entity.Property(e => e.Rxo241SupplementaryCodeIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_24_1_SupplementaryCode_Identifier");
            entity.Property(e => e.Rxo242SupplementaryCodeText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_24_2_SupplementaryCode_Text");
            entity.Property(e => e.Rxo243SupplementaryCodeNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_24_3_SupplementaryCode_NameOfCodingSystem");
            entity.Property(e => e.Rxo244SupplementaryCodeAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_24_4_SupplementaryCode_AlternateIdentifier");
            entity.Property(e => e.Rxo245SupplementaryCodeAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_24_5_SupplementaryCode_AlternateText");
            entity.Property(e => e.Rxo246SupplementaryCodeNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_24_6_SupplementaryCode_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo2RequestedGiveAmountMinimum)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("RXO_2_RequestedGiveAmountMinimum");
            entity.Property(e => e.Rxo3RequestedGiveAmountMaximum)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("RXO_3_RequestedGiveAmountMaximum");
            entity.Property(e => e.Rxo41RequestedGiveUnitsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_4_1_RequestedGiveUnits_Identifier");
            entity.Property(e => e.Rxo42RequestedGiveUnitsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_4_2_RequestedGiveUnits_Text");
            entity.Property(e => e.Rxo43RequestedGiveUnitsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_4_3_RequestedGiveUnits_NameOfCodingSystem");
            entity.Property(e => e.Rxo44RequestedGiveUnitsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_4_4_RequestedGiveUnits_AlternateIdentifier");
            entity.Property(e => e.Rxo45RequestedGiveUnitsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_4_5_RequestedGiveUnits_AlternateText");
            entity.Property(e => e.Rxo46RequestedGiveUnitsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_4_6_RequestedGiveUnits_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo51RequestedDosageFormIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_5_1_RequestedDosageForm_Identifier");
            entity.Property(e => e.Rxo52RequestedDosageFormText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_5_2_RequestedDosageForm_Text");
            entity.Property(e => e.Rxo53RequestedDosageFormNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_5_3_RequestedDosageForm_NameOfCodingSystem");
            entity.Property(e => e.Rxo54RequestedDosageFormAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_5_4_RequestedDosageForm_AlternateIdentifier");
            entity.Property(e => e.Rxo55RequestedDosageFormAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_5_5_RequestedDosageForm_AlternateText");
            entity.Property(e => e.Rxo56RequestedDosageFormNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_5_6_RequestedDosageForm_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo61ProvidersPharmacyTreatmentInstructionsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_6_1_ProvidersPharmacyTreatmentInstructions_Identifier");
            entity.Property(e => e.Rxo62ProvidersPharmacyTreatmentInstructionsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_6_2_ProvidersPharmacyTreatmentInstructions_Text");
            entity.Property(e => e.Rxo63ProvidersPharmacyTreatmentInstructionsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_6_3_ProvidersPharmacyTreatmentInstructions_NameOfCodingSystem");
            entity.Property(e => e.Rxo64ProvidersPharmacyTreatmentInstructionsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_6_4_ProvidersPharmacyTreatmentInstructions_AlternateIdentifier");
            entity.Property(e => e.Rxo65ProvidersPharmacyTreatmentInstructionsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_6_5_ProvidersPharmacyTreatmentInstructions_AlternateText");
            entity.Property(e => e.Rxo66ProvidersPharmacyTreatmentInstructionsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_6_6_ProvidersPharmacyTreatmentInstructions_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo71ProvidersAdministrationInstructionsIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_7_1_ProvidersAdministrationInstructions_Identifier");
            entity.Property(e => e.Rxo72ProvidersAdministrationInstructionsText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_7_2_ProvidersAdministrationInstructions_Text");
            entity.Property(e => e.Rxo73ProvidersAdministrationInstructionsNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_7_3_ProvidersAdministrationInstructions_NameOfCodingSystem");
            entity.Property(e => e.Rxo74ProvidersAdministrationInstructionsAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_7_4_ProvidersAdministrationInstructions_AlternateIdentifier");
            entity.Property(e => e.Rxo75ProvidersAdministrationInstructionsAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_7_5_ProvidersAdministrationInstructions_AlternateText");
            entity.Property(e => e.Rxo76ProvidersAdministrationInstructionsNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXO_7_6_ProvidersAdministrationInstructions_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxo81DeliverToLocationPointOfCare)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_1_DeliverToLocation_PointOfCare");
            entity.Property(e => e.Rxo82DeliverToLocationRoom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_2_DeliverToLocation_Room");
            entity.Property(e => e.Rxo83DeliverToLocationBed)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_3_DeliverToLocation_Bed");
            entity.Property(e => e.Rxo841DeliverToLocationFacilityNamespaceId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_4_1_DeliverToLocation_Facility_NamespaceId");
            entity.Property(e => e.Rxo842DeliverToLocationFacilityUniversalId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_4_2_DeliverToLocation_Facility_UniversalId");
            entity.Property(e => e.Rxo843DeliverToLocationFacilityUniversalIdType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_4_3_DeliverToLocation_Facility_UniversalIdType");
            entity.Property(e => e.Rxo85DeliverToLocationLocationStatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_5_DeliverToLocation_LocationStatus");
            entity.Property(e => e.Rxo86DeliverToLocationPatientLocationType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_6_DeliverToLocation_PatientLocationType");
            entity.Property(e => e.Rxo87DeliverToLocationBuilding)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_7_DeliverToLocation_Building");
            entity.Property(e => e.Rxo88DeliverToLocationFloor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_8_DeliverToLocation_Floor");
            entity.Property(e => e.Rxo891DeliverToLocationAddressStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_9_1_DeliverToLocation_Address_StreetAddress");
            entity.Property(e => e.Rxo892DeliverToLocationAddressOtherDesignated)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_9_2_DeliverToLocation_Address_OtherDesignated");
            entity.Property(e => e.Rxo893DeliverToLocationAddressCity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_9_3_DeliverToLocation_Address_City");
            entity.Property(e => e.Rxo894DeliverToLocationAddressStateOrProvince)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_9_4_DeliverToLocation_Address_StateOrProvince");
            entity.Property(e => e.Rxo895DeliverToLocationAddressZipOrPostalCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_9_5_DeliverToLocation_Address_ZipOrPostalCode");
            entity.Property(e => e.Rxo896DeliverToLocationAddressCountry)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_9_6_DeliverToLocation_Address_Country");
            entity.Property(e => e.Rxo897DeliverToLocationAddressAddressType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_9_7_DeliverToLocation_Address_AddressType");
            entity.Property(e => e.Rxo898DeliverToLocationAddressOtherGeographicDesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RXO_8_9_8_DeliverToLocation_Address_OtherGeographicDesignation");
            entity.Property(e => e.Rxo9AllowSubstitutions)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RXO_9_AllowSubstitutions");
        });

        modelBuilder.Entity<RxrPharmacyTreatmentRoute>(entity =>
        {
            entity.HasKey(e => e.PkRxrId).HasName("PK_RXR");

            entity.ToTable("RXR_Pharmacy_Treatment_Route", "HL7");

            entity.HasIndex(e => e.Hl7personLogId, "NCI_PersonLog").HasFillFactor(80);

            entity.Property(e => e.PkRxrId).HasColumnName("pk_RXR_ID");
            entity.Property(e => e.Hl7personLogId).HasColumnName("HL7PersonLogID");
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.Rxr11RouteIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_1_1_Route_Identifier");
            entity.Property(e => e.Rxr12RouteText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_1_2_Route_Text");
            entity.Property(e => e.Rxr13RouteNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_1_3_Route_NameOfCodingSystem");
            entity.Property(e => e.Rxr14RouteAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_1_4_Route_AlternateIdentifier");
            entity.Property(e => e.Rxr15RouteAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_1_5_Route_AlternateText");
            entity.Property(e => e.Rxr16RouteNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_1_6_Route_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxr1Route)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_1_Route");
            entity.Property(e => e.Rxr21AdministrationSiteIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_2_1_AdministrationSite_Identifier");
            entity.Property(e => e.Rxr22AdministrationSiteText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_2_2_AdministrationSite_Text");
            entity.Property(e => e.Rxr23AdministrationSiteNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_2_3_AdministrationSite_NameOfCodingSystem");
            entity.Property(e => e.Rxr24AdministrationSiteAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_2_4_AdministrationSite_AlternateIdentifier");
            entity.Property(e => e.Rxr25AdministrationSiteAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_2_5_AdministrationSite_AlternateText");
            entity.Property(e => e.Rxr26AdministrationSiteNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_2_6_AdministrationSite_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxr2AdministrationSite)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_2_AdministrationSite");
            entity.Property(e => e.Rxr31AdministrationDeviceIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_3_1_AdministrationDevice_Identifier");
            entity.Property(e => e.Rxr32AdministrationDeviceText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_3_2_AdministrationDevice_Text");
            entity.Property(e => e.Rxr33AdministrationDeviceNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_3_3_AdministrationDevice_NameOfCodingSystem");
            entity.Property(e => e.Rxr34AdministrationDeviceAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_3_4_AdministrationDevice_AlternateIdentifier");
            entity.Property(e => e.Rxr35AdministrationDeviceAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_3_5_AdministrationDevice_AlternateText");
            entity.Property(e => e.Rxr36AdministrationDeviceNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_3_6_AdministrationDevice_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxr3AdministrationDevice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_3_AdministrationDevice");
            entity.Property(e => e.Rxr41AdministrationMethodIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_4_1_AdministrationMethod_Identifier");
            entity.Property(e => e.Rxr42AdministrationMethodText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_4_2_AdministrationMethod_Text");
            entity.Property(e => e.Rxr43AdministrationMethodNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_4_3_AdministrationMethod_NameOfCodingSystem");
            entity.Property(e => e.Rxr44AdministrationMethodAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_4_4_AdministrationMethod_AlternateIdentifier");
            entity.Property(e => e.Rxr45AdministrationMethodAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_4_5_AdministrationMethod_AlternateText");
            entity.Property(e => e.Rxr46AdministrationMethodNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_4_6_AdministrationMethod_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxr4AdministrationMethod)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_4_AdministrationMethod");
            entity.Property(e => e.Rxr51RoutingInstructionIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_5_1_RoutingInstruction_Identifier");
            entity.Property(e => e.Rxr52RoutingInstructionText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_5_2_RoutingInstruction_Text");
            entity.Property(e => e.Rxr53RoutingInstructionNameOfCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_5_3_RoutingInstruction_NameOfCodingSystem");
            entity.Property(e => e.Rxr54RoutingInstructionAlternateIdentifier)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_5_4_RoutingInstruction_AlternateIdentifier");
            entity.Property(e => e.Rxr55RoutingInstructionAlternateText)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_5_5_RoutingInstruction_AlternateText");
            entity.Property(e => e.Rxr56RoutingInstructionNameOfAlternateCodingSystem)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_5_6_RoutingInstruction_NameOfAlternateCodingSystem");
            entity.Property(e => e.Rxr5RoutingInstruction)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RXR_5_RoutingInstruction");
        });

        modelBuilder.Entity<Saphl7message>(entity =>
        {
            entity.HasKey(e => e.Saphl7msgId).HasName("PK__SAPHL7Me__3F2CADC840EE3083");

            entity.ToTable("SAPHL7Messages", "HL7");

            entity.Property(e => e.Saphl7msgId).HasColumnName("SAPHL7MsgID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Hl7message).HasColumnName("HL7Message");
            entity.Property(e => e.Hl7msgTypeId).HasColumnName("HL7MsgTypeID");
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Saphl7msgType>(entity =>
        {
            entity.HasKey(e => e.Hl7msgTypeId).HasName("PK__SAPHL7Ms__39BE82B0CAB095CC");

            entity.ToTable("SAPHL7MsgTypes", "HL7");

            entity.Property(e => e.Hl7msgTypeId).HasColumnName("HL7MsgTypeID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Created_Date");
            entity.Property(e => e.MessageType).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<SapstockMasterWeekly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SAPStockMasterWeekly", "IMT");

            entity.Property(e => e.ActiveIngredient)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT");
            entity.Property(e => e.ActiveIngredient2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT2");
            entity.Property(e => e.ActiveIngredient2Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT2 DESCRIPTION");
            entity.Property(e => e.ActiveIngredient3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT3");
            entity.Property(e => e.ActiveIngredient3Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT3 DESCRIPTION");
            entity.Property(e => e.ActiveIngredient4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT4");
            entity.Property(e => e.ActiveIngredient4Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT4 DESCRIPTION");
            entity.Property(e => e.ActiveIngredient5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT5");
            entity.Property(e => e.ActiveIngredient5Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT5 DESCRIPTION");
            entity.Property(e => e.ActiveIngredient6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT6");
            entity.Property(e => e.ActiveIngredient6Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT6 DESCRIPTION");
            entity.Property(e => e.ActiveIngredient7)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT7");
            entity.Property(e => e.ActiveIngredient7Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT7 DESCRIPTION");
            entity.Property(e => e.ActiveIngredient8)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT8");
            entity.Property(e => e.ActiveIngredient8Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT8 DESCRIPTION");
            entity.Property(e => e.ActiveIngredientQty)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT QTY");
            entity.Property(e => e.ActiveIngredientText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT TEXT");
            entity.Property(e => e.ActiveIngredientUnit)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACTIVE INGREDIENT UNIT");
            entity.Property(e => e.AnestheticIndicator)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ANESTHETIC INDICATOR");
            entity.Property(e => e.AtcCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ATC CODE");
            entity.Property(e => e.AtcCodeText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ATC CODE TEXT");
            entity.Property(e => e.AtcCodeType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ATC CODE TYPE");
            entity.Property(e => e.BarCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BAR CODE");
            entity.Property(e => e.ConsumableIndicator)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONSUMABLE INDICATOR");
            entity.Property(e => e.DateTo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DATE TO");
            entity.Property(e => e.DeletionIndicator)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DELETION INDICATOR");
            entity.Property(e => e.DiscontinuedFlag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DISCONTINUED FLAG");
            entity.Property(e => e.DiscontinuedFlagText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DISCONTINUED FLAG TEXT");
            entity.Property(e => e.ExternalMaterialGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EXTERNAL MATERIAL GROUP");
            entity.Property(e => e.ImportTrackingId).HasColumnName("ImportTrackingID");
            entity.Property(e => e.IndustrySector)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INDUSTRY SECTOR");
            entity.Property(e => e.IndustrySectorDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INDUSTRY SECTOR DESCRIPTION");
            entity.Property(e => e.KeyOfActiveIngredient1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KEY OF ACTIVE INGREDIENT1");
            entity.Property(e => e.KeyOfActiveIngredient2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KEY OF ACTIVE INGREDIENT2");
            entity.Property(e => e.KeyOfActiveIngredient3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KEY OF ACTIVE INGREDIENT3");
            entity.Property(e => e.KeyOfActiveIngredient4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KEY OF ACTIVE INGREDIENT4");
            entity.Property(e => e.KeyOfActiveIngredient5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KEY OF ACTIVE INGREDIENT5");
            entity.Property(e => e.KeyOfActiveIngredient6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KEY OF ACTIVE INGREDIENT6");
            entity.Property(e => e.KeyOfActiveIngredient7)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KEY OF ACTIVE INGREDIENT7");
            entity.Property(e => e.KeyOfActiveIngredient8)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KEY OF ACTIVE INGREDIENT8");
            entity.Property(e => e.ListPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("LIST PRICE");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.ManufacturerText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURER TEXT");
            entity.Property(e => e.Material)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MATERIAL");
            entity.Property(e => e.MaterialCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MATERIAL CATEGORY");
            entity.Property(e => e.MaterialCategoryDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATERIAL CATEGORY DESCRIPTION");
            entity.Property(e => e.MaterialGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MATERIAL GROUP");
            entity.Property(e => e.MaterialGroupDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATERIAL GROUP DESCRIPTION");
            entity.Property(e => e.MaterialGroupSubDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATERIAL GROUP SUB DESCRIPTION");
            entity.Property(e => e.MaterialServiceMasterRecord)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MATERIAL SERVICE MASTER RECORD");
            entity.Property(e => e.MaterialStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATERIAL STATUS");
            entity.Property(e => e.MaterialText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MATERIAL TEXT");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MATERIAL TYPE");
            entity.Property(e => e.MaterialTypeText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MATERIAL TYPE TEXT");
            entity.Property(e => e.MimsMedicalSpecialities)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MIMS MEDICAL SPECIALITIES");
            entity.Property(e => e.MimsMedicalSpecialitiesDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MIMS MEDICAL SPECIALITIES DESCRIPTION");
            entity.Property(e => e.NapCurrency)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NAP CURRENCY");
            entity.Property(e => e.NapPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NAP PRICE");
            entity.Property(e => e.NappiCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NAPPI CODE");
            entity.Property(e => e.NepCurrency)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NEP CURRENCY");
            entity.Property(e => e.NepPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NEP PRICE");
            entity.Property(e => e.OldMaterialNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OLD MATERIAL NUMBER");
            entity.Property(e => e.PackSize)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PACK SIZE");
            entity.Property(e => e.SepScheduleNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SEP SCHEDULE NUMBER");
            entity.Property(e => e.SepScheduleNumberDescription)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEP SCHEDULE NUMBER DESCRIPTION");
            entity.Property(e => e.StockGroup)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("STOCK GROUP");
            entity.Property(e => e.StockGroupText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("STOCK GROUP TEXT");
            entity.Property(e => e.StockSubGroup)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("STOCK SUB GROUP");
            entity.Property(e => e.StockSubGroupText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("STOCK SUB GROUP TEXT");
            entity.Property(e => e.SupplierProductCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER PRODUCT CODE");
            entity.Property(e => e.Unit)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIT");
            entity.Property(e => e.Vendor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VENDOR");
            entity.Property(e => e.VendorDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR DESCRIPTION");
        });

        modelBuilder.Entity<SapwardDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Device");

            entity.ToTable("SAPWardDevice", "IMT");

            entity.Property(e => e.CapturedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceReference).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.SapNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.WardNumber).HasMaxLength(50);

            entity.HasOne(d => d.Device).WithMany(p => p.SapwardDevices)
                .HasForeignKey(d => d.DeviceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedDevice_Device");
        });

        modelBuilder.Entity<SurgicalBcaauditAnswer>(entity =>
        {
            entity.HasKey(e => e.AnswerId);

            entity.ToTable("SurgicalBCAAuditAnswer", "IMT");

            entity.Property(e => e.BedNo).HasMaxLength(50);
            entity.Property(e => e.CaseNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ProcedureCodeIdentifier)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcedureDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Question).WithMany(p => p.SurgicalBcaauditAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgicalBCAAuditAnswer_SurgicalBCAAuditQuestion");
        });

        modelBuilder.Entity<SurgicalBcaauditHeading>(entity =>
        {
            entity.HasKey(e => e.SauditHeadingId);

            entity.ToTable("SurgicalBCAAuditHeading", "IMT");

            entity.Property(e => e.SauditHeadingId)
                .ValueGeneratedNever()
                .HasColumnName("SAuditHeadingId");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Text).HasMaxLength(500);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SurgicalBcaauditQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId);

            entity.ToTable("SurgicalBCAAuditQuestion", "IMT");

            entity.Property(e => e.QuestionId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SurgicalDiscipline>(entity =>
        {
            entity.ToTable("SurgicalDisciplines", "IMT");

            entity.Property(e => e.Text).HasMaxLength(100);
        });

        modelBuilder.Entity<SurgicalProphylaxisAntibiotic>(entity =>
        {
            entity.ToTable("SurgicalProphylaxisAntibiotics", "IMT");

            entity.Property(e => e.Text).HasMaxLength(100);
        });

        modelBuilder.Entity<SurgicalProphylaxisAuditAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Answers");

            entity.ToTable("SurgicalProphylaxisAuditAnswers", "IMT");

            entity.Property(e => e.CaseNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SurgicalProphylaxisAuditQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Questions");

            entity.ToTable("SurgicalProphylaxisAuditQuestions", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Text)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SurgicalProphylaxisQuestionOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_[IMT].SurgicalProphylaxisQuestionOption");

            entity.ToTable("SurgicalProphylaxisQuestionOptions", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SurgicalProphylaxisScriptUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SurgicalProphylaxisScriptUpdate");

            entity.ToTable("SurgicalProphylaxisScriptUpdates", "IMT");

            entity.Property(e => e.AdministrationTime).HasColumnType("datetime");
            entity.Property(e => e.AntibioticName).HasMaxLength(255);
            entity.Property(e => e.AntibioticNameOther).HasMaxLength(255);
            entity.Property(e => e.CaseNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DiscontinuationTime).HasColumnType("datetime");
            entity.Property(e => e.DoctorName).HasMaxLength(255);
            entity.Property(e => e.DoseIdValue).HasMaxLength(255);
            entity.Property(e => e.DoseValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FrequencyValue).HasMaxLength(255);
            entity.Property(e => e.IncisionTime).HasColumnType("datetime");
            entity.Property(e => e.LoadingDose).HasMaxLength(200);
            entity.Property(e => e.SurgicalDisciplineValue).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SurgicalProphylaxisSelectableOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SurgicalProphylaxisSelectableOption");

            entity.ToTable("SurgicalProphylaxisSelectableOptions", "IMT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Text).HasMaxLength(50);
        });

        modelBuilder.Entity<TempUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TempUpda__3214EC27527FD18E");

            entity.ToTable("TempUpdate", "HL7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CaseNo).HasMaxLength(255);
            entity.Property(e => e.Hl7uniqueIdentifier).HasColumnName("HL7UniqueIdentifier");
            entity.Property(e => e.LogId).HasColumnName("logID");
        });

        modelBuilder.Entity<TmpLancetCatelogue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmpLance__3214EC27F87B4DCC");

            entity.ToTable("tmpLancetCatelogue", "IMT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupName).HasColumnName("Group Name");
        });

        modelBuilder.Entity<TransplantRegion>(entity =>
        {
            entity.HasKey(e => e.TransplantRegionId).HasName("pk_HL7_TransplantRegion");

            entity.ToTable("TransplantRegion", "HL7", tb => tb.HasComment("Stores the Transplant Regions synced from SAP using data services"));

            entity.HasIndex(e => e.RegionCode, "idx_HL7_TransplantRegion");

            entity.Property(e => e.TransplantRegionId).HasColumnName("TransplantRegionID");
            entity.Property(e => e.RegionBegin).HasColumnType("datetime");
            entity.Property(e => e.RegionCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegionDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RegionEnd).HasColumnType("datetime");
        });

        modelBuilder.Entity<TransplantType>(entity =>
        {
            entity.HasKey(e => e.TransplantTypeId).HasName("pk_HL7_TransplantType");

            entity.ToTable("TransplantType", "HL7", tb => tb.HasComment("Stores the Transplant Types synced from SAP using data services"));

            entity.HasIndex(e => e.TypeCode, "idx_HL7_TransplantType");

            entity.Property(e => e.TransplantTypeId).HasColumnName("TransplantTypeID");
            entity.Property(e => e.TypeBegin).HasColumnType("datetime");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TypeDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TypeEnd).HasColumnType("datetime");
        });

        modelBuilder.Entity<TransplantUserNotification>(entity =>
        {
            entity.HasKey(e => e.TransplantUserNotificationId).HasName("pk_HL7_TransplantUserNotification");

            entity.ToTable("TransplantUserNotification", "HL7", tb => tb.HasComment("Stores the configuration for which staff members need to receive region and type specific Transplant notfications."));

            entity.HasIndex(e => new { e.TransplantRegionId, e.TransplantTypeId }, "idx_HL7_TransplantUserNotification");

            entity.Property(e => e.TransplantUserNotificationId).HasColumnName("TransplantUserNotificationID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TransplantRegionId).HasColumnName("TransplantRegionID");
            entity.Property(e => e.TransplantTypeId).HasColumnName("TransplantTypeID");
            entity.Property(e => e.UserName)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.TransplantRegion).WithMany(p => p.TransplantUserNotifications)
                .HasForeignKey(d => d.TransplantRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transplan__Trans__2097C3F2");

            entity.HasOne(d => d.TransplantType).WithMany(p => p.TransplantUserNotifications)
                .HasForeignKey(d => d.TransplantTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transplan__Trans__218BE82B");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User", "IMT");

            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .IsFixedLength();
            entity.Property(e => e.Username)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAbxCurrentAuditDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AbxCurrentAuditDay", "IMT");

            entity.Property(e => e.AbxauditId).HasColumnName("ABXAuditID");
        });

        modelBuilder.Entity<VwAbxautoClosedAuditDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ABXAutoClosedAuditDay", "IMT");

            entity.Property(e => e.AbxauditId).HasColumnName("ABXAuditID");
            entity.Property(e => e.InstitutionId).HasColumnName("institutionID");
        });

        modelBuilder.Entity<VwImtlatestCaseStatesWithAdmissionDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_IMTLatestCaseStatesWithAdmissionDetails", "IMT");

            entity.Property(e => e.AdmissionType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.AdmittedDate).HasColumnType("datetime");
            entity.Property(e => e.AdmittingDoctor)
                .HasMaxLength(405)
                .IsUnicode(false);
            entity.Property(e => e.CaseNumber).HasMaxLength(100);
            entity.Property(e => e.CaseNumberL)
                .HasMaxLength(100)
                .HasColumnName("CaseNumber_L");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DischargedDate).HasColumnType("datetime");
            entity.Property(e => e.Hl7personLogIdcurrentLocation).HasColumnName("HL7PersonLogIDCurrentLocation");
            entity.Property(e => e.Hl7uniqueIdentifierCurrentLocation).HasColumnName("HL7UniqueIdentifierCurrentLocation");
            entity.Property(e => e.InstitutionMasterId).HasColumnName("InstitutionMasterID");
            entity.Property(e => e.InstitutionSapIshCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LatestCaseStatesIdL).HasColumnName("LatestCaseStatesId_L");
            entity.Property(e => e.PatientClass)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PatientCurrentlyAdmittedL).HasColumnName("PatientCurrentlyAdmitted_L");
            entity.Property(e => e.PatientDeathDateTime).HasColumnType("datetime");
            entity.Property(e => e.PatientDob)
                .HasColumnType("date")
                .HasColumnName("PatientDOB");
            entity.Property(e => e.PatientFirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientFullName)
                .HasMaxLength(401)
                .IsUnicode(false);
            entity.Property(e => e.PatientIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PatientIDNumber");
            entity.Property(e => e.PatientLocationBed)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientLocationPointOfCare)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientLocationPointOfCareL)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PatientLocationPointOfCare_L");
            entity.Property(e => e.PatientLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PatientMedicalAid)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientMedicalAidPolicyNumber)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientPminumber).HasColumnName("PatientPMINumber");
            entity.Property(e => e.PatientSex)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatientStreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatientSurname)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WardDescriptionL)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("WardDescription_L");
        });

        modelBuilder.Entity<WorkListResolveReason>(entity =>
        {
            entity.ToTable("WorkListResolveReasons", "IMT");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.IsVisibleOnUi)
                .HasDefaultValueSql("('TRUE')")
                .HasColumnName("IsVisibleOnUI");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<XiEvnEventTypeCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XI_EVN_EventTypeCode", "HL7");

            entity.Property(e => e.DateTimeInserted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EventTypeCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EventTypeDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
