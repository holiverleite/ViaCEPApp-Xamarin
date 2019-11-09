using System;
using App1Xamarin.Servico.Modelo;
using System.Net;
using Newtonsoft.Json;

namespace App1Xamarin.Servico
{
    public class ViaCEP
    {
        private static String enderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public ViaCEP()
        {
   
        }

        public static Endereco buscarEnderecoCEP(String cep) 
        {
            String novoEnderecoURL = String.Format(enderecoURL, cep);

            WebClient webClient = new WebClient();

            String conteudo = webClient.DownloadString(novoEnderecoURL);

            if (conteudo == null)
            {
                return null;
            }

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            

            return end;
        }
    }
}
