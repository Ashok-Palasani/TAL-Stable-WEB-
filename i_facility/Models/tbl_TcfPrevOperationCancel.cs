//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace i_facility.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_TcfPrevOperationCancel
    {
        public int TCFOPCancelID { get; set; }
        public string ProductionOrder { get; set; }
        public string Operation { get; set; }
        public int IsCancelled { get; set; }
        public Nullable<int> Qty { get; set; }
        public string CorrectedDate { get; set; }
        public string WorkCenter { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public int SendApprove { get; set; }
        public int AcceptReject { get; set; }
        public int ApprovalLevel { get; set; }
        public int Update { get; set; }
        public string PartNumber { get; set; }
        public string UploadDate { get; set; }
        public int AcceptReject1 { get; set; }
        public int RejectReason { get; set; }
        public int RejectReason1 { get; set; }
        public int UpdateLevel { get; set; }
        public int IsPending { get; set; }
    }
}
