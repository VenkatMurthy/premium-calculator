//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PremiumCalculator.DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Occupation
    {
        public int Id { get; set; }
        public string OccupationName { get; set; }
        public int OccupationRatingId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual OccupationRating OccupationRating { get; set; }
    }
}
