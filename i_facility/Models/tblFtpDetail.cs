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
    
    public partial class tblFtpDetail
    {
        public int PTId { get; set; }
        public int PlantId { get; set; }
        public int ShopID { get; set; }
        public int CellID { get; set; }
        public int MachineID { get; set; }
        public int ProgType { get; set; }
        public string IpAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int port { get; set; }
        public string Domain { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public int Isdeleted { get; set; }
    }
}
