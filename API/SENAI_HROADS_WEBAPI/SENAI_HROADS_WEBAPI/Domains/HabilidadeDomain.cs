using System;
using System.Collections.Generic;



namespace senai_hroads_webapi.Domains
{
    public partial class HabilidadeDomain
    {
        public Habilidade()
        {
            Classehabilidades = new HashSet<Classehabilidade>();
        }

        public byte IdHabilidade { get; set; }
        public byte IdTipoHabilidade { get; set; }
        public string NomeHabilidade { get; set; }

        public virtual Tipohabilidade IdTipoHabilidadeNavigation { get; set; }
        public virtual ICollection<Classehabilidade> Classehabilidades { get; set; }
    }
}