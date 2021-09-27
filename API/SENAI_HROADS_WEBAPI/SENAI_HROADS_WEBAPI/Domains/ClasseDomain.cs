using System;
using System.Collections.Generic;



namespace senai_hroads_webAPI.Domains
{
    public partial class ClasseDomain
    {
        public Classe()
        {
            Classehabilidades = new HashSet<Classehabilidade>();
        }

        public byte IdClasse { get; set; }
        public string NomeClasse { get; set; }

        public virtual ICollection<Classehabilidade> Classehabilidades { get; set; }
    }
}