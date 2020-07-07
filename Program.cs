using System;

namespace Aula30
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            Contato c1 = new Contato("Gabriel", "(11) 43256 - 53254");
            Contato c2 = new Contato("Lucas", "(11) 43256 - 53254");
            Contato c3 = new Contato("Elaine", "(11) 43256 - 53254");

            agenda.Cadastrar(c1);
            agenda.Cadastrar(c2);
            agenda.Cadastrar(c3);

            agenda.Excluir(c2);

            foreach(Contato c in agenda.Listar()){
                Console.WriteLine($"Nome: {c.NomeContato} - Tel/cel: {c.Telefone}");
            }
            Mensagem msg = new Mensagem();
            msg.Destinatario = c3;
            msg.Texto = "Ola"+msg.Destinatario.NomeContato + "!";
            msg.Enviar();
            Console.WriteLine(msg.Enviar());

        }
    }
}
