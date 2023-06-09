//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Account_Payable_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProcessStatu
    {
        public int ID { get; set; }
        public string Invoice_Status { get; set; }
        public bool AP_approval { get; set; }
        public bool FD_approval { get; set; }
        public System.DateTime AP_approvalDate { get; set; }
        public System.DateTime FD_approvalDate { get; set; }
        public int AP_User { get; set; }
        public int FD_User { get; set; }
        public string AP_Comment { get; set; }
        public string FD_Comment { get; set; }
        public int InvoiceID { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}