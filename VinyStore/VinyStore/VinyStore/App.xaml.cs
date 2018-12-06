using System;
using System.Collections.Generic;
using VinyStore.Contas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VinyStore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Lista com as contas para aparecer
            List<Conta> list = new List<Conta>
            {
                new Conta("Venda de Eletrônico", "Venda de um computador", 1349.99, TipoConta.ENTRADA, "12/03/2018"),
                new Conta("Entrada do dia 15 de novembro", "Tudo que ganhei no dia 15 de novembro", 3495.55,TipoConta.ENTRADA, "12/03/2018"),
                new Conta("Compra de equipamentos", "Comprei um notebook e uma impressora", 1230.50, TipoConta.SAIDA, "12/03/2018"),
                new Conta("Entrada de caixa", "Movimentação do dia 11 de janeiro", 2500.50, TipoConta.ENTRADA, "11/01/2018"),
                new Conta("Entrada de caixa", "Movimentação do dia 12 de fevereiro", 315.55,TipoConta.ENTRADA, "12/02/2018"),
                new Conta("Pagamento de salário", "Salário dos vendedores", 12348.50, TipoConta.SAIDA, "19/04/2018"),
                new Conta("Manutenção de Infraestrutura", "Troca de lampadas", 112.99, TipoConta.SAIDA, "24/08/2018"),
                new Conta("Compensação de cheques", "Cheques do mês de Agosto", 13495.55,TipoConta.ENTRADA, "01/09/2018"),
                new Conta("Manutenção de Infraestrutura", "Troca de roteador", 88.50, TipoConta.SAIDA, "28/11/2018")
            };  

            if(ContaList.listaContas.Count == 0)
                ContaList.listaContas.AddRange(list);


            MainPage = new NavigationPage(new PageLista());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
