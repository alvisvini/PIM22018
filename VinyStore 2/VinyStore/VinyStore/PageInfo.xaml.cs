using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinyStore.Contas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinyStore
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageInfo : ContentPage
	{
		public PageInfo ()
		{
			InitializeComponent ();
		    EntradaText.Text = "Você Recebeu R$ " + Calculos.Entrada;
		    SaidaText.Text = "Você Pagou R$ " + Calculos.Saida;
		    if (Calculos.Resultado > 0)
		    {
		        LucroText.Text = "Você Lucrou R$ " + Math.Round(Calculos.Resultado,2);
		        LucroText.TextColor = Color.Green;
		    }

		    else
		    {
		        LucroText.Text = "Você está devendo R$ " + Math.Round(Calculos.Resultado*-1,2);
		        LucroText.TextColor = Color.Red;
		    }
		        
		    //{Binding Calculos.Entrada, StringFormat='Você Recebeu: R$ {0}'}
		}
    }
}