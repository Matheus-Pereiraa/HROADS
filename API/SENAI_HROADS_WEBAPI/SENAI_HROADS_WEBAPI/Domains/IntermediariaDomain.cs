using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webAPI.Domains
{
    public partial class Intermediaria

    {
        public Intermediaria()
        {
            Personagems = new HashSet<Personagem>();
        }

        public byte IdClasseHabilidade { get; set; }
        public byte IdClasse { get; set; }
        public byte IdHabilidade { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual Habilidade IdHabilidadeNavigation { get; set; }
        public virtual ICollection<Personagem> Personagems { get; set; }
    }
}
