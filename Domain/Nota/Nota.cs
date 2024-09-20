using Microsoft.Toolkit.Diagnostics;
namespace ProjetoTeste.Domain.Nota
{
    public class Nota
    {
        public Nota(string titulo, string conteudo, int importancia)
        {
            Guard.IsNotNullOrWhiteSpace(titulo, nameof(titulo));
            Guard.IsNotNullOrWhiteSpace(conteudo, nameof(conteudo));
            Guard.IsBetweenOrEqualTo(importancia, 1, 5, nameof(importancia));

            Titulo = titulo;
            Conteudo = conteudo;
            Importancia = importancia;
            
        }
            public Nota() { }

        public string Titulo { get; private set; }
        public string Conteudo { get; private set; }
        public int Importancia { get; private set; }

        public void RankearImportancia(int novaImportancia)
        {
            Guard.IsBetweenOrEqualTo(novaImportancia, 1, 5, nameof(novaImportancia));
            Importancia = novaImportancia;
        }
    }
}


