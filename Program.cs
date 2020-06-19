using System;
using System.Threading.Tasks;
using Refit;
using Rest.Cep;

namespace Rest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");
              
                System.Console.WriteLine("Informe seu CEP:");
                string cepInformado = Console.ReadLine().ToString();
                System.Console.WriteLine("Consultando o CEP: " + cepInformado);

                var address = await cepClient.GetAddressAsync(cepInformado);
                
                System.Console.WriteLine();
                System.Console.WriteLine(address.ToString());

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro na consulta de cep: "
                    + e.Message );
            }
        }
    }
}
