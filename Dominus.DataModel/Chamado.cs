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
    
    public partial class Chamado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chamado()
        {
            this.ChamadoAssociado = new HashSet<Chamado>();
        }
    
        public System.Guid IdChamado { get; set; }
        public System.Guid IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.Guid> IdUsuarioSuporte { get; set; }
        public string MensagemResposta { get; set; }
        public Nullable<System.DateTime> DataResposta { get; set; }
        public int Validado { get; set; }
        public Nullable<System.Guid> IdChamadoAssociado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chamado> ChamadoAssociado { get; set; }
        public virtual Chamado ChamadoPrincipal { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario UsuarioSuporte { get; set; }
    }
}
