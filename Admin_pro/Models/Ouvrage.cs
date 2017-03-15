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
    
    public partial class Ouvrage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ouvrage()
        {
            this.Exemplaire = new HashSet<Exemplaire>();
            this.Mise_a_Jour = new HashSet<Mise_a_Jour>();
            this.Type = new HashSet<Type>();
            this.Auteur = new HashSet<Auteur>();
        }
    
        public string id_ouvrage { get; set; }
        public string titre { get; set; }
        public Nullable<int> nb_pages { get; set; }
        public string id_Editeur { get; set; }
    
        public virtual Editeur Editeur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exemplaire> Exemplaire { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mise_a_Jour> Mise_a_Jour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Type> Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auteur> Auteur { get; set; }
    }
}