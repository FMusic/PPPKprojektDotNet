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
    
    public partial class Route
    {
        public int IDRoute { get; set; }
        public Nullable<int> WarrantID { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public string CoordA { get; set; }
        public string CoordB { get; set; }
        public Nullable<int> DistanceInKm { get; set; }
        public Nullable<int> AvgV { get; set; }
        public Nullable<int> FuelSpent { get; set; }
    
        public virtual travelWarrant travelWarrant { get; set; }
    }
}
