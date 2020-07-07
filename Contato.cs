namespace Aula30
{
    public class Contato
    {
        //Propriedade - PascalCase
        public string NomeContato { get; set; }
        public string Telefone { get; set; }


        // Atributo - Camel Case
        //public string nomeContato;

        public Contato(string _nome,string _telefone){
            this.NomeContato = _nome;
            this.Telefone = _telefone;
        }

    }

}