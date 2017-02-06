﻿using System;
using System.Collections.Generic;

namespace Vendas.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente c)
        {
            return c.Ativo && DateTime.Now.Year - c.DataCadastro.Year >= 5;
        }
    }
}
