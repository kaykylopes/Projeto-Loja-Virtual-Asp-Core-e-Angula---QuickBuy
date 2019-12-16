﻿using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }

        private List<string> mensagensValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());  }
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagensValidacao.Add(mensagem);
        }
        protected void LimparMensagemValidacao()
        {
            mensagensValidacao.Clear();
        }

        public abstract void Validate();

       protected bool EhValido
        {
            get { return !mensagensValidacao.Any();  }
        }

    }
}
