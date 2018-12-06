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
    }
}
