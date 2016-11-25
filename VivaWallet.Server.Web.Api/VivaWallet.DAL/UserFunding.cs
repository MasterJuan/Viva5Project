//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VivaWallet.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserFunding
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public long FundingPackageId { get; set; }
        public long UserId { get; set; }
        public System.DateTime WhenDateTime { get; set; }
        public decimal AmountPaid { get; set; }
        public string TransactionId { get; set; }
    
        public virtual FundingPackage FundingPackage { get; set; }
        public virtual User User { get; set; }
    }
}
