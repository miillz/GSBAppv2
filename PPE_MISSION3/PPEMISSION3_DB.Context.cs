﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE_MISSION3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PPE_MISSION3_entity : DbContext
    {
        public PPE_MISSION3_entity()
            : base("name=PPE_MISSION3_entity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<famille> familles { get; set; }
        public DbSet<medecin> medecins { get; set; }
        public DbSet<medicament> medicaments { get; set; }
        public DbSet<offrir> offrirs { get; set; }
        public DbSet<rapport> rapports { get; set; }
        public DbSet<visiteur> visiteurs { get; set; }
    }
}
