//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carreteras
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ciudades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ciudades()
        {
            this.tb_carreteras = new HashSet<tb_carreteras>();
            this.tb_carreterasXciudades = new HashSet<tb_carreterasXciudades>();
            this.tb_empleados = new HashSet<tb_empleados>();
        }
    
        public string ciu_id { get; set; }
        public string ciu_descripcion { get; set; }
        public string dep_id { get; set; }
        public string ciu_usuario_crea { get; set; }
        public Nullable<System.DateTime> ciu_fecha_crea { get; set; }
        public string ciu_usuario_modifica { get; set; }
        public Nullable<System.DateTime> ciu_fecha_modifica { get; set; }
        public Nullable<bool> ciu_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_carreteras> tb_carreteras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_carreterasXciudades> tb_carreterasXciudades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_empleados> tb_empleados { get; set; }
        public virtual tb_departamentos tb_departamentos { get; set; }
        public virtual tb_usuarios tb_usuarios { get; set; }
        public virtual tb_usuarios tb_usuarios1 { get; set; }
    }
}
