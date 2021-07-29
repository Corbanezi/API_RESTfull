﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos.Data
{
    public class Produto
    {
        //expecifications of the products and type of them
        //expecificações dos produtos e seus tipos
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
