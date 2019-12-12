using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

           

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Critica: Campo Nome deve ser preenchido");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Critica: Campo Descrição deve ser preenchido");

            if (Preco == 0)
                AdicionarCritica("Critica: Campo Preço deve ser preenchido");
        }
    }
}
