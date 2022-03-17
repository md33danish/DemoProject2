﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EngineersAppWebCore.Models
{
    public partial class SP_GetAllJobsForAEngineerResult
    {
        public Guid Id { get; set; }
        public Guid ClaimId { get; set; }
        public Guid EngineerId { get; set; }
        public long JobId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsComplete { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingAddress { get; set; }
        public string AllocatedEngineerTime { get; set; }
        public DateTime EngineerAllocatedForDate { get; set; }
        public DateTime? EndServiceDate { get; set; }
        public string JobType { get; set; }
        public string TicketEmail { get; set; }
        public string AppointmentTime { get; set; }
        public decimal? ESTIMATESFNOL { get; set; }
        public string ESTIMATESFNOLDescription { get; set; }
        public decimal? PARTS { get; set; }
        public string PARTSFNOLDescription { get; set; }
        public decimal? LABOUR { get; set; }
        public string LABOURDescription { get; set; }
        public decimal? OTHER { get; set; }
        public string OTHERDescription { get; set; }
        public decimal? AGREEDAMOUNT { get; set; }
        public string AGREEDAMOUNTDescription { get; set; }
        public decimal? GRANDTOTAL { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? EngineerESTIMATESFNOL { get; set; }
        public string EngineerESTIMATESFNOLDescription { get; set; }
        public decimal? EngineerPARTS { get; set; }
        public string EngineerPARTSFNOLDescription { get; set; }
        public decimal? EngineerLABOUR { get; set; }
        public string EngineerLABOURDescription { get; set; }
        public decimal? EngineerOTHER { get; set; }
        public string EngineerOTHERDescription { get; set; }
        public decimal? EngineerAGREEDAMOUNT { get; set; }
        public string EngineerAGREEDAMOUNTDescription { get; set; }
        public decimal? EngineerGRANDTOTAL { get; set; }
        public bool InvoiceCreated { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? EngineerNet { get; set; }
        public decimal? EngineerVat { get; set; }
        public decimal? EngineerGross { get; set; }
        public bool? InvoiceApproved { get; set; }
        public long? InvoiceApprovedBy { get; set; }
        public DateTime? InvoiceApprovedDate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Age { get; set; }
        public string Notes { get; set; }
        public string AppointmentEndTime { get; set; }
        public bool? JobCompleted { get; set; }
        public decimal? RATING { get; set; }
        public string RATENOTE { get; set; }
        public string FILEPATH { get; set; }
        public bool? CannotGetContactToGetAccess { get; set; }
        public bool? AppointmentBooked { get; set; }
        public string JobStatus { get; set; }
        public int? EngineerClusterAppointmentId { get; set; }
        public string RiskContactName { get; set; }
        public string RiskContactNo1 { get; set; }
        public string RiskContactNo2 { get; set; }
        public string EngineerReportParts { get; set; }
        public string MoreInfo { get; set; }
        public int? RouteOrder { get; set; }
        public decimal? Distance { get; set; }
        public long? RequiredArrTime { get; set; }
        public string ApproxArrTime { get; set; }
        public string TimeType { get; set; }
        public decimal? DistanceBetweenJobs { get; set; }
        public string TimeBetweenJobs { get; set; }
        public string DetailsWork { get; set; }
        public int? NoOfAppTested { get; set; }
        public DateTime? NextDueDt { get; set; }
        public string OGIns { get; set; }
        public string OGSup { get; set; }
        public string ECon { get; set; }
        public string OGTight { get; set; }
        public string EquiBond { get; set; }
        public string SigImage { get; set; }
        public string SigRec { get; set; }
        public DateTime? FlueChkDt { get; set; }
        public string CertificateName { get; set; }
        public DateTime? CertificateDate { get; set; }
        public DateTime? ArrivedAtJobDatetime { get; set; }
        public decimal? Points { get; set; }
        public bool? ShowJobsOnEApp { get; set; }
        public int? AuthMReason { get; set; }
        public string AuthMMake { get; set; }
        public string AuthMModel { get; set; }
        public int? AuthMAge { get; set; }
        public decimal? AuthMBoilerValue { get; set; }
        public decimal? AuthMMarketValue { get; set; }
        public decimal? AuthMBERLimit { get; set; }
        public decimal? AuthCostOfLabour { get; set; }
        public string AuthTotalCntrbtn_PartsCost_Formula { get; set; }
        public string AuthBERLimit_TotalCntrbtn_Formula { get; set; }
        public string AuthTotalCntrbtn_Formula { get; set; }
        public string AuthCntrbtnToCollect_Formula { get; set; }
        public decimal? Auth1stHour { get; set; }
        public decimal? AuthAdditionalHour { get; set; }
        public bool? AuthMissedDiagnosis { get; set; }
        public int? AuthBerReasonId { get; set; }
        public int? AuthOutcomeId { get; set; }
        public string AuthGivenHour { get; set; }
        public string AuthGivenMin { get; set; }
        public DateTime? AuthGivenDateTime { get; set; }
        public long? AuthGivenBy { get; set; }
        public DateTime? OnRoute { get; set; }
        public DateTime? ArrivedAtJob { get; set; }
        public DateTime? EngineerJobCompleteDate { get; set; }
        public Guid? FkJSId { get; set; }
        public bool? NewInvoiceRoutine { get; set; }
        public int? NewRouteOrder { get; set; }
        public decimal? NewDistance { get; set; }
        public string NewEstimatedArrTime { get; set; }
        public string NewActualArrTime { get; set; }
        public decimal? NewDistanceBetweenJobs { get; set; }
        public decimal? NewTimeBetweenJobs { get; set; }
        public string SigImageBase64 { get; set; }
        public bool? IsAllPartsConfirmed { get; set; }
        public long? PartsConfirmedBy { get; set; }
        public DateTime? PartsConfirmedOn { get; set; }
        public string COFitted { get; set; }
        public string COTested { get; set; }
        public int? ComboClaimJobId { get; set; }
        public bool? ComboIsComplete { get; set; }
        public string ComboCantCompleteReason { get; set; }
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }
        public bool GenericQuestionAsked { get; set; }
        public Guid? ClientID { get; set; }
        public string ClaimRef { get; set; }
        public long? CreatedBy { get; set; }
       // public DateTime? CreatedOn { get; set; }
        public Guid? StatusID { get; set; }
        public bool? IsHighPriority { get; set; }
        public string Priority { get; set; }
        public Guid? AllocatedEngineerId { get; set; }
        public DateTime? EngineerAllocatedDate { get; set; }
        public bool ResolvedIssue { get; set; }
        //public string AllocatedEngineerTime { get; set; }
        //public DateTime? EngineerAllocatedForDate { get; set; }
        public string PolicyDocument { get; set; }
        public string TCDocument { get; set; }
        public string CancelReason { get; set; }
        public bool? IsCancel { get; set; }
        public int JobID { get; set; }
        public Guid? LeadID { get; set; }
        public string ReferReason { get; set; }
        public Guid? ClaimTypeId { get; set; }
        //public DateTime? EndServiceDate { get; set; }
        //public string Make { get; set; }
        //public string Model { get; set; }
        //public string Age { get; set; }
        //public string Notes { get; set; }
        public string FilePath { get; set; }
        public string RemedialWorkRecomendations { get; set; }
        public decimal? AgreedFee { get; set; }
        public decimal? InvoiceAmount { get; set; }
        //public DateTime? InvoiceDate { get; set; }
        //public bool? InvoiceCreated { get; set; }
        //public bool? InvoiceApproved { get; set; }
        //public DateTime? InvoiceApprovedDate { get; set; }
        //public long? InvoiceApprovedBy { get; set; }
        public bool? InvoiceProcessed { get; set; }
        public DateTime? InvoiceProcessedDate { get; set; }
        public long? InvoiceProcessedBy { get; set; }
        public decimal? Rating { get; set; }
        public string RateNote { get; set; }
        public string RiskAddress { get; set; }
        public string RiskPostcode { get; set; }
        public DateTime? HoldDate { get; set; }
        public decimal? HandlingFee { get; set; }
        public string Labour { get; set; }
        public string Parts { get; set; }
        public decimal? Total { get; set; }
        public bool? JobComplete { get; set; }
        public DateTime? JobCompleteDate { get; set; }
        public bool? FNOLcomplete { get; set; }
        public DateTime? FNOLcompleteDate { get; set; }
        public string Town { get; set; }
        public bool? oneoffrepair { get; set; }
        public Guid? FkEnggId { get; set; }
        public DateTime? ServiceDueDate { get; set; }
        public bool? IsExcess { get; set; }
        public decimal? ExcessAmount { get; set; }
        public int? TypeID { get; set; }
        public Guid? PreviousStatusID { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string AppointmentBookedDate { get; set; }
        public string AppointmentBookedTime { get; set; }
        public string WebInceptionDate { get; set; }
        public string WebStatus { get; set; }
        public string WebExcessAmount { get; set; }
        public string WebServiceDate { get; set; }
        public string WebTeam { get; set; }
        public string WebTotalAmount { get; set; }
        public string WebLossRatio { get; set; }
        public string WebInvoices { get; set; }
        public string EngineerAssignReason { get; set; }
        public DateTime? GoesIntoAuthDate { get; set; }
        public string AuthPriority { get; set; }
        public string AuthStatus { get; set; }
        public decimal? AuthAmountCollected { get; set; }
        public string AuthNote { get; set; }
        public DateTime? AuthLastSaveDate { get; set; }
        public DateTime? ServiceDelayDate { get; set; }
        public DateTime? DialledTodayDate { get; set; }
        public bool? SMSSent { get; set; }
        public long? InhibitorTextCount { get; set; }
        public bool? InhibitorSold { get; set; }
        public bool? InhibitorNotInterested { get; set; }
        public DateTime? InhibitorDate { get; set; }
        public DateTime? InhibitorDialledTodayDate { get; set; }
        public DateTime? InhibitorSentSmsToday { get; set; }
        public Guid? LinkClaimId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public DateTime? OnRouteDate { get; set; }
        public string IsBoilerAccessible { get; set; }
        public string IsBoilerWorking { get; set; }
        public string WhereIsBoilerLocated { get; set; }
        public string Underwriting_OutCome { get; set; }
        public int? Underwriting_Point { get; set; }
        public string Underwriting_PaymentType { get; set; }
        public int? Underwriting_PaymentToBeCollected { get; set; }
        public string Underwriting_Extra { get; set; }
        public int? Underwriting_ExcessAmount { get; set; }
        public int? ClaimSource { get; set; }
        public Guid? UnderwritingDisbursments { get; set; }
        public bool? ReminderSmsSent { get; set; }
        public bool? HideFromRemedial { get; set; }
        public long? HideFromRemedialClickedBy { get; set; }
        public bool? EmailSentToCustomer { get; set; }
        public long? EmailSentToCustomerClickedBy { get; set; }
        public bool? WithUpsells { get; set; }
        public long? WithUpsellsClickedBy { get; set; }
        public bool? WithAuthorisation { get; set; }
        public long? WithAuthorisationClickedBy { get; set; }
        public bool? WithCappedOff { get; set; }
        public long? WithCappedOffClickedBy { get; set; }
        public bool? SendRemedial { get; set; }
        public DateTime? SendRemedialDate { get; set; }
        public string BoilerServiceDocument { get; set; }
        public string BoilerServiceDocument1 { get; set; }
        public int? PriorityLabel { get; set; }
        public long? DeclineTypeID { get; set; }
        public string AuthBanding { get; set; }
        public long? IncompleteTypeID { get; set; }
        public int? LossRatioColour { get; set; }
        public bool? FirstTimeFix { get; set; }
        public bool? QualityFix { get; set; }
        public string ClaimGivenHour { get; set; }
        public string ClaimGivenMin { get; set; }
        //public int? AuthMReason { get; set; }
        //public string AuthMMake { get; set; }
        //public string AuthMModel { get; set; }
        //public int? AuthMAge { get; set; }
        //public decimal? AuthMBoilerValue { get; set; }
        //public decimal? AuthMMarketValue { get; set; }
        //public decimal? AuthMBERLimit { get; set; }
        public bool? PriorityService { get; set; }
        public DateTime? FirstTimeETA { get; set; }
        public DateTime? LastETA { get; set; }
        public bool? IsStaywarmCustomer { get; set; }
        public bool? IsNewServiceRouteine { get; set; }
        public int? TextCount { get; set; }
        public DateTime? TempServiceDueDate { get; set; }
        public int? CancelCounterByCustomer { get; set; }
        public int? CancelCounterByHO { get; set; }
        public int? COVIDSMS { get; set; }
        public bool IsFCA { get; set; }
        public string Web1stPolicyLiveDate { get; set; }
        public bool? ManufracturerService { get; set; }
        public int? VulnerabilityId { get; set; }
        public string VulnerabilityText { get; set; }
    }
}
