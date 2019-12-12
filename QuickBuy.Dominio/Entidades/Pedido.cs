using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido  { get; set; }
        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega  { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento  { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Critica:  pedido não pode ficar sem item do pedido");

            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("Critica: Campo CEP deve ser preenchido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Critica: Não foi informado a forma de pagamento");

      
        }
    }
}
