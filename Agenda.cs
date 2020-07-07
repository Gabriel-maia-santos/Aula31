using System.Collections.Generic;
using System.IO;

namespace Aula30
{
    public class Agenda : IAgenda
    {

        List<Contato> contatos = new List<Contato>();
            private const string PATH = "Database/contato.csv";
        public Agenda(){
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists (pasta)) {
                 Directory.CreateDirectory (pasta);
        }
        if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }

        }
        

            public void Cadastrar(Contato cntt)
        {
            string[] linhas = {PrepararLinhaCSV(cntt)};
            File.AppendAllLines(PATH, linhas);
        }

        private string PrepararLinhaCSV(Contato c){
            return $"{c.NomeContato};{c.Telefone}";
        }

        //Excluir contatos

        public void Excluir(Contato cntt)
        {
            List<string> linhas = new List<string>();

            using(StreamReader arquivo = new StreamReader(PATH)){
                string linha;
                while((linha = arquivo.ReadLine()) !=null){
                    linhas.Add(linha);
                }
            }

            linhas.RemoveAll(x => x.Contains(cntt.NomeContato));
            ReescreverCSV(linhas);
        }
    

        public List<Contato> Listar()
        {
            throw new System.NotImplementedException();
        }


            //rescrever csv

        private void ReescreverCSV(List<string> lines){
            using(StreamWriter output = new StreamWriter(PATH)){
                foreach(string ln in lines){
                    output.Write(ln + "\n");
                }
            }
        }
    }
}