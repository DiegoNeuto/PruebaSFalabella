﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestFalabella.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PruebaFalabellaEntities : DbContext
    {
        public PruebaFalabellaEntities()
            : base("name=PruebaFalabellaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_asesores> tbl_asesores { get; set; }
        public virtual DbSet<tbl_detalle_pedidos> tbl_detalle_pedidos { get; set; }
        public virtual DbSet<tbl_empresas> tbl_empresas { get; set; }
        public virtual DbSet<tbl_empresas_productos> tbl_empresas_productos { get; set; }
        public virtual DbSet<tbl_pedidos> tbl_pedidos { get; set; }
        public virtual DbSet<tbl_productos> tbl_productos { get; set; }
        public virtual DbSet<tbl_status_pedido> tbl_status_pedido { get; set; }
        public virtual DbSet<tbl_tipo_productos> tbl_tipo_productos { get; set; }
    }
}
