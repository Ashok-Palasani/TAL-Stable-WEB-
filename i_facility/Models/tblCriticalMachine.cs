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
    
    public partial class tblCriticalMachine
    {
        public int criticalMachineId { get; set; }
        public Nullable<int> machineId { get; set; }
        public string correctedDate { get; set; }
        public Nullable<System.DateTime> insertedOn { get; set; }
        public Nullable<int> insertedBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public Nullable<int> isCritical { get; set; }
        public Nullable<int> isDeleted { get; set; }
    }
}
