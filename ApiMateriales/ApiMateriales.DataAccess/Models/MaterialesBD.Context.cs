﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiMateriales.DataAccess.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MATERIALESDBEntities : DbContext
    {
        public MATERIALESDBEntities()
            : base("name=MATERIALESDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<trs_persona> trs_persona { get; set; }
        public virtual DbSet<trs_usuario> trs_usuario { get; set; }
    
        public virtual ObjectResult<SP_OBTENER_ESTADOS_PRODUCCION_Result> SP_OBTENER_ESTADOS_PRODUCCION()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_ESTADOS_PRODUCCION_Result>("SP_OBTENER_ESTADOS_PRODUCCION");
        }
    
        public virtual ObjectResult<SP_OBTENER_PAIS_Result> SP_OBTENER_PAIS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PAIS_Result>("SP_OBTENER_PAIS");
        }
    
        public virtual ObjectResult<SP_OBTENER_PRODUCTO_Result> SP_OBTENER_PRODUCTO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PRODUCTO_Result>("SP_OBTENER_PRODUCTO");
        }
    
        public virtual ObjectResult<SP_OBTENER_PRODUCTO_FINAL_Result> SP_OBTENER_PRODUCTO_FINAL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PRODUCTO_FINAL_Result>("SP_OBTENER_PRODUCTO_FINAL");
        }
    
        public virtual ObjectResult<SP_OBTENER_PROVEEDORES_Result> SP_OBTENER_PROVEEDORES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PROVEEDORES_Result>("SP_OBTENER_PROVEEDORES");
        }
    
        public virtual ObjectResult<SP_REGISTRAR_PROVEEDOR_Result> SP_REGISTRAR_PROVEEDOR(string cod_pais, string nombre_proveedor, string ruc, string direccion, string celular, string correo, string representante, string celular_repre, string correo_repre)
        {
            var cod_paisParameter = cod_pais != null ?
                new ObjectParameter("cod_pais", cod_pais) :
                new ObjectParameter("cod_pais", typeof(string));
    
            var nombre_proveedorParameter = nombre_proveedor != null ?
                new ObjectParameter("nombre_proveedor", nombre_proveedor) :
                new ObjectParameter("nombre_proveedor", typeof(string));
    
            var rucParameter = ruc != null ?
                new ObjectParameter("ruc", ruc) :
                new ObjectParameter("ruc", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("celular", celular) :
                new ObjectParameter("celular", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var representanteParameter = representante != null ?
                new ObjectParameter("representante", representante) :
                new ObjectParameter("representante", typeof(string));
    
            var celular_repreParameter = celular_repre != null ?
                new ObjectParameter("celular_repre", celular_repre) :
                new ObjectParameter("celular_repre", typeof(string));
    
            var correo_repreParameter = correo_repre != null ?
                new ObjectParameter("correo_repre", correo_repre) :
                new ObjectParameter("correo_repre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_REGISTRAR_PROVEEDOR_Result>("SP_REGISTRAR_PROVEEDOR", cod_paisParameter, nombre_proveedorParameter, rucParameter, direccionParameter, celularParameter, correoParameter, representanteParameter, celular_repreParameter, correo_repreParameter);
        }
    }
}
