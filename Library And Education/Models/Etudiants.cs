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
    
    public partial class Etudiants
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Etudiants()
        {
            this.Exemplaires = new HashSet<Exemplaires>();
        }
    
        public int num_etudiant { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public Nullable<System.DateTime> date_naissance { get; set; }
        public string telephone { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string code_postal { get; set; }
        public string Pays { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exemplaires> Exemplaires { get; set; }
    }
}
