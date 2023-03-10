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

        public string getDescricao()
        {
            return Descricao;
        }

        public int getId( ) 
        {
            return Id;
        }

        public decimal getValor()
        {
            return Valor;
        }
    }
}