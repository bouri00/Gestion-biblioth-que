﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Manage_BooksEntities1 : DbContext
    {
        public Manage_BooksEntities1()
            : base("name=Manage_BooksEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Acheters> Acheters { get; set; }
        public virtual DbSet<appartients> appartients { get; set; }
        public virtual DbSet<Auteurs> Auteurs { get; set; }
        public virtual DbSet<Authentifications> Authentifications { get; set; }
        public virtual DbSet<Commander> Commander { get; set; }
        public virtual DbSet<Editeur> Editeur { get; set; }
        public virtual DbSet<Editeurs> Editeurs { get; set; }
        public virtual DbSet<Etudiants> Etudiants { get; set; }
        public virtual DbSet<Exemplaires> Exemplaires { get; set; }
        public virtual DbSet<Formations> Formations { get; set; }
        public virtual DbSet<InfoUsers> InfoUsers { get; set; }
        public virtual DbSet<Inscriptions> Inscriptions { get; set; }
        public virtual DbSet<Mise_a_Jour> Mise_a_Jour { get; set; }
        public virtual DbSet<Ouvrage> Ouvrage { get; set; }
        public virtual DbSet<Ouvrages> Ouvrages { get; set; }
        public virtual DbSet<professours> professours { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<Version_ouvrage> Version_ouvrage { get; set; }
    }
}
