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
    
        public virtual ObjectResult<SP_EDITAR_PROVEEDOR_Result> SP_EDITAR_PROVEEDOR(Nullable<int> id_proveedor, string cod_pais, string nombre_proveedor, string ruc, string direccion, string celular, string correo, string representante, string celular_repre, string correo_repre)
        {
            var id_proveedorParameter = id_proveedor.HasValue ?
                new ObjectParameter("id_proveedor", id_proveedor) :
                new ObjectParameter("id_proveedor", typeof(int));
    
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_EDITAR_PROVEEDOR_Result>("SP_EDITAR_PROVEEDOR", id_proveedorParameter, cod_paisParameter, nombre_proveedorParameter, rucParameter, direccionParameter, celularParameter, correoParameter, representanteParameter, celular_repreParameter, correo_repreParameter);
        }
    
        public virtual ObjectResult<SP_ELIMINAR_PROVEEDOR_Result> SP_ELIMINAR_PROVEEDOR(Nullable<int> id_proveedor)
        {
            var id_proveedorParameter = id_proveedor.HasValue ?
                new ObjectParameter("id_proveedor", id_proveedor) :
                new ObjectParameter("id_proveedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ELIMINAR_PROVEEDOR_Result>("SP_ELIMINAR_PROVEEDOR", id_proveedorParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_DETALLE_PROVEEDOR_Result> SP_OBTENER_DETALLE_PROVEEDOR(Nullable<int> id_proveedor)
        {
            var id_proveedorParameter = id_proveedor.HasValue ?
                new ObjectParameter("id_proveedor", id_proveedor) :
                new ObjectParameter("id_proveedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_DETALLE_PROVEEDOR_Result>("SP_OBTENER_DETALLE_PROVEEDOR", id_proveedorParameter);
        }
    
        public virtual ObjectResult<SP_EDITAR_CLIENTE_Result> SP_EDITAR_CLIENTE(Nullable<int> id_cliente, string cod_pais, string nombre_cliente, string ruc, string direccion, string celular, string correo, string representante, string celular_repre, string correo_repre)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            var cod_paisParameter = cod_pais != null ?
                new ObjectParameter("cod_pais", cod_pais) :
                new ObjectParameter("cod_pais", typeof(string));
    
            var nombre_clienteParameter = nombre_cliente != null ?
                new ObjectParameter("nombre_cliente", nombre_cliente) :
                new ObjectParameter("nombre_cliente", typeof(string));
    
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_EDITAR_CLIENTE_Result>("SP_EDITAR_CLIENTE", id_clienteParameter, cod_paisParameter, nombre_clienteParameter, rucParameter, direccionParameter, celularParameter, correoParameter, representanteParameter, celular_repreParameter, correo_repreParameter);
        }
    
        public virtual ObjectResult<SP_ELIMINAR_CLIENTE_Result> SP_ELIMINAR_CLIENTE(Nullable<int> id_cliente)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ELIMINAR_CLIENTE_Result>("SP_ELIMINAR_CLIENTE", id_clienteParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_DETALLE_CLIENTE_Result> SP_OBTENER_DETALLE_CLIENTE(Nullable<int> id_cliente)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_DETALLE_CLIENTE_Result>("SP_OBTENER_DETALLE_CLIENTE", id_clienteParameter);
        }
    
        public virtual ObjectResult<SP_REGISTRAR_CLIENTE_Result> SP_REGISTRAR_CLIENTE(string cod_pais, string nombre_cliente, string ruc, string direccion, string celular, string correo, string representante, string celular_repre, string correo_repre)
        {
            var cod_paisParameter = cod_pais != null ?
                new ObjectParameter("cod_pais", cod_pais) :
                new ObjectParameter("cod_pais", typeof(string));
    
            var nombre_clienteParameter = nombre_cliente != null ?
                new ObjectParameter("nombre_cliente", nombre_cliente) :
                new ObjectParameter("nombre_cliente", typeof(string));
    
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_REGISTRAR_CLIENTE_Result>("SP_REGISTRAR_CLIENTE", cod_paisParameter, nombre_clienteParameter, rucParameter, direccionParameter, celularParameter, correoParameter, representanteParameter, celular_repreParameter, correo_repreParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_CLIENTES_Result> SP_OBTENER_CLIENTES(string nombreCliente)
        {
            var nombreClienteParameter = nombreCliente != null ?
                new ObjectParameter("nombreCliente", nombreCliente) :
                new ObjectParameter("nombreCliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_CLIENTES_Result>("SP_OBTENER_CLIENTES", nombreClienteParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_PRODUCTO_Result> SP_OBTENER_PRODUCTO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PRODUCTO_Result>("SP_OBTENER_PRODUCTO");
        }
    
        public virtual ObjectResult<SP_OBTENER_PRODUCTO_FINAL_Result> SP_OBTENER_PRODUCTO_FINAL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PRODUCTO_FINAL_Result>("SP_OBTENER_PRODUCTO_FINAL");
        }
    
        public virtual ObjectResult<SP_OBTENER_PROVEEDORES_Result> SP_OBTENER_PROVEEDORES(string nombreProveedor)
        {
            var nombreProveedorParameter = nombreProveedor != null ?
                new ObjectParameter("nombreProveedor", nombreProveedor) :
                new ObjectParameter("nombreProveedor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PROVEEDORES_Result>("SP_OBTENER_PROVEEDORES", nombreProveedorParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_HISTORIAL_COMPRAS_Result> SP_OBTENER_HISTORIAL_COMPRAS(string nombreProveedor)
        {
            var nombreProveedorParameter = nombreProveedor != null ?
                new ObjectParameter("nombreProveedor", nombreProveedor) :
                new ObjectParameter("nombreProveedor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_HISTORIAL_COMPRAS_Result>("SP_OBTENER_HISTORIAL_COMPRAS", nombreProveedorParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_DETALLE_COMPRA_Result> SP_OBTENER_DETALLE_COMPRA(Nullable<int> idCompra)
        {
            var idCompraParameter = idCompra.HasValue ?
                new ObjectParameter("idCompra", idCompra) :
                new ObjectParameter("idCompra", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_DETALLE_COMPRA_Result>("SP_OBTENER_DETALLE_COMPRA", idCompraParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_DETALLE_VENTA_Result> SP_OBTENER_DETALLE_VENTA(Nullable<int> idVenta)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("idVenta", idVenta) :
                new ObjectParameter("idVenta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_DETALLE_VENTA_Result>("SP_OBTENER_DETALLE_VENTA", idVentaParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_HISTORIAL_VENTAS_Result> SP_OBTENER_HISTORIAL_VENTAS(string nombreCliente)
        {
            var nombreClienteParameter = nombreCliente != null ?
                new ObjectParameter("nombreCliente", nombreCliente) :
                new ObjectParameter("nombreCliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_HISTORIAL_VENTAS_Result>("SP_OBTENER_HISTORIAL_VENTAS", nombreClienteParameter);
        }
    
        public virtual ObjectResult<SP_PREPRODUCCION_COMPROBAR_STOCK_INSUMOS_Result> SP_PREPRODUCCION_COMPROBAR_STOCK_INSUMOS(string codProductoFinal, Nullable<int> cantidadProduccion)
        {
            var codProductoFinalParameter = codProductoFinal != null ?
                new ObjectParameter("codProductoFinal", codProductoFinal) :
                new ObjectParameter("codProductoFinal", typeof(string));
    
            var cantidadProduccionParameter = cantidadProduccion.HasValue ?
                new ObjectParameter("cantidadProduccion", cantidadProduccion) :
                new ObjectParameter("cantidadProduccion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_PREPRODUCCION_COMPROBAR_STOCK_INSUMOS_Result>("SP_PREPRODUCCION_COMPROBAR_STOCK_INSUMOS", codProductoFinalParameter, cantidadProduccionParameter);
        }
    
        public virtual ObjectResult<SP_REGISTRAR_PRODUCCION_Result> SP_REGISTRAR_PRODUCCION(string codProductoFinal, Nullable<int> cantidad, string fechaInicio, string fechaComprometida)
        {
            var codProductoFinalParameter = codProductoFinal != null ?
                new ObjectParameter("codProductoFinal", codProductoFinal) :
                new ObjectParameter("codProductoFinal", typeof(string));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            var fechaInicioParameter = fechaInicio != null ?
                new ObjectParameter("fechaInicio", fechaInicio) :
                new ObjectParameter("fechaInicio", typeof(string));
    
            var fechaComprometidaParameter = fechaComprometida != null ?
                new ObjectParameter("fechaComprometida", fechaComprometida) :
                new ObjectParameter("fechaComprometida", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_REGISTRAR_PRODUCCION_Result>("SP_REGISTRAR_PRODUCCION", codProductoFinalParameter, cantidadParameter, fechaInicioParameter, fechaComprometidaParameter);
        }
    
        public virtual ObjectResult<SP_ACTUALIZAR_ESTADO_PRODUCCION_Result> SP_ACTUALIZAR_ESTADO_PRODUCCION(Nullable<int> idProduccion, string codEstadoProduccion)
        {
            var idProduccionParameter = idProduccion.HasValue ?
                new ObjectParameter("idProduccion", idProduccion) :
                new ObjectParameter("idProduccion", typeof(int));
    
            var codEstadoProduccionParameter = codEstadoProduccion != null ?
                new ObjectParameter("codEstadoProduccion", codEstadoProduccion) :
                new ObjectParameter("codEstadoProduccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ACTUALIZAR_ESTADO_PRODUCCION_Result>("SP_ACTUALIZAR_ESTADO_PRODUCCION", idProduccionParameter, codEstadoProduccionParameter);
        }
    
        public virtual ObjectResult<SP_ACTUALIZAR_PRECIO_PRODUCTO_FINAL_Result> SP_ACTUALIZAR_PRECIO_PRODUCTO_FINAL(Nullable<int> idProductoFinal, Nullable<decimal> precio)
        {
            var idProductoFinalParameter = idProductoFinal.HasValue ?
                new ObjectParameter("idProductoFinal", idProductoFinal) :
                new ObjectParameter("idProductoFinal", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ACTUALIZAR_PRECIO_PRODUCTO_FINAL_Result>("SP_ACTUALIZAR_PRECIO_PRODUCTO_FINAL", idProductoFinalParameter, precioParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_FLUJO_PRODUCTO_Result> SP_OBTENER_FLUJO_PRODUCTO(string codProducto, string fechaDesde, string fechaHasta)
        {
            var codProductoParameter = codProducto != null ?
                new ObjectParameter("codProducto", codProducto) :
                new ObjectParameter("codProducto", typeof(string));
    
            var fechaDesdeParameter = fechaDesde != null ?
                new ObjectParameter("fechaDesde", fechaDesde) :
                new ObjectParameter("fechaDesde", typeof(string));
    
            var fechaHastaParameter = fechaHasta != null ?
                new ObjectParameter("fechaHasta", fechaHasta) :
                new ObjectParameter("fechaHasta", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_FLUJO_PRODUCTO_Result>("SP_OBTENER_FLUJO_PRODUCTO", codProductoParameter, fechaDesdeParameter, fechaHastaParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_FLUJO_PRODUCTO_FINAL_Result> SP_OBTENER_FLUJO_PRODUCTO_FINAL(string codProductoFinal, string fechaDesde, string fechaHasta)
        {
            var codProductoFinalParameter = codProductoFinal != null ?
                new ObjectParameter("codProductoFinal", codProductoFinal) :
                new ObjectParameter("codProductoFinal", typeof(string));
    
            var fechaDesdeParameter = fechaDesde != null ?
                new ObjectParameter("fechaDesde", fechaDesde) :
                new ObjectParameter("fechaDesde", typeof(string));
    
            var fechaHastaParameter = fechaHasta != null ?
                new ObjectParameter("fechaHasta", fechaHasta) :
                new ObjectParameter("fechaHasta", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_FLUJO_PRODUCTO_FINAL_Result>("SP_OBTENER_FLUJO_PRODUCTO_FINAL", codProductoFinalParameter, fechaDesdeParameter, fechaHastaParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_HISTORIAL_PRODUCCION_Result> SP_OBTENER_HISTORIAL_PRODUCCION(string fechaDesde, string fechaHasta, string codProductoFinal)
        {
            var fechaDesdeParameter = fechaDesde != null ?
                new ObjectParameter("fechaDesde", fechaDesde) :
                new ObjectParameter("fechaDesde", typeof(string));
    
            var fechaHastaParameter = fechaHasta != null ?
                new ObjectParameter("fechaHasta", fechaHasta) :
                new ObjectParameter("fechaHasta", typeof(string));
    
            var codProductoFinalParameter = codProductoFinal != null ?
                new ObjectParameter("codProductoFinal", codProductoFinal) :
                new ObjectParameter("codProductoFinal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_HISTORIAL_PRODUCCION_Result>("SP_OBTENER_HISTORIAL_PRODUCCION", fechaDesdeParameter, fechaHastaParameter, codProductoFinalParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_STOCKS_PRODUCTOS_Result> SP_OBTENER_STOCKS_PRODUCTOS(string codProducto)
        {
            var codProductoParameter = codProducto != null ?
                new ObjectParameter("codProducto", codProducto) :
                new ObjectParameter("codProducto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_STOCKS_PRODUCTOS_Result>("SP_OBTENER_STOCKS_PRODUCTOS", codProductoParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_INSUMOS_POR_LINGOTE_Result> SP_OBTENER_INSUMOS_POR_LINGOTE(string codProductoFinal, Nullable<int> cantidadProduccion)
        {
            var codProductoFinalParameter = codProductoFinal != null ?
                new ObjectParameter("codProductoFinal", codProductoFinal) :
                new ObjectParameter("codProductoFinal", typeof(string));
    
            var cantidadProduccionParameter = cantidadProduccion.HasValue ?
                new ObjectParameter("cantidadProduccion", cantidadProduccion) :
                new ObjectParameter("cantidadProduccion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_INSUMOS_POR_LINGOTE_Result>("SP_OBTENER_INSUMOS_POR_LINGOTE", codProductoFinalParameter, cantidadProduccionParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_STOCKS_PRODUCTOS_FINALES_Result> SP_OBTENER_STOCKS_PRODUCTOS_FINALES(string codProductoFinal)
        {
            var codProductoFinalParameter = codProductoFinal != null ?
                new ObjectParameter("codProductoFinal", codProductoFinal) :
                new ObjectParameter("codProductoFinal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_STOCKS_PRODUCTOS_FINALES_Result>("SP_OBTENER_STOCKS_PRODUCTOS_FINALES", codProductoFinalParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_PRODUCCIONES_Result> SP_OBTENER_PRODUCCIONES(string codEstadoProduccion, string fechaDesde, string fechaHasta)
        {
            var codEstadoProduccionParameter = codEstadoProduccion != null ?
                new ObjectParameter("codEstadoProduccion", codEstadoProduccion) :
                new ObjectParameter("codEstadoProduccion", typeof(string));
    
            var fechaDesdeParameter = fechaDesde != null ?
                new ObjectParameter("fechaDesde", fechaDesde) :
                new ObjectParameter("fechaDesde", typeof(string));
    
            var fechaHastaParameter = fechaHasta != null ?
                new ObjectParameter("fechaHasta", fechaHasta) :
                new ObjectParameter("fechaHasta", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PRODUCCIONES_Result>("SP_OBTENER_PRODUCCIONES", codEstadoProduccionParameter, fechaDesdeParameter, fechaHastaParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_MAESTRO_CLIENTE_Result> SP_OBTENER_MAESTRO_CLIENTE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_MAESTRO_CLIENTE_Result>("SP_OBTENER_MAESTRO_CLIENTE");
        }
    
        public virtual ObjectResult<SP_OBTENER_MAESTRO_PROVEEDOR_Result> SP_OBTENER_MAESTRO_PROVEEDOR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_MAESTRO_PROVEEDOR_Result>("SP_OBTENER_MAESTRO_PROVEEDOR");
        }
    
        public virtual ObjectResult<SP_OBTENER_PRODUCTOS_FINALES_MAS_VENDIDOS_Result> SP_OBTENER_PRODUCTOS_FINALES_MAS_VENDIDOS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PRODUCTOS_FINALES_MAS_VENDIDOS_Result>("SP_OBTENER_PRODUCTOS_FINALES_MAS_VENDIDOS");
        }
    
        public virtual ObjectResult<SP_OBTENER_PRODUCTOS_MAS_COMPRADOS_Result> SP_OBTENER_PRODUCTOS_MAS_COMPRADOS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_PRODUCTOS_MAS_COMPRADOS_Result>("SP_OBTENER_PRODUCTOS_MAS_COMPRADOS");
        }
    }
}
