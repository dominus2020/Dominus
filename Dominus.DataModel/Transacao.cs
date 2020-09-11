//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominus.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transacao
    {
        public System.Guid IdTransacao { get; set; }
        public System.Guid IdUsuario { get; set; }
        public System.Guid IdCategoria { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Comentario { get; set; }
        public int Provisionado { get; set; }
        public Nullable<decimal> ValorProvisao { get; set; }
        public Nullable<System.DateTime> DataProvisao { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
