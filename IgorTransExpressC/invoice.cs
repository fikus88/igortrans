//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IgorTransExpressC
{
    using System;
    using System.Collections.Generic;
    
    public partial class invoice
    {
        public int invoiceid { get; set; }
        public int customerid { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_paid { get; set; }
        public short status { get; set; }
        public decimal total { get; set; }
        public decimal vat { get; set; }
        public byte[] pdf { get; set; }
        public string invoice_number { get; set; }
        public decimal total_paid { get; set; }
    }
}