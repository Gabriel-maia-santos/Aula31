using System.Collections.Generic;

namespace Aula30
{
    public interface IAgenda
    {
         void Cadastrar(Contato cntt);
         void Excluir (Contato cntt);

         List<Contato> Listar();
    }
}