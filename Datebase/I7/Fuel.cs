//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPPKprojektDotNet.Datebase.I7
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fuel
    {
        public int IDFuel { get; set; }
        public Nullable<int> DriverId { get; set; }
        public Nullable<System.DateTime> DateWhen { get; set; }
        public Nullable<System.TimeSpan> TimeWhen { get; set; }
        public string Location { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> VehicleID { get; set; }
    
        public virtual Driver Driver { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
