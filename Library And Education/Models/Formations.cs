//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_And_Education.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Formations
    {
        public int id_formation { get; set; }
        public string libelle { get; set; }
        public Nullable<System.DateTime> date_debut { get; set; }
        public Nullable<System.DateTime> date_fin { get; set; }
        public Nullable<int> id_prof { get; set; }
        public string type { get; set; }
    
        public virtual professours professours { get; set; }
    }
}