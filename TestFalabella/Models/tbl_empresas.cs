//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_empresas
    {
        public string pk_codigo_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string nit { get; set; }
        public string direccion { get; set; }
        public string contacto { get; set; }
        public string telefono { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string ciudad { get; set; }
        public Nullable<bool> status { get; set; }
    }
}
