﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Services_DSI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cj : DbContext
    {
        public cj()
            : base("name=cj")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CODE_NOMENCLATURE> CODE_NOMENCLATURE { get; set; }
        public virtual DbSet<ESP_ETUDIANT> ESP_ETUDIANT { get; set; }
        public virtual DbSet<ESP_INSCRIPTION> ESP_INSCRIPTION { get; set; }
        public virtual DbSet<SOCIETE> SOCIETE { get; set; }
        public virtual DbSet<STR_NOME> STR_NOME { get; set; }
        public virtual DbSet<SERVICES_DSI_PRIVILEGE> SERVICES_DSI_PRIVILEGE { get; set; }
    }
}
