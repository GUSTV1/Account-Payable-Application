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
    
    public partial class Payment
    {
        public int ID { get; set; }
        public System.DateTime Payment_Date { get; set; }
        public string Payment_Method { get; set; }
        public Nullable<int> InvoiceID { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}