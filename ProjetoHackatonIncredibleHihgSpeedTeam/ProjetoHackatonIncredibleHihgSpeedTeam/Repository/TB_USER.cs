//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoHackatonIncredibleHihgSpeedTeam.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_USER()
        {
            this.TB_USER_QUALIFICACAO = new HashSet<TB_USER_QUALIFICACAO>();
        }
    
        public int ID { get; set; }
        public string NM_NOME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USER_QUALIFICACAO> TB_USER_QUALIFICACAO { get; set; }
    }
}