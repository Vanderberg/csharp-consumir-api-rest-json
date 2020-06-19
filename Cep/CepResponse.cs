using System.Text;
using Newtonsoft.Json;

namespace Rest
{
    public class CepResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }  

        [JsonProperty("localidade")]
        public string Localidade { get; set; } 

        [JsonProperty("uf")]
        public string Uf { get; set; }  

        [JsonProperty("unidade")]
        public string Unidade { get; set; } 

        [JsonProperty("ibge")]
        public string Ibge { get; set; }

        [JsonProperty("gia")]
        public string Gia { get; set; }   

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();           
            sb.AppendLine("Logradouro: " + Logradouro);
            sb.AppendLine("Complemento: " + Complemento);                
            sb.AppendLine("Bairro: " + Bairro);                
            sb.AppendLine("Cidade: " + Localidade); 
            sb.AppendLine("CEP: " + Cep);
            sb.AppendLine("Ibge: " + Ibge); 
            return sb.ToString();

        }  
    }
}