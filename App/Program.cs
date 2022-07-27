using ConverterXmlParaObjeto;
using System.Xml.Serialization;

//Obtém o caminho do arquivo XML na pasta do projeto
string diretorioProjeto = Directory.GetCurrentDirectory();
string caminhoArquivo = Path.Combine(diretorioProjeto, "ListaDeMusicas.xml");

Stream reader = new FileStream(caminhoArquivo, FileMode.Open);

//Cria uma instância de XmlSerializer e desserializa para uma variavel do tipo Lista
XmlSerializer serializer = new(typeof(Lista));
Lista listaMusicas = (Lista)serializer.Deserialize(reader);

//Inteira nos elementos da lista e gera mensagens no console com os dados.
foreach (var musica in listaMusicas.musicas)
{
    Console.WriteLine($"#{musica.id} - {musica.titulo} - Duração: {musica.duracao}");
    Console.WriteLine($"Artistas: {musica.artista}\n");
}
