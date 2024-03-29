﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04
{
    public class Produto
    {
        private int Id;
        private decimal Valor;
        private string Descricao;

        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        }

        public string ExibirDados()
        {
            return "\nID: " + Id + ",  Valor:R$" + (Valor*3/2)+ ",  Descrição: " + Descricao+Descricao;
        }

        public string ExibirVenda()
        {
            return "\nID: " + Id + ",  Valor: R$" +Valor+",  Descrição: " + Descricao;
        }
        public string getDescricao( )
        {
            return Descricao;
        }
        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public int getId( ) 
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }

        public decimal getValor()
        {
            return Valor;
        }
        public void setValor(decimal valor)
        {
            Valor = valor;
        }
    }
}
