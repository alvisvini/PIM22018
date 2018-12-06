using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinyStore.Contas;
using Xamarin.Forms;

namespace VinyStore
{
    public partial class PageLista : ContentPage
    {
        public PageLista()
        {
            InitializeComponent();

            TitleText.Text = "Filtre para conferir os dados do período";

            // Bind
            this.BindingContext = ContaList.listaContas;
        }

        private void Adicionar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PageAdicionar());
        }

        private void Informacoes(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PageInfo());
        }

        private void TipoSelecionado(object sender, EventArgs e)
        {
            List<Conta> listaImprimir = new List<Conta>();
            List<Conta> listaMes = new List<Conta>();

            //FILTRO POR TIPO DE TRANSAÇÃO
            if (Tipo.SelectedIndex == 0)
            {
                foreach(Conta conta in ContaList.listaContas)
                {
                    if (conta.TipoConta.ToString() == "ENTRADA")
                    {
                        listaImprimir.Add(conta);
                    }
                }
                this.BindingContext = listaImprimir;
            }

            else if(Tipo.SelectedIndex == 1)
            {
                foreach (Conta conta in ContaList.listaContas)
                {
                    if (conta.TipoConta.ToString() == "SAIDA")
                    {
                        listaImprimir.Add(conta);
                    }
                }
                this.BindingContext = listaImprimir;
            }
            else
            {
                foreach (Conta conta in ContaList.listaContas)
                {
                    listaImprimir.Add(conta);
                }
                this.BindingContext = listaImprimir;
            }

            //FILTRO POR MÊS
            if (Mes.SelectedIndex == 1)
            { 
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "01")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 2)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "02")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 3)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "03")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 4)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "04")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 5)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "05")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 6)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "06")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 7)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "07")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 8)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "08")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 9)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "09")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 10)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "10")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 11)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "11")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else if (Mes.SelectedIndex == 12)
            {
                foreach (Conta conta in listaImprimir)
                {
                    var data = conta.Data.ToString();
                    string[] dataSplit = data.Split('/');
                    if (dataSplit[1] == "12")
                    {
                        listaMes.Add(conta);
                    }
                }
                this.BindingContext = listaMes;
            }
            else
            {
                foreach (Conta conta in listaImprimir)
                {
                    listaMes.Add(conta);
                }
                this.BindingContext = listaMes;
            }

            //CALCULOS

            var entrada = 0.0;
            var saida = 0.0;

            foreach (Conta conta in listaMes)
            {
                var valor = conta.Valor;
                var tipo = conta.TipoConta.ToString();

                if(tipo == "ENTRADA")
                {
                    entrada += valor;
                }
                else if (tipo == "SAIDA")
                {
                    saida += valor;
                }

            }
            TitleText.Text = "Informações do Caixa";
            EntradaText.Text = "Entrada total: R$ " + Math.Round(entrada, 2);
            SaidaText.Text = "Saída total: R$ " + Math.Round(saida, 2);
            var total = entrada - saida;
            if (total > 0)
            {
                LucroText.Text = "Saldo: R$ " + Math.Round(total, 2);
                LucroText.TextColor = Color.Green;
            }

            else
            {
                LucroText.Text = "Você está devendo R$ " + Math.Round(total * -1, 2);
                LucroText.TextColor = Color.Red;
            }
        }
    }
}
