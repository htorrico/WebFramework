﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFramework.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NeptunoEntities : DbContext
    {
        public NeptunoEntities()
            : base("name=NeptunoEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria> categorias { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<compañiasdeenvios> compañiasdeenvios { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<producto> productos { get; set; }
        public virtual DbSet<proveedore> proveedores { get; set; }
        public virtual DbSet<detallesdepedido> detallesdepedidos { get; set; }
    }
}
