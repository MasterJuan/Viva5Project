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
    
    public partial class ProjectUpdate
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public long ProjectId { get; set; }
        public Nullable<long> AttachmentSetId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime WhenDateTime { get; set; }
    
        public virtual AttachmentSet AttachmentSet { get; set; }
        public virtual Project Project { get; set; }
    }
}
