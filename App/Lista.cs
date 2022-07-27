using System.Xml.Serialization;

namespace ConverterXmlParaObjeto
{
    [XmlRoot("lista", Namespace = "", IsNullable = false)]
    public partial class Lista
    {
        [XmlElement("musica")]
        public listaMusica[] musicas { get; set; }
    }

    public partial class listaMusica
    {
        public string titulo { get; set; }

        public string artista { get; set; }

        public string duracao { get; set; }

        [XmlArrayItem("genero", IsNullable = false)]
        public string[] generos { get; set; }

        [XmlAttribute()]
        public byte id { get; set; }
    }
}
