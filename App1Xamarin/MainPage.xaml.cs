using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1Xamarin.Servico;
using App1Xamarin.Servico.Modelo;

namespace App1Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void buscarEndereco(object sender, System.EventArgs args)
        {
            String cep = CEP.Text.Trim();

            Endereco end = ViaCEP.buscarEnderecoCEP(cep);

            if (end != null) {
                MENSAGEM.Text = String.Format("Endereço: {0} - {1}, {2}-{3}", end.logradouro, end.bairro, end.localidade, end.uf);
            } else {
                MENSAGEM.Text = "Erro de CEP";
            }
        }
    }
}
