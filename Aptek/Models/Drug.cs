//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aptek.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drug
    {
        public int Id { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<byte> ValidityDuration { get; set; }
        public string Photo { get; set; }
    
        public virtual Category Category { get; set; }
    }
}