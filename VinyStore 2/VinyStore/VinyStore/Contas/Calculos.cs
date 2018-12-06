using System;
using System.Collections.Generic;
using System.Text;

namespace VinyStore.Contas
{
    class Calculos
    {
        public static double Entrada
        {
            get
            {
                double _entrada = 0;
                foreach (Conta conta in ContaList.listaContas)
                {
                    if (conta.TipoConta == TipoConta.ENTRADA)
                        _entrada += conta.Valor;
                }

                return _entrada;
            }
            set => Saida = value;
        }

        public static double Saida
        {
            get
            {
                double _saida = 0;
                foreach (Conta conta in ContaList.listaContas)
                {
                    if (conta.TipoConta == TipoConta.SAIDA)
                        _saida += conta.Valor;
                }

                return _saida;
            }
            set => Saida = value;
        }

        public static double Resultado => Entrada - Saida;
    }
}
