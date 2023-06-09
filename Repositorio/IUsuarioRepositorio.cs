﻿using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario );
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
        void Adicionar(object usuario);
        UsuarioModel BuscarPorId(int id);
        void Atualizar(object usuario);
    }
}
