using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EngineerWebService
{
    public class Constants
    {
        
            public const string STATUS_NewClaim = "f70e50e2-11c9-48fa-a33c-c6054ae72c8c";
            public const string STATUS_EngineerToBeAssinged = "4bf32cdb-0ee5-4383-9705-8f7090d04fd1";
            public const string STATUS_SoftfixComplete = "0c671de9-4650-46e9-917c-28b0901d9b62";

            public const string STATUS_WIP_Claim = "888c48eb-a77c-4c6d-a7d9-cd4a22e67e9b";

            public const string STATUS_WIP_Service = "888c48eb-a77c-4c6d-a7d9-cd4a22e67e9a";
            public const string STATUS_Engineer_Removed = "49861E07-4A96-4EB1-8BCE-C9E1C0B1D062";

            public const string STATUS_Authorization_Required = "724E4357-66B9-4B3A-9CA6-36161270B872";
            public const string STATUS_Second_Visit_Required = "CC09C44F-4B00-44BF-AA11-FBBA8309C3F2";




            public const string STATUS_Allocated_Engineer = "9AE9969A-C0B6-488B-B11F-07602C29DFCD";
            public const string STATUS_Service_EngineerToBeAssinged = "C8424302-CCC7-4337-833B-1F957381ED7A";
            public const string STATUS_Remidial_Work_Recommended = "2201D031-06A9-4615-B54F-5D41A4AE75A3";
            public const string STATUS_No_Answer = "B5FB2250-8955-45F0-A684-DDE4A485253B";
            public const string STATUS_Service_Complete = "67132CAF-854F-4D74-B7B4-DEDD129A5C3B";


            public const string CLAIMTYPE_Service_Id = "f5a3807c-4c6b-4352-81fd-c9ba5c2a526d";
            public const string CLAIMTYPE_Product_Id = "e223ef78-ca1c-4064-b890-5fdafc567e40";


            public const string STATUS_Claim_Complete = "72D31E9F-DC4D-4C69-AD2E-452A4DB943D3";
            public const string STATUS_Claim_Invoice_Created = "61424C84-43E2-4428-9A7A-DACB0A21747C";

            public const string STATUS_Service_Hold = "d39ce6c3-2889-4b52-8830-24105d54e54a";

            public const string STATUS_Archived = "FC25076D-8A21-4CE8-8448-F70B9B738E7E";

            public const string STATUS_PaidAndClosed = "603983F1-C770-4437-A301-2AA8AB6C6E96";

            public const string STATUS_JobCompleted = "CF6D605D-011F-454C-BA43-D37C697FB0E5";

            public const string STATUS_AuthRequired = "44CE5E63-6E64-41C9-9669-73FA6BB158CF";

            public const string STATUS_Service_Incomplete = "3905D838-DEF5-4B4D-86A2-B09112D712F8";

            public const string STATUS_NewService = "F70E50E2-11C9-48FA-A33C-C6034AE72C8C";

        public const string STATUS_ClaimAccepted = "43811533-3981-4327-ABCA-3E2241C80054";
        public const string STATUS_Claim_Incomplete = "2942B5C9-65CB-4852-83C5-F1A93DB8C39C";

        public const string JobStatus_AbandonCallOut = "55AD16A1-B75A-43CC-A7EC-BE71F0D1EB33";

        public const string TASKTYPE_Service = "09B75978-7B81-4F8F-B080-A4EC3C7C6025";
            public const string TASKTYPE_ReviewEngineersReport = "988AFB79-4FB7-441D-8303-3CC9CBDCADD4";

        public const string PRODUCT_BoilerBreakdown = "049EF944-FFB9-4185-8378-16B678401C53";
        public const string PRODUCT_PLUMBING = "B1EDFAE9-D276-4D4C-A78B-EF54CABE521A";

    }

    public enum ClaimTypeStatus
    {
        NewCase = 1,
        OneOffRepair = 2,
        Recall = 3
    }
}