//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin_pro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mise_a_Jour
    {
        public int id_ouvrage { get; set; }
        public string id_version { get; set; }
        public Nullable<System.DateTime> date_miseajour { get; set; }
    
        public virtual Ouvrage1 Ouvrage { get; set; }
        public virtual Version_ouvrage Version_ouvrage { get; set; }
    }
}
