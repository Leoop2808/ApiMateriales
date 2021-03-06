//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class trs_persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trs_persona()
        {
            this.trs_usuario = new HashSet<trs_usuario>();
        }
    
        public int id_persona { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido_materno { get; set; }
        public string apellido_paterno { get; set; }
        public string correo { get; set; }
        public Nullable<bool> activo { get; set; }
        public Nullable<bool> eliminado { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<System.DateTime> fecha_actualizacion { get; set; }
        public Nullable<System.DateTime> fecha_eliminacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trs_usuario> trs_usuario { get; set; }
    }
}
