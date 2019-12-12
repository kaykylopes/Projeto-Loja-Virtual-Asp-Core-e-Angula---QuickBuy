using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio
{
    public class Client
    {
        public Client()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var produo = new Produto();
            var usuario = new Usuario();

            UsuarioRepositorio.Adicionar();

        }


    }
}
