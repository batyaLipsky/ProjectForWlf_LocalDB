//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Traveling
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Traveling()
        {
            this.Registerations = new HashSet<Registeration>();
        }
    
        public int TravelingId { get; set; }
        public int DriverId { get; set; }
        public string Weekday { get; set; }
        public string Places { get; set; }
        public System.TimeSpan Time { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public int Price { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    
        public virtual Driver Driver { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registeration> Registerations { get; set; }
    }
}
