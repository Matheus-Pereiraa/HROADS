using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Interfaces
{
    interface IIntermediariaRepository
    {
        List<Intermediaria> Listar();
        Intermediaria BuscarPorId(int idIntermediaria);
        void AtualizarIdUrl(int idIntermediaria, Intermediaria IntermediariaAtualizada);
        void Cadastrar(Intermediaria novaIntermediaria);
        void Deletar(int idIntermediaria);
    }
}