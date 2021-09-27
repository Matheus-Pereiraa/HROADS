using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class IntermediariaRepository : IIntermediariaRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idIntermediaria, Intermediaria IntermediariaAtualizada)
        {
            Intermediaria classeBuscada = ctx.Intermediaria.Find(idIntermediaria);

            if (IntermediariaAtualizada.IdClasse != 0 && IntermediariaAtualizada.IdHabilidade != 0)
            {
                classeBuscada.IdClasse = IntermediariaAtualizada.IdClasse;
                classeBuscada.IdHabilidade = IntermediariaAtualizada.IdHabilidade;
            }

            ctx.Intermediaria.Update(classeBuscada);

            ctx.SaveChanges();
        }

        public Intermediaria BuscarPorId(int idIntermediaria)
        {
            return ctx.Intermediaria.FirstOrDefault(e => e.IdIntermediaria == idIntermediaria);
        }

        public void Cadastrar(Intermediaria novaIntermediaria)
        {
            ctx.Intermediaria.Add(novaIntermediaria);

            ctx.SaveChanges();
        }

        public void Deletar(int idIntermediaria)
        {
            Intermediaria Intermediaria = ctx.Intermediaria.Find(idIntermediaria);

            ctx.Intermediaria.Remove(Intermediaria);

            ctx.SaveChanges();
        }

        public List<Intermediaria> Listar()
        {
            return ctx.Intermediaria.ToList();
        }
    }
}