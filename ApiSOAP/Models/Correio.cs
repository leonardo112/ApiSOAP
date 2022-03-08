namespace ApiSOAP.Models
{
    public class Correio
    {
        public Cep cep { get; set; }
        public Endereco endereco { get; set; }
        public class Cep
        {
            public string Codigo { get; set; }
        }
        public class Endereco
        {
            public string Descricao { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
        }
    }
}
