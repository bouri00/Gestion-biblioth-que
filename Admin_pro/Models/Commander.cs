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
    
    public partial class Commander
    {
        public int ouvrage { get; set; }
        public Nullable<double> Prix { get; set; }
        public Nullable<int> quantite { get; set; }
        public Nullable<double> remise { get; set; }
        public Nullable<double> Total { get; set; }
        public int Idcom { get; set; }
        public Nullable<System.DateTime> date_envoi { get; set; }
        public string destinataire { get; set; }
        public Nullable<System.DateTime> datecommande { get; set; }
        public string ville_livraison { get; set; }
        public string pays_livraison { get; set; }
        public Nullable<int> code_postal_livraison { get; set; }
        public Nullable<int> id_ouvrage { get; set; }
    
        public virtual Ouvrage Ouvrage1 { get; set; }
    }
}
