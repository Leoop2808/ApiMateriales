﻿using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.Entities.Contacto.Request;
using ApiMateriales.Entities.Contacto.Response;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/contacto")]
    public class ContactoController : ApiController
    {
        private readonly IContactoBO _contactoBO;
        public ContactoController(IContactoBO contactoBO)
        {
            _contactoBO = contactoBO;
        }

        [Route("proveedor/lista-proveedores")]
        [HttpGet]
        [Authorize]
        public IHttpActionResult ObtenerListaProveedores()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new ObtenerListaProveedoresResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_contactoBO.ObtenerListaProveedores(id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerListaProveedoresResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener lista proveedores"
                });
            }
        }

        [Route("proveedor/registrar-proveedor")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult RegistrarProveedor(RegistrarProveedorRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new RegistrarProveedorResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_contactoBO.RegistrarProveedor(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new RegistrarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al registrar proveedor"
                });
            }
        }

        [Route("proveedor/editar-proveedor/{idProveedor}")]
        [HttpPut]
        [Authorize]
        public IHttpActionResult EditarProveedor(EditarProveedorRequest request, int idProveedor)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new EditarProveedorResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_contactoBO.EditarProveedor(request, idProveedor, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new EditarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al editar proveedor"
                });
            }
        }

        [Route("proveedor/eliminar-proveedor/{idProveedor}")]
        [HttpDelete]
        [Authorize]
        public IHttpActionResult EliminarProveedor(int idProveedor)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new EliminarProveedorResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_contactoBO.EliminarProveedor(idProveedor, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new EliminarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al eliminar proveedor"
                });
            }
        }
    }
}