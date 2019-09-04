using System;
using System.Collections.Generic;
using Portal.Domain.Entities;

namespace Portal.Domain.Interface.Repository
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario ObterPorId(string id);
        IEnumerable<Usuario> ObterTodos();
        void DesativarLock(string id);
    }
}