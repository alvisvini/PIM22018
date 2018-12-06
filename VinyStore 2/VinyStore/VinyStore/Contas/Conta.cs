using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace VinyStore
{
    class Conta
    {
        public string ImagemCaminho { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public TipoConta TipoConta { get; set; }

        public Color Cor { get; set; }

        public Conta(string titulo, string descricao, double valor, TipoConta tipoConta)
        {
            Titulo = titulo;
            Descricao = descricao;
            Valor = valor;
            TipoConta = tipoConta;
            if (TipoConta == TipoConta.SAIDA)
            {
                Cor = Color.Red;
                ImagemCaminho = "sair.png";
            }
            else
            {
                Cor = Color.Green;
                ImagemCaminho = "entrar.png";
            }
        }

        public Conta()
        {

        }
    }
}
