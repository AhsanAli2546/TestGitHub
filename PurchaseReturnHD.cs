//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TailoBillSoftWare
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseReturnHD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseReturnHD()
        {
            this.Barcodes = new HashSet<Barcode>();
            this.Ledgers = new HashSet<Ledger>();
            this.PurchaseReturnDets = new HashSet<PurchaseReturnDet>();
            this.StockLedgers = new HashSet<StockLedger>();
        }
    
        public int PR_head_id { get; set; }
        public Nullable<System.DateTime> PR_date { get; set; }
        public Nullable<int> Pur_Inv_no { get; set; }
        public Nullable<int> Pur_head_id { get; set; }
        public string Return_type { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_MobileNO { get; set; }
        public string Supplier_Address { get; set; }
        public Nullable<int> Total_item_quantity { get; set; }
        public Nullable<int> Total_item_Count { get; set; }
        public Nullable<decimal> Discount_amount { get; set; }
        public Nullable<decimal> Basic_amount { get; set; }
        public Nullable<decimal> TaxPer { get; set; }
        public Nullable<decimal> TaxAmt { get; set; }
        public Nullable<decimal> RoundOff_Amt { get; set; }
        public Nullable<decimal> Net_total_amount { get; set; }
        public string AmountinWords { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> Company_id { get; set; }
        public Nullable<int> Branch_id { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string Discount_type { get; set; }
        public Nullable<decimal> Discount_rate { get; set; }
        public Nullable<decimal> VatPer { get; set; }
        public Nullable<decimal> VatAmt { get; set; }
        public Nullable<decimal> CGSTPer { get; set; }
        public Nullable<decimal> CGSTAmt { get; set; }
        public Nullable<decimal> SGSTPer { get; set; }
        public Nullable<decimal> SGSTAmt { get; set; }
        public Nullable<decimal> IGSTPer { get; set; }
        public Nullable<decimal> IGSTAmt { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> Modifiedby { get; set; }
        public Nullable<int> Supplier_id { get; set; }
        public Nullable<int> Net_item_quantity { get; set; }
        public string VATGSTTIN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Barcode> Barcodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ledger> Ledgers { get; set; }
        public virtual PurchaseHD PurchaseHD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseReturnDet> PurchaseReturnDets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLedger> StockLedgers { get; set; }
    }
}
