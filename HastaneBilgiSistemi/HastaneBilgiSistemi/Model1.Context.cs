﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneBilgiSistemi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HastaneSistemEntities : DbContext
    {
        public HastaneSistemEntities()
            : base("name=HastaneSistemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblBolum> TblBolum { get; set; }
        public virtual DbSet<TblDoktor> TblDoktor { get; set; }
        public virtual DbSet<TblLaboratuvar> TblLaboratuvar { get; set; }
        public virtual DbSet<TblMuayene> TblMuayene { get; set; }
        public virtual DbSet<TblHasta> TblHasta { get; set; }
    }
}
