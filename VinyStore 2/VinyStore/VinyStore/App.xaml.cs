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
                new Conta("Venda de Eletrônico", "Venda de um computador", 1349.99, TipoConta.ENTRADA),
                new Conta("Entrada do dia 15 de novembro", "Tudo que ganhei no dia 15 de novembro", 3495.55,TipoConta.ENTRADA),
                new Conta("Compra de equipamentos", "Comprei um notebook e uma impressora", 1230.50, TipoConta.SAIDA)
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
