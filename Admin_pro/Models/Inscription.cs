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
    
    public partial class Inscription
    {
        public string Username { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DateNaissance { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
        public string Nationalite { get; set; }
        public string Ville { get; set; }
        public string Numerotele { get; set; }
    }
}
