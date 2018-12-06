﻿using System;
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
	public partial class PageAdicionar : ContentPage
	{
	    private TipoConta tipoConta = TipoConta.ENTRADA;
		public PageAdicionar ()
		{
			InitializeComponent ();
		    Tipo.SelectedIndex = 0;

		}


	    private void Adicionar(object sender, EventArgs e)
	    {
	        if (!String.IsNullOrEmpty(Titulo.Text) && !String.IsNullOrEmpty(Descricao.Text) &&
	            !String.IsNullOrEmpty(Valor.Text))
	        {
	            ContaList.listaContas.Add(new Conta(Titulo.Text, Descricao.Text, Double.Parse(Valor.Text), tipoConta));
                App.Current.MainPage = new NavigationPage(new PageLista());
            }
	            
	        else
	            DisplayAlert("Erro","Favor completar todos os campos!","Ok");

	    }

	    private void TipoSelecionado(object sender, EventArgs e)
	    {
	        if (Tipo.SelectedIndex == 0)
	            tipoConta = TipoConta.ENTRADA;
	        else
	            tipoConta = TipoConta.SAIDA;
	    }
	}
}