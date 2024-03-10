﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PuntodeVentaEntities : DbContext
    {
        public PuntodeVentaEntities()
            : base("name=PuntodeVentaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Facturacion> Facturacion { get; set; }
        public virtual DbSet<vCliFactu> vCliFactu { get; set; }
    
        public virtual ObjectResult<P_GetCliFactu_Result> P_GetCliFactu(string apellido, string nombre, string codigo)
        {
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var codigoParameter = codigo != null ?
                new ObjectParameter("Codigo", codigo) :
                new ObjectParameter("Codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_GetCliFactu_Result>("P_GetCliFactu", apellidoParameter, nombreParameter, codigoParameter);
        }
    }
}